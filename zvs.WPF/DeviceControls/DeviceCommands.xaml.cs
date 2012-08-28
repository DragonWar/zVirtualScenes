﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using zvs.WPF.DynamicActionControls;
using zvs.Entities;


namespace zvs.WPF.DeviceControls
{
    /// <summary>
    /// Interaction logic for DeviceCommands.xaml
    /// </summary>
    public partial class DeviceCommands : UserControl
    {
        private BitmapImage icon = new BitmapImage(new Uri("pack://application:,,,/zVirtualScenes;component/Images/send_signal.png"));
        private zvsContext context;
        private int DeviceID = 0;

        public DeviceCommands(int DeviceID)
        {
            this.DeviceID = DeviceID;
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            context = new zvsContext();
            LoadCommands();
        }

        private void UserControl_Unloaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void LoadCommands()
        {
            DeviceCommandsStkPnl.Children.Clear();
            TypeCommandsStkPnl.Children.Clear();

            Device d = context.Devices.FirstOrDefault(dv => dv.DeviceId == DeviceID);
            if (d != null)
            {
                #region Device Commands
                foreach (DeviceCommand d_cmd in d.Commands.OrderByDescending(c => c.SortOrder))
                {
                    DeviceCommand device_command = d_cmd;
                    switch ((DataType)d_cmd.ArgumentType)
                    {
                        case DataType.NONE:
                            {
                                ButtonControl bc = new ButtonControl(d_cmd.Name, d_cmd.Description, () =>
                                {
                                    QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, "");
                                    QueuedDeviceCommand.Run(cmd, context);
                                }, icon);
                                DeviceCommandsStkPnl.Children.Add(bc);
                                break;
                            }
                        case DataType.BOOL:
                            {
                                //get the current value from the value table list
                                bool DefaultValue = false;
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    bool.TryParse(dv.Value, out DefaultValue);
                                }

                                CheckboxControl control = new CheckboxControl(d_cmd.Name, d_cmd.Description, DefaultValue, (isChecked) =>
                                {
                                    QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, isChecked.ToString());
                                    QueuedDeviceCommand.Run(cmd, context);
                                }, icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.DECIMAL:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Decimal,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.INTEGER:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Integer,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.BYTE:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Byte,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.SHORT:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Short,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }

                        case DataType.STRING:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                StringControl control = new StringControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.LIST:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                ComboboxControl control = new ComboboxControl(d_cmd.Name,
                                    d_cmd.Description,
                                    d_cmd.Options.Select(o => o.Name).ToList(),
                                    DefaultValue,
                                    (value) =>
                                    {
                                        QueuedDeviceCommand cmd = QueuedDeviceCommand.Create(d_cmd, value);
                                        QueuedDeviceCommand.Run(cmd, context);
                                    },
                                    icon);
                                DeviceCommandsStkPnl.Children.Add(control);

                                break;
                            }
                    }
                }
                #endregion

                #region Device Type Commands
                foreach (DeviceTypeCommand d_cmd in d.Type.Commands.OrderByDescending(c => c.SortOrder))
                {
                    DeviceTypeCommand device_type_command = d_cmd;
                    switch (d_cmd.ArgumentType)
                    {
                        case DataType.NONE:
                            {
                                ButtonControl bc = new ButtonControl(d_cmd.Name, d_cmd.Description, () =>
                                {
                                    QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, "");
                                    QueuedDeviceTypeCommand.Run(qdtc, context);
                                },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(bc);
                                break;
                            }
                        case DataType.BOOL:
                            {
                                //get the current value from the value table list
                                bool DefaultValue = false;
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    bool.TryParse(dv.Value, out DefaultValue);
                                }

                                CheckboxControl control = new CheckboxControl(d_cmd.Name, d_cmd.Description, DefaultValue, (isChecked) =>
                                {
                                    QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, isChecked.ToString());
                                    QueuedDeviceTypeCommand.Run(qdtc, context);                                    
                                },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.DECIMAL:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Decimal,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.INTEGER:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                   NumericControl.NumberType.Integer,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.SHORT:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    NumericControl.NumberType.Short,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.BYTE:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                NumericControl control = new NumericControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                   NumericControl.NumberType.Byte,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.STRING:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                StringControl control = new StringControl(d_cmd.Name,
                                    d_cmd.Description,
                                    DefaultValue,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                        case DataType.LIST:
                            {
                                //get the current value from the value table list
                                string DefaultValue = "0";
                                DeviceValue dv = d.Values.FirstOrDefault(v => v.UniqueIdentifier == d_cmd.CustomData2);
                                if (dv != null)
                                {
                                    DefaultValue = dv.Value;
                                }

                                ComboboxControl control = new ComboboxControl(d_cmd.Name,
                                    d_cmd.Description,
                                    d_cmd.Options.Select(o => o.Name).ToList(),
                                    DefaultValue,
                                    (value) =>
                                    {
                                        QueuedDeviceTypeCommand qdtc = QueuedDeviceTypeCommand.Create(device_type_command, d, value);
                                        QueuedDeviceTypeCommand.Run(qdtc, context); 
                                    },
                                    icon);
                                TypeCommandsStkPnl.Children.Add(control);

                                break;
                            }
                    }
                }
                #endregion
            }

            if (DeviceCommandsStkPnl.Children.Count == 0)
                DeviceGrpBx.Visibility = System.Windows.Visibility.Collapsed;

            if (TypeCommandsStkPnl.Children.Count == 0)
                TypeGrpBx.Visibility = System.Windows.Visibility.Collapsed;
            
        }


    }
}