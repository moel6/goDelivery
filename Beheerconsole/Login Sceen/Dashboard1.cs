using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using EV3WifiLib;


namespace Login_Sceen
{
    public partial class Dashboard1 : Form
    {
        private EV3Wifi myEV3;
        private Timer messageReceiveTimer;

        // Connectiegegevens voor database
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        public Dashboard1()
        {
            InitializeComponent();
            // Create the Timer object and set it to generate a timer tick event 
            // every 100 milliseconds. The timer tick can be used to execute code at fixed intervals.
            // De timer1_tick methode is onderaan deze code gedefineerd (zoek timer1) 
            messageReceiveTimer = new Timer
            {
                Interval = 100
            };
            messageReceiveTimer.Tick += new System.EventHandler(timer1_Tick);

            // EV3: Nieuw Object voor de EV3 zodat deze makkelijk aangeroepen kan worden.
            myEV3 = new EV3Wifi();
            UpdateButtonsAndConnectionInfo();
        }

        // Functie voor het ophalen van data vanuit database. 
        void PopulateData()
        {
            MySqlDataAdapter showFromDatabase = new MySqlDataAdapter("SELECT account.id_account,account.username, account.rol, administratie.appartmentnummer, administratie.kleur FROM account INNER JOIN administratie ON account_id_account = account.id_account", conn);
            DataSet administratieGegevens = new DataSet();
            showFromDatabase.Fill(administratieGegevens);
            dataGridView1.DataSource = administratieGegevens.Tables[0];
            conn.Close();
        }


        // update connectieinformatie binnen gehele applicatie
        private void UpdateButtonsAndConnectionInfo()
        {
            bool isConnected = myEV3.isConnected;

            btnConnect.Enabled = !isConnected;
            btnDisconnect.Enabled = isConnected;

            if (isConnected)
            {
                string disconnectDebug = DateTime.Now.ToString("h:mm:ss tt")+ "  - Connected";
                libDebug.Items.Add(disconnectDebug);
                lbConnectState.Text = "disconnected";
                cbStatus.Text = "disconnected";
                gbStatus.Visible = true;
            }
            else
            {
                string disconnectedDebug = DateTime.Now.ToString("h:mm:ss tt" ) +"  - Disconnected";
                lbConnectState.Text = "disconnected";
                libDebug.Items.Add(disconnectedDebug);
            }
        }

            
        // Sluit applicatie als er op kruisje wordt geklikt
        private void Dashboard1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // laat formulier zien
            var FormLocation = new AddLocation();
            FormLocation.Show();
        }

        private void Dashboard1_Load_1(object sender, EventArgs e)
        {
            // Inladen van data in de datagridview op het tabblad administratie.
            PopulateData();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Geef een bevestiging bij het verwijderen. Als er op "Ja" geklikt is wordt het record verwijderd
            // Als er op "nee" geklikt wordt gebeurd er niks.


            // Genereer ID uit 
            int recordId;
            recordId= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            DialogResult Remove;
            Remove = MessageBox.Show("Weet u zeker dat u dit item wilt verwijderen?", "Bevestiging Verwijderen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Remove == DialogResult.OK)
            {
                string updateQuery = "DELETE FROM administratie WHERE administratie.account_id_account = '" + recordId + "';" +
                "DELETE FROM account WHERE account.id_account = '" + recordId + "'; ";

                conn.Open();
                MySqlCommand update = new MySqlCommand(updateQuery, conn);

                try
                {
                    if (update.ExecuteNonQuery() == 2)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Onjuist ID geselecteerd, Er is geen data veranderd.");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Open het edit formulier als er dubbelklik gedaan wordt op de juiste rij
            FrmEditLocation frmEditLocation = new FrmEditLocation();
            frmEditLocation.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            frmEditLocation.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // haal data opnieuw op zodra er op de knop update wordt geklikt
            PopulateData();
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De status is veranderd naar " + cbStatus.Text);
            if (cbStatus.Text == "onderhoud")
            {
                gbRemoteControl.Visible = true;
                if (myEV3.isConnected)
                {
                    myEV3.SendMessage("Maintenance", "0");
                }
            }
            else if (cbStatus.Text == "start bezorging")
            {
                gbRemoteControl.Visible = false;
                if (myEV3.isConnected)
                {
                    myEV3.SendMessage("StartProgram", "0");
                }
            }
            else if (cbStatus.Text == "stop bezorging")
            {
                gbRemoteControl.Visible = false;
                if (myEV3.isConnected)
                {
                    myEV3.SendMessage("StopProgram", "0");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult comfirmation;
            comfirmation = MessageBox.Show("Weet u zeker dat de robot moet worden gestopt?", "Robot stop!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirmation == DialogResult.OK)
            {
                if (myEV3.isConnected)
                {
                    myEV3.SendMessage("Reset", "0");
                }
            }
            else
            {
                //No delete
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult comfirmation;
            comfirmation = MessageBox.Show("Weet u zeker dat de robot teruggestuurd moet worden naar het basisstation?", "Robot Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirmation == DialogResult.OK)
            {
                if (myEV3.isConnected)
                {
                    myEV3.SendMessage("ReturnHome", "0");
                }
            }
            else
            {
                //Doe niks
            }
        }

        // Connectie met robot opzetten
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = cbIp.Text;
            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                MessageBox.Show("Fill in valid IP address of EV3");
            }
            else if (myEV3.Connect("1234", ipAddress) == true)
            {
                UpdateButtonsAndConnectionInfo();
                messageReceiveTimer.Start();
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Failed to connect to EV3 with IP address " + ipAddress);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            myEV3.Disconnect();
            UpdateButtonsAndConnectionInfo();
        }

        // Timer voor vernieuwen messages
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        // Maak debug list leeg
        private void btnClear_Click(object sender, EventArgs e)
        {
            libDebug.Items.Clear();
        }

        // --------------------------- Handmatige Controls ---------------------------//
        private void btnForward_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Forward", "0");  
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Backward", "0");  
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Right", "0"); 
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Left", "0"); 
            }
        }
        // --------------------------- Einde Handmatige controls ---------------------------//
    }
}

