using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienWinForm.DAL
{
    public class DAL_Khoa
    {
        private static DAL_Khoa instance;
        public static DAL_Khoa Instance
        {
            get { if (instance == null) instance = new DAL_Khoa(); return instance; }
            private set => instance = value;
        }
        private DAL_Khoa() { }
        public bool Them(string makhoa, string tenkhoa)
        {
            string sql = @"
                 INSERT INTO Khoa (Makhoa, TenKhoa)
                 VALUES (@Makhoa, @TenKhoa)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Makhoa", makhoa),
                new SqlParameter("@TenKhoa", tenkhoa)
             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua(string makhoa, string tenkhoa, int id)
        {
            string sql = @"
                    UPDATE Khoa
                    SET Makhoa = @Makhoa,
                    TenKhoa = @TenKhoa
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@Makhoa", makhoa),
                    new SqlParameter("@TenKhoa", tenkhoa),
                    new SqlParameter("@Id", id)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool Xoa(int id)
        {
            string sql = "DELETE FROM Khoa WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id)
          };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from Khoa");
        }
    }
}
