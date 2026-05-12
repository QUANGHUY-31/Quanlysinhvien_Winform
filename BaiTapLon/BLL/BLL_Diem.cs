using BaiTapLon.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.BLL
{
    public class BLL_Diem
    {
        private static BLL_Diem instance;
        public static BLL_Diem Instance
        {
            get { if (instance == null) instance = new BLL_Diem(); return instance; }
            private set => instance = value;
        }
        private BLL_Diem() { }

        public DataTable DanhSach()
        {
            return DAL_Diem.Instance.DanhSach();
        }

        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTb, string Loai)
        {
            return DAL_Diem.Instance.Them(MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTb, Loai);
        }
        public bool Sua(int id, string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTb, string Loai)
        {
            return DAL_Diem.Instance.Sua(id, MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTb, Loai);
        }
        public bool Xoa(int id)
        {
            return DAL_Diem.Instance.Xoa(id);
        }
    }
}
