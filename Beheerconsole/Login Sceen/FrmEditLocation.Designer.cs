namespace Login_Sceen
{
    partial class FrmEditLocation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelss = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.BtnLocationSub = new System.Windows.Forms.Button();
            this.nubNumber = new System.Windows.Forms.NumericUpDown();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.LbColor = new System.Windows.Forms.Label();
            this.LbHouseNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelss);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.BtnLocationSub);
            this.groupBox1.Controls.Add(this.nubNumber);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.LbColor);
            this.groupBox1.Controls.Add(this.LbHouseNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vul de benodige gegevens in";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rol:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Bewoner",
            "Administrator"});
            this.cbRole.Location = new System.Drawing.Point(110, 81);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(100, 21);
            this.cbRole.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wachtwoord:";
            // 
            // labelss
            // 
            this.labelss.AutoSize = true;
            this.labelss.Location = new System.Drawing.Point(6, 28);
            this.labelss.Name = "labelss";
            this.labelss.Size = new System.Drawing.Size(87, 13);
            this.labelss.TabIndex = 9;
            this.labelss.Text = "Gebruikersnaam:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(110, 55);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(110, 28);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // BtnLocationSub
            // 
            this.BtnLocationSub.Location = new System.Drawing.Point(362, 139);
            this.BtnLocationSub.Name = "BtnLocationSub";
            this.BtnLocationSub.Size = new System.Drawing.Size(75, 23);
            this.BtnLocationSub.TabIndex = 5;
            this.BtnLocationSub.Text = "Verstuur";
            this.BtnLocationSub.UseVisualStyleBackColor = true;
            this.BtnLocationSub.Click += new System.EventHandler(this.BtnLocationSub_Click);
            // 
            // nubNumber
            // 
            this.nubNumber.Location = new System.Drawing.Point(320, 29);
            this.nubNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nubNumber.Name = "nubNumber";
            this.nubNumber.Size = new System.Drawing.Size(100, 20);
            this.nubNumber.TabIndex = 3;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Rood",
            "Geel",
            "Blauw",
            "Groen"});
            this.cbColor.Location = new System.Drawing.Point(320, 51);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(100, 21);
            this.cbColor.TabIndex = 4;
            // 
            // LbColor
            // 
            this.LbColor.AutoSize = true;
            this.LbColor.Location = new System.Drawing.Point(232, 51);
            this.LbColor.Name = "LbColor";
            this.LbColor.Size = new System.Drawing.Size(31, 13);
            this.LbColor.TabIndex = 4;
            this.LbColor.Text = "Kleur";
            // 
            // LbHouseNumber
            // 
            this.LbHouseNumber.AutoSize = true;
            this.LbHouseNumber.Location = new System.Drawing.Point(232, 28);
            this.LbHouseNumber.Name = "LbHouseNumber";
            this.LbHouseNumber.Size = new System.Drawing.Size(65, 13);
            this.LbHouseNumber.TabIndex = 3;
            this.LbHouseNumber.Text = "Huisnummer";
            // 
            // FrmEditLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 246);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditLocation";
            this.Text = "Bewerk";
            this.Load += new System.EventHandler(this.editLocation_Load);
            this.Shown += new System.EventHandler(this.editLocation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelss;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button BtnLocationSub;
        public System.Windows.Forms.NumericUpDown nubNumber;
        public System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label LbColor;
        private System.Windows.Forms.Label LbHouseNumber;
    }
}