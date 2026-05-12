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
    public partial class fQuanLyLop : Form
    {
        public fQuanLyLop()
        {
            InitializeComponent();
        }

        private void fQuanLyLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();

            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "Makhoa";

            if (dgvLop.Rows.Count > 0)
            {
                dgvLop.ClearSelection();
            }

            txbID.Clear();
        }
        private bool isClearing = false;

        private void dgvLop_SelectionChanged(object sender, EventArgs e)
        {
            if (isClearing) return;
            if (dgvLop.CurrentRow == null) return;
            if (dgvLop.CurrentRow.IsNewRow) return;

            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString();
            txbMaLop.Text = dgvLop.CurrentRow.Cells[1].Value.ToString();
            txbTenLop.Text = dgvLop.CurrentRow.Cells[2].Value.ToString();
            numSoLuong.Value = Convert.ToInt32(dgvLop.CurrentRow.Cells[3].Value);
            cmbMaKhoa.SelectedValue = dgvLop.CurrentRow.Cells[4].Value.ToString();
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa");
                return;
            }

            int id = Convert.ToInt32(dgvLop.CurrentRow.Cells[0].Value);
            string tenlop = dgvLop.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show(
                $"Bạn có muốn xoá lop {tenlop} không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Lop.Instance.Xoa(id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lớp đang được sử dụng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malop = txbMaLop.Text;
            string tenlop = txbTenLop.Text;
            string makhoa = cmbMaKhoa.SelectedValue.ToString().Trim();
            int soluong = (int)numSoLuong.Value;

            if (malop.Length > 0 && tenlop.Length > 0)
            {
                try
                {
                    if (BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            isClearing = true;

            dgvLop.DataSource = BLL_Lop.Instance.DanhSach();
            dgvLop.ClearSelection();

            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "Makhoa";

            ClearInput();

            isClearing = false;
        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txbID.Text = dgvLop.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[2].Value.ToString();
            numSoLuong.Value = Convert.ToInt32(dgvLop.Rows[e.RowIndex].Cells[3].Value);
            cmbMaKhoa.SelectedValue = dgvLop.Rows[e.RowIndex].Cells[4].Value.ToString();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                return;
            }

            int id = Convert.ToInt32(dgvLop.CurrentRow.Cells[0].Value);

            string malop = txbMaLop.Text.Trim();
            string tenlop = txbTenLop.Text.Trim();
            string makhoa = cmbMaKhoa.SelectedValue?.ToString();
            int soluong = (int)numSoLuong.Value;

            if (string.IsNullOrEmpty(malop) || string.IsNullOrEmpty(tenlop))
            {
                MessageBox.Show("Không được để trống dữ liệu!");
                return;
            }

            if (BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id))
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
            }
        }
        private void ClearInput()
        {
            txbID.Clear();
            txbMaLop.Clear();
            txbTenLop.Clear();
            numSoLuong.Value = 0;

            if (cmbMaKhoa.Items.Count > 0)
                cmbMaKhoa.SelectedIndex = -1; // KHÔNG chọn khoa nào
        }


    }
}
