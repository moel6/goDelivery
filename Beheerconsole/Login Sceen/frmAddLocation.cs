using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySql.Data; 

namespace Login_Sceen
{

    public partial class frmAddLocation : Form
    {
        public FrmDashboard dashboard;

        // Connectiegegevens voor database opgehaald uit app.config
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public frmAddLocation()
        {
            InitializeComponent();
        }

        private void BtnLocationSub_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.Text;
            string number = Convert.ToString(nubNumber.Value);
            string color = cbColor.Text;
            string beschikbaarheid = cbBeschikbaarheid.Text; 

            // Genereerd aanmaaktijd. 
            string timeAndDate = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            // Query voor het invoegen van waarden uit formulier.
            string insertQuery = 
                "INSERT INTO account (account.username, account.password, account.rol, account.account_sinds) VALUES('"+username+"', '"+password + "', '"+ role + "', '"+timeAndDate+"');" +
                "INSERT INTO administratie(administratie.account_id_account, administratie.appartmentnummer, administratie.kleur, beschikbaarheid)" +
                "VALUES(LAST_INSERT_ID(), '"+number+ "', '"+color+ "', '" + beschikbaarheid + "'); ";

            if (username == "" || password == "" || role == "" || number =="" || color == "")
            {
                MessageBox.Show("Controleer de gegevens, een of meerdere velden zijn niet juist ingevuld","Onvolledige gegevens");
            }

            else
            {
                conn.Open();
                MySqlCommand insert = new MySqlCommand(insertQuery, conn);

                try
                {
                    if (insert.ExecuteNonQuery() == 2)
                    {
                        dashboard.PopulateData(); //force refresh
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}