using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAL
{
    public class DAL_SinhVien
    {
        private static DAL_SinhVien instance;
        public static DAL_SinhVien Instance
        {
            get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }
        public bool Them(string MaSV, string TenSV, DateTime NgaySinh, string GioiTinh, string QueQuan, DateTime NgayNhapHoc, string Malop, string MaKhoa, string MaCVHT)
        {
            string sql = @"
                 INSERT INTO SinhVien (MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT)
                 VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh, @QueQuan, @NgayNhapHoc, @MaLop, @MaKhoa, @MaCVHT)";
            // Đóng gói tham số để tránh lỗi SQL Injection
            // Sử dụng SqlParameter để truyền tham số vào SQL
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSV", MaSV),
                new SqlParameter("@TenSV", TenSV),
                // Sử dụng SqlDbType.Date để đảm bảo định dạng ngày tháng chính xác
                new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = NgaySinh },
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@QueQuan", QueQuan),
                new SqlParameter("@NgayNhapHoc", SqlDbType.Date) { Value = NgayNhapHoc },
                new SqlParameter("@MaLop", Malop),
                new SqlParameter("@MaKhoa", MaKhoa),
                new SqlParameter("@MaCVHT", MaCVHT)
               
             };
            // trả về true nếu có ít nhất 1 dòng bị ảnh hưởng , ngược lại trả về false
            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }


        public bool Sua(int Id, string MaSV, string TenSV, DateTime NgaySinh,
                        string GioiTinh, string QueQuan, DateTime NgayNhapHoc,
                        string Malop, string MaKhoa, string MaCVHT)
        {
            string sql = @"UPDATE SinhVien SET 
                           MaSV = @MaSV,
                           TenSV = @TenSV,
                           NgaySinh = @NgaySinh,
                           GioiTinh = @GioiTinh,
                           QueQuan = @QueQuan,
                           NgayNhapHoc = @NgayNhapHoc,
                           MaLop = @MaLop,
                           MaKhoa = @MaKhoa,
                           MaCVHT = @MaCVHT
                           WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@Id", Id),
                    new SqlParameter("@MaSV", MaSV),
                    new SqlParameter("@TenSV", TenSV),
                    new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = NgaySinh },
                    new SqlParameter("@GioiTinh", GioiTinh),
                    new SqlParameter("@QueQuan", QueQuan),
                    new SqlParameter("@NgayNhapHoc", SqlDbType.Date) { Value = NgayNhapHoc },
                    new SqlParameter("@MaLop", Malop),
                    new SqlParameter("@MaKhoa", MaKhoa),
                    new SqlParameter("@MaCVHT", MaCVHT)
            };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }

        public bool Xoa(int id)
        {
            string sql = "DELETE FROM SinhVien WHERE Id = @Id";

            SqlParameter[] parameters =
            {
                   new SqlParameter("@Id", id)
             };

            return KetNoi.Instance.ExcuteNonQuery(sql, parameters) > 0;
        }
        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select *from SinhVien");
        }
    }
}
