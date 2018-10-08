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
    public partial class editLocation : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        public editLocation()
        {
            InitializeComponent();
        }

       private void editLocation_Load(object sender, EventArgs e)
        {
            // Gegevens moeten opgehaald worden vanuit SQL op basis van ID om weergegeven te worden in het formulier. 
            // Zodat ze kunnen worden bewerkt

            tbUsername.Text = "";
            tbPassword.Text = "";
            cbRole.Text = "";
            nubNumber.Value = 0;
            cbColor.Text = "";
        }

        private void BtnLocationSub_Click(object sender, EventArgs e)
        {
            // ID moet nog automatisch meegegeven worden van vorige actie (klik op bewerk in het dashboard) . 
            
            int id = 37;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.Text;
            decimal number = nubNumber.Value;
            string color = cbColor.Text;

            // string voor het vervangen van data voor specifieke ID 
            string updateQuery = "UPDATE account, administratie " +
           " SET account.username = '" + username + "', account.password = '" + password + "', account.rol = '" + role + "',administratie.appartmentnummer = '" + number + "',administratie.kleur = '" + color + "'" +
           "WHERE account.id_account = " + id + " AND administratie.account_id_account = " + id;


            conn.Open();
            MySqlCommand update = new MySqlCommand(updateQuery, conn);

            try
            {
                if (update.ExecuteNonQuery() == 2)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    
}
