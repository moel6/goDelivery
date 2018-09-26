using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Sceen
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {

            if (TbUsername.Text == "" || TbPassword.Text == "")
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is niet ingevuld.");
            }

            else
            {

                if ((TbUsername.Text == "username") & (TbPassword.Text == "password"))
                {
                    MessageBox.Show("Juiste inloggegevens");
                }
                else
                {
                    MessageBox.Show("Onjuiste inloggegevens");
                    TbUsername.Text = "";
                    TbPassword.Text = "";

                }
            }
        }
    }
}
