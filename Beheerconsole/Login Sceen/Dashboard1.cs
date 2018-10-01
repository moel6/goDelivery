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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
