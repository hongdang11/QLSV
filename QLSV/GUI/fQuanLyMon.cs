using QLSV.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fQuanLyMonHoc : Form
    {
        private object dgvKhoa;

        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void fQuanLyKhoa_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMon.DataSource = BLL_MonHoc.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMH = txbMaMonHoc.Text;
            string tenMH = txbTenMonHoc.Text;
            int SoTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;
            if (BLL_MonHoc.Instance.Them(maMH, tenMH, SoTC, LT, TH) == true)
                btnLamMoi.PerformClick();
        }
        private void dgvMonHoc_CellClick(object sender, DataGirdViewCellEventArgs e)
        {
            txbID.Text = dgvMon.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvMon.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvMon.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoTinChi.Value = int.Parse(dgvMon.CurrentRow.Cells[3].Value.ToString());
            numTietLyThuyet.Value = int.Parse(dgvMon.CurrentRow.Cells[4].Value.ToString());
            numTietThucHanh.Value = int.Parse(dgvMon.CurrentRow.Cells[5].Value.ToString());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string MaMH = txbMaMonHoc.Text;

            if (MessageBox.Show("Bạn có muốn xóa môn học {maMH}? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_MonHoc.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMonHoc.Text;
            string tenMH = txbTenMonHoc.Text;
            int SoTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;
            if (BLL_MonHoc.Instance.Sua(maMH, tenMH, SoTC, LT, TH, id) == true)
                btnLamMoi.PerformClick();
        }
    }
}
