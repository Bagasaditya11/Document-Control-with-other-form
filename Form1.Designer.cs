
namespace Upload_Dlabor
{
    partial class Upload_Dlabor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload_Dlabor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKosong = new System.Windows.Forms.Button();
            this.btnMuatData = new System.Windows.Forms.Button();
            this.btnUnggah = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelusuri = new System.Windows.Forms.TextBox();
            this.btnTelusuri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgLabor = new Zuby.ADGV.AdvancedDataGridView();
            this.dtUPDT = new System.Windows.Forms.DateTimePicker();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLabor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKosong
            // 
            this.btnKosong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.btnKosong.FlatAppearance.BorderSize = 0;
            this.btnKosong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKosong.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosong.Location = new System.Drawing.Point(391, 12);
            this.btnKosong.Margin = new System.Windows.Forms.Padding(4);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(113, 40);
            this.btnKosong.TabIndex = 1;
            this.btnKosong.Text = "Kosongkan";
            this.btnKosong.UseVisualStyleBackColor = false;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            this.btnKosong.MouseLeave += new System.EventHandler(this.btnKosong_MouseLeave);
            this.btnKosong.MouseHover += new System.EventHandler(this.btnKosong_MouseHover);
            // 
            // btnMuatData
            // 
            this.btnMuatData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.btnMuatData.FlatAppearance.BorderSize = 0;
            this.btnMuatData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuatData.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuatData.Location = new System.Drawing.Point(512, 12);
            this.btnMuatData.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuatData.Name = "btnMuatData";
            this.btnMuatData.Size = new System.Drawing.Size(115, 40);
            this.btnMuatData.TabIndex = 2;
            this.btnMuatData.Text = "Muat Data";
            this.btnMuatData.UseVisualStyleBackColor = false;
            this.btnMuatData.Click += new System.EventHandler(this.btnMuatData_Click);
            this.btnMuatData.MouseLeave += new System.EventHandler(this.btnMuatData_MouseLeave);
            this.btnMuatData.MouseHover += new System.EventHandler(this.btnMuatData_MouseHover);
            // 
            // btnUnggah
            // 
            this.btnUnggah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.btnUnggah.Enabled = false;
            this.btnUnggah.FlatAppearance.BorderSize = 0;
            this.btnUnggah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnggah.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnggah.Location = new System.Drawing.Point(758, 12);
            this.btnUnggah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnggah.Name = "btnUnggah";
            this.btnUnggah.Size = new System.Drawing.Size(115, 40);
            this.btnUnggah.TabIndex = 3;
            this.btnUnggah.Text = "Unggah";
            this.btnUnggah.UseVisualStyleBackColor = false;
            this.btnUnggah.Click += new System.EventHandler(this.btnUnggah_Click);
            this.btnUnggah.MouseLeave += new System.EventHandler(this.btnUnggah_MouseLeave);
            this.btnUnggah.MouseHover += new System.EventHandler(this.btnUnggah_MouseHover);
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelesai.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(635, 12);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(115, 40);
            this.btnSelesai.TabIndex = 4;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            this.btnSelesai.MouseLeave += new System.EventHandler(this.btnSelesai_MouseLeave);
            this.btnSelesai.MouseHover += new System.EventHandler(this.btnSelesai_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tahun :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Berkas Data :";
            // 
            // txtTelusuri
            // 
            this.txtTelusuri.BackColor = System.Drawing.Color.Silver;
            this.txtTelusuri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelusuri.Enabled = false;
            this.txtTelusuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelusuri.Location = new System.Drawing.Point(120, 70);
            this.txtTelusuri.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelusuri.Name = "txtTelusuri";
            this.txtTelusuri.Size = new System.Drawing.Size(845, 20);
            this.txtTelusuri.TabIndex = 8;
            // 
            // btnTelusuri
            // 
            this.btnTelusuri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTelusuri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelusuri.BackgroundImage")));
            this.btnTelusuri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelusuri.FlatAppearance.BorderSize = 0;
            this.btnTelusuri.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelusuri.Location = new System.Drawing.Point(252, 17);
            this.btnTelusuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelusuri.Name = "btnTelusuri";
            this.btnTelusuri.Size = new System.Drawing.Size(40, 37);
            this.btnTelusuri.TabIndex = 9;
            this.btnTelusuri.UseVisualStyleBackColor = false;
            this.btnTelusuri.Click += new System.EventHandler(this.btnTelusuri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))));
            this.panel1.Location = new System.Drawing.Point(119, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 2);
            this.panel1.TabIndex = 12;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(1332, 81);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(67, 18);
            this.lblLoading.TabIndex = 15;
            this.lblLoading.Text = "Loading";
            // 
            // dgLabor
            // 
            this.dgLabor.AllowUserToAddRows = false;
            this.dgLabor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgLabor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgLabor.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgLabor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLabor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgLabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLabor.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgLabor.FilterAndSortEnabled = true;
            this.dgLabor.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgLabor.GridColor = System.Drawing.Color.Black;
            this.dgLabor.Location = new System.Drawing.Point(10, 113);
            this.dgLabor.MaxFilterButtonImageHeight = 23;
            this.dgLabor.Name = "dgLabor";
            this.dgLabor.ReadOnly = true;
            this.dgLabor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgLabor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLabor.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgLabor.RowHeadersVisible = false;
            this.dgLabor.RowHeadersWidth = 51;
            this.dgLabor.RowTemplate.Height = 24;
            this.dgLabor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLabor.Size = new System.Drawing.Size(1445, 613);
            this.dgLabor.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.dgLabor.TabIndex = 17;
            // 
            // dtUPDT
            // 
            this.dtUPDT.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtUPDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUPDT.Location = new System.Drawing.Point(1335, 53);
            this.dtUPDT.Name = "dtUPDT";
            this.dtUPDT.Size = new System.Drawing.Size(120, 22);
            this.dtUPDT.TabIndex = 18;
            this.dtUPDT.Visible = false;
            // 
            // cmbTahun
            // 
            this.cmbTahun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTahun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTahun.BackColor = System.Drawing.Color.White;
            this.cmbTahun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.cmbTahun.Location = new System.Drawing.Point(120, 23);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(110, 28);
            this.cmbTahun.TabIndex = 19;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapus.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(881, 11);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 40);
            this.btnHapus.TabIndex = 20;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Upload_Dlabor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1467, 741);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.cmbTahun);
            this.Controls.Add(this.dtUPDT);
            this.Controls.Add(this.dgLabor);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTelusuri);
            this.Controls.Add(this.txtTelusuri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnUnggah);
            this.Controls.Add(this.btnMuatData);
            this.Controls.Add(this.btnKosong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Upload_Dlabor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sallaries Budget Uploaders";
            ((System.ComponentModel.ISupportInitialize)(this.dgLabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKosong;
        private System.Windows.Forms.Button btnMuatData;
        private System.Windows.Forms.Button btnUnggah;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelusuri;
        private System.Windows.Forms.Button btnTelusuri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoading;
        private Zuby.ADGV.AdvancedDataGridView dgLabor;
        private System.Windows.Forms.DateTimePicker dtUPDT;
        private System.Windows.Forms.ComboBox cmbTahun;
        private System.Windows.Forms.Button btnHapus;
    }
}

