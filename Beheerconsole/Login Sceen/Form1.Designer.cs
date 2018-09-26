namespace Login_Sceen
{
    partial class fmLogin
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
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(108, 32);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(100, 20);
            this.TbUsername.TabIndex = 0;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(108, 62);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 1;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(15, 35);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(87, 13);
            this.LbUsername.TabIndex = 2;
            this.LbUsername.Text = "Gebruikersnaam:";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(28, 65);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(71, 13);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Wachtwoord:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(133, 98);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Inloggen";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.TbUsername);
            this.groupBox1.Controls.Add(this.LbPassword);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Controls.Add(this.LbUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmLogin";
            this.Text = "Inloggen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

