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
    public partial class fmLogin : Form
    {
        // Zet MySQL Connectie op LET OP: Nu op localhost)
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        public fmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = "admin";

            // Haal logingegevens op en stop deze in een tijdelijke tabel. 
            MySqlDataAdapter loginCheck = new MySqlDataAdapter("select count(*) from account where rol = '" + role + "'and username = '" + username + "' and password = '" + password + "'", conn);
            DataTable dtAccounts = new DataTable();
            loginCheck.Fill(dtAccounts);
            conn.Close(); 


            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
              MessageBox.Show("Gebruikersnaam of wachtwoord is niet ingevuld.","Geen Gegevens");
            }
            else
            {
                if (dtAccounts.Rows[0][0].ToString() == "1") 
                {
                    MessageBox.Show("Juiste inloggegevens");
                    InitializeComponent();
                    var Dashboard = new Dashboard1();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Onjuiste inloggegevens of machtigingen", "Onjuiste gegevens");
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
