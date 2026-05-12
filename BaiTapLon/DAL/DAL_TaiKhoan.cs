using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;
        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }
        private DAL_TaiKhoan() { }
        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = @"
                 INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan)
                 VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenDangNhap", ten),
                new SqlParameter("@MatKhau", matkhau),
                new SqlParameter("@LoaiTaiKhoan", loai)
             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua_het(string ten, string matkhau, string loai, int id)
        {
            string sql = @"
                    UPDATE TaiKhoan
                    SET TenDangNhap = @TenDangNhap,
                    MatKhau = @MatKhau,
                    LoaiTaiKhoan = @LoaiTaiKhoan
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@TenDangNhap", ten),
                    new SqlParameter("@MatKhau", matkhau),
                    new SqlParameter("@LoaiTaiKhoan", loai),
                    new SqlParameter("@Id", id)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            string sql = @"
                    UPDATE TaiKhoan
                    SET TenDangNhap = @TenDangNhap,
                    LoaiTaiKhoan = @LoaiTaiKhoan
                    WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@TenDangNhap", ten),
                    new SqlParameter("@LoaiTaiKhoan", loai),
                    new SqlParameter("@Id", id)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public bool Xoa(int id)
        {
            string sql = "DELETE FROM TaiKhoan WHERE Id = @Id";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Id", id)
          };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from TaiKhoan");
        }
        public DataTable DangNhap(string ten, string matkhau) 
        {
            string sql = "select *from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau ";
            return KetNoi.Instance.ExcuteQuery(sql, new object[] { ten, matkhau });
        }
        public bool DoiMatKhau(string ten, string matkhaumoi, string matkhaucu)
        {
            string sql = @"
        UPDATE TaiKhoan
        SET MatKhau = @MatKhauMoi
        WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhauCu";

            SqlParameter[] parameters =
            {
                new SqlParameter("@MatKhauMoi", matkhaumoi),
                new SqlParameter("@TenDangNhap", ten),
                new SqlParameter("@MatKhauCu", matkhaucu),
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }

    }
}
