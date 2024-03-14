namespace P2P
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
            this.label4 = new System.Windows.Forms.Label();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iptxt = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peer\'s port";
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(170, 139);
            this.porttxt.Multiline = true;
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(186, 33);
            this.porttxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Peer\'s Ip";
            // 
            // iptxt
            // 
            this.iptxt.Location = new System.Drawing.Point(170, 59);
            this.iptxt.Multiline = true;
            this.iptxt.Name = "iptxt";
            this.iptxt.Size = new System.Drawing.Size(186, 33);
            this.iptxt.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(39, 211);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(317, 61);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iptxt);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "P2P";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iptxt;
        private System.Windows.Forms.Button btnCreate;
    }
}

