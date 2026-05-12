using BaiTapLon.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon.GUI
{
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvQuanLyMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
        }

        private void dgvQuanLyMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLyMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMonHoc.Text = dgvQuanLyMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoTinChi.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[3].Value.ToString());
            numTietLyThuyet.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[4].Value.ToString());
            numTietThucHanh.Value = int.Parse(dgvQuanLyMonHoc.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMH = txbMaMonHoc.Text;
            string tenMH = txbTenMonHoc.Text;
            int soTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;

            if (BLL_MonHoc.Instance.Them(maMH, tenMH, soTC, LT, TH) == true)
            {
                btnLamMoi.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMonHoc.Text;

            if (MessageBox.Show($"Bạn có muốn xoá môn học {maMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_MonHoc.Instance.Xoa(id) == true)
                {
                    btnLamMoi.PerformClick();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMonHoc.Text;
            string tenMH = txbTenMonHoc.Text;
            int soTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;

            if (BLL_MonHoc.Instance.Sua(maMH, tenMH, soTC, LT, TH, id) == true)
            {
                btnLamMoi.PerformClick();
            }
        }

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }
    }
}
