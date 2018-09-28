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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string userName = "user";
            string passWord = "pass";

            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is niet ingevuld.");
            }

            else
            {

                if ((tbUsername.Text == userName ) & (tbPassword.Text == passWord))
                {
                    MessageBox.Show("Juiste inloggegevens");
                    InitializeComponent();
                    var Dashboard = new Dashboard1();
                    Dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Onjuiste inloggegevens");
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
