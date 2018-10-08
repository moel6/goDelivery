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

namespace Login_Sceen
{
    public partial class Dashboard1 : Form
    {

        // Connectiegegevens voor database
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");
     
        public Dashboard1()
        {
            InitializeComponent();
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

        private void Dashboard1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            // Sluit applicatie als er op kruisje wordt geklikt. 
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
            // Geef een bevestiging bij het verwijderen. Als er op "Ja" geklikt is wordt het record verwijderd als er op "nee" geklikt wordt gebeurd er niks.
            // LET OP: ID moet nog worden meegegeven zodat juiste result wordt verwijderd. 

            int recordId = 28;

            DialogResult Remove;
            Remove = MessageBox.Show("Weet u zeker dat u dit item wilt verwijderen?", "Bevestiging Verwijderen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Remove == DialogResult.OK)
            {
                string updateQuery = "DELETE FROM administratie WHERE administratie.account_id_account = '"+recordId+"';" +
                "DELETE FROM account WHERE account.id_account = '"+recordId+"'; "; 

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
            else
            {
               // Doe niets als er op "No" wordt geklikt
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Open het edit formulier als er dubbelklik gedaan wordt op de juiste rij
            editLocation FormEdit = new editLocation();
            FormEdit.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // haal data opnieuw op zodra er op de knop update wordt geklikt
            PopulateData();
        }
    }
    }

