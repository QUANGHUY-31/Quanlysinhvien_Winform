# QuanLySinhVien_Winform

Ứng dụng quản lý sinh viên được xây dựng bằng **C# Windows Forms** và **SQL Server**.

## Chức năng chính

* Đăng nhập hệ thống
* Quản lý sinh viên
* Quản lý khoa
* Quản lý lớp
* Quản lý môn học
* Quản lý điểm
* Tìm kiếm dữ liệu
* Phân quyền tài khoản

---

## Công nghệ sử dụng

* C#
* Windows Forms (.NET 8)
* SQL Server
* Microsoft.Data.SqlClient
* Git & GitHub

---

## Cấu trúc project

### `KetNoi.cs`

Lớp kết nối và thao tác cơ sở dữ liệu.

* Sử dụng Singleton Pattern
* Hỗ trợ:

  * SELECT (`ExcuteQuery`)
  * INSERT / UPDATE / DELETE (`ExcuteNonQuery`)

### `HeThong.cs`

Lớp hệ thống.

* Lưu thông tin đăng nhập hiện tại
* Mã hóa mật khẩu bằng SHA1

### `Program.cs`

Điểm khởi động chính của ứng dụng.

---

## Yêu cầu môi trường

* Visual Studio 2022 hoặc Visual Studio Insiders
* .NET 8 SDK
* SQL Server

---

## Cấu hình database

Chỉnh chuỗi kết nối trong:

```csharp
private string connectionString =
@"Data Source=.\SQLEXPRESS01;
Initial Catalog=db_QLSV1;
Integrated Security=True;
TrustServerCertificate=True";
```

---

## Clone project

```bash
git clone https://github.com/QUANGHUY-31/Quanlysinhvien_Winform.git
```

---

## Team workflow

Trước khi làm mỗi thành viên nên tạo branch riêng bằng cách để không bị ảnh hưởng vào main chính của code , không push hẳn vào main chính của code sẽ bị xung đột làm hỏng project :

```bash
git checkout -b feature/ten-chuc-nang
(tên chức năng là phần anh em làm )
```

Ví dụ:

```bash
git checkout -b feature/login
```

---

Trước khi bắt đầu code nên cập nhật source mới nhất:

```bash
git pull
```

---

Sau khi hoàn thành:

```bash
git add .
git commit -m "Add login feature" ( cho ae mới dùng git "Đây là ghi chú cho phần ae làm có thể tùy biến " )
git push
```


---

## Thành viên nhóm

* Quang Huy
* Huynh
* Hùng

---

## Ghi chú

Project phục vụ mục đích học tập và thực hành lập trình Windows Forms.
