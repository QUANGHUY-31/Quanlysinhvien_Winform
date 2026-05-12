using QuanLySinhVienWinForm.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienWinForm.BLL
{
    public class BLL_SinhVien
    {
        private static BLL_SinhVien instance;
        public static BLL_SinhVien Instance
        {
            get { if (instance == null) instance = new BLL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private BLL_SinhVien() { }

        public DataTable DanhSach()
        {
            return DAL_SinhVien.Instance.DanhSach();
        }

        public bool Them(string MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string QueQuan, DateTime NgayNhapHoc, string Malop, string MaKhoa, string MaCVHT)
        {
            return DAL_SinhVien.Instance.Them( MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc,  Malop,  MaKhoa,  MaCVHT);
        }
        public bool Sua(int Id, string MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string QueQuan, DateTime NgayNhapHoc, string Malop, string MaKhoa, string MaCVHT)
        {
            return DAL_SinhVien.Instance.Sua(Id, MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, Malop, MaKhoa, MaCVHT);
        }
        public bool Xoa(int id)
        {
            return DAL_SinhVien.Instance.Xoa(id);
        }
    }
}
