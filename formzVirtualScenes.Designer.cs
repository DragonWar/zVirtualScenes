﻿namespace zVirtualScenesApplication
{
    partial class formzVirtualScenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formzVirtualScenes));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeDeviceLevel = new System.Windows.Forms.Button();
            this.btn_EditDevice = new System.Windows.Forms.Button();
            this.labelLastEvent = new System.Windows.Forms.Label();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEditAction = new System.Windows.Forms.Button();
            this.btn_AddAction = new System.Windows.Forms.Button();
            this.btn_EditScene = new System.Windows.Forms.Button();
            this.labelSceneRunStatus = new System.Windows.Forms.Label();
            this.btn_createnonzwaction = new System.Windows.Forms.Button();
            this.btn_sceneMoveDown = new System.Windows.Forms.Button();
            this.comboBoxNonZWAction = new System.Windows.Forms.ComboBox();
            this.btn_SceneMoveUp = new System.Windows.Forms.Button();
            this.buttonDelScene = new System.Windows.Forms.Button();
            this.buttonAddScene = new System.Windows.Forms.Button();
            this.btn_MoveDown = new System.Windows.Forms.Button();
            this.btn_MoveUp = new System.Windows.Forms.Button();
            this.btn_DelAction = new System.Windows.Forms.Button();
            this.listBoxScenes = new System.Windows.Forms.ListBox();
            this.lbl_sceneActions = new System.Windows.Forms.Label();
            this.listBoxSceneActions = new System.Windows.Forms.ListBox();
            this.btn_runScene = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxJabberUserTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxJabberServer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxJabberPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxJabberUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxJabberVerbose = new System.Windows.Forms.CheckBox();
            this.checkBoxJabberEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxLSLimit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxLSport = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLSPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxLSDebugVerbose = new System.Windows.Forms.CheckBox();
            this.checkBoxLSEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtb_exampleURL = new System.Windows.Forms.TextBox();
            this.checkBoxHTTPEnable = new System.Windows.Forms.CheckBox();
            this.txtb_httpPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.reconnectToControlThinkUSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookForNewDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Location = new System.Drawing.Point(0, 25);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(786, 448);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChangeDeviceLevel);
            this.groupBox1.Controls.Add(this.btn_EditDevice);
            this.groupBox1.Controls.Add(this.labelLastEvent);
            this.groupBox1.Controls.Add(this.listBoxDevices);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ZWave Devices";
            // 
            // buttonChangeDeviceLevel
            // 
            this.buttonChangeDeviceLevel.Location = new System.Drawing.Point(613, 113);
            this.buttonChangeDeviceLevel.Name = "buttonChangeDeviceLevel";
            this.buttonChangeDeviceLevel.Size = new System.Drawing.Size(91, 23);
            this.buttonChangeDeviceLevel.TabIndex = 28;
            this.buttonChangeDeviceLevel.Text = "Change Level";
            this.buttonChangeDeviceLevel.UseVisualStyleBackColor = true;
            this.buttonChangeDeviceLevel.Click += new System.EventHandler(this.buttonChangeDeviceLevel_Click);
            // 
            // btn_EditDevice
            // 
            this.btn_EditDevice.Location = new System.Drawing.Point(708, 113);
            this.btn_EditDevice.Name = "btn_EditDevice";
            this.btn_EditDevice.Size = new System.Drawing.Size(46, 23);
            this.btn_EditDevice.TabIndex = 27;
            this.btn_EditDevice.Text = "Edit";
            this.btn_EditDevice.UseVisualStyleBackColor = true;
            this.btn_EditDevice.Click += new System.EventHandler(this.btn_EditDevice_Click_1);
            // 
            // labelLastEvent
            // 
            this.labelLastEvent.AutoSize = true;
            this.labelLastEvent.Location = new System.Drawing.Point(8, 118);
            this.labelLastEvent.Name = "labelLastEvent";
            this.labelLastEvent.Size = new System.Drawing.Size(64, 13);
            this.labelLastEvent.TabIndex = 22;
            this.labelLastEvent.Text = "Last Event: ";
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.Location = new System.Drawing.Point(6, 17);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(748, 95);
            this.listBoxDevices.TabIndex = 0;
            this.listBoxDevices.DoubleClick += new System.EventHandler(this.listBoxDevices_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEditAction);
            this.groupBox2.Controls.Add(this.btn_AddAction);
            this.groupBox2.Controls.Add(this.btn_EditScene);
            this.groupBox2.Controls.Add(this.labelSceneRunStatus);
            this.groupBox2.Controls.Add(this.btn_createnonzwaction);
            this.groupBox2.Controls.Add(this.btn_sceneMoveDown);
            this.groupBox2.Controls.Add(this.comboBoxNonZWAction);
            this.groupBox2.Controls.Add(this.btn_SceneMoveUp);
            this.groupBox2.Controls.Add(this.buttonDelScene);
            this.groupBox2.Controls.Add(this.buttonAddScene);
            this.groupBox2.Controls.Add(this.btn_MoveDown);
            this.groupBox2.Controls.Add(this.btn_MoveUp);
            this.groupBox2.Controls.Add(this.btn_DelAction);
            this.groupBox2.Controls.Add(this.listBoxScenes);
            this.groupBox2.Controls.Add(this.lbl_sceneActions);
            this.groupBox2.Controls.Add(this.listBoxSceneActions);
            this.groupBox2.Controls.Add(this.btn_runScene);
            this.groupBox2.Location = new System.Drawing.Point(8, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 270);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scenes";
            // 
            // buttonEditAction
            // 
            this.buttonEditAction.Location = new System.Drawing.Point(407, 197);
            this.buttonEditAction.Name = "buttonEditAction";
            this.buttonEditAction.Size = new System.Drawing.Size(46, 20);
            this.buttonEditAction.TabIndex = 26;
            this.buttonEditAction.Text = "Edit";
            this.buttonEditAction.UseVisualStyleBackColor = true;
            this.buttonEditAction.Click += new System.EventHandler(this.buttonEditAction_Click);
            // 
            // btn_AddAction
            // 
            this.btn_AddAction.Location = new System.Drawing.Point(208, 198);
            this.btn_AddAction.Name = "btn_AddAction";
            this.btn_AddAction.Size = new System.Drawing.Size(132, 20);
            this.btn_AddAction.TabIndex = 25;
            this.btn_AddAction.Text = "Add ZWave Action";
            this.btn_AddAction.UseVisualStyleBackColor = true;
            this.btn_AddAction.Click += new System.EventHandler(this.btn_AddAction_Click);
            // 
            // btn_EditScene
            // 
            this.btn_EditScene.Location = new System.Drawing.Point(126, 219);
            this.btn_EditScene.Name = "btn_EditScene";
            this.btn_EditScene.Size = new System.Drawing.Size(53, 20);
            this.btn_EditScene.TabIndex = 24;
            this.btn_EditScene.Text = "Edit";
            this.btn_EditScene.UseVisualStyleBackColor = true;
            this.btn_EditScene.Click += new System.EventHandler(this.btn_EditScene_Click);
            // 
            // labelSceneRunStatus
            // 
            this.labelSceneRunStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSceneRunStatus.AutoSize = true;
            this.labelSceneRunStatus.Location = new System.Drawing.Point(211, 249);
            this.labelSceneRunStatus.Name = "labelSceneRunStatus";
            this.labelSceneRunStatus.Size = new System.Drawing.Size(158, 13);
            this.labelSceneRunStatus.TabIndex = 23;
            this.labelSceneRunStatus.Text = "Last Scene Completetion Status";
            // 
            // btn_createnonzwaction
            // 
            this.btn_createnonzwaction.Location = new System.Drawing.Point(209, 222);
            this.btn_createnonzwaction.Name = "btn_createnonzwaction";
            this.btn_createnonzwaction.Size = new System.Drawing.Size(131, 20);
            this.btn_createnonzwaction.TabIndex = 21;
            this.btn_createnonzwaction.Text = "Add Non-Zwave Action";
            this.btn_createnonzwaction.UseVisualStyleBackColor = true;
            this.btn_createnonzwaction.Click += new System.EventHandler(this.btn_createnonzwaction_Click);
            // 
            // btn_sceneMoveDown
            // 
            this.btn_sceneMoveDown.Location = new System.Drawing.Point(182, 40);
            this.btn_sceneMoveDown.Name = "btn_sceneMoveDown";
            this.btn_sceneMoveDown.Size = new System.Drawing.Size(17, 20);
            this.btn_sceneMoveDown.TabIndex = 20;
            this.btn_sceneMoveDown.Text = "-";
            this.btn_sceneMoveDown.UseVisualStyleBackColor = true;
            this.btn_sceneMoveDown.Click += new System.EventHandler(this.btn_sceneMoveDown_Click);
            // 
            // comboBoxNonZWAction
            // 
            this.comboBoxNonZWAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNonZWAction.FormattingEnabled = true;
            this.comboBoxNonZWAction.Items.AddRange(new object[] {
            "Create Delay Timer",
            "Launch EXE"});
            this.comboBoxNonZWAction.Location = new System.Drawing.Point(346, 222);
            this.comboBoxNonZWAction.Name = "comboBoxNonZWAction";
            this.comboBoxNonZWAction.Size = new System.Drawing.Size(163, 21);
            this.comboBoxNonZWAction.TabIndex = 23;
            // 
            // btn_SceneMoveUp
            // 
            this.btn_SceneMoveUp.Location = new System.Drawing.Point(182, 17);
            this.btn_SceneMoveUp.Name = "btn_SceneMoveUp";
            this.btn_SceneMoveUp.Size = new System.Drawing.Size(17, 20);
            this.btn_SceneMoveUp.TabIndex = 19;
            this.btn_SceneMoveUp.Text = "+";
            this.btn_SceneMoveUp.UseVisualStyleBackColor = true;
            this.btn_SceneMoveUp.Click += new System.EventHandler(this.btn_SceneMoveUp_Click);
            // 
            // buttonDelScene
            // 
            this.buttonDelScene.Location = new System.Drawing.Point(65, 219);
            this.buttonDelScene.Name = "buttonDelScene";
            this.buttonDelScene.Size = new System.Drawing.Size(55, 20);
            this.buttonDelScene.TabIndex = 18;
            this.buttonDelScene.Text = "Delete";
            this.buttonDelScene.UseVisualStyleBackColor = true;
            this.buttonDelScene.Click += new System.EventHandler(this.buttonDelScene_Click);
            // 
            // buttonAddScene
            // 
            this.buttonAddScene.Location = new System.Drawing.Point(6, 219);
            this.buttonAddScene.Name = "buttonAddScene";
            this.buttonAddScene.Size = new System.Drawing.Size(53, 20);
            this.buttonAddScene.TabIndex = 17;
            this.buttonAddScene.Text = "Add";
            this.buttonAddScene.UseVisualStyleBackColor = true;
            this.buttonAddScene.Click += new System.EventHandler(this.buttonAddScene_Click);
            // 
            // btn_MoveDown
            // 
            this.btn_MoveDown.Location = new System.Drawing.Point(739, 57);
            this.btn_MoveDown.Name = "btn_MoveDown";
            this.btn_MoveDown.Size = new System.Drawing.Size(17, 20);
            this.btn_MoveDown.TabIndex = 16;
            this.btn_MoveDown.Text = "-";
            this.btn_MoveDown.UseVisualStyleBackColor = true;
            this.btn_MoveDown.Click += new System.EventHandler(this.btn_MoveDown_Click);
            // 
            // btn_MoveUp
            // 
            this.btn_MoveUp.Location = new System.Drawing.Point(739, 35);
            this.btn_MoveUp.Name = "btn_MoveUp";
            this.btn_MoveUp.Size = new System.Drawing.Size(17, 20);
            this.btn_MoveUp.TabIndex = 15;
            this.btn_MoveUp.Text = "+";
            this.btn_MoveUp.UseVisualStyleBackColor = true;
            this.btn_MoveUp.Click += new System.EventHandler(this.btn_MoveUp_Click);
            // 
            // btn_DelAction
            // 
            this.btn_DelAction.Location = new System.Drawing.Point(346, 197);
            this.btn_DelAction.Name = "btn_DelAction";
            this.btn_DelAction.Size = new System.Drawing.Size(56, 20);
            this.btn_DelAction.TabIndex = 14;
            this.btn_DelAction.Text = "Delete";
            this.btn_DelAction.UseVisualStyleBackColor = true;
            this.btn_DelAction.Click += new System.EventHandler(this.btn_DelAction_Click);
            // 
            // listBoxScenes
            // 
            this.listBoxScenes.FormattingEnabled = true;
            this.listBoxScenes.Location = new System.Drawing.Point(7, 17);
            this.listBoxScenes.Name = "listBoxScenes";
            this.listBoxScenes.Size = new System.Drawing.Size(172, 199);
            this.listBoxScenes.TabIndex = 3;
            this.listBoxScenes.SelectedIndexChanged += new System.EventHandler(this.listBoxScenes_SelectedIndexChanged);
            this.listBoxScenes.DoubleClick += new System.EventHandler(this.listBoxScenes_DoubleClick);
            // 
            // lbl_sceneActions
            // 
            this.lbl_sceneActions.AutoSize = true;
            this.lbl_sceneActions.Location = new System.Drawing.Point(206, 20);
            this.lbl_sceneActions.Name = "lbl_sceneActions";
            this.lbl_sceneActions.Size = new System.Drawing.Size(76, 13);
            this.lbl_sceneActions.TabIndex = 6;
            this.lbl_sceneActions.Text = "Scene Actions";
            // 
            // listBoxSceneActions
            // 
            this.listBoxSceneActions.FormattingEnabled = true;
            this.listBoxSceneActions.Location = new System.Drawing.Point(208, 35);
            this.listBoxSceneActions.Name = "listBoxSceneActions";
            this.listBoxSceneActions.Size = new System.Drawing.Size(528, 160);
            this.listBoxSceneActions.TabIndex = 5;
            this.listBoxSceneActions.DoubleClick += new System.EventHandler(this.listBoxSceneActions_DoubleClick);
            // 
            // btn_runScene
            // 
            this.btn_runScene.Location = new System.Drawing.Point(6, 240);
            this.btn_runScene.Name = "btn_runScene";
            this.btn_runScene.Size = new System.Drawing.Size(173, 20);
            this.btn_runScene.TabIndex = 10;
            this.btn_runScene.Text = "Run Scene Now";
            this.btn_runScene.UseVisualStyleBackColor = true;
            this.btn_runScene.Click += new System.EventHandler(this.btn_runScene_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSaveSettings);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(778, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(631, 376);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(137, 38);
            this.buttonSaveSettings.TabIndex = 7;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxJabberUserTo);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.textBoxJabberServer);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.textBoxJabberPassword);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.textBoxJabberUser);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.checkBoxJabberVerbose);
            this.groupBox7.Controls.Add(this.checkBoxJabberEnabled);
            this.groupBox7.Location = new System.Drawing.Point(3, 217);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(595, 127);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Send Notifications to Jabber";
            // 
            // textBoxJabberUserTo
            // 
            this.textBoxJabberUserTo.Location = new System.Drawing.Point(348, 99);
            this.textBoxJabberUserTo.Name = "textBoxJabberUserTo";
            this.textBoxJabberUserTo.Size = new System.Drawing.Size(236, 20);
            this.textBoxJabberUserTo.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(338, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Usernames of jabber users to send notifcations to (comma seperated): ";
            // 
            // textBoxJabberServer
            // 
            this.textBoxJabberServer.Location = new System.Drawing.Point(348, 73);
            this.textBoxJabberServer.Name = "textBoxJabberServer";
            this.textBoxJabberServer.Size = new System.Drawing.Size(172, 20);
            this.textBoxJabberServer.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Jabber Server:";
            // 
            // textBoxJabberPassword
            // 
            this.textBoxJabberPassword.Location = new System.Drawing.Point(348, 47);
            this.textBoxJabberPassword.Name = "textBoxJabberPassword";
            this.textBoxJabberPassword.Size = new System.Drawing.Size(236, 20);
            this.textBoxJabberPassword.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Jabber Password:";
            // 
            // textBoxJabberUser
            // 
            this.textBoxJabberUser.Location = new System.Drawing.Point(348, 21);
            this.textBoxJabberUser.Name = "textBoxJabberUser";
            this.textBoxJabberUser.Size = new System.Drawing.Size(236, 20);
            this.textBoxJabberUser.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jabber Username:";
            // 
            // checkBoxJabberVerbose
            // 
            this.checkBoxJabberVerbose.AutoSize = true;
            this.checkBoxJabberVerbose.Location = new System.Drawing.Point(9, 42);
            this.checkBoxJabberVerbose.Name = "checkBoxJabberVerbose";
            this.checkBoxJabberVerbose.Size = new System.Drawing.Size(142, 17);
            this.checkBoxJabberVerbose.TabIndex = 13;
            this.checkBoxJabberVerbose.Text = "Enable Verbose Logging";
            this.checkBoxJabberVerbose.UseVisualStyleBackColor = true;
            // 
            // checkBoxJabberEnabled
            // 
            this.checkBoxJabberEnabled.AutoSize = true;
            this.checkBoxJabberEnabled.Location = new System.Drawing.Point(9, 19);
            this.checkBoxJabberEnabled.Name = "checkBoxJabberEnabled";
            this.checkBoxJabberEnabled.Size = new System.Drawing.Size(94, 17);
            this.checkBoxJabberEnabled.TabIndex = 13;
            this.checkBoxJabberEnabled.Text = "Enable Jabber";
            this.checkBoxJabberEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxLSLimit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBoxLSport);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textBoxLSPassword);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.checkBoxLSDebugVerbose);
            this.groupBox5.Controls.Add(this.checkBoxLSEnabled);
            this.groupBox5.Location = new System.Drawing.Point(3, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(595, 72);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LightSwitch Settings";
            // 
            // textBoxLSLimit
            // 
            this.textBoxLSLimit.Location = new System.Drawing.Point(537, 39);
            this.textBoxLSLimit.Name = "textBoxLSLimit";
            this.textBoxLSLimit.Size = new System.Drawing.Size(47, 20);
            this.textBoxLSLimit.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(397, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "# of Connection Limited to ";
            // 
            // textBoxLSport
            // 
            this.textBoxLSport.Location = new System.Drawing.Point(282, 40);
            this.textBoxLSport.Name = "textBoxLSport";
            this.textBoxLSport.Size = new System.Drawing.Size(47, 20);
            this.textBoxLSport.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Listen on Port:";
            // 
            // textBoxLSPassword
            // 
            this.textBoxLSPassword.Location = new System.Drawing.Point(282, 16);
            this.textBoxLSPassword.Name = "textBoxLSPassword";
            this.textBoxLSPassword.Size = new System.Drawing.Size(302, 20);
            this.textBoxLSPassword.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Client Password:";
            // 
            // checkBoxLSDebugVerbose
            // 
            this.checkBoxLSDebugVerbose.AutoSize = true;
            this.checkBoxLSDebugVerbose.Location = new System.Drawing.Point(9, 42);
            this.checkBoxLSDebugVerbose.Name = "checkBoxLSDebugVerbose";
            this.checkBoxLSDebugVerbose.Size = new System.Drawing.Size(142, 17);
            this.checkBoxLSDebugVerbose.TabIndex = 8;
            this.checkBoxLSDebugVerbose.Text = "Enable Verbose Logging";
            this.checkBoxLSDebugVerbose.UseVisualStyleBackColor = true;
            // 
            // checkBoxLSEnabled
            // 
            this.checkBoxLSEnabled.AutoSize = true;
            this.checkBoxLSEnabled.Location = new System.Drawing.Point(9, 19);
            this.checkBoxLSEnabled.Name = "checkBoxLSEnabled";
            this.checkBoxLSEnabled.Size = new System.Drawing.Size(151, 17);
            this.checkBoxLSEnabled.TabIndex = 7;
            this.checkBoxLSEnabled.Text = "Enable LightSwitch Server";
            this.checkBoxLSEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtb_exampleURL);
            this.groupBox6.Controls.Add(this.checkBoxHTTPEnable);
            this.groupBox6.Controls.Add(this.txtb_httpPort);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(6, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(523, 117);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ZVirtualScene HTTP Listen ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Example HTTP URL: ";
            // 
            // txtb_exampleURL
            // 
            this.txtb_exampleURL.Location = new System.Drawing.Point(9, 84);
            this.txtb_exampleURL.Name = "txtb_exampleURL";
            this.txtb_exampleURL.ReadOnly = true;
            this.txtb_exampleURL.Size = new System.Drawing.Size(505, 20);
            this.txtb_exampleURL.TabIndex = 5;
            // 
            // checkBoxHTTPEnable
            // 
            this.checkBoxHTTPEnable.AutoSize = true;
            this.checkBoxHTTPEnable.Location = new System.Drawing.Point(392, 15);
            this.checkBoxHTTPEnable.Name = "checkBoxHTTPEnable";
            this.checkBoxHTTPEnable.Size = new System.Drawing.Size(122, 17);
            this.checkBoxHTTPEnable.TabIndex = 5;
            this.checkBoxHTTPEnable.Text = "Enable HTTP Listen";
            this.checkBoxHTTPEnable.UseVisualStyleBackColor = true;
            // 
            // txtb_httpPort
            // 
            this.txtb_httpPort.Location = new System.Drawing.Point(392, 38);
            this.txtb_httpPort.Name = "txtb_httpPort";
            this.txtb_httpPort.Size = new System.Drawing.Size(111, 20);
            this.txtb_httpPort.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Listen on Port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.Location = new System.Drawing.Point(4, 6);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(768, 407);
            this.listBoxLog.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToControlThinkUSBToolStripMenuItem,
            this.lookForNewDevicesToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton2.Text = "Devices";
            // 
            // reconnectToControlThinkUSBToolStripMenuItem
            // 
            this.reconnectToControlThinkUSBToolStripMenuItem.Name = "reconnectToControlThinkUSBToolStripMenuItem";
            this.reconnectToControlThinkUSBToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.reconnectToControlThinkUSBToolStripMenuItem.Text = "Reconnect to ControlThink USB";
            this.reconnectToControlThinkUSBToolStripMenuItem.Click += new System.EventHandler(this.reconnectToControlThinkUSBToolStripMenuItem_Click);
            // 
            // lookForNewDevicesToolStripMenuItem
            // 
            this.lookForNewDevicesToolStripMenuItem.Name = "lookForNewDevicesToolStripMenuItem";
            this.lookForNewDevicesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.lookForNewDevicesToolStripMenuItem.Text = "Look for new devices";
            this.lookForNewDevicesToolStripMenuItem.Click += new System.EventHandler(this.lookForNewDevicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // formzVirtualScenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 473);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formzVirtualScenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.zVirtualScenes_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Label lbl_sceneActions;
        private System.Windows.Forms.ListBox listBoxSceneActions;
        private System.Windows.Forms.ListBox listBoxScenes;
        private System.Windows.Forms.Button btn_runScene;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DelAction;
        private System.Windows.Forms.Button btn_MoveUp;
        private System.Windows.Forms.Button btn_MoveDown;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtb_httpPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxHTTPEnable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtb_exampleURL;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button buttonAddScene;
        private System.Windows.Forms.Button buttonDelScene;
        private System.Windows.Forms.Button btn_SceneMoveUp;
        private System.Windows.Forms.Button btn_sceneMoveDown;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxLSPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxLSDebugVerbose;
        private System.Windows.Forms.CheckBox checkBoxLSEnabled;
        private System.Windows.Forms.TextBox textBoxLSport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxLSLimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_createnonzwaction;
        private System.Windows.Forms.ComboBox comboBoxNonZWAction;
        private System.Windows.Forms.Label labelLastEvent;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxJabberUserTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxJabberServer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxJabberPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxJabberUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxJabberVerbose;
        private System.Windows.Forms.CheckBox checkBoxJabberEnabled;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem lookForNewDevicesToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label labelSceneRunStatus;
        private System.Windows.Forms.Button btn_EditScene;
        private System.Windows.Forms.Button btn_AddAction;
        private System.Windows.Forms.Button buttonEditAction;
        private System.Windows.Forms.Button btn_EditDevice;
        private System.Windows.Forms.ToolStripMenuItem reconnectToControlThinkUSBToolStripMenuItem;
        private System.Windows.Forms.Button buttonChangeDeviceLevel;
    }
}
