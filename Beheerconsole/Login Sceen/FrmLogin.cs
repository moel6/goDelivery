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
using System.Configuration;

namespace Login_Sceen
{
    public partial class fmLogin : Form
    {
        // Connectiegegevens voor database opgehaald uit app.config
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public fmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            // invoer van textboxes en rol moet "admin" zijn in database. Om te voorkomen dat bewoners in het adminpanel kunnen. 
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = "administrator";

            // Haal logingegevens op en stop deze in een tijdelijke tabel. 
            MySqlDataAdapter loginCheck = new MySqlDataAdapter("select count(*) from account where rol = '" + role + "'and username = '" + username + "' and password = '" + password + "'", conn);
            DataTable dtAccounts = new DataTable();
            loginCheck.Fill(dtAccounts);
            conn.Close(); 

            // Controleer of beide textvelden zijn ingevuld. 
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
              MessageBox.Show("Gebruikersnaam of wachtwoord is niet ingevuld.","Geen Gegevens");
            }
            else
            {
                // Als gegevens juist zijn laat het dashboard zien
                if (dtAccounts.Rows[0][0].ToString() == "1") 
                {
                    InitializeComponent();
                    var Dashboard = new FrmDashboard();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    // Als gegevens onjuist zijn geef een foutmelding en maak textboxes leeg.
                    MessageBox.Show("Onjuiste inloggegevens of machtigingen", "Onjuiste gegevens");
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Indien er op de cancel button geklikt wordt. Sluit dan het venster. 
            this.Close(); 
        }
    }
}
