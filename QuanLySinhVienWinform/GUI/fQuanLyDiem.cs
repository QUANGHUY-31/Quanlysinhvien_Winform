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
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDiem.DataSource = BLL_Diem.Instance.DanhSach();
            cmbMaSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSinhVien.DisplayMember = "TenSV";
            cmbMaSinhVien.ValueMember = "MaSV";
            cmbMaSinhVien.SelectedIndex = 0;


            cmbMaMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbMaMonHoc.DisplayMember = "TenMH";
            cmbMaMonHoc.ValueMember = "MaMH";
            cmbMaMonHoc.SelectedIndex = 0;

            cmbLoai.DataSource = new List<string> { "A", "B", "C", "D" };
            cmbLoai.SelectedIndex = 0;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbMaSinhVien.SelectedValue == null ||
                cmbMaMonHoc.SelectedValue == null ||
                cmbLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMonHoc.SelectedValue.ToString();
            int phantramLop = (int)numPhanTramLop.Value;
            int phantramThi = (int)numPhanTramThi.Value;

            if (!float.TryParse(txbDiemLop.Text, out float diemlop) ||
                !float.TryParse(txbDiemThi.Text, out float diemthi) ||
                !float.TryParse(txbDiemTB.Text, out float diemtb))
            {
                MessageBox.Show("Điểm phải là số!", "Lỗi");
                return;
            }

            string loai = cmbLoai.SelectedValue.ToString();
            int nam = DateTime.Now.Year;

            if (BLL_Diem.Instance.Them(masv, mamh, phantramLop, phantramThi,
                                       diemlop, diemthi, diemtb, loai))
            {
                MessageBox.Show("Thêm thành công!");
                btnLamMoi.PerformClick();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow == null || dgvDiem.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            int id = Convert.ToInt32(dgvDiem.CurrentRow.Cells[0].Value);

            

            string masv = cmbMaSinhVien.SelectedValue.ToString();
            string mamh = cmbMaMonHoc.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phantramthi = (int)numPhanTramThi.Value;

            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            float diemtb = float.Parse(txbDiemTB.Text);

            string loai = cmbLoai.SelectedValue.ToString();

            if (BLL_Diem.Instance.Sua(id, masv, mamh, phantramlop, phantramthi,
                                      diemlop, diemthi, diemtb, loai))
            {
                MessageBox.Show("Cập nhật thành công!");
                btnLamMoi.PerformClick();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);

            if (MessageBox.Show($"Bạn có muốn xoá điểm có ID {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_Diem.Instance.Xoa(id) == true)
                {
                    btnLamMoi.PerformClick();
                }
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDiem.CurrentRow == null)
                return;

            txbID.Text = dgvDiem.CurrentRow.Cells["Column1"].Value?.ToString() ?? "";

            cmbMaSinhVien.SelectedValue = dgvDiem.CurrentRow.Cells["Column2"].Value?.ToString();
            cmbMaMonHoc.SelectedValue = dgvDiem.CurrentRow.Cells["Column3"].Value?.ToString();

            numPhanTramLop.Value = Convert.ToDecimal(
                dgvDiem.CurrentRow.Cells["Column4"].Value ?? 0
            );

            numPhanTramThi.Value = Convert.ToDecimal(
                dgvDiem.CurrentRow.Cells["Column5"].Value ?? 0
            );

            txbDiemLop.Text = dgvDiem.CurrentRow.Cells["Column6"].Value?.ToString() ?? "";
            txbDiemThi.Text = dgvDiem.CurrentRow.Cells["Column7"].Value?.ToString() ?? "";
            txbDiemTB.Text = dgvDiem.CurrentRow.Cells["Column8"].Value?.ToString() ?? "";
            cmbLoai.Text = dgvDiem.CurrentRow.Cells["Column9"].Value.ToString()?.Trim();
        }

    }
}
