namespace ChatApp
{
    partial class Form1
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
            this.edtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerIp = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.edtServerPort = new System.Windows.Forms.TextBox();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.edtClientPort = new System.Windows.Forms.TextBox();
            this.lblClientIP = new System.Windows.Forms.Label();
            this.edtClientIP = new System.Windows.Forms.TextBox();
            this.redtHistory = new System.Windows.Forms.RichTextBox();
            this.btnToSend = new System.Windows.Forms.Button();
            this.edtToSend = new System.Windows.Forms.TextBox();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // edtServerIP
            // 
            this.edtServerIP.Location = new System.Drawing.Point(31, 41);
            this.edtServerIP.Name = "edtServerIP";
            this.edtServerIP.Size = new System.Drawing.Size(400, 20);
            this.edtServerIP.TabIndex = 0;
            // 
            // lblServerIp
            // 
            this.lblServerIp.AutoSize = true;
            this.lblServerIp.Location = new System.Drawing.Point(31, 22);
            this.lblServerIp.Name = "lblServerIp";
            this.lblServerIp.Size = new System.Drawing.Size(51, 13);
            this.lblServerIp.TabIndex = 1;
            this.lblServerIp.Text = "Server IP";
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(437, 22);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(60, 13);
            this.lblServerPort.TabIndex = 3;
            this.lblServerPort.Text = "Server Port";
            // 
            // edtServerPort
            // 
            this.edtServerPort.Location = new System.Drawing.Point(437, 41);
            this.edtServerPort.Name = "edtServerPort";
            this.edtServerPort.Size = new System.Drawing.Size(100, 20);
            this.edtServerPort.TabIndex = 2;
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(437, 75);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(55, 13);
            this.lblClientPort.TabIndex = 7;
            this.lblClientPort.Text = "Client Port";
            // 
            // edtClientPort
            // 
            this.edtClientPort.Location = new System.Drawing.Point(437, 94);
            this.edtClientPort.Name = "edtClientPort";
            this.edtClientPort.Size = new System.Drawing.Size(100, 20);
            this.edtClientPort.TabIndex = 6;
            // 
            // lblClientIP
            // 
            this.lblClientIP.AutoSize = true;
            this.lblClientIP.Location = new System.Drawing.Point(31, 75);
            this.lblClientIP.Name = "lblClientIP";
            this.lblClientIP.Size = new System.Drawing.Size(46, 13);
            this.lblClientIP.TabIndex = 5;
            this.lblClientIP.Text = "Client IP";
            // 
            // edtClientIP
            // 
            this.edtClientIP.Location = new System.Drawing.Point(31, 94);
            this.edtClientIP.Name = "edtClientIP";
            this.edtClientIP.Size = new System.Drawing.Size(400, 20);
            this.edtClientIP.TabIndex = 4;
            // 
            // redtHistory
            // 
            this.redtHistory.Location = new System.Drawing.Point(31, 148);
            this.redtHistory.Name = "redtHistory";
            this.redtHistory.Size = new System.Drawing.Size(506, 254);
            this.redtHistory.TabIndex = 8;
            this.redtHistory.Text = "";
            // 
            // btnToSend
            // 
            this.btnToSend.Location = new System.Drawing.Point(568, 416);
            this.btnToSend.Name = "btnToSend";
            this.btnToSend.Size = new System.Drawing.Size(97, 23);
            this.btnToSend.TabIndex = 9;
            this.btnToSend.Text = "Send";
            this.btnToSend.UseVisualStyleBackColor = true;
            this.btnToSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edtToSend
            // 
            this.edtToSend.Location = new System.Drawing.Point(31, 418);
            this.edtToSend.Name = "edtToSend";
            this.edtToSend.Size = new System.Drawing.Size(506, 20);
            this.edtToSend.TabIndex = 10;
            // 
            // btnClientStart
            // 
            this.btnClientStart.Location = new System.Drawing.Point(543, 92);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(122, 23);
            this.btnClientStart.TabIndex = 11;
            this.btnClientStart.Text = "CONNECT";
            this.btnClientStart.UseVisualStyleBackColor = true;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(544, 37);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(121, 23);
            this.btnServerStart.TabIndex = 12;
            this.btnServerStart.Text = "START";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnServerStart);
            this.Controls.Add(this.btnClientStart);
            this.Controls.Add(this.edtToSend);
            this.Controls.Add(this.btnToSend);
            this.Controls.Add(this.redtHistory);
            this.Controls.Add(this.lblClientPort);
            this.Controls.Add(this.edtClientPort);
            this.Controls.Add(this.lblClientIP);
            this.Controls.Add(this.edtClientIP);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.edtServerPort);
            this.Controls.Add(this.lblServerIp);
            this.Controls.Add(this.edtServerIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtServerIP;
        private System.Windows.Forms.Label lblServerIp;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox edtServerPort;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.TextBox edtClientPort;
        private System.Windows.Forms.Label lblClientIP;
        private System.Windows.Forms.TextBox edtClientIP;
        private System.Windows.Forms.RichTextBox redtHistory;
        private System.Windows.Forms.Button btnToSend;
        private System.Windows.Forms.TextBox edtToSend;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.Button btnServerStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

