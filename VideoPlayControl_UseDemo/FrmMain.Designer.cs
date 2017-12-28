﻿namespace VideoPlayControl_UseDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.grpVideoInfo = new System.Windows.Forms.GroupBox();
            this.btnStartTalk = new System.Windows.Forms.Button();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.btnSKTestData = new System.Windows.Forms.Button();
            this.btnEzvizTestData = new System.Windows.Forms.Button();
            this.btnWindowPlay = new System.Windows.Forms.Button();
            this.btnTestClose = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbOperAtPreset = new System.Windows.Forms.ComboBox();
            this.cmbOperAtWindows = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVideoPlayClose = new System.Windows.Forms.Button();
            this.btnTestPlay = new System.Windows.Forms.Button();
            this.cmbDVSAddress = new System.Windows.Forms.ComboBox();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoID = new System.Windows.Forms.TextBox();
            this.txtContactPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.pnlBottom_Left = new System.Windows.Forms.Panel();
            this.chkMonitorEnable = new System.Windows.Forms.CheckBox();
            this.chkVideoRecordEnable = new System.Windows.Forms.CheckBox();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpPlayVIdeoWindows = new System.Windows.Forms.TableLayoutPanel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageVideoInfo = new System.Windows.Forms.TabPage();
            this.pnlVideoInfo_Right = new System.Windows.Forms.Panel();
            this.pnlVideoInfo_Right_Top = new System.Windows.Forms.Panel();
            this.cmbPlayWindows = new System.Windows.Forms.ComboBox();
            this.chkPresetEanble = new System.Windows.Forms.CheckBox();
            this.txtCurrentDVSAddress = new System.Windows.Forms.TextBox();
            this.txtCurrentDVSType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrentDVSPwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCurrentDVSPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCurrentUserName = new System.Windows.Forms.TextBox();
            this.txtCurrentChannelNum = new System.Windows.Forms.TextBox();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.pageEventRecord = new System.Windows.Forms.TabPage();
            this.dgvReocrd = new System.Windows.Forms.DataGridView();
            this.dgvReocrd_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReocrd_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEventRecord_Top = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkSDKStateCallback = new System.Windows.Forms.CheckBox();
            this.pageSetting = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.grpSKSDKStatus = new System.Windows.Forms.GroupBox();
            this.btnSKSDKInit = new System.Windows.Forms.Button();
            this.btnGetSKSDKStatus = new System.Windows.Forms.Button();
            this.btnSKSDKUninit = new System.Windows.Forms.Button();
            this.grpEzvizSDKState = new System.Windows.Forms.GroupBox();
            this.btnEzvizSDKInit = new System.Windows.Forms.Button();
            this.btnEzvizSDKRelease = new System.Windows.Forms.Button();
            this.grpCloundSeeSDKState = new System.Windows.Forms.GroupBox();
            this.btnCloundSeeSDKInit = new System.Windows.Forms.Button();
            this.btnCloundSeeSDKRelease = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbPlayVideoWindowSet = new System.Windows.Forms.ComboBox();
            this.ssrTip = new System.Windows.Forms.StatusStrip();
            this.tsslblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.videoPTZControl1 = new VideoPlayControl.VideoPTZControl();
            this.videoWindowTest = new VideoPlayControl.VideoPlayWindow();
            this.videoChannelList = new VideoPlayControl.VideoChannelList();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageTestData = new System.Windows.Forms.TabPage();
            this.PageOther = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkProVideoRecord = new System.Windows.Forms.CheckBox();
            this.pnlBottom.SuspendLayout();
            this.grpVideoInfo.SuspendLayout();
            this.pnlBottom_Left.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageVideoInfo.SuspendLayout();
            this.pnlVideoInfo_Right.SuspendLayout();
            this.pnlVideoInfo_Right_Top.SuspendLayout();
            this.pageEventRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).BeginInit();
            this.pnlEventRecord_Top.SuspendLayout();
            this.pageSetting.SuspendLayout();
            this.grpSKSDKStatus.SuspendLayout();
            this.grpEzvizSDKState.SuspendLayout();
            this.grpCloundSeeSDKState.SuspendLayout();
            this.ssrTip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PageTestData.SuspendLayout();
            this.PageOther.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.grpVideoInfo);
            this.pnlBottom.Controls.Add(this.pnlBottom_Left);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 399);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(766, 136);
            this.pnlBottom.TabIndex = 0;
            // 
            // grpVideoInfo
            // 
            this.grpVideoInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpVideoInfo.Controls.Add(this.tabControl1);
            this.grpVideoInfo.Controls.Add(this.btnWindowPlay);
            this.grpVideoInfo.Controls.Add(this.btnTestClose);
            this.grpVideoInfo.Controls.Add(this.btnAddList);
            this.grpVideoInfo.Controls.Add(this.label14);
            this.grpVideoInfo.Controls.Add(this.btnTestPlay);
            this.grpVideoInfo.Controls.Add(this.cmbDVSAddress);
            this.grpVideoInfo.Controls.Add(this.cmbVideoType);
            this.grpVideoInfo.Controls.Add(this.label5);
            this.grpVideoInfo.Controls.Add(this.label7);
            this.grpVideoInfo.Controls.Add(this.label6);
            this.grpVideoInfo.Controls.Add(this.label4);
            this.grpVideoInfo.Controls.Add(this.txtPassword);
            this.grpVideoInfo.Controls.Add(this.label2);
            this.grpVideoInfo.Controls.Add(this.txtVideoID);
            this.grpVideoInfo.Controls.Add(this.txtContactPort);
            this.grpVideoInfo.Controls.Add(this.label3);
            this.grpVideoInfo.Controls.Add(this.txtUserName);
            this.grpVideoInfo.Controls.Add(this.txtChannel);
            this.grpVideoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVideoInfo.Location = new System.Drawing.Point(219, 0);
            this.grpVideoInfo.Name = "grpVideoInfo";
            this.grpVideoInfo.Size = new System.Drawing.Size(547, 136);
            this.grpVideoInfo.TabIndex = 5;
            this.grpVideoInfo.TabStop = false;
            this.grpVideoInfo.Text = "主机信息";
            // 
            // btnStartTalk
            // 
            this.btnStartTalk.Location = new System.Drawing.Point(9, 28);
            this.btnStartTalk.Name = "btnStartTalk";
            this.btnStartTalk.Size = new System.Drawing.Size(71, 23);
            this.btnStartTalk.TabIndex = 16;
            this.btnStartTalk.Text = "开始对讲";
            this.btnStartTalk.UseVisualStyleBackColor = true;
            // 
            // btnStopTest
            // 
            this.btnStopTest.Location = new System.Drawing.Point(6, 3);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.Size = new System.Drawing.Size(74, 23);
            this.btnStopTest.TabIndex = 15;
            this.btnStopTest.Text = "停止测试";
            this.btnStopTest.UseVisualStyleBackColor = true;
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // btnSKTestData
            // 
            this.btnSKTestData.Location = new System.Drawing.Point(83, 3);
            this.btnSKTestData.Name = "btnSKTestData";
            this.btnSKTestData.Size = new System.Drawing.Size(74, 22);
            this.btnSKTestData.TabIndex = 14;
            this.btnSKTestData.Text = "时刻数据";
            this.btnSKTestData.UseVisualStyleBackColor = true;
            this.btnSKTestData.Click += new System.EventHandler(this.btnSKTestData_Click);
            // 
            // btnEzvizTestData
            // 
            this.btnEzvizTestData.Location = new System.Drawing.Point(3, 3);
            this.btnEzvizTestData.Name = "btnEzvizTestData";
            this.btnEzvizTestData.Size = new System.Drawing.Size(74, 22);
            this.btnEzvizTestData.TabIndex = 14;
            this.btnEzvizTestData.Text = "萤石数据";
            this.btnEzvizTestData.UseVisualStyleBackColor = true;
            this.btnEzvizTestData.Click += new System.EventHandler(this.btnEzvizTestData_Click);
            // 
            // btnWindowPlay
            // 
            this.btnWindowPlay.Location = new System.Drawing.Point(208, 53);
            this.btnWindowPlay.Name = "btnWindowPlay";
            this.btnWindowPlay.Size = new System.Drawing.Size(63, 23);
            this.btnWindowPlay.TabIndex = 13;
            this.btnWindowPlay.Text = "窗口播放";
            this.btnWindowPlay.UseVisualStyleBackColor = true;
            this.btnWindowPlay.Click += new System.EventHandler(this.btnWindowPlay_Click);
            // 
            // btnTestClose
            // 
            this.btnTestClose.Location = new System.Drawing.Point(208, 107);
            this.btnTestClose.Name = "btnTestClose";
            this.btnTestClose.Size = new System.Drawing.Size(63, 23);
            this.btnTestClose.TabIndex = 12;
            this.btnTestClose.Text = "测试关闭";
            this.btnTestClose.UseVisualStyleBackColor = true;
            this.btnTestClose.Click += new System.EventHandler(this.btnTestClose_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(208, 13);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(63, 23);
            this.btnAddList.TabIndex = 11;
            this.btnAddList.Text = "添加";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "设备编号:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "预置点";
            // 
            // cmbOperAtPreset
            // 
            this.cmbOperAtPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperAtPreset.FormattingEnabled = true;
            this.cmbOperAtPreset.Location = new System.Drawing.Point(129, 27);
            this.cmbOperAtPreset.Name = "cmbOperAtPreset";
            this.cmbOperAtPreset.Size = new System.Drawing.Size(49, 20);
            this.cmbOperAtPreset.TabIndex = 30;
            this.cmbOperAtPreset.SelectedIndexChanged += new System.EventHandler(this.cmbOperAtPreset_SelectedIndexChanged);
            // 
            // cmbOperAtWindows
            // 
            this.cmbOperAtWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperAtWindows.FormattingEnabled = true;
            this.cmbOperAtWindows.Location = new System.Drawing.Point(129, 5);
            this.cmbOperAtWindows.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOperAtWindows.Name = "cmbOperAtWindows";
            this.cmbOperAtWindows.Size = new System.Drawing.Size(125, 20);
            this.cmbOperAtWindows.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "画面:";
            // 
            // btnVideoPlayClose
            // 
            this.btnVideoPlayClose.Location = new System.Drawing.Point(190, 61);
            this.btnVideoPlayClose.Name = "btnVideoPlayClose";
            this.btnVideoPlayClose.Size = new System.Drawing.Size(63, 23);
            this.btnVideoPlayClose.TabIndex = 0;
            this.btnVideoPlayClose.Text = "关闭视频";
            this.btnVideoPlayClose.UseVisualStyleBackColor = true;
            this.btnVideoPlayClose.Click += new System.EventHandler(this.btnVideoPlayClose_Click);
            // 
            // btnTestPlay
            // 
            this.btnTestPlay.Location = new System.Drawing.Point(208, 81);
            this.btnTestPlay.Name = "btnTestPlay";
            this.btnTestPlay.Size = new System.Drawing.Size(63, 23);
            this.btnTestPlay.TabIndex = 8;
            this.btnTestPlay.Text = "测试播放";
            this.btnTestPlay.UseVisualStyleBackColor = true;
            this.btnTestPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDVSAddress
            // 
            this.cmbDVSAddress.FormattingEnabled = true;
            this.cmbDVSAddress.Items.AddRange(new object[] {
            "B3CVR8WPEJLGAVKB111A\t",
            "NZP94PUSEB75YEH9111A\t",
            "AY4H56N9NA39D23T111A\t",
            "X5014851",
            "X6937816",
            "X7438372",
            "X5796224",
            "X4659975",
            "X6227077",
            "X6944415",
            "X7325728",
            "X12041891",
            "X7635198",
            "721283866",
            "720274352"});
            this.cmbDVSAddress.Location = new System.Drawing.Point(61, 60);
            this.cmbDVSAddress.Name = "cmbDVSAddress";
            this.cmbDVSAddress.Size = new System.Drawing.Size(141, 20);
            this.cmbDVSAddress.TabIndex = 4;
            this.cmbDVSAddress.Text = "819953945";
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Location = new System.Drawing.Point(61, 14);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(141, 20);
            this.cmbVideoType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密  码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "设备类型:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "连接端口:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用 户 名:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(40, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备地址:";
            // 
            // txtVideoID
            // 
            this.txtVideoID.Location = new System.Drawing.Point(60, 36);
            this.txtVideoID.Name = "txtVideoID";
            this.txtVideoID.Size = new System.Drawing.Size(142, 21);
            this.txtVideoID.TabIndex = 1;
            this.txtVideoID.Text = "000101";
            // 
            // txtContactPort
            // 
            this.txtContactPort.Location = new System.Drawing.Point(61, 83);
            this.txtContactPort.Name = "txtContactPort";
            this.txtContactPort.Size = new System.Drawing.Size(42, 21);
            this.txtContactPort.TabIndex = 1;
            this.txtContactPort.Text = "9101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "通道数:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(61, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(42, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "admin";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(162, 83);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(40, 21);
            this.txtChannel.TabIndex = 1;
            this.txtChannel.Text = "12";
            // 
            // pnlBottom_Left
            // 
            this.pnlBottom_Left.Controls.Add(this.videoWindowTest);
            this.pnlBottom_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottom_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom_Left.Name = "pnlBottom_Left";
            this.pnlBottom_Left.Size = new System.Drawing.Size(219, 136);
            this.pnlBottom_Left.TabIndex = 7;
            // 
            // chkMonitorEnable
            // 
            this.chkMonitorEnable.AutoSize = true;
            this.chkMonitorEnable.Checked = true;
            this.chkMonitorEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonitorEnable.Location = new System.Drawing.Point(3, 66);
            this.chkMonitorEnable.Name = "chkMonitorEnable";
            this.chkMonitorEnable.Size = new System.Drawing.Size(72, 16);
            this.chkMonitorEnable.TabIndex = 6;
            this.chkMonitorEnable.Text = "音频使能";
            this.chkMonitorEnable.UseVisualStyleBackColor = true;
            // 
            // chkVideoRecordEnable
            // 
            this.chkVideoRecordEnable.AutoSize = true;
            this.chkVideoRecordEnable.Checked = true;
            this.chkVideoRecordEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVideoRecordEnable.Location = new System.Drawing.Point(3, 46);
            this.chkVideoRecordEnable.Name = "chkVideoRecordEnable";
            this.chkVideoRecordEnable.Size = new System.Drawing.Size(72, 16);
            this.chkVideoRecordEnable.TabIndex = 6;
            this.chkVideoRecordEnable.Text = "录像使能";
            this.chkVideoRecordEnable.UseVisualStyleBackColor = true;
            // 
            // cmbPreset
            // 
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(65, 24);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(49, 20);
            this.cmbPreset.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 535);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(766, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tlpPlayVIdeoWindows);
            this.pnlMain.Controls.Add(this.splitter2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(766, 399);
            this.pnlMain.TabIndex = 2;
            // 
            // tlpPlayVIdeoWindows
            // 
            this.tlpPlayVIdeoWindows.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tlpPlayVIdeoWindows.ColumnCount = 1;
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlayVIdeoWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayVIdeoWindows.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayVIdeoWindows.Name = "tlpPlayVIdeoWindows";
            this.tlpPlayVIdeoWindows.RowCount = 1;
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayVIdeoWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tlpPlayVIdeoWindows.Size = new System.Drawing.Size(763, 399);
            this.tlpPlayVIdeoWindows.TabIndex = 9;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(763, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 399);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.tabControl);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(766, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(275, 538);
            this.pnlRight.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageVideoInfo);
            this.tabControl.Controls.Add(this.pageEventRecord);
            this.tabControl.Controls.Add(this.pageSetting);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(275, 538);
            this.tabControl.TabIndex = 0;
            // 
            // pageVideoInfo
            // 
            this.pageVideoInfo.Controls.Add(this.pnlVideoInfo_Right);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSAddress);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSType);
            this.pageVideoInfo.Controls.Add(this.label1);
            this.pageVideoInfo.Controls.Add(this.label9);
            this.pageVideoInfo.Controls.Add(this.label10);
            this.pageVideoInfo.Controls.Add(this.label11);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSPwd);
            this.pageVideoInfo.Controls.Add(this.label12);
            this.pageVideoInfo.Controls.Add(this.txtCurrentDVSPort);
            this.pageVideoInfo.Controls.Add(this.label13);
            this.pageVideoInfo.Controls.Add(this.txtCurrentUserName);
            this.pageVideoInfo.Controls.Add(this.txtCurrentChannelNum);
            this.pageVideoInfo.Controls.Add(this.cmbVideoList);
            this.pageVideoInfo.Location = new System.Drawing.Point(4, 22);
            this.pageVideoInfo.Name = "pageVideoInfo";
            this.pageVideoInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageVideoInfo.Size = new System.Drawing.Size(267, 512);
            this.pageVideoInfo.TabIndex = 0;
            this.pageVideoInfo.Text = "视频设备信息";
            this.pageVideoInfo.UseVisualStyleBackColor = true;
            // 
            // pnlVideoInfo_Right
            // 
            this.pnlVideoInfo_Right.Controls.Add(this.videoChannelList);
            this.pnlVideoInfo_Right.Controls.Add(this.pnlVideoInfo_Right_Top);
            this.pnlVideoInfo_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVideoInfo_Right.Location = new System.Drawing.Point(145, 3);
            this.pnlVideoInfo_Right.Name = "pnlVideoInfo_Right";
            this.pnlVideoInfo_Right.Size = new System.Drawing.Size(119, 506);
            this.pnlVideoInfo_Right.TabIndex = 34;
            // 
            // pnlVideoInfo_Right_Top
            // 
            this.pnlVideoInfo_Right_Top.Controls.Add(this.cmbPlayWindows);
            this.pnlVideoInfo_Right_Top.Controls.Add(this.chkPresetEanble);
            this.pnlVideoInfo_Right_Top.Controls.Add(this.cmbPreset);
            this.pnlVideoInfo_Right_Top.Controls.Add(this.chkVideoRecordEnable);
            this.pnlVideoInfo_Right_Top.Controls.Add(this.chkProVideoRecord);
            this.pnlVideoInfo_Right_Top.Controls.Add(this.chkMonitorEnable);
            this.pnlVideoInfo_Right_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVideoInfo_Right_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlVideoInfo_Right_Top.Name = "pnlVideoInfo_Right_Top";
            this.pnlVideoInfo_Right_Top.Size = new System.Drawing.Size(119, 103);
            this.pnlVideoInfo_Right_Top.TabIndex = 11;
            // 
            // cmbPlayWindows
            // 
            this.cmbPlayWindows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayWindows.FormattingEnabled = true;
            this.cmbPlayWindows.Location = new System.Drawing.Point(3, 3);
            this.cmbPlayWindows.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlayWindows.Name = "cmbPlayWindows";
            this.cmbPlayWindows.Size = new System.Drawing.Size(111, 20);
            this.cmbPlayWindows.TabIndex = 35;
            // 
            // chkPresetEanble
            // 
            this.chkPresetEanble.AutoSize = true;
            this.chkPresetEanble.Location = new System.Drawing.Point(3, 26);
            this.chkPresetEanble.Name = "chkPresetEanble";
            this.chkPresetEanble.Size = new System.Drawing.Size(60, 16);
            this.chkPresetEanble.TabIndex = 7;
            this.chkPresetEanble.Text = "预置点";
            this.chkPresetEanble.UseVisualStyleBackColor = true;
            // 
            // txtCurrentDVSAddress
            // 
            this.txtCurrentDVSAddress.Location = new System.Drawing.Point(67, 52);
            this.txtCurrentDVSAddress.Name = "txtCurrentDVSAddress";
            this.txtCurrentDVSAddress.Size = new System.Drawing.Size(75, 21);
            this.txtCurrentDVSAddress.TabIndex = 33;
            // 
            // txtCurrentDVSType
            // 
            this.txtCurrentDVSType.Location = new System.Drawing.Point(67, 29);
            this.txtCurrentDVSType.Name = "txtCurrentDVSType";
            this.txtCurrentDVSType.Size = new System.Drawing.Size(75, 21);
            this.txtCurrentDVSType.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "密    码:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "设备类型:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "连接端口:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "用 户 名:";
            // 
            // txtCurrentDVSPwd
            // 
            this.txtCurrentDVSPwd.Location = new System.Drawing.Point(67, 146);
            this.txtCurrentDVSPwd.Name = "txtCurrentDVSPwd";
            this.txtCurrentDVSPwd.Size = new System.Drawing.Size(75, 21);
            this.txtCurrentDVSPwd.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "设备地址:";
            // 
            // txtCurrentDVSPort
            // 
            this.txtCurrentDVSPort.Location = new System.Drawing.Point(67, 75);
            this.txtCurrentDVSPort.Name = "txtCurrentDVSPort";
            this.txtCurrentDVSPort.Size = new System.Drawing.Size(75, 21);
            this.txtCurrentDVSPort.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "通道数量:";
            // 
            // txtCurrentUserName
            // 
            this.txtCurrentUserName.Location = new System.Drawing.Point(67, 122);
            this.txtCurrentUserName.Name = "txtCurrentUserName";
            this.txtCurrentUserName.Size = new System.Drawing.Size(75, 21);
            this.txtCurrentUserName.TabIndex = 28;
            // 
            // txtCurrentChannelNum
            // 
            this.txtCurrentChannelNum.Location = new System.Drawing.Point(68, 99);
            this.txtCurrentChannelNum.Name = "txtCurrentChannelNum";
            this.txtCurrentChannelNum.Size = new System.Drawing.Size(74, 21);
            this.txtCurrentChannelNum.TabIndex = 29;
            // 
            // cmbVideoList
            // 
            this.cmbVideoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoList.FormattingEnabled = true;
            this.cmbVideoList.Location = new System.Drawing.Point(6, 6);
            this.cmbVideoList.Name = "cmbVideoList";
            this.cmbVideoList.Size = new System.Drawing.Size(136, 20);
            this.cmbVideoList.TabIndex = 14;
            this.cmbVideoList.SelectedIndexChanged += new System.EventHandler(this.cmbVideoList_SelectedIndexChanged);
            // 
            // pageEventRecord
            // 
            this.pageEventRecord.Controls.Add(this.dgvReocrd);
            this.pageEventRecord.Controls.Add(this.pnlEventRecord_Top);
            this.pageEventRecord.Location = new System.Drawing.Point(4, 22);
            this.pageEventRecord.Name = "pageEventRecord";
            this.pageEventRecord.Padding = new System.Windows.Forms.Padding(3);
            this.pageEventRecord.Size = new System.Drawing.Size(267, 512);
            this.pageEventRecord.TabIndex = 1;
            this.pageEventRecord.Text = "事件记录";
            this.pageEventRecord.UseVisualStyleBackColor = true;
            // 
            // dgvReocrd
            // 
            this.dgvReocrd.AllowUserToAddRows = false;
            this.dgvReocrd.AllowUserToDeleteRows = false;
            this.dgvReocrd.AllowUserToResizeRows = false;
            this.dgvReocrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReocrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvReocrd_Time,
            this.dgvReocrd_Tag,
            this.dgvReocrd_Content});
            this.dgvReocrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReocrd.Location = new System.Drawing.Point(3, 48);
            this.dgvReocrd.Name = "dgvReocrd";
            this.dgvReocrd.ReadOnly = true;
            this.dgvReocrd.RowHeadersVisible = false;
            this.dgvReocrd.RowTemplate.Height = 23;
            this.dgvReocrd.Size = new System.Drawing.Size(261, 461);
            this.dgvReocrd.TabIndex = 1;
            // 
            // dgvReocrd_Time
            // 
            this.dgvReocrd_Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Time.HeaderText = "记录事件";
            this.dgvReocrd_Time.Name = "dgvReocrd_Time";
            this.dgvReocrd_Time.ReadOnly = true;
            this.dgvReocrd_Time.Width = 78;
            // 
            // dgvReocrd_Tag
            // 
            this.dgvReocrd_Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Tag.HeaderText = "记录标签";
            this.dgvReocrd_Tag.Name = "dgvReocrd_Tag";
            this.dgvReocrd_Tag.ReadOnly = true;
            this.dgvReocrd_Tag.Width = 78;
            // 
            // dgvReocrd_Content
            // 
            this.dgvReocrd_Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvReocrd_Content.HeaderText = "记录内容";
            this.dgvReocrd_Content.Name = "dgvReocrd_Content";
            this.dgvReocrd_Content.ReadOnly = true;
            this.dgvReocrd_Content.Width = 78;
            // 
            // pnlEventRecord_Top
            // 
            this.pnlEventRecord_Top.Controls.Add(this.checkBox3);
            this.pnlEventRecord_Top.Controls.Add(this.checkBox2);
            this.pnlEventRecord_Top.Controls.Add(this.chkSDKStateCallback);
            this.pnlEventRecord_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEventRecord_Top.Location = new System.Drawing.Point(3, 3);
            this.pnlEventRecord_Top.Name = "pnlEventRecord_Top";
            this.pnlEventRecord_Top.Size = new System.Drawing.Size(261, 45);
            this.pnlEventRecord_Top.TabIndex = 2;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(3, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 16);
            this.checkBox3.TabIndex = 31;
            this.checkBox3.Text = "视频播放事件回调显示";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(123, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 16);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "SDK回调事件显示";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkSDKStateCallback
            // 
            this.chkSDKStateCallback.AutoSize = true;
            this.chkSDKStateCallback.Checked = true;
            this.chkSDKStateCallback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSDKStateCallback.Location = new System.Drawing.Point(3, 3);
            this.chkSDKStateCallback.Name = "chkSDKStateCallback";
            this.chkSDKStateCallback.Size = new System.Drawing.Size(114, 16);
            this.chkSDKStateCallback.TabIndex = 33;
            this.chkSDKStateCallback.Text = "SDK状态回调显示";
            this.chkSDKStateCallback.UseVisualStyleBackColor = true;
            // 
            // pageSetting
            // 
            this.pageSetting.Controls.Add(this.label17);
            this.pageSetting.Controls.Add(this.grpSKSDKStatus);
            this.pageSetting.Controls.Add(this.grpEzvizSDKState);
            this.pageSetting.Controls.Add(this.grpCloundSeeSDKState);
            this.pageSetting.Controls.Add(this.label16);
            this.pageSetting.Controls.Add(this.cmbPlayVideoWindowSet);
            this.pageSetting.Location = new System.Drawing.Point(4, 22);
            this.pageSetting.Name = "pageSetting";
            this.pageSetting.Size = new System.Drawing.Size(267, 512);
            this.pageSetting.TabIndex = 2;
            this.pageSetting.Text = "系统状态";
            this.pageSetting.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "label17";
            // 
            // grpSKSDKStatus
            // 
            this.grpSKSDKStatus.Controls.Add(this.btnSKSDKInit);
            this.grpSKSDKStatus.Controls.Add(this.btnGetSKSDKStatus);
            this.grpSKSDKStatus.Controls.Add(this.btnSKSDKUninit);
            this.grpSKSDKStatus.Location = new System.Drawing.Point(5, 139);
            this.grpSKSDKStatus.Name = "grpSKSDKStatus";
            this.grpSKSDKStatus.Size = new System.Drawing.Size(200, 48);
            this.grpSKSDKStatus.TabIndex = 33;
            this.grpSKSDKStatus.TabStop = false;
            this.grpSKSDKStatus.Text = "时刻SDK状态";
            // 
            // btnSKSDKInit
            // 
            this.btnSKSDKInit.Location = new System.Drawing.Point(7, 19);
            this.btnSKSDKInit.Name = "btnSKSDKInit";
            this.btnSKSDKInit.Size = new System.Drawing.Size(67, 23);
            this.btnSKSDKInit.TabIndex = 32;
            this.btnSKSDKInit.Text = "SDK初始化";
            this.btnSKSDKInit.UseVisualStyleBackColor = true;
            // 
            // btnGetSKSDKStatus
            // 
            this.btnGetSKSDKStatus.Location = new System.Drawing.Point(137, 19);
            this.btnGetSKSDKStatus.Name = "btnGetSKSDKStatus";
            this.btnGetSKSDKStatus.Size = new System.Drawing.Size(57, 23);
            this.btnGetSKSDKStatus.TabIndex = 32;
            this.btnGetSKSDKStatus.Text = "SDK状态";
            this.btnGetSKSDKStatus.UseVisualStyleBackColor = true;
            this.btnGetSKSDKStatus.Click += new System.EventHandler(this.btnGetSKSDKStatus_Click);
            // 
            // btnSKSDKUninit
            // 
            this.btnSKSDKUninit.Location = new System.Drawing.Point(77, 19);
            this.btnSKSDKUninit.Name = "btnSKSDKUninit";
            this.btnSKSDKUninit.Size = new System.Drawing.Size(57, 23);
            this.btnSKSDKUninit.TabIndex = 32;
            this.btnSKSDKUninit.Text = "SDK释放";
            this.btnSKSDKUninit.UseVisualStyleBackColor = true;
            // 
            // grpEzvizSDKState
            // 
            this.grpEzvizSDKState.Controls.Add(this.btnEzvizSDKInit);
            this.grpEzvizSDKState.Controls.Add(this.btnEzvizSDKRelease);
            this.grpEzvizSDKState.Location = new System.Drawing.Point(5, 85);
            this.grpEzvizSDKState.Name = "grpEzvizSDKState";
            this.grpEzvizSDKState.Size = new System.Drawing.Size(200, 48);
            this.grpEzvizSDKState.TabIndex = 33;
            this.grpEzvizSDKState.TabStop = false;
            this.grpEzvizSDKState.Text = "萤石云SDK状态";
            // 
            // btnEzvizSDKInit
            // 
            this.btnEzvizSDKInit.Location = new System.Drawing.Point(7, 20);
            this.btnEzvizSDKInit.Name = "btnEzvizSDKInit";
            this.btnEzvizSDKInit.Size = new System.Drawing.Size(79, 23);
            this.btnEzvizSDKInit.TabIndex = 32;
            this.btnEzvizSDKInit.Text = "SDK初始化";
            this.btnEzvizSDKInit.UseVisualStyleBackColor = true;
            this.btnEzvizSDKInit.Click += new System.EventHandler(this.btnEzvizSDKInit_Click);
            // 
            // btnEzvizSDKRelease
            // 
            this.btnEzvizSDKRelease.Location = new System.Drawing.Point(115, 19);
            this.btnEzvizSDKRelease.Name = "btnEzvizSDKRelease";
            this.btnEzvizSDKRelease.Size = new System.Drawing.Size(79, 23);
            this.btnEzvizSDKRelease.TabIndex = 32;
            this.btnEzvizSDKRelease.Text = "SDK释放";
            this.btnEzvizSDKRelease.UseVisualStyleBackColor = true;
            this.btnEzvizSDKRelease.Click += new System.EventHandler(this.btnEzvizSDKRelease_Click);
            // 
            // grpCloundSeeSDKState
            // 
            this.grpCloundSeeSDKState.Controls.Add(this.btnCloundSeeSDKInit);
            this.grpCloundSeeSDKState.Controls.Add(this.btnCloundSeeSDKRelease);
            this.grpCloundSeeSDKState.Location = new System.Drawing.Point(5, 31);
            this.grpCloundSeeSDKState.Name = "grpCloundSeeSDKState";
            this.grpCloundSeeSDKState.Size = new System.Drawing.Size(200, 48);
            this.grpCloundSeeSDKState.TabIndex = 33;
            this.grpCloundSeeSDKState.TabStop = false;
            this.grpCloundSeeSDKState.Text = "云视通SDK状态";
            // 
            // btnCloundSeeSDKInit
            // 
            this.btnCloundSeeSDKInit.Location = new System.Drawing.Point(7, 20);
            this.btnCloundSeeSDKInit.Name = "btnCloundSeeSDKInit";
            this.btnCloundSeeSDKInit.Size = new System.Drawing.Size(79, 23);
            this.btnCloundSeeSDKInit.TabIndex = 32;
            this.btnCloundSeeSDKInit.Text = "SDK初始化";
            this.btnCloundSeeSDKInit.UseVisualStyleBackColor = true;
            this.btnCloundSeeSDKInit.Click += new System.EventHandler(this.btnCloundSeeSDKInit_Click);
            // 
            // btnCloundSeeSDKRelease
            // 
            this.btnCloundSeeSDKRelease.Location = new System.Drawing.Point(115, 19);
            this.btnCloundSeeSDKRelease.Name = "btnCloundSeeSDKRelease";
            this.btnCloundSeeSDKRelease.Size = new System.Drawing.Size(79, 23);
            this.btnCloundSeeSDKRelease.TabIndex = 32;
            this.btnCloundSeeSDKRelease.Text = "SDK释放";
            this.btnCloundSeeSDKRelease.UseVisualStyleBackColor = true;
            this.btnCloundSeeSDKRelease.Click += new System.EventHandler(this.btnCloundSeeSDKRelease_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "画面数量";
            // 
            // cmbPlayVideoWindowSet
            // 
            this.cmbPlayVideoWindowSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayVideoWindowSet.FormattingEnabled = true;
            this.cmbPlayVideoWindowSet.Location = new System.Drawing.Point(61, 6);
            this.cmbPlayVideoWindowSet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlayVideoWindowSet.Name = "cmbPlayVideoWindowSet";
            this.cmbPlayVideoWindowSet.Size = new System.Drawing.Size(126, 20);
            this.cmbPlayVideoWindowSet.TabIndex = 30;
            // 
            // ssrTip
            // 
            this.ssrTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblPrompt});
            this.ssrTip.Location = new System.Drawing.Point(0, 538);
            this.ssrTip.Name = "ssrTip";
            this.ssrTip.Size = new System.Drawing.Size(1041, 22);
            this.ssrTip.TabIndex = 7;
            this.ssrTip.Text = "statusStrip1";
            // 
            // tsslblPrompt
            // 
            this.tsslblPrompt.Name = "tsslblPrompt";
            this.tsslblPrompt.Size = new System.Drawing.Size(32, 17);
            this.tsslblPrompt.Text = "提示";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // videoPTZControl1
            // 
            this.videoPTZControl1.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl1.Location = new System.Drawing.Point(3, 6);
            this.videoPTZControl1.Name = "videoPTZControl1";
            this.videoPTZControl1.Size = new System.Drawing.Size(81, 78);
            this.videoPTZControl1.TabIndex = 9;
            // 
            // videoWindowTest
            // 
            this.videoWindowTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoWindowTest.Location = new System.Drawing.Point(0, 0);
            this.videoWindowTest.Name = "videoWindowTest";
            this.videoWindowTest.Size = new System.Drawing.Size(219, 136);
            this.videoWindowTest.TabIndex = 0;
            this.videoWindowTest.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // videoChannelList
            // 
            this.videoChannelList.AutoSetChannelButtonSize = false;
            this.videoChannelList.ChannelButtonColumn = 1;
            this.videoChannelList.ChannelButtonHeight = 30;
            this.videoChannelList.ChannelButtonWidth = 60;
            this.videoChannelList.ClrBackColor = System.Drawing.SystemColors.ControlDark;
            this.videoChannelList.ClrChannelButtonDefaultColor = System.Drawing.SystemColors.Control;
            this.videoChannelList.ClrChannelButtonSelectedColor = System.Drawing.Color.Red;
            this.videoChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoChannelList.Location = new System.Drawing.Point(0, 103);
            this.videoChannelList.Name = "videoChannelList";
            this.videoChannelList.Size = new System.Drawing.Size(119, 403);
            this.videoChannelList.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageTestData);
            this.tabControl1.Controls.Add(this.PageOther);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(277, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 117);
            this.tabControl1.TabIndex = 35;
            // 
            // PageTestData
            // 
            this.PageTestData.Controls.Add(this.btnEzvizTestData);
            this.PageTestData.Controls.Add(this.btnSKTestData);
            this.PageTestData.Location = new System.Drawing.Point(4, 22);
            this.PageTestData.Name = "PageTestData";
            this.PageTestData.Padding = new System.Windows.Forms.Padding(3);
            this.PageTestData.Size = new System.Drawing.Size(163, 74);
            this.PageTestData.TabIndex = 0;
            this.PageTestData.Text = "测试数据";
            this.PageTestData.UseVisualStyleBackColor = true;
            // 
            // PageOther
            // 
            this.PageOther.Controls.Add(this.btnStartTalk);
            this.PageOther.Controls.Add(this.btnStopTest);
            this.PageOther.Location = new System.Drawing.Point(4, 22);
            this.PageOther.Name = "PageOther";
            this.PageOther.Padding = new System.Windows.Forms.Padding(3);
            this.PageOther.Size = new System.Drawing.Size(163, 74);
            this.PageOther.TabIndex = 1;
            this.PageOther.Text = "其他";
            this.PageOther.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cmbOperAtPreset);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbOperAtWindows);
            this.tabPage1.Controls.Add(this.btnVideoPlayClose);
            this.tabPage1.Controls.Add(this.videoPTZControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(256, 91);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkProVideoRecord
            // 
            this.chkProVideoRecord.AutoSize = true;
            this.chkProVideoRecord.Checked = true;
            this.chkProVideoRecord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProVideoRecord.Location = new System.Drawing.Point(3, 84);
            this.chkProVideoRecord.Name = "chkProVideoRecord";
            this.chkProVideoRecord.Size = new System.Drawing.Size(84, 16);
            this.chkProVideoRecord.TabIndex = 6;
            this.chkProVideoRecord.Text = "预录像使能";
            this.chkProVideoRecord.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 560);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.ssrTip);
            this.Name = "FrmMain";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            this.pnlBottom.ResumeLayout(false);
            this.grpVideoInfo.ResumeLayout(false);
            this.grpVideoInfo.PerformLayout();
            this.pnlBottom_Left.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pageVideoInfo.ResumeLayout(false);
            this.pageVideoInfo.PerformLayout();
            this.pnlVideoInfo_Right.ResumeLayout(false);
            this.pnlVideoInfo_Right_Top.ResumeLayout(false);
            this.pnlVideoInfo_Right_Top.PerformLayout();
            this.pageEventRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReocrd)).EndInit();
            this.pnlEventRecord_Top.ResumeLayout(false);
            this.pnlEventRecord_Top.PerformLayout();
            this.pageSetting.ResumeLayout(false);
            this.pageSetting.PerformLayout();
            this.grpSKSDKStatus.ResumeLayout(false);
            this.grpEzvizSDKState.ResumeLayout(false);
            this.grpCloundSeeSDKState.ResumeLayout(false);
            this.ssrTip.ResumeLayout(false);
            this.ssrTip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PageTestData.ResumeLayout(false);
            this.PageOther.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.GroupBox grpVideoInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactPort;
        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip ssrTip;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPrompt;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvReocrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvReocrd_Content;
        private System.Windows.Forms.Panel pnlBottom_Left;
        private System.Windows.Forms.TableLayoutPanel tlpPlayVIdeoWindows;
        private VideoPlayControl.VideoPlayWindow videoWindowTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDVSAddress;
        private System.Windows.Forms.Button btnVideoPlayClose;
        private System.Windows.Forms.CheckBox chkVideoRecordEnable;
        private System.Windows.Forms.CheckBox chkMonitorEnable;
        private System.Windows.Forms.Button btnTestPlay;
        private VideoPlayControl.VideoPTZControl videoPTZControl1;
        private VideoPlayControl.VideoChannelList videoChannelList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageVideoInfo;
        private System.Windows.Forms.TabPage pageEventRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrentDVSPwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCurrentDVSPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCurrentUserName;
        private System.Windows.Forms.TextBox txtCurrentChannelNum;
        private System.Windows.Forms.ComboBox cmbVideoList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCurrentDVSType;
        private System.Windows.Forms.TextBox txtVideoID;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox txtCurrentDVSAddress;
        private System.Windows.Forms.Panel pnlEventRecord_Top;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkSDKStateCallback;
        private System.Windows.Forms.CheckBox chkPresetEanble;
        private System.Windows.Forms.Panel pnlVideoInfo_Right;
        private System.Windows.Forms.Panel pnlVideoInfo_Right_Top;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbOperAtPreset;
        private System.Windows.Forms.ComboBox cmbPlayWindows;
        private System.Windows.Forms.ComboBox cmbOperAtWindows;
        private System.Windows.Forms.TabPage pageSetting;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbPlayVideoWindowSet;
        private System.Windows.Forms.Button btnTestClose;
        private System.Windows.Forms.Button btnCloundSeeSDKInit;
        private System.Windows.Forms.Button btnCloundSeeSDKRelease;
        private System.Windows.Forms.GroupBox grpCloundSeeSDKState;
        private System.Windows.Forms.Button btnWindowPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox grpEzvizSDKState;
        private System.Windows.Forms.Button btnEzvizSDKInit;
        private System.Windows.Forms.Button btnEzvizSDKRelease;
        private System.Windows.Forms.Button btnEzvizTestData;
        private System.Windows.Forms.Button btnStopTest;
        private System.Windows.Forms.Button btnSKTestData;
        private System.Windows.Forms.Button btnStartTalk;
        private System.Windows.Forms.GroupBox grpSKSDKStatus;
        private System.Windows.Forms.Button btnSKSDKInit;
        private System.Windows.Forms.Button btnSKSDKUninit;
        private System.Windows.Forms.Button btnGetSKSDKStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageTestData;
        private System.Windows.Forms.TabPage PageOther;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkProVideoRecord;
    }
}

