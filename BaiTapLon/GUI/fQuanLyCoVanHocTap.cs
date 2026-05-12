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
    public partial class fQuanLyCoVanHocTap : Form
    {
        public fQuanLyCoVanHocTap()
        {
            InitializeComponent();
        }

        private void fQuanLyCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvQuanLyCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            String malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
            {
                btnLamMoi.PerformClick();
            }
        }

        private void dgvQuanLyCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvQuanLyCoVanHocTap.CurrentRow.Cells[0].Value.ToString();
            txbMaCoVan.Text = dgvQuanLyCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvQuanLyCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvQuanLyCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvQuanLyCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            cmbMaLop.SelectedValue = dgvQuanLyCoVanHocTap.CurrentRow.Cells[6].Value.ToString().Trim();
            cmbMaKhoa.SelectedValue = dgvQuanLyCoVanHocTap.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maCoVan = txbMaCoVan.Text;

            if (MessageBox.Show($"Bạn có muốn xoá cố vấn {maCoVan}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_CoVanHocTap.Instance.Xoa(id) == true)
                {
                    btnLamMoi.PerformClick();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            String malop = cmbMaLop.SelectedValue.ToString();

            if (BLL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id) == true)
            {
                btnLamMoi.PerformClick();
            }
        }

        private void txbMaCoVan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
