using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.Core
{
    /// <summary>
    /// Mã hóa chuỗi văn bản bằng thuật toán SHA1.
    /// Dùng để hash mật khẩu trước khi lưu vào database.
    /// </summary>
    
    public class HeThong
    {
        public static string TENDANGNHAP = "";
        public static string LOAITAIKHOAN = "";
        /// <summary>
        /// Mã hóa chuỗi văn bản bằng thuật toán SHA1.
        /// </summary>
        /// <param name="text">Chuỗi cần mã hóa</param>
        /// <returns>Chuỗi đã được mã hóa</returns>
        public static string Hash(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
                hashSb.Append(b.ToString("X2"));
            return hashSb.ToString();
        }
    }
}
