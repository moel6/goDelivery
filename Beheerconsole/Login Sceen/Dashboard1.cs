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

        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // laat formulier zien
            InitializeComponent();
            var FormLocation = new AddLocation();
            FormLocation.Show();
        }

        private void Dashboard1_Load_1(object sender, EventArgs e)
        {
            MySqlDataAdapter showFromDatabase = new MySqlDataAdapter("SELECT account.username, account.rol, administratie.appartmentnummer, administratie.kleur FROM account INNER JOIN administratie ON account_id_account = account.id_account", conn);
            DataSet administratieGegevens = new DataSet();
            showFromDatabase.Fill(administratieGegevens);
            dataGridView1.DataSource = administratieGegevens.Tables[0];
        }
    }
}
