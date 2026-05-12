using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienWinForm.DAL
{
    public class DAL_Lop
    {
        private static DAL_Lop instance;
        public static DAL_Lop Instance
        {
            get { if (instance == null) instance = new DAL_Lop(); return instance; }
            private set => instance = value;
        }
        private DAL_Lop() { }
        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            string sql = @"
                 INSERT INTO Lop (Malop, TenLop, SoLuong, MaKhoa)
                 VALUES (@Malop, @TenLop, @SoLuong, @MaKhoa)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Malop", malop),
                new SqlParameter("@TenLop", tenlop),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@MaKhoa", makhoa)

             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {
            string sql = @"
                    UPDATE Lop
                    SET Malop = @Malop,
                    TenLop = @TenLop,
                    SoLuong = @SoLuong,
                    MaKhoa = @MaKhoa
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@Malop", malop),
                    new SqlParameter("@TenLop", tenlop),
                    new SqlParameter("@SoLuong", soluong),
                    new SqlParameter("@MaKhoa", makhoa),
                    new SqlParameter("@Id", id)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool Xoa(int id)
        {
            string sql = "DELETE FROM Lop WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id)
          };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from Lop");
        }
    }
}
