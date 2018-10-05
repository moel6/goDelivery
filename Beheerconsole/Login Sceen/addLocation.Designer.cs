namespace Login_Sceen
{
    partial class AddLocation
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
            this.LbHouseNumber = new System.Windows.Forms.Label();
            this.LbColor = new System.Windows.Forms.Label();
            this.CbColor = new System.Windows.Forms.ComboBox();
            this.NubNumber = new System.Windows.Forms.NumericUpDown();
            this.BtnLocationSub = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLocationSub);
            this.groupBox1.Controls.Add(this.NubNumber);
            this.groupBox1.Controls.Add(this.CbColor);
            this.groupBox1.Controls.Add(this.LbColor);
            this.groupBox1.Controls.Add(this.LbHouseNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vul de benodige gegevens in";
            // 
            // LbHouseNumber
            // 
            this.LbHouseNumber.AutoSize = true;
            this.LbHouseNumber.Location = new System.Drawing.Point(18, 25);
            this.LbHouseNumber.Name = "LbHouseNumber";
            this.LbHouseNumber.Size = new System.Drawing.Size(65, 13);
            this.LbHouseNumber.TabIndex = 3;
            this.LbHouseNumber.Text = "Huisnummer";
            // 
            // LbColor
            // 
            this.LbColor.AutoSize = true;
            this.LbColor.Location = new System.Drawing.Point(18, 48);
            this.LbColor.Name = "LbColor";
            this.LbColor.Size = new System.Drawing.Size(31, 13);
            this.LbColor.TabIndex = 4;
            this.LbColor.Text = "Kleur";
            // 
            // CbColor
            // 
            this.CbColor.FormattingEnabled = true;
            this.CbColor.Items.AddRange(new object[] {
            "Rood",
            "Geel",
            "Blauw",
            "Groen"});
            this.CbColor.Location = new System.Drawing.Point(106, 48);
            this.CbColor.Name = "CbColor";
            this.CbColor.Size = new System.Drawing.Size(100, 21);
            this.CbColor.TabIndex = 1;
            // 
            // NubNumber
            // 
            this.NubNumber.Location = new System.Drawing.Point(106, 25);
            this.NubNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NubNumber.Name = "NubNumber";
            this.NubNumber.Size = new System.Drawing.Size(100, 20);
            this.NubNumber.TabIndex = 5;
            // 
            // BtnLocationSub
            // 
            this.BtnLocationSub.Location = new System.Drawing.Point(131, 75);
            this.BtnLocationSub.Name = "BtnLocationSub";
            this.BtnLocationSub.Size = new System.Drawing.Size(75, 23);
            this.BtnLocationSub.TabIndex = 6;
            this.BtnLocationSub.Text = "Verstuur";
            this.BtnLocationSub.UseVisualStyleBackColor = true;
            this.BtnLocationSub.Click += new System.EventHandler(this.BtnLocationSub_Click);
            // 
            // addLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 187);
            this.Controls.Add(this.groupBox1);
            this.Name = "addLocation";
            this.Text = "Locatie toevoegen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NubNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLocationSub;
        private System.Windows.Forms.NumericUpDown NubNumber;
        private System.Windows.Forms.ComboBox CbColor;
        private System.Windows.Forms.Label LbColor;
        private System.Windows.Forms.Label LbHouseNumber;
    }
}