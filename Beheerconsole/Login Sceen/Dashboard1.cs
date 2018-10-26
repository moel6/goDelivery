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
using System.Configuration;
using System.Collections.Specialized;

namespace Login_Sceen
{


    public partial class FrmDashboard : Form
    {
        private EV3Wifi myEV3;
        private Timer messageReceiveTimer;

        // Connectiegegevens voor database opgehaald uit app.config
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public FrmDashboard()
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
        public void PopulateData()
        {
            MySqlDataAdapter showFromDatabase = new MySqlDataAdapter("SELECT account.id_account,account.username, account.rol, administratie.appartmentnummer, administratie.kleur, beschikbaarheid FROM account INNER JOIN administratie ON account_id_account = account.id_account", conn);
            DataSet administratieGegevens = new DataSet();
            showFromDatabase.Fill(administratieGegevens);
            dataGridView1.DataSource = administratieGegevens.Tables[0];
            conn.Close();
        }

        // Methode voor het versturen van commando's naar EV3 Robot
        public void SendEv3Command(string command)
        {
           if (myEV3.isConnected)
            {
                myEV3.SendMessage(command, "0");
                libDebug.Items.Add(DebugListItem("Commando " + command));
            }
        }

        // Voeg een item toe aan de debug list met tijd 
        public string DebugListItem(string text)
        {
            return DateTime.Now.ToString("h:mm:ss tt") + "  - " + text;
        }


        // update connectieinformatie binnen gehele applicatie
        private void UpdateButtonsAndConnectionInfo()
        {
            bool isConnected = myEV3.isConnected;
            btnConnect.Enabled = !isConnected;
            btnDisconnect.Enabled = isConnected;

            if (isConnected)
            {
                libDebug.Items.Add(DebugListItem("Connected"));
                lbConnectState.Text = "connected";
                cbStatus.Text = "connected";
                gbStatus.Visible = true;
            }
            else
            {
                lbConnectState.Text = "disconnected";
                libDebug.Items.Add(DebugListItem("Disconnected"));
            }
        }
        
        // Sluit applicatie als er op kruisje wordt geklikt
        private void Dashboard1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // laat het formulier zien waarbij gegevens worden toegevoegd. 
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAddLocation frmAddLocation = new frmAddLocation();
            frmAddLocation.Show();
            frmAddLocation.dashboard = this;
        }

        private void Dashboard1_Load_1(object sender, EventArgs e)
        {
            // Inladen van data in de datagridview op het tabblad administratie.
            PopulateData();
        }

            // Controleer op welke rij is geklikt, genereer daarvan het ID in een variable en verwijder vervolgens het record uit de database. 
        private void BtnRemove_Click(object sender, EventArgs e)
        {
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
                PopulateData(); 
                conn.Close();
            }
        }

        // Open het edit formulier als er dubbelklik gedaan wordt op de juiste rij en stuur het ID door naar het formulier
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmEditLocation frmEditLocation = new FrmEditLocation();
            frmEditLocation.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            frmEditLocation.dashboard = this;
            frmEditLocation.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // haalt data opnieuw op zodra er op de knop update wordt geklikt
            PopulateData();
        }

        // Stuurt de geselecteerde status naar de robot toe middels de berichten "Maintenance", "StartProgram", "StopProgram"
        private void btnChangeState_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De status is veranderd naar " + cbStatus.Text);
            if (cbStatus.Text == "onderhoud")
            {
                gbRemoteControl.Visible = true;
                lbStatusState.Text = "onderhoud";
                SendEv3Command("Maintenance");
                libDebug.Items.Add(DebugListItem("Onderhoudmodus gestart"));
            }
            else if (cbStatus.Text == "start bezorging")
            {
                gbRemoteControl.Visible = false;
                lbStatusState.Text = "bezorging gestart";
                SendEv3Command("StartProgram");
                libDebug.Items.Add(DebugListItem("Bezorging gestart"));
            }
            else if (cbStatus.Text == "stop bezorging")
            {
                gbRemoteControl.Visible = false;
                lbStatusState.Text = "bezorging gestopt";
                SendEv3Command("StopProgram");
                libDebug.Items.Add(DebugListItem("Bezorging gestopt"));
            }
        }

        // Stuurt het bericht "reset" naar de robot
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult comfirmation;
            comfirmation = MessageBox.Show("Weet u zeker dat de robot moet worden gestopt?", "Robot stop!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirmation == DialogResult.OK)
            {
                SendEv3Command("Reset");
            }
        }

        // Stuurt het bericht "ReturnHome" naar de robot
        private void btnReturnTohome_Click(object sender, EventArgs e)
        {
            DialogResult comfirmation;
            comfirmation = MessageBox.Show("Weet u zeker dat de robot teruggestuurd moet worden naar het basisstation?", "Robot Home", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirmation == DialogResult.OK)
            {
                SendEv3Command("ReturnHome");
            }
        }

        // Connectie met robot opzetten
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = cbIp.Text;
            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                MessageBox.Show("Vul een geldig IP adres in");
            }
            else if (myEV3.Connect("1234", ipAddress) == true)
            {
                UpdateButtonsAndConnectionInfo();
                messageReceiveTimer.Start();
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Kan niet verbinden met EV3 met IP address " + ipAddress);
            }
        }

        // Disconnect de robot en update de status. 
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            myEV3.Disconnect();
            UpdateButtonsAndConnectionInfo();
            gbStatus.Visible = false; 
        }

        // Timer voor ophalen messages
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
                if (strMessage != "")
                {
                    string[] data = strMessage.Split(' ');
                    if (data.Length == 2)
                    {
                       //  receivedMessagesListBox.Items.Add(data[0] + " " + data[1]);
                       // distanceTextBox.Text = data[0];
                        // angleTextBox.Text = data[1];
                    }
                }
            }
        }

        // Maak debug list leeg
        private void btnClear_Click(object sender, EventArgs e)
        {
            libDebug.Items.Clear();
        }

        // --------------------------- Handmatige Controls ---------------------------//
        private void btnForward_Click(object sender, EventArgs e)
        {
            SendEv3Command("Forward");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SendEv3Command("Backward");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            SendEv3Command("Left");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            SendEv3Command("Right");
            
        }

        // --------------------------- Einde Handmatige controls ---------------------------//
    }
}
