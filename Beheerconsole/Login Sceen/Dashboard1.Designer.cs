namespace Login_Sceen
{
    partial class FrmDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbConnectState = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbIp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbRemoteControl = new System.Windows.Forms.GroupBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRtHome = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lbStatusState = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnChangeState = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox121 = new System.Windows.Forms.GroupBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbRuntime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.libDebug = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.gbRemoteControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupbox121.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.lbConnectState);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbIp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connectie";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(20, 59);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(76, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(102, 59);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(77, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbConnectState
            // 
            this.lbConnectState.AutoSize = true;
            this.lbConnectState.Location = new System.Drawing.Point(92, 16);
            this.lbConnectState.Name = "lbConnectState";
            this.lbConnectState.Size = new System.Drawing.Size(73, 13);
            this.lbConnectState.TabIndex = 5;
            this.lbConnectState.Text = "Disconnected";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Connectiestatus:";
            // 
            // cbIp
            // 
            this.cbIp.FormattingEnabled = true;
            this.cbIp.Items.AddRange(new object[] {
            "192.168.43.250"});
            this.cbIp.Location = new System.Drawing.Point(48, 32);
            this.cbIp.Name = "cbIp";
            this.cbIp.Size = new System.Drawing.Size(121, 21);
            this.cbIp.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Robot:";
            // 
            // gbRemoteControl
            // 
            this.gbRemoteControl.Controls.Add(this.btnLeft);
            this.gbRemoteControl.Controls.Add(this.BtnBack);
            this.gbRemoteControl.Controls.Add(this.btnRight);
            this.gbRemoteControl.Controls.Add(this.btnForward);
            this.gbRemoteControl.Location = new System.Drawing.Point(197, 6);
            this.gbRemoteControl.Name = "gbRemoteControl";
            this.gbRemoteControl.Size = new System.Drawing.Size(247, 241);
            this.gbRemoteControl.TabIndex = 1;
            this.gbRemoteControl.TabStop = false;
            this.gbRemoteControl.Text = "Emergency Remote Controller";
            this.gbRemoteControl.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(23, 108);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Links";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(92, 146);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(70, 23);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Achteruit";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(159, 108);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Rechts";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(92, 71);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(70, 23);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "Vooruit";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRtHome
            // 
            this.btnRtHome.Location = new System.Drawing.Point(6, 388);
            this.btnRtHome.Name = "btnRtHome";
            this.btnRtHome.Size = new System.Drawing.Size(86, 52);
            this.btnRtHome.TabIndex = 6;
            this.btnRtHome.Text = "Return Home";
            this.btnRtHome.UseVisualStyleBackColor = true;
            this.btnRtHome.Click += new System.EventHandler(this.btnReturnTohome_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(133, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 13);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 30;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(602, 388);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 52);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Noodstop";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Energy level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "30%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status current delivery:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(133, 93);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(384, 13);
            this.progressBar2.TabIndex = 12;
            this.progressBar2.Value = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "75%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 485);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbStatus);
            this.tabPage1.Controls.Add(this.groupbox121);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbRemoteControl);
            this.tabPage1.Controls.Add(this.btnRtHome);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Robot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lbStatusState);
            this.gbStatus.Controls.Add(this.label16);
            this.gbStatus.Controls.Add(this.btnChangeState);
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.Controls.Add(this.label1);
            this.gbStatus.Location = new System.Drawing.Point(6, 114);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(185, 126);
            this.gbStatus.TabIndex = 6;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            this.gbStatus.Visible = false;
            // 
            // lbStatusState
            // 
            this.lbStatusState.AutoSize = true;
            this.lbStatusState.Location = new System.Drawing.Point(86, 20);
            this.lbStatusState.Name = "lbStatusState";
            this.lbStatusState.Size = new System.Drawing.Size(59, 13);
            this.lbStatusState.TabIndex = 14;
            this.lbStatusState.Text = "niet gestart";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Huidige Status:";
            // 
            // btnChangeState
            // 
            this.btnChangeState.Location = new System.Drawing.Point(55, 73);
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(121, 23);
            this.btnChangeState.TabIndex = 12;
            this.btnChangeState.Text = "Verander Status";
            this.btnChangeState.UseVisualStyleBackColor = true;
            this.btnChangeState.Click += new System.EventHandler(this.btnChangeState_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "start bezorging",
            "stop bezorging",
            "onderhoud"});
            this.cbStatus.Location = new System.Drawing.Point(55, 46);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status:";
            // 
            // groupbox121
            // 
            this.groupbox121.Controls.Add(this.lbLocation);
            this.groupbox121.Controls.Add(this.lbRuntime);
            this.groupbox121.Controls.Add(this.label15);
            this.groupbox121.Controls.Add(this.label18);
            this.groupbox121.Controls.Add(this.progressBar2);
            this.groupbox121.Controls.Add(this.label2);
            this.groupbox121.Controls.Add(this.label3);
            this.groupbox121.Controls.Add(this.label6);
            this.groupbox121.Controls.Add(this.progressBar1);
            this.groupbox121.Controls.Add(this.label5);
            this.groupbox121.Location = new System.Drawing.Point(6, 253);
            this.groupbox121.Name = "groupbox121";
            this.groupbox121.Size = new System.Drawing.Size(683, 129);
            this.groupbox121.TabIndex = 16;
            this.groupbox121.TabStop = false;
            this.groupbox121.Text = "status";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(130, 47);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(35, 13);
            this.lbLocation.TabIndex = 19;
            this.lbLocation.Text = "status";
            // 
            // lbRuntime
            // 
            this.lbRuntime.AutoSize = true;
            this.lbRuntime.Location = new System.Drawing.Point(130, 24);
            this.lbRuntime.Name = "lbRuntime";
            this.lbRuntime.Size = new System.Drawing.Size(35, 13);
            this.lbRuntime.TabIndex = 18;
            this.lbRuntime.Text = "status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Huidige Locatie:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Runtime:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.libDebug);
            this.groupBox3.Location = new System.Drawing.Point(453, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 241);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug Rapport";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(230, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Maak leeg";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // libDebug
            // 
            this.libDebug.FormattingEnabled = true;
            this.libDebug.Location = new System.Drawing.Point(6, 19);
            this.libDebug.Name = "libDebug";
            this.libDebug.Size = new System.Drawing.Size(230, 186);
            this.libDebug.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administratie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.BtnRemove);
            this.groupBox4.Location = new System.Drawing.Point(18, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(677, 447);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bewoners";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(573, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 385);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(96, 18);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Verwijderen";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard1_FormClosed_1);
            this.Load += new System.EventHandler(this.Dashboard1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRemoteControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupbox121.ResumeLayout(false);
            this.groupbox121.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbRemoteControl;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRtHome;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnRemove;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbConnectState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox libDebug;
        private System.Windows.Forms.GroupBox groupbox121;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbRuntime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lbStatusState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnChangeState;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
    }
}