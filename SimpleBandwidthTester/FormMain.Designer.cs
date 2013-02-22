namespace SimpleBandwidthTester
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonClientMode = new System.Windows.Forms.RadioButton();
            this.radioButtonServerMode = new System.Windows.Forms.RadioButton();
            this.groupBoxServerControls = new System.Windows.Forms.GroupBox();
            this.buttonStopServer = new System.Windows.Forms.Button();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.textBoxServerServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxClientControls = new System.Windows.Forms.GroupBox();
            this.textBoxClientServerPort = new System.Windows.Forms.TextBox();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.textBoxClientServerAddress = new System.Windows.Forms.TextBox();
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxServerControls.SuspendLayout();
            this.groupBoxClientControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setConfigurationToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // setConfigurationToolStripMenuItem
            // 
            this.setConfigurationToolStripMenuItem.Name = "setConfigurationToolStripMenuItem";
            this.setConfigurationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setConfigurationToolStripMenuItem.Text = "Set Configuration";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Details";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(592, 163);
            this.textBoxOutput.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonClientMode);
            this.groupBox4.Controls.Add(this.radioButtonServerMode);
            this.groupBox4.Location = new System.Drawing.Point(12, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 42);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operation Type";
            // 
            // radioButtonClientMode
            // 
            this.radioButtonClientMode.AutoSize = true;
            this.radioButtonClientMode.Location = new System.Drawing.Point(390, 19);
            this.radioButtonClientMode.Name = "radioButtonClientMode";
            this.radioButtonClientMode.Size = new System.Drawing.Size(81, 17);
            this.radioButtonClientMode.TabIndex = 1;
            this.radioButtonClientMode.Text = "Client Mode";
            this.radioButtonClientMode.UseVisualStyleBackColor = true;
            this.radioButtonClientMode.CheckedChanged += new System.EventHandler(this.radioButtonClientMode_CheckedChanged);
            // 
            // radioButtonServerMode
            // 
            this.radioButtonServerMode.AutoSize = true;
            this.radioButtonServerMode.Location = new System.Drawing.Point(143, 19);
            this.radioButtonServerMode.Name = "radioButtonServerMode";
            this.radioButtonServerMode.Size = new System.Drawing.Size(86, 17);
            this.radioButtonServerMode.TabIndex = 0;
            this.radioButtonServerMode.Text = "Server Mode";
            this.radioButtonServerMode.UseVisualStyleBackColor = true;
            this.radioButtonServerMode.CheckedChanged += new System.EventHandler(this.radioButtonServerMode_CheckedChanged);
            // 
            // groupBoxServerControls
            // 
            this.groupBoxServerControls.Controls.Add(this.buttonStopServer);
            this.groupBoxServerControls.Controls.Add(this.buttonStartServer);
            this.groupBoxServerControls.Controls.Add(this.textBoxServerServerPort);
            this.groupBoxServerControls.Controls.Add(this.label2);
            this.groupBoxServerControls.Location = new System.Drawing.Point(12, 77);
            this.groupBoxServerControls.Name = "groupBoxServerControls";
            this.groupBoxServerControls.Size = new System.Drawing.Size(298, 148);
            this.groupBoxServerControls.TabIndex = 8;
            this.groupBoxServerControls.TabStop = false;
            this.groupBoxServerControls.Text = "Server Controls";
            // 
            // buttonStopServer
            // 
            this.buttonStopServer.Location = new System.Drawing.Point(16, 116);
            this.buttonStopServer.Name = "buttonStopServer";
            this.buttonStopServer.Size = new System.Drawing.Size(78, 26);
            this.buttonStopServer.TabIndex = 14;
            this.buttonStopServer.Text = "Stop Server";
            this.buttonStopServer.UseVisualStyleBackColor = true;
            this.buttonStopServer.Click += new System.EventHandler(this.buttonStopServer_Click);
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Location = new System.Drawing.Point(203, 116);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(78, 26);
            this.buttonStartServer.TabIndex = 13;
            this.buttonStartServer.Text = "Start Server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // textBoxServerServerPort
            // 
            this.textBoxServerServerPort.Location = new System.Drawing.Point(16, 41);
            this.textBoxServerServerPort.Name = "textBoxServerServerPort";
            this.textBoxServerServerPort.Size = new System.Drawing.Size(265, 20);
            this.textBoxServerServerPort.TabIndex = 12;
            this.textBoxServerServerPort.Text = "11112";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Listening Port";
            // 
            // groupBoxClientControls
            // 
            this.groupBoxClientControls.Controls.Add(this.textBoxClientServerPort);
            this.groupBoxClientControls.Controls.Add(this.labelServerPort);
            this.groupBoxClientControls.Controls.Add(this.buttonStartTest);
            this.groupBoxClientControls.Controls.Add(this.textBoxClientServerAddress);
            this.groupBoxClientControls.Controls.Add(this.labelServerAddress);
            this.groupBoxClientControls.Location = new System.Drawing.Point(325, 77);
            this.groupBoxClientControls.Name = "groupBoxClientControls";
            this.groupBoxClientControls.Size = new System.Drawing.Size(295, 148);
            this.groupBoxClientControls.TabIndex = 14;
            this.groupBoxClientControls.TabStop = false;
            this.groupBoxClientControls.Text = "Client Controls";
            // 
            // textBoxClientServerPort
            // 
            this.textBoxClientServerPort.Location = new System.Drawing.Point(16, 80);
            this.textBoxClientServerPort.Name = "textBoxClientServerPort";
            this.textBoxClientServerPort.Size = new System.Drawing.Size(269, 20);
            this.textBoxClientServerPort.TabIndex = 15;
            this.textBoxClientServerPort.Text = "11112";
            // 
            // labelServerPort
            // 
            this.labelServerPort.AutoSize = true;
            this.labelServerPort.Location = new System.Drawing.Point(13, 64);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(60, 13);
            this.labelServerPort.TabIndex = 14;
            this.labelServerPort.Text = "Server Port";
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(207, 116);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(78, 26);
            this.buttonStartTest.TabIndex = 13;
            this.buttonStartTest.Text = "Start Test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartText_Click);
            // 
            // textBoxClientServerAddress
            // 
            this.textBoxClientServerAddress.Location = new System.Drawing.Point(16, 41);
            this.textBoxClientServerAddress.Name = "textBoxClientServerAddress";
            this.textBoxClientServerAddress.Size = new System.Drawing.Size(269, 20);
            this.textBoxClientServerAddress.TabIndex = 12;
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.AutoSize = true;
            this.labelServerAddress.Location = new System.Drawing.Point(13, 25);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(79, 13);
            this.labelServerAddress.TabIndex = 11;
            this.labelServerAddress.Text = "Server Address";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.groupBoxClientControls);
            this.Controls.Add(this.groupBoxServerControls);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Simple Bandwidth Tester";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxServerControls.ResumeLayout(false);
            this.groupBoxServerControls.PerformLayout();
            this.groupBoxClientControls.ResumeLayout(false);
            this.groupBoxClientControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setConfigurationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonClientMode;
        private System.Windows.Forms.RadioButton radioButtonServerMode;
        private System.Windows.Forms.GroupBox groupBoxServerControls;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.TextBox textBoxServerServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxClientControls;
        private System.Windows.Forms.TextBox textBoxClientServerPort;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.TextBox textBoxClientServerAddress;
        private System.Windows.Forms.Label labelServerAddress;
        private System.Windows.Forms.Button buttonStopServer;
    }
}

