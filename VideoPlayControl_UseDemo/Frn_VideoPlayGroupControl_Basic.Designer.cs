﻿namespace VideoPlayControl_UseDemo
{
    partial class Frn_VideoPlayGroupControl_Basic
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.videoPlayGroupControls_Basic1 = new VideoPlayControl.VideoPlayGroupControls_Basic();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnSDKReInit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCameraID = new System.Windows.Forms.TextBox();
            this.txtVideoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.btnTestData1 = new System.Windows.Forms.Button();
            this.btnTestData2 = new System.Windows.Forms.Button();
            this.btnTestData3 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoPlayGroupControls_Basic1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(706, 472);
            this.pnlMain.TabIndex = 1;
            // 
            // videoPlayGroupControls_Basic1
            // 
            this.videoPlayGroupControls_Basic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayGroupControls_Basic1.Location = new System.Drawing.Point(0, 0);
            this.videoPlayGroupControls_Basic1.Name = "videoPlayGroupControls_Basic1";
            this.videoPlayGroupControls_Basic1.Size = new System.Drawing.Size(706, 472);
            this.videoPlayGroupControls_Basic1.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnTestData3);
            this.pnlRight.Controls.Add(this.btnTestData2);
            this.pnlRight.Controls.Add(this.btnTestData1);
            this.pnlRight.Controls.Add(this.btnSDKReInit);
            this.pnlRight.Controls.Add(this.button1);
            this.pnlRight.Controls.Add(this.txtCameraID);
            this.pnlRight.Controls.Add(this.txtVideoID);
            this.pnlRight.Controls.Add(this.label2);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.btnVideoPlay);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(706, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(134, 472);
            this.pnlRight.TabIndex = 2;
            // 
            // btnSDKReInit
            // 
            this.btnSDKReInit.Location = new System.Drawing.Point(30, 137);
            this.btnSDKReInit.Name = "btnSDKReInit";
            this.btnSDKReInit.Size = new System.Drawing.Size(92, 23);
            this.btnSDKReInit.TabIndex = 3;
            this.btnSDKReInit.Text = "SDKReInit";
            this.btnSDKReInit.UseVisualStyleBackColor = true;
            this.btnSDKReInit.Click += new System.EventHandler(this.btnSDKReInit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ReInit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCameraID
            // 
            this.txtCameraID.Location = new System.Drawing.Point(69, 33);
            this.txtCameraID.Name = "txtCameraID";
            this.txtCameraID.Size = new System.Drawing.Size(53, 21);
            this.txtCameraID.TabIndex = 2;
            this.txtCameraID.Text = "01";
            // 
            // txtVideoID
            // 
            this.txtVideoID.Location = new System.Drawing.Point(69, 6);
            this.txtVideoID.Name = "txtVideoID";
            this.txtVideoID.Size = new System.Drawing.Size(53, 21);
            this.txtVideoID.TabIndex = 2;
            this.txtVideoID.Text = "000102";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "CameraID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "VideoID";
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(47, 60);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(75, 23);
            this.btnVideoPlay.TabIndex = 0;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.btnVideoPlay_Click);
            // 
            // btnTestData1
            // 
            this.btnTestData1.Location = new System.Drawing.Point(47, 166);
            this.btnTestData1.Name = "btnTestData1";
            this.btnTestData1.Size = new System.Drawing.Size(75, 23);
            this.btnTestData1.TabIndex = 4;
            this.btnTestData1.Text = "测试数据1";
            this.btnTestData1.UseVisualStyleBackColor = true;
            this.btnTestData1.Click += new System.EventHandler(this.btnTestData1_Click);
            // 
            // btnTestData2
            // 
            this.btnTestData2.Location = new System.Drawing.Point(47, 195);
            this.btnTestData2.Name = "btnTestData2";
            this.btnTestData2.Size = new System.Drawing.Size(75, 23);
            this.btnTestData2.TabIndex = 4;
            this.btnTestData2.Text = "测试数据2";
            this.btnTestData2.UseVisualStyleBackColor = true;
            this.btnTestData2.Click += new System.EventHandler(this.btnTestData2_Click);
            // 
            // btnTestData3
            // 
            this.btnTestData3.Location = new System.Drawing.Point(47, 224);
            this.btnTestData3.Name = "btnTestData3";
            this.btnTestData3.Size = new System.Drawing.Size(75, 23);
            this.btnTestData3.TabIndex = 4;
            this.btnTestData3.Text = "测试数据3";
            this.btnTestData3.UseVisualStyleBackColor = true;
            this.btnTestData3.Click += new System.EventHandler(this.btnTestData3_Click);
            // 
            // Frn_VideoPlayGroupControl_Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRight);
            this.Name = "Frn_VideoPlayGroupControl_Basic";
            this.Text = "视频播放控件组_基本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frn_VideoPlayGroupControl_Basic_FormClosing);
            this.Load += new System.EventHandler(this.Frn_VideoPlayGroupControl_Basic_Load);
            this.Move += new System.EventHandler(this.Frn_VideoPlayGroupControl_Basic_Move);
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControls_Basic videoPlayGroupControls_Basic1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.TextBox txtCameraID;
        private System.Windows.Forms.TextBox txtVideoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSDKReInit;
        private System.Windows.Forms.Button btnTestData3;
        private System.Windows.Forms.Button btnTestData2;
        private System.Windows.Forms.Button btnTestData1;
    }
}