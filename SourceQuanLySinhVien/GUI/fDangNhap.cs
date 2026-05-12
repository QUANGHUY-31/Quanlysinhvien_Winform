using BaiTapLon.BLL;
using BaiTapLon.GUI;

namespace BaiTapLon
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text;
            string matkhau = txbMatKhau.Text;

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau))
            {
                txbMatKhau.Clear();
                fSinhVien f = new fSinhVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
