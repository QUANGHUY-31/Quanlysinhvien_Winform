using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAL
{
    public class DAL_CoVanHocTap
    {
        private static DAL_CoVanHocTap instance;
        public static DAL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }
        private DAL_CoVanHocTap() { }
        public bool Them(string MaCoVan, string TenCoVan,string NgaySinh ,string GioiTinh, string Makhoa, string MaLop)
        {
            string sql = @"
                 INSERT INTO CoVanHocTap (MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop)
                 VALUES (@MaCVHT, @TenCVHT, @NgaySinh, @GioiTinh, @Makhoa, @MaLop)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaCVHT", MaCoVan),
                new SqlParameter("@TenCVHT", TenCoVan),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@Makhoa", Makhoa),
                new SqlParameter("@MaLop", MaLop)

             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string Makhoa, string MaLop, int id)
        {
            string sql = @"
                    UPDATE CoVanHocTap
                    SET MaCVHT = @MaCVHT,
                    TenCVHT = @TenCVHT,
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh,
                    Makhoa = @Makhoa,
                    MaLop = @MaLop
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@MaCVHT", MaCoVan),
                    new SqlParameter("@TenCVHT", TenCoVan),
                    new SqlParameter("@NgaySinh", NgaySinh),
                    new SqlParameter("@GioiTinh", GioiTinh),
                    new SqlParameter("@Makhoa", Makhoa),
                    new SqlParameter("@MaLop", MaLop),
                    new SqlParameter("@Id", id)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool Xoa(int id)
        {
            string sql = "DELETE FROM CoVanHocTap WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id)
          };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from CoVanHocTap");
        }
    }
}
