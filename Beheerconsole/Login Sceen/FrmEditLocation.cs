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
    public partial class FrmEditLocation : Form
    {
        public int id;
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        public FrmEditLocation()
        {
            InitializeComponent();
        }

        public DataSet PopulateData()
        {
            string query = "SELECT account.id_account,account.username, account.password, account.rol, administratie.appartmentnummer, administratie.kleur " +
            "FROM account INNER JOIN administratie ON account_id_account = account.id_account" +
            " WHERE account.id_account = '" + id + "'";
            MySqlDataAdapter selectFromID = new MySqlDataAdapter(query, conn);
            DataSet administratiegegevens = new DataSet();
            selectFromID.Fill(administratiegegevens);
            return administratiegegevens; 
        }

        private void editLocation_Load(object sender, EventArgs e)
        {
            // ID wordt meegegegeven vanuit dashboard. 
            PopulateData();
            string username = PopulateData().Tables[0].Rows[0]["username"].ToString();
            string password = PopulateData().Tables[0].Rows[0]["password"].ToString();
            string role = PopulateData().Tables[0].Rows[0]["rol"].ToString();
            string number = PopulateData().Tables[0].Rows[0]["appartmentnummer"].ToString();
            string color = PopulateData().Tables[0].Rows[0]["kleur"].ToString();


            tbUsername.Text = username;
            tbPassword.Text = password;
            cbRole.Text = role;
            nubNumber.Value = Convert.ToInt32(number);
            cbColor.Text = color;
        }

        private void BtnLocationSub_Click(object sender, EventArgs e)
        {
            // ID moet nog automatisch meegegeven worden van vorige actie (klik op bewerk in het dashboard) . 
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
