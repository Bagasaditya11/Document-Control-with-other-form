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
using ExcelDataReader;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using DataTable = System.Data.DataTable;
using CsvHelper;

namespace Upload_Dlabor
{
    public partial class Upload_Dlabor : Form
    {
        public Upload_Dlabor()
        {
            InitializeComponent();
        }
        SqlConnection connsql = new SqlConnection(@"Data Source=SERVERLOCA\SQLEXPRESS;Initial Catalog=LOCALDB;User ID=sa;Password=sa123;");
        //SqlConnection connsql = new SqlConnection(@"Data Source=192.168.20.8\SERVLOCAL;Initial Catalog=ZAI_PARAM;User ID=sa;Password=local123;");

        int totalRecords = 0;
        public void ClearData()
        {
            dgLabor.DataSource = "";
            txtTelusuri.Text = "";
            btnUnggah.Enabled = false;
            btnMuatData.Enabled = true;
            cmbTahun.Text = "";
        }

        public void ShowDataLabor()
        {
            SqlCommand sqlcmd;
            sqlcmd = connsql.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM SRM_BUDGET";
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            DataSet sqlds = new DataSet();
            sqladapter.Fill(sqlds);
            dgLabor.DataSource = sqlds.Tables[0].DefaultView;
        }

        public void SearchDataLabor()
        {
            SqlCommand sqlcmd;
            sqlcmd = connsql.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM SRM_BUDGET WHERE TYEAR = '"+cmbTahun.Text+"'";
            SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);
            DataSet sqlds = new DataSet();
            sqladapter.Fill(sqlds);
            dgLabor.DataSource = sqlds.Tables[0].DefaultView;
        }

        public void BrowseDataLabor()
        {
            using (OpenFileDialog openFD = new OpenFileDialog())
            {
                openFD.InitialDirectory = "c:\\";
                openFD.Filter = "CSV files (*.csv)|*.csv";
                openFD.RestoreDirectory = true;

                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    txtTelusuri.Text = openFD.FileName;
                    string filePath = openFD.FileName;
                    DataTable dataTable = new DataTable();

                    // Read the CSV file
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dr = dataTable.NewRow();
                            for (int i = 0; i < headers.Length; i++)
                            {
                                dr[i] = rows[i];
                            }
                            dataTable.Rows.Add(dr);
                        }
                    }

                    // Showing DataGrid from Db
                    dgLabor.DataSource = dataTable;
                    btnUnggah.Enabled = true;
                    btnMuatData.Enabled = false;         
                }
            }
        }

        public void uploadDataLabor()
        {
            try
            {
                connsql.Open();
                for (int i = 0; i < dgLabor.Rows.Count;i++)
                {
                    SqlCommand sqlcmd;
                    sqlcmd = connsql.CreateCommand();
                    sqlcmd.CommandText = "INSERT INTO SRM_BUDGET (TYEAR,TGROUP,MGROUP,SGROUP,CC_ID,CC_NM,PCODE,TCODE,DESCRIPTION,ITEM,ITEM_NM,QTY_01,QTY_02,QTY_03,QTY_04,QTY_05,QTY_06,QTY_07,QTY_08,QTY_09,QTY_10,QTY_11,QTY_12,QTY_TOTAL,AMT_01,AMT_02,AMT_03,AMT_04,AMT_05,AMT_06,AMT_07,AMT_08,AMT_09,AMT_10,AMT_11,AMT_12,AMT_TOTAL,RGSTD,UPDTD,UPDTWKCD,LOCK_F)" +
                        "VALUES (@TYEAR,@TGROUP,@MGROUP,@SGROUP,@CC_ID,@CC_NM,@PCODE,@TCODE,@DESCRIPTION,@ITEM,@ITEM_NM,@QTY_01,@QTY_02,@QTY_03,@QTY_04,@QTY_05,@QTY_06,@QTY_07,@QTY_08,@QTY_09,@QTY_10,@QTY_11,@QTY_12,@QTY_TOTAL,@AMT_01,@AMT_02,@AMT_03,@AMT_04,@AMT_05,@AMT_06,@AMT_07,@AMT_08,@AMT_09,@AMT_10,@AMT_11,@AMT_12,@AMT_TOTAL,@RGSTD,@UPDTD,@UPDTWKCD,@LOCK_F)";
                    sqlcmd.Parameters.AddWithValue("@TYEAR", cmbTahun.Text);
                    sqlcmd.Parameters.AddWithValue("@TGROUP", "SALARY");
                    sqlcmd.Parameters.AddWithValue("@MGROUP", dgLabor.Rows[i].Cells[0].Value);
                    sqlcmd.Parameters.AddWithValue("@SGROUP", dgLabor.Rows[i].Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@CC_ID", dgLabor.Rows[i].Cells[2].Value);
                    sqlcmd.Parameters.AddWithValue("@CC_NM", dgLabor.Rows[i].Cells[3].Value);
                    sqlcmd.Parameters.AddWithValue("@PCODE", dgLabor.Rows[i].Cells[4].Value.ToString().Substring(0, 6)); //trim from left 6 char
                    sqlcmd.Parameters.AddWithValue("@TCODE", dgLabor.Rows[i].Cells[4].Value);
                    sqlcmd.Parameters.AddWithValue("@DESCRIPTION", dgLabor.Rows[i].Cells[5].Value);
                    sqlcmd.Parameters.AddWithValue("@ITEM", dgLabor.Rows[i].Cells[6].Value);
                    sqlcmd.Parameters.AddWithValue("@ITEM_NM", dgLabor.Rows[i].Cells[7].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_01", dgLabor.Rows[i].Cells[8].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_02", dgLabor.Rows[i].Cells[9].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_03", dgLabor.Rows[i].Cells[10].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_04", dgLabor.Rows[i].Cells[11].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_05", dgLabor.Rows[i].Cells[12].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_06", dgLabor.Rows[i].Cells[13].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_07", dgLabor.Rows[i].Cells[14].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_08", dgLabor.Rows[i].Cells[15].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_09", dgLabor.Rows[i].Cells[16].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_10", dgLabor.Rows[i].Cells[17].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_11", dgLabor.Rows[i].Cells[18].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_12", dgLabor.Rows[i].Cells[19].Value);
                    sqlcmd.Parameters.AddWithValue("@QTY_TOTAL", dgLabor.Rows[i].Cells[20].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_01", dgLabor.Rows[i].Cells[21].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_02", dgLabor.Rows[i].Cells[22].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_03", dgLabor.Rows[i].Cells[23].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_04", dgLabor.Rows[i].Cells[24].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_05", dgLabor.Rows[i].Cells[25].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_06", dgLabor.Rows[i].Cells[26].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_07", dgLabor.Rows[i].Cells[27].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_08", dgLabor.Rows[i].Cells[28].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_09", dgLabor.Rows[i].Cells[29].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_10", dgLabor.Rows[i].Cells[30].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_11", dgLabor.Rows[i].Cells[31].Value);
                    sqlcmd.Parameters.AddWithValue("@AMT_12", dgLabor.Rows[i].Cells[32].Value);
                    //Console.WriteLine(i);
                    sqlcmd.Parameters.AddWithValue("@AMT_TOTAL", dgLabor.Rows[i].Cells[33].Value);
                    sqlcmd.Parameters.AddWithValue("@RGSTD", dtUPDT.Value);
                    sqlcmd.Parameters.AddWithValue("@UPDTD", dtUPDT.Value);
                    sqlcmd.Parameters.AddWithValue("@UPDTWKCD", "BAGAS");
                    sqlcmd.Parameters.AddWithValue("@LOCK_F", "1");

                    sqlcmd.ExecuteNonQuery();
                    totalRecords++;
                }
                connsql.Close();
                MessageBox.Show("IMPORT COMPLETED", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLoading.Text = $"Total Records Imported : { totalRecords }";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void HapusDataLabor()
        {
            try
            {             
                connsql.Open();
                for (int i = 0; i < dgLabor.Rows.Count; i++)
                {
                    SqlCommand sqlcmd;
                    sqlcmd = connsql.CreateCommand();
                    sqlcmd.CommandText = "DELETE FROM SRM_BUDGET WHERE TYEAR=@TYEAR AND TGROUP=@TGROUP AND TCODE=@TCODE AND ITEM=@ITEM ";
                    sqlcmd.Parameters.AddWithValue("@TYEAR", cmbTahun.Text);
                    sqlcmd.Parameters.AddWithValue("@TGROUP", "SALARY");
                    sqlcmd.Parameters.AddWithValue("@TCODE", dgLabor.Rows[i].Cells[4].Value);
                    sqlcmd.Parameters.AddWithValue("@ITEM", dgLabor.Rows[i].Cells[6].Value);
                    sqlcmd.ExecuteNonQuery();
                }            
                connsql.Close();
                MessageBox.Show("DATA TELAH DIHAPUS HARAP UPLOAD FILE ULANG", "MESSAGES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMuatData_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbTahun.Text))
            {
                ShowDataLabor();
            }
            else
            {
                SearchDataLabor();
            }
            
        }

        private void btnTelusuri_Click(object sender, EventArgs e)
        {
            BrowseDataLabor();
        }

        private void btnUnggah_Click(object sender, EventArgs e)
        {
            dgLabor.ClearSelection();
            int row = dgLabor.CurrentCell.RowIndex;
            if (string.IsNullOrEmpty(cmbTahun.Text))
            {
                MessageBox.Show("KOLOM TAHUN BELUM TERISI", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dgLabor.Rows[row].Cells[0].Value.ToString() == "2.1." || dgLabor.Rows[row].Cells[0].Value.ToString() == "3.1." || dgLabor.Rows[row].Cells[0].Value.ToString() == "3.2." || dgLabor.Rows[row].Cells[0].Value.ToString() == "3.3." || dgLabor.Rows[row].Cells[1].Value.ToString() == "1.3.")
            {
                //MessageBox.Show("SESUAI", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uploadDataLabor();
                ClearData();
            }
            else
            {
                MessageBox.Show("KOLOM MGROUP DAN SGROUP UNTUK BUDGET SALLARIES BELUM SESUAI", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbTahun.Text))
            {
                MessageBox.Show("KOLOM TAHUN BELUM TERISI", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                HapusDataLabor();
                ClearData();
            }

        }

        //================================================Customize UI===============================================================
        private void btnKosong_MouseHover(object sender, EventArgs e)
        {
            btnKosong.BackColor = Color.FromArgb(255, 236, 200);
        }

        private void btnKosong_MouseLeave(object sender, EventArgs e)
        {
            btnKosong.BackColor = Color.FromArgb(252, 255, 224);
        }

        private void btnMuatData_MouseHover(object sender, EventArgs e)
        {
            btnMuatData.BackColor = Color.FromArgb(255, 236, 200);
        }

        private void btnMuatData_MouseLeave(object sender, EventArgs e)
        {
            btnMuatData.BackColor = Color.FromArgb(252, 255, 224);
        }

        private void btnSelesai_MouseHover(object sender, EventArgs e)
        {
            btnSelesai.BackColor = Color.FromArgb(255, 236, 200);
        }

        private void btnSelesai_MouseLeave(object sender, EventArgs e)
        {
            btnSelesai.BackColor = Color.FromArgb(252, 255, 224);
        }

        private void btnUnggah_MouseHover(object sender, EventArgs e)
        {
            btnUnggah.BackColor = Color.FromArgb(255, 236, 200);
        }

        private void btnUnggah_MouseLeave(object sender, EventArgs e)
        {
            btnUnggah.BackColor = Color.FromArgb(252, 255, 224);
        }
    }
}
