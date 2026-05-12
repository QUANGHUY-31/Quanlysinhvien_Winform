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
    public partial class fQuanLyKhoa : Form
    {
        public fQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void fQuanLyKhoa_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
            dgvKhoa.DataSource = BLL_Khoa.Instance.DanhSach();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;

            if (makhoa.Length == 0 && tenkhoa.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (BLL_Khoa.Instance.Them(makhoa, tenkhoa) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã khoa đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txbID.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txbMaKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txbTenKhoa.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString();

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa");
                return;
            }

            int id = Convert.ToInt32(dgvKhoa.CurrentRow.Cells[0].Value);
            string makhoa = txbMaKhoa.Text.Trim();
            string tenkhoa = txbTenKhoa.Text.Trim();

            if (makhoa == "" || tenkhoa == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            if (BLL_Khoa.Instance.Sua(makhoa, tenkhoa, id))
            {
                btnLamMoi.PerformClick();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa");
                return;
            }

            int id = Convert.ToInt32(dgvKhoa.CurrentRow.Cells[0].Value);
            string tenkhoa = dgvKhoa.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show(
                $"Bạn có muốn xoá khoa {tenkhoa} không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Khoa.Instance.Xoa(id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Khoa đang được sử dụng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
