namespace QLSV
{
    partial class fQuanLyMonHoc
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
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTenMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTietLyThuyet = new System.Windows.Forms.NumericUpDown();
            this.numTietThucHanh = new System.Windows.Forms.NumericUpDown();
            this.numSoTinChi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietThucHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMon
            // 
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMon.Location = new System.Drawing.Point(0, 111);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.Size = new System.Drawing.Size(777, 269);
            this.dgvMon.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSoTinChi);
            this.panel1.Controls.Add(this.numTietThucHanh);
            this.panel1.Controls.Add(this.numTietLyThuyet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txbTenMonHoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaMonHoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 380);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(666, 62);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 29);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(599, 62);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 29);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(532, 62);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(465, 62);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 29);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txbTenMonHoc
            // 
            this.txbTenMonHoc.Location = new System.Drawing.Point(403, 26);
            this.txbTenMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenMonHoc.MaxLength = 255;
            this.txbTenMonHoc.Name = "txbTenMonHoc";
            this.txbTenMonHoc.Size = new System.Drawing.Size(185, 26);
            this.txbTenMonHoc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên môn học:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.Location = new System.Drawing.Point(208, 26);
            this.txbMaMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMaMonHoc.MaxLength = 255;
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Size = new System.Drawing.Size(88, 26);
            this.txbMaMonHoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã môn học:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(49, 26);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.MaxLength = 255;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(57, 26);
            this.txbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "S.tín chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiết lý thuyết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiết thực hành:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaMH";
            this.Column2.HeaderText = "MÃ MÔN HỌC";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenMH";
            this.Column3.HeaderText = "TÊN MÔN HỌC";
            this.Column3.Name = "Column3";
            this.Column3.Width = 155;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoTC";
            this.Column4.HeaderText = "S.TÍN CHỈ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TietLT";
            this.Column5.HeaderText = "T.LÝ THUYẾT";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TietTH";
            this.Column6.HeaderText = "T.THỰC HÀNH";
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // numTietLyThuyet
            // 
            this.numTietLyThuyet.Location = new System.Drawing.Point(227, 63);
            this.numTietLyThuyet.Name = "numTietLyThuyet";
            this.numTietLyThuyet.Size = new System.Drawing.Size(56, 26);
            this.numTietLyThuyet.TabIndex = 14;
            // 
            // numTietThucHanh
            // 
            this.numTietThucHanh.Location = new System.Drawing.Point(392, 63);
            this.numTietThucHanh.Name = "numTietThucHanh";
            this.numTietThucHanh.Size = new System.Drawing.Size(56, 26);
            this.numTietThucHanh.TabIndex = 15;
            // 
            // numSoTinChi
            // 
            this.numSoTinChi.Location = new System.Drawing.Point(73, 63);
            this.numSoTinChi.Name = "numSoTinChi";
            this.numSoTinChi.Size = new System.Drawing.Size(57, 26);
            this.numSoTinChi.TabIndex = 16;
            // 
            // fQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 380);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fQuanLyMon";
            this.Text = "fQuanLyMon";
            this.Load += new System.EventHandler(this.fQuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTietLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietThucHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTinChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown numSoTinChi;
        private System.Windows.Forms.NumericUpDown numTietThucHanh;
        private System.Windows.Forms.NumericUpDown numTietLyThuyet;
    }
}