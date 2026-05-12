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
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();

            this.Font = new Font("Segoe UI", 9.5f);
            StyleDataGridView(dgvSinhVien);
        }
        private void quánLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýCốVấnHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCoVanHocTap f = new fQuanLyCoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fThongTinChiTiet().ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fDoiMatKhau().ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //button them
        {
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nu";
            string quequan = txbQueQuan.Text;
            DateTime ngaynhaphoc = dtpkNhapHoc.Value;
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();
            if (BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan))
            {
                btnLamMoi.PerformClick();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaCoVan.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaCoVan.DisplayMember = "TenCVHT";
            cmbMaCoVan.ValueMember = "MaCVHT";
            cmbMaCoVan.SelectedIndex = -1;

            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaKhoa.SelectedIndex = -1;

            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
            cmbMaLop.SelectedIndex = -1;

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = DateTime.Parse(dgvSinhVien.CurrentRow.Cells[3].Value.ToString());
            if (dgvSinhVien.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            dtpkNhapHoc.Value = DateTime.Parse(dgvSinhVien.CurrentRow.Cells[6].Value.ToString());
            cmbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
            cmbMaKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
            cmbMaCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            DateTime ngaysinh = dtpkNgaySinh.Value;
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nu";
            string quequan = txbQueQuan.Text;
            DateTime ngaynhaphoc = dtpkNhapHoc.Value;
            if (cmbMaLop.SelectedValue == null ||
                cmbMaKhoa.SelectedValue == null ||
                cmbMaCoVan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Lớp, Khoa, Cố vấn");
                return;
            }
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();
            if (BLL_SinhVien.Instance.Sua(id, masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan))
            {
                btnLamMoi.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaSV.Text;

            if (MessageBox.Show($"Bạn có muốn xoá sinh viên {maMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_SinhVien.Instance.Xoa(id) == true)
                {
                    btnLamMoi.PerformClick();
                }
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 36;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 234, 248);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowTemplate.Height = 30;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 254);
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpkNhapHoc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaCoVan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
