﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Shell;
using zvs.DataModel;
using zvs.DataModel.Migrations;
using zvs.Processor;
using MessageBox = System.Windows.MessageBox;

namespace zvs.WPF
{
    /// <summary>
    /// interaction logic for App.xaml
    /// </summary>
    public partial class App : ISingleInstanceApp
    {
        public CancellationTokenSource Cts { get; private set; }

        bool _isMainWindowCreated;
        public ZvsEngine ZvsEngine { get; set; }
        public ZVSTaskbarIcon TaskbarIcon { get; set; }
        public ZvsMainWindow ZvsWindow { get; set; }
        public IEntityContextConnection EntityContextConnection { get; set; }

        private IFeedback<LogEntry> Log { get; set; }

        private Mutex _zvsMutex;

        [STAThread]
        public static void Main()
        {
            if (!SingleInstance<App>.InitializeAsFirstInstance("AdvancedJumpList")) return;

            var application = new App();
            application.Init();
            application.Run();
            // Allow single instance code to perform cleanup operations
            SingleInstance<App>.Cleanup();
        }

        public void Init()
        {
            Cts = new CancellationTokenSource();
            EntityContextConnection = new ZvsEntityContextConnection();
            Log = new DatabaseFeedback(EntityContextConnection) { Source = "Zvs Gui" };
            InitializeComponent();
        }

        public async Task<bool> SignalExternalCommandLineArgs(IList<string> args)
        {
            if (args == null || args.Count == 0)
                return true;
            if ((args.Count <= 2)) return true;
            //the first index always contains the location of the exe so we need to check the second index
            if ((args[1].ToLowerInvariant() != "-startscene")) return true;
            var searchQuery = args[2].ToLower();

            using (var context = new ZvsContext(EntityContextConnection))
            {
                Scene scene;
                int sceneId;
                if (int.TryParse(searchQuery, out sceneId))
                    scene = await context.Scenes.FirstOrDefaultAsync(s => s.Id == sceneId);
                else scene = await context.Scenes.FirstOrDefaultAsync(s => s.Name.ToLower().Equals(searchQuery));

                if (scene != null)
                {
                    var cmd = await context.BuiltinCommands.FirstOrDefaultAsync(c => c.UniqueIdentifier == "RUN_SCENE");
                    if (cmd == null) return true;

                    await ZvsEngine.RunCommandAsync(cmd.Id, scene.Id.ToString(CultureInfo.InvariantCulture), string.Empty, Cts.Token);
                }
                else
                    await Log.ReportInfoFormatAsync(Cts.Token, "Cannot find scene '{0}'", searchQuery);
            }
            return true;
        }

        public static Adapter CreateFakeAdapter()
        {
            return new Adapter
            {
                AdapterGuid = Guid.NewGuid(),
                Name = "Unit testing adapter",
            };
        }

        public static DeviceType CreateFakeDeviceType()
        {
            return new DeviceType
            {
                UniqueIdentifier = "1",
                Name = "DIMMER",
                Adapter = CreateFakeAdapter()
            };
        }

        public static Device CreateFakeDevice()
        {
            return new Device
            {
                Name = "Light Switch",
                Type = CreateFakeDeviceType()
            };

        }

        protected async override void OnStartup(StartupEventArgs e)
        {
            var adapterLoader = new AdapterLoader();
            var result = await adapterLoader.FindAdaptersAsync("Adapters", Cts.Token);
            if (result.HasError)
                await Log.ReportErrorAsync(result.Message, Cts.Token);

            var adapterManager = new Processor.AdapterManager(result.Adapters, EntityContextConnection, new DatabaseFeedback(EntityContextConnection));

            var pluginLoader = new PluginLoader();
            var pluginFindResult = await pluginLoader.FindPluginsAsync("plugins", Cts.Token);
            if (pluginFindResult.HasError)
                await Log.ReportErrorAsync(pluginFindResult.Message, Cts.Token);

            var pluginManager = new Processor.PluginManager(pluginFindResult.Plugins, EntityContextConnection, new DatabaseFeedback(EntityContextConnection), adapterManager);


            var triggerRunner = new TriggerRunner(new DatabaseFeedback(EntityContextConnection), new CommandProcessor(adapterManager, EntityContextConnection, new DatabaseFeedback(EntityContextConnection)), EntityContextConnection);
            var scheduledTaskRunner = new ScheduledTaskRunner(new DatabaseFeedback(EntityContextConnection), new CommandProcessor(adapterManager, EntityContextConnection, new DatabaseFeedback(EntityContextConnection)), EntityContextConnection, new CurrentTimeProvider());
            ZvsEngine = new ZvsEngine(new DatabaseFeedback(EntityContextConnection), adapterManager, pluginManager, EntityContextConnection, triggerRunner, scheduledTaskRunner);

            var splashscreen = new SplashScreen();
            splashscreen.SetLoadingTextFormat("Starting {0}", Utils.ApplicationNameAndVersion);
            splashscreen.Show();
            await Task.Delay(10);

#if DEBUG
            var sw = new Stopwatch();
            sw.Start();
#endif

#if (RELEASE)
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
#endif
            using (var context = new ZvsContext(new ZvsEntityContextConnection()))
            {
                //Install Program Options
                var option =
                    await
                        context.ProgramOptions.FirstOrDefaultAsync(o => o.UniqueIdentifier == "LOGDIRECTION",
                            Cts.Token);
                if (option == null)
                {
                    var registerLogDirectionResult = await ProgramOption.TryAddOrEditAsync(context, new ProgramOption
                    {
                        UniqueIdentifier = "LOGDIRECTION",
                        Value = "Descending"
                    }, Cts.Token);

                    if (registerLogDirectionResult.HasError)
                        await Log.ReportErrorAsync(registerLogDirectionResult.Message, Cts.Token);
                }
            }
            //using (var context = new ZvsContext(new ZvsEntityContextConnection()))
            //{
            //    var adapter = CreateFakeAdapter();
            //    context.Devices.Add(new Device
            //    {
            //        Name = "Light Switch",
            //        Location = "Living Room",
            //        Type = new DeviceType
            //        {
            //            Name = "Switch Device Type",
            //            UniqueIdentifier = "Switch",
            //            Adapter = adapter
            //        }
            //    });

            //    context.Devices.Add(new Device
            //    {
            //        Name = "Main Controller",
            //        Location = "Utility",
            //        Type = new DeviceType
            //        {
            //            Name = "Controller Type",
            //            UniqueIdentifier = "Controller",
            //            Adapter = adapter
            //        }
            //    });

            //    context.Devices.Add(new Device
            //    {
            //        Name = "Can Lights",
            //        Location = "Kitchen",
            //        Type = new DeviceType
            //        {
            //            Name = "Dimmer Type",
            //            UniqueIdentifier = "Dimmer",
            //            Adapter = adapter
            //        }
            //    });

            //    context.Devices.Add(new Device
            //    {
            //        Name = "Thermostat",
            //        Location = "Kitchen",
            //        Type = new DeviceType
            //        {
            //            Name = "Thermostat Type",
            //            UniqueIdentifier = "Thermostat",
            //            Adapter = adapter
            //        }
            //    });

            //    context.Devices.Add(new Device
            //    {
            //        Name = "Front Door",
            //        Location = "Entry",
            //        Type = new DeviceType
            //        {
            //            Name = "Doorlock Type",
            //            UniqueIdentifier = "Doorlock",
            //            Adapter = adapter
            //        }
            //    });
            //    var sensorDt = new DeviceType
            //    {
            //        Name = "Sensor Type",
            //        UniqueIdentifier = "Sensor",
            //        Adapter = adapter
            //    };
            //    var device = new Device
            //    {
            //        Name = "Motion Sensor",
            //        Location = "Entry",
            //        Type = sensorDt,
            //    };
            //    var value = new DeviceValue
            //    {
            //        Name = "Level",
            //        ValueType = DataType.BYTE,
            //        Value = "255"
            //    };
            //    device.Values.Add(value);
            //    context.Devices.Add(device);

            //     //context.SaveChanges();
            //}

            #region Create Logger

            await Log.ReportInfoFormatAsync(Cts.Token, "Init Complete ({0})", (Utils.DebugMode ? "Debug Mode" : "Release Mode"));
#if DEBUG
            await Log.ReportInfoAsync("--------------DUMPING ENVIRONMENT--------------", Cts.Token);
            await Log.ReportInfoFormatAsync(Cts.Token, "AppDataPath:{0}", Utils.AppDataPath);
            await Log.ReportInfoFormatAsync(Cts.Token, "AppPath:{0}", Utils.AppPath);
            await Log.ReportInfoFormatAsync(Cts.Token, "ApplicationNameAndVersion:{0}", Utils.ApplicationNameAndVersion);
            await Log.ReportInfoFormatAsync(Cts.Token, "ApplicationVersionLong:{0}", Utils.ApplicationVersionLong);
            await Log.ReportInfoFormatAsync(Cts.Token, "HasDotNet45:{0}", Utils.HasDotNet45());
            await Log.ReportInfoFormatAsync(Cts.Token, "HasSQLCE4:{0}", Utils.HasSQLCE4());
            await Log.ReportInfoFormatAsync(Cts.Token, "CommandLine:{0}", Environment.CommandLine);
            await Log.ReportInfoFormatAsync(Cts.Token, "CurrentDirectory:{0}", Environment.CurrentDirectory);
            await Log.ReportInfoFormatAsync(Cts.Token, "Is64BitOperatingSystem:{0}", Environment.Is64BitOperatingSystem);
            await Log.ReportInfoFormatAsync(Cts.Token, "Is64BitProcess:{0}", Environment.Is64BitProcess);
            await Log.ReportInfoFormatAsync(Cts.Token, "MachineName:{0}", Environment.MachineName);
            await Log.ReportInfoFormatAsync(Cts.Token, "OSVersion:{0}", Environment.OSVersion);
            await Log.ReportInfoFormatAsync(Cts.Token, "ProcessorCount:{0}", Environment.ProcessorCount);
            await Log.ReportInfoFormatAsync(Cts.Token, "UserDomainName:{0}", Environment.UserDomainName);
            await Log.ReportInfoFormatAsync(Cts.Token, "UserInteractive:{0}", Environment.UserInteractive);
            await Log.ReportInfoFormatAsync(Cts.Token, "UserName:{0}", Environment.UserName);
            await Log.ReportInfoFormatAsync(Cts.Token, "Version:{0}", Environment.Version);
            await Log.ReportInfoFormatAsync(Cts.Token, "WorkingSet:{0}", Environment.WorkingSet);
            await Log.ReportInfoAsync("--------------/DUMPING ENVIRONMENT--------------", Cts.Token);
#endif
            AppDomain.CurrentDomain.SetData("DataDirectory", Utils.AppDataPath);
            #endregion

            #region Checking for other running instances
            await Task.Delay(10);
            splashscreen.SetLoadingTextFormat("Checking for other running instances");
            await Task.Delay(10);

            try
            {
                _zvsMutex = Mutex.OpenExisting("zVirtualScenesGUIMutex");
                ProgramHasToClosePrompt(Utils.ApplicationName + " can't start because it is already running");
            }
            catch
            {
                //the specified mutex doesn't exist, we should create it
                _zvsMutex = new Mutex(true, "zVirtualScenesGUIMutex"); //these names need to match.
            }
            #endregion

            #region Check for .Net Framework 4.5
            await Task.Delay(10);
            splashscreen.SetLoadingTextFormat("Checking for .Net framework 4.5");
            await Task.Delay(10);

            if (!Utils.HasDotNet45())
            {
                ProgramHasToClosePrompt(
                    $"Microsoft .NET Framework 4.5 Full/Extended is required to run {Utils.ApplicationName}. \r\n\r\nPlease install Microsoft .NET Framework 4.5 and re-launch the application.");
            }
            #endregion

            #region Checking for Microsoft® SQL Server® Compact 4.0 SP1
            await Task.Delay(10);
            splashscreen.SetLoadingTextFormat("Checking for Microsoft® SQL Server® Compact 4.0 SP1");
            await Task.Delay(10);

            if (!Utils.HasSQLCE4())
            {
                ProgramHasToClosePrompt(
                    $"Microsoft® SQL Server® Compact 4.0 SP1 is required to run {Utils.ApplicationName}. \r\n\r\nPlease install Microsoft® SQL Server® Compact 4.0 SP1 and re-launch the application.");
            }
            #endregion

            #region Initializing and upgrading local database
            await Task.Delay(10);
            splashscreen.SetLoadingTextFormat("Initializing and migrating database");
            await Task.Delay(10);

            await Task.Run(() =>
            {
                using (var context = new ZvsContext())
                {
                    var configuration = new Configuration();
                    var migrator = new DbMigrator(configuration);

                    migrator.Update();
                    context.Database.Initialize(true);
                }
            });
            #endregion

            //TODO: Check for VCRedist

            #region Start zvsEngine Services
            await Task.Delay(10);
            splashscreen.SetLoadingTextFormat("Starting zvsEngine services");
            await Task.Delay(10);

            //Initialize the zvsEngine

            try
            {
                await Task.Run(() => ZvsEngine.StartAsync(Cts.Token));
            }
            catch (Exception ex)
            {
                ProgramHasToClosePrompt(ex.Message);
            }

            #endregion

            //Create taskbar Icon 
            TaskbarIcon = new ZVSTaskbarIcon();
            TaskbarIcon.ShowBalloonTip(Utils.ApplicationName, Utils.ApplicationNameAndVersion + " started", 3000, ToolTipIcon.Info);

            //close Splash Screen
            splashscreen.Close();

#if DEBUG
            sw.Stop();
            Debug.WriteLine("App Startup initialized in {0}", sw.Elapsed.ToString() as object);
#endif

            base.OnStartup(e);
        }

        //TODO: MOVE TO SAVE CHANGES
        public async Task RefreshTriggerDescripitions()
        {
            using (var context = new ZvsContext(EntityContextConnection))
            {
                var triggers = await context.DeviceValueTriggers
                    .Include(o => o.DeviceValue)
                    .Include(o => o.DeviceValue.Device)
                    .ToListAsync();

                foreach (var trigger in triggers)
                    trigger.SetDescription();

                var result = await context.TrySaveChangesAsync(Cts.Token);
                if (result.HasError)
                    await Log.ReportErrorAsync(result.Message, Cts.Token);
            }
        }

        //TODO: MOVE TO SAVE CHANGES
        public async Task RefreshCommandDescripitions()
        {
            using (var context = new ZvsContext(EntityContextConnection))
            {
                var storedCommands = await context.SceneStoredCommands.ToListAsync();

                foreach (var storedCommand in storedCommands)
                {
                    await storedCommand.SetTargetObjectNameAsync(context);
                    storedCommand.SetDescription();
                }

                var result = await context.TrySaveChangesAsync(Cts.Token);
                if (result.HasError)
                    await Log.ReportErrorFormatAsync(Cts.Token, "Error refeshing command descriptions. {0}", result.Message);
            }
        }

#if (RELEASE)
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            log.Fatal(sender.ToString(), (System.Exception)e.ExceptionObject);

            App app = (App)Application.Current;
            string exception = GetHostDetails + Environment.NewLine + Environment.NewLine + e.ExceptionObject.ToString();
            FatalErrorWindow fWindow = new FatalErrorWindow(exception);
            fWindow.ShowDialog();
        }
#endif



        public async void ShowzvsWindow()
        {
            if (ZvsWindow == null || !_isMainWindowCreated)
            {
#if DEBUG
                var sw = new Stopwatch();
                sw.Start();
#endif
                _isMainWindowCreated = true;

                var splashscreen = new SplashScreen();
                splashscreen.SetLoadingText("Loading user interface");
                splashscreen.Show();

                await Task.Delay(10);
                splashscreen.SetLoadingTextFormat("Loading user interface settings");
                await Task.Delay(10);

                ZvsWindow = new ZvsMainWindow();
                ZvsWindow.Loaded += (a, s) => splashscreen.Close();
                ZvsWindow.Closed += async (a, s) =>
                {
                    ZvsWindow = null;
                    await Log.ReportInfoFormatAsync(Cts.Token, "{0} User Interface Unloaded", Utils.ApplicationName);
                    _isMainWindowCreated = false;

                };
                ZvsWindow.Show();
#if DEBUG
                sw.Stop();
                Debug.WriteLine("ZVS window created in {0}", sw.Elapsed.ToString() as object);
#endif
            }

            ZvsWindow.Activate();
        }

        public async Task ShutdownZvs()
        {
            if (_zvsMutex != null)
                _zvsMutex.ReleaseMutex();

            await Log.ReportInfoAsync("Shutting down", Cts.Token);
            Cts.Cancel();
            Current.Shutdown();
        }

        private void Application_Exit_1(object sender, ExitEventArgs e)
        {
            TaskbarIcon.Dispose();
        }

        private static void ProgramHasToClosePrompt(string reason)
        {

            var wpfBugWindow = new Window
            {
                AllowsTransparency = true,
                Background = Brushes.Transparent,
                WindowStyle = WindowStyle.None,
                Top = 0,
                Left = 0,
                Width = 1,
                Height = 1,
                ShowInTaskbar = false
            };
            wpfBugWindow.Show();
            if (MessageBox.Show(reason, Utils.ApplicationName, MessageBoxButton.OK, MessageBoxImage.Error) !=
                MessageBoxResult.OK) return;

            wpfBugWindow.Close();
            Environment.Exit(1);
        }
    }
}
