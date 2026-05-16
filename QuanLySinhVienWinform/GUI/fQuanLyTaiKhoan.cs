using QuanLySinhVienWinForm.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienWinForm.GUI
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)// button xóa 
        {
            int id = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            string ten = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này " + ten + " Không? ", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Xoa(id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0 && matkhau.Length >= 6 && loaiTK.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaiTK) == true)
                    {
                        btnLamMoi.PerformClick();//Bấm lại
                    }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 kí tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbID.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0 && loaiTK.Length > 0)
            {
                try
                {
                    // không cần sửa mật khẩu
                    if (matkhau.Length == 0)
                    {
                        if (BLL_TaiKhoan.Instance.KhongSuaMatKhau(tendangnhap, loaiTK, id) == true)
                        {
                            btnLamMoi.PerformClick();//Bấm lại
                        }
                    }
                    // Sửa Mật Khẩu
                    if (BLL_TaiKhoan.Instance.Sua(tendangnhap, matkhau, loaiTK, id) == true)
                    {
                        btnLamMoi.PerformClick();//Bấm lại
                    }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được dưới 6 kí tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();

            // reset lại form
            txbID.Text = "";
            txbTenDangNhap.Text = "";
            txbMatKhau.Text = "";
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbLoai_Click(object sender, EventArgs e)
        {

        }
        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cmbLoaiTaiKhoan.SelectedIndex = 0; // Items đã có sẵn trong Designer
            btnLamMoi.PerformClick();

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim();
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTaiKhoan.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void fQuanLyTaiKhoan_Load_1(object sender, EventArgs e)
        {
            cmbLoaiTaiKhoan.SelectedIndex = 0; // Items đã có sẵn trong Designer
            btnLamMoi.PerformClick();
        }
    }
}
