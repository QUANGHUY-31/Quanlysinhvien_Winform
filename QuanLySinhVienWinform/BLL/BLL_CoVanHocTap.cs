using QuanLySinhVienWinForm.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienWinForm.BLL
{
    public class BLL_CoVanHocTap
    {
        private static BLL_CoVanHocTap instance;
        public static BLL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new BLL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }
        private BLL_CoVanHocTap() { }

        public DataTable DanhSach()
        {
            return DAL_CoVanHocTap.Instance.DanhSach();
        }

        public bool Them(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string Makhoa, string MaLop)
        {
            return DAL_CoVanHocTap.Instance.Them(MaCoVan, TenCoVan, NgaySinh, GioiTinh, Makhoa, MaLop);
        }
        public bool Sua(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string Makhoa, string MaLop, int id)
        {
            return DAL_CoVanHocTap.Instance.Sua(MaCoVan, TenCoVan, NgaySinh, GioiTinh, Makhoa, MaLop, id);
        }
        public bool Xoa(int id)
        {
            return DAL_CoVanHocTap.Instance.Xoa(id);
        }
    }
}
