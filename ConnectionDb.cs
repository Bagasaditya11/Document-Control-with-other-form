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

namespace Upload_Dlabor
{
    public partial class ConnectionDb : Form
    {
        public ConnectionDb()
        {
            InitializeComponent();
        }

        //SqlConnection connsql = new SqlConnection(@"Data Source={server};Initial Catalog={database};User ID={user};Password={password};");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string database = txtDB.Text;

            SqlConnection connsql = new SqlConnection(@"Data Source={server};Initial Catalog={database};User ID={user};Password={password};");
            connsql.Open();
            try
            {
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connsql.Close();

        }

        //public void connectDB()
        //{
        //    connsql.Open();
        //    try
        //    {
        //        MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show($"Connection Failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    connsql.Close();
        //}
    }
}
