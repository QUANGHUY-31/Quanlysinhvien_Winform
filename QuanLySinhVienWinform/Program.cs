namespace QuanLySinhVienWinForm
{
    internal static class Program
    {
        /// <summary>
        ///  Điểm chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Để tùy chỉnh cấu hình ứng dụng như cài đặt DPI cao hoặc font mặc định,
            // xem https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fDangNhap());
        }
    }
}