﻿using System;
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
    public partial class FrmEditLocation : Form
    {
        public int id;
        public FrmDashboard dashboard;

        // Connectiegegevens voor database opgehaald uit app.config
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public FrmEditLocation()
        {
            InitializeComponent();
        }

        public DataSet PopulateData()
        {
            string query = "SELECT account.id_account,account.username, account.password, account.rol, administratie.appartmentnummer, administratie.kleur,beschikbaarheid " +
            "FROM account INNER JOIN administratie ON account_id_account = account.id_account" +
            " WHERE account.id_account = '" + id + "'";
            MySqlDataAdapter selectFromID = new MySqlDataAdapter(query, conn);
            DataSet administratiegegevens = new DataSet();
            selectFromID.Fill(administratiegegevens);
            return administratiegegevens; 
        }

        // Haalt input uit database en geeft vervolgens de gewenste waarde in een string 
        public string celToString(string input)
        {
            return input = PopulateData().Tables[0].Rows[0][input].ToString();
        }

        private void editLocation_Load(object sender, EventArgs e)
        {
            // ID wordt meegegegeven vanuit dashboard. 
            PopulateData();
            string username = celToString("username");
            string password = celToString("password");
            string role = celToString("rol");
            string number = celToString("appartmentnummer");
            string color = celToString("kleur");
            string beschikbaarheid = celToString("beschikbaarheid");

            tbUsername.Text = username;
            tbPassword.Text = password;
            cbRole.Text = role;
            nubNumber.Value = Convert.ToInt32(number);
            cbColor.Text = color;
            cbBeschikbaarheid.Text = beschikbaarheid;
        }

        private void BtnLocationSub_Click(object sender, EventArgs e)
        {
            // ID moet nog automatisch meegegeven worden van vorige actie (klik op bewerk in het dashboard) . 
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.Text;
            decimal number = nubNumber.Value;
            string color = cbColor.Text;
            string beschikbaarheid = cbBeschikbaarheid.Text;

            // string voor het vervangen van data voor specifieke ID 
            string updateQuery = "UPDATE account, administratie " +
           " SET account.username = '" + username + "', account.password = '" + password + "', account.rol = '" + role + "',administratie.appartmentnummer = '" + number + "',administratie.kleur = '" + color + "',administratie.beschikbaarheid = '" + beschikbaarheid + "'" +
           "WHERE account.id_account = " + id + " AND administratie.account_id_account = " + id;

            conn.Open();
            MySqlCommand update = new MySqlCommand(updateQuery, conn);

            try
            {
                if (update.ExecuteNonQuery() == 2)
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
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
