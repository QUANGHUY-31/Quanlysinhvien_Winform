using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLySinhVienWinForm.DAL
{
    /// <summary>
    /// Lớp dùng để kết nối và thao tác với cơ sở dữ liệu SQL Server.
    /// Áp dụng Singleton Pattern để chỉ tạo một instance duy nhất.
    /// </summary>
    public class KetNoi
    {
        /// <summary>
        /// Chuỗi kết nối tới cơ sở dữ liệu.
        /// </summary>
        private string connectionString =
            @"Data Source=.\SQLEXPRESS01;
              Initial Catalog=db_QLSV1;
              Integrated Security=True;
              TrustServerCertificate=True"; 

        private static KetNoi instance;

        /// <summary>
        /// Instance duy nhất của lớp KetNoi ,được tạo khi lần đầu truy cập và sẽ được tái sử dụng cho các lần sau.
        /// </summary>
        public static KetNoi Instance
        {
            get
            {
                if (instance == null)
                    instance = new KetNoi();

                return instance;
            }
            private set => instance = value;
        }

        /// <summary>
        /// Constructor private để ngăn tạo object từ bên ngoài.
        /// </summary>
        private KetNoi() { }

        /// <summary>
        /// Thực thi câu lệnh SELECT và trả về kết quả dưới dạng DataTable.
        /// </summary>
        /// <param name="query">Câu lệnh SQL SELECT.</param>
        /// <param name="parameter">Danh sách tham số truyền vào query.</param>
        /// <returns>DataTable chứa dữ liệu truy vấn.</returns>
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có tham số, sẽ tìm kiếm các tham số trong câu lệnh SQL và gán giá trị tương ứng từ mảng parameter.
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    // Vòng lặp duyệt các phần tử trong câu lệnh SQL để tìm kiếm các tham số (bắt đầu bằng @) và gán giá trị từ mảng parameter.
                    foreach (string item in listParams)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
            }

            return data;
        }

        /// <summary>
        /// Thực thi các câu lệnh INSERT, UPDATE, DELETE.
        /// </summary>
        /// <param name="query">Câu lệnh SQL cần thực thi.</param>
        /// <param name="parameters">Danh sách tham số SQL.</param>
        /// <returns>Số dòng bị ảnh hưởng.</returns>
        public int ExcuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteNonQuery();
            }
        }
    }
}