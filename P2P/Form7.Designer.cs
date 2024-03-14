namespace P2P
{
    partial class Form7
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
            this.txtNews = new System.Windows.Forms.TextBox();
            this.txtNotif = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMyHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.showRumerbtn = new System.Windows.Forms.Button();
            this.rumortxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNews
            // 
            this.txtNews.BackColor = System.Drawing.SystemColors.Control;
            this.txtNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNews.Location = new System.Drawing.Point(614, 217);
            this.txtNews.Multiline = true;
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(110, 191);
            this.txtNews.TabIndex = 106;
            // 
            // txtNotif
            // 
            this.txtNotif.BackColor = System.Drawing.SystemColors.Control;
            this.txtNotif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotif.ForeColor = System.Drawing.Color.Red;
            this.txtNotif.Location = new System.Drawing.Point(97, 173);
            this.txtNotif.Name = "txtNotif";
            this.txtNotif.Size = new System.Drawing.Size(100, 15);
            this.txtNotif.TabIndex = 105;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(535, 43);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 22);
            this.btnStop.TabIndex = 104;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(412, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 23);
            this.btnStart.TabIndex = 103;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(334, 43);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(66, 22);
            this.txtMyPort.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "My Port";
            // 
            // txtMyHost
            // 
            this.txtMyHost.Location = new System.Drawing.Point(137, 43);
            this.txtMyHost.Name = "txtMyHost";
            this.txtMyHost.Size = new System.Drawing.Size(129, 22);
            this.txtMyHost.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "My Host";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(97, 217);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(218, 191);
            this.txtStatus.TabIndex = 98;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(412, 124);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 43);
            this.btnSend.TabIndex = 97;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(97, 124);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(303, 43);
            this.txtMessage.TabIndex = 96;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(334, 86);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(66, 22);
            this.txtPort.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(137, 85);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(129, 22);
            this.txtHost.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Host";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(412, 86);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 22);
            this.btnConnect.TabIndex = 91;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // showRumerbtn
            // 
            this.showRumerbtn.Location = new System.Drawing.Point(535, 124);
            this.showRumerbtn.Name = "showRumerbtn";
            this.showRumerbtn.Size = new System.Drawing.Size(102, 43);
            this.showRumerbtn.TabIndex = 109;
            this.showRumerbtn.Text = "Show";
            this.showRumerbtn.UseVisualStyleBackColor = true;
            this.showRumerbtn.Click += new System.EventHandler(this.showRumerbtn_Click);
            // 
            // rumortxt
            // 
            this.rumortxt.Location = new System.Drawing.Point(345, 217);
            this.rumortxt.Multiline = true;
            this.rumortxt.Name = "rumortxt";
            this.rumortxt.Size = new System.Drawing.Size(218, 191);
            this.rumortxt.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "rumer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "events";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showRumerbtn);
            this.Controls.Add(this.rumortxt);
            this.Controls.Add(this.txtNews);
            this.Controls.Add(this.txtNotif);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMyPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMyHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form7";
            this.Text = "Peer6";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNews;
        private System.Windows.Forms.TextBox txtNotif;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMyHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button showRumerbtn;
        private System.Windows.Forms.TextBox rumortxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}