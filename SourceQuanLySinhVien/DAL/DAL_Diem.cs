using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAL
{
    public class DAL_Diem
    {
        private static DAL_Diem instance;
        public static DAL_Diem Instance
        {
            get { if (instance == null) instance = new DAL_Diem(); return instance; }
            private set => instance = value;
        }
        private DAL_Diem() { }
        public bool Them(string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTb, string Loai)
        {
            string sql = @"
                 INSERT INTO Diem (MaSV, MaMH, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTb, Loai)
                 VALUES (@MaSV, @MaMH, @PhanTramTrenLop, @PhanTramThi, @DiemTrenLop, @DiemThi, @DiemTb, @Loai)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSV", MaSV),
                new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@PhanTramTrenLop", PhanTramTrenLop),
                new SqlParameter("@PhanTramThi", PhanTramThi),
                new SqlParameter("@DiemTrenLop", DiemTrenLop),
                new SqlParameter("@DiemThi", DiemThi),
                new SqlParameter("@DiemTb", DiemTb),
                new SqlParameter("@Loai", Loai)
                

             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua(int id,string MaSV, string MaMH, int PhanTramTrenLop, int PhanTramThi, float DiemTrenLop, float DiemThi, float DiemTb, string Loai)
        {
            string sql = @"
                    UPDATE Diem
                    SET MaSV = @MaSV,
                    MaMH = @MaMH,
                    PhanTramTrenLop = @PhanTramTrenLop,
                    PhanTramThi = @PhanTramThi,
                    DiemTrenLop = @DiemTrenLop,   
                    DiemThi = @DiemThi,
                    DiemTb = @DiemTb,
                    Loai = @Loai
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@MaSV", MaSV),
                new SqlParameter("@MaMH", MaMH),
                new SqlParameter("@PhanTramTrenLop", PhanTramTrenLop),
                new SqlParameter("@PhanTramThi", PhanTramThi),
                new SqlParameter("@DiemTrenLop", DiemTrenLop),
                new SqlParameter("@DiemThi", DiemThi),
                new SqlParameter("@DiemTb", DiemTb),
                new SqlParameter("@Loai", Loai)
                
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool Xoa(int id)
        {
            string sql = "DELETE FROM Diem WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id)
          };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from  Diem");
        }
    }
}
