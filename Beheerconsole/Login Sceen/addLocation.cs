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
using MySql.Data; 

namespace Login_Sceen
{

    public partial class AddLocation : Form
    {
        MySqlConnection conn = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");


        public AddLocation()
        {
            InitializeComponent();
        }

        private void BtnLocationSub_Click(object sender, EventArgs e)
        {
            if (NubNumber.Value == 0 || CbColor.Text == "")
            {
                MessageBox.Show("Vul de locatie in en kies de juiste kleur");
            }
            else
            {
              // conn.Open();

            }
        }
    }
}
