# Hotel Management

Ứng dụng Quản lý khách sạn cơ bản được xây dựng trên nền tảng WinForms với giao diện hiện đại.

## Tính năng

- Hiển thị trạng thái các phòng theo sơ đồ 1 cách trực quan.
- Quản lý phòng.
- Quản lý loại phòng.
- Quản lý đặt phòng.
- Quản lý hóa đơn.
- Quản lý các loại dịch vụ.
- Quản lý các loại tiện nghi.
- Quản lý thông tin cơ bản nhân viên.
- Quản lý thông tin cơ bản khách hàng.
- Quản lý loại tài khoản sử dụng ứng dụng.
- Thống kê doanh thu.
- In hóa đơn.
- Hỗ trợ lấy lại và thay đổi mất khẩu.
- Xuất file Excel các loại danh sách.
- Phân quyền cấp độ các loại tài khoản.

Ngôn ngữ: Tiếng Việt.

## Yêu cầu cài đặt

- Môi trường chạy chương trình:

   - Windows 8.1+.
   - .NET Framework 4.7.2.
   - Microsoft SQL Server 2021+.

- Môi trường phát triển phần mềm:

   - Microsoft Visual Studio 2022+.
   - Microsoft SQL Server 2021+.

## Hướng dẫn cài đặt

1. Đầu tiên, chạy file Hotel-Management-Setup.msi và cài đặt theo hướng dẫn bên trong.
	
2. Sau đó, mở ứng dụng Microsoft SQL Server Management Studio:
	
    - B1: Lấy Server name khi vừa khởi động ứng dụng này.	
	
    - B2: Chạy file SQLHotelManagement.sql và bạn có thể tạo tên của Database tùy ý. Mặc định là "HotelManagement".
	
    **Đặc biệt chú ý sử dụng Authentication là Windows Authentication.**

3. Để sử dụng ứng dụng Hotel Management, bạn cần chạy ứng dụng dưới quyền của Admin. Xem hướng dẫn [tại đây.](https://www.thegioididong.com/hoi-dap/run-as-administrator-la-gi-cach-chay-ung-dung-bang-quyen-1326223#:~:text=cho%20%E1%BB%A9ng%20d%E1%BB%A5ng-,B%C6%B0%E1%BB%9Bc%201%3A%20Click%20chu%E1%BB%99t%20ph%E1%BA%A3i%20v%C3%A0o%20%E1%BB%A9ng,m%C3%A0%20b%E1%BA%A1n%20mu%E1%BB%91n%20ch%E1%BA%A1y%20%3E%20Properties.&text=B%C6%B0%E1%BB%9Bc%202%3A%20Trong%20tab%20Compatibility,this%20program%20as%20an%20administrator.&text=B%C6%B0%E1%BB%9Bc%203%3A%20Ch%E1%BB%8Dn%20Change%20settings,%C4%91%E1%BB%83%20ho%C3%A0n%20t%E1%BA%A5t%20c%C3%A0i%20%C4%91%E1%BA%B7t.)

3. Bây giờ, bạn đã có thể sử dụng Hotel Management. Lúc này ứng dụng sẽ hỏi "Nhập tên server" (B1) và "Nhập tên Database" (B2) mà bạn đã có lúc nãy.

> Để tiện việc sử dụng Demo, nhóm có tạo một CSDL mặc định. Bạn có thể dùng ngay CSDL tại đó. Tài khoản mặc định là admin, mật khẩu là 1234.
 (Lưu ý: Nếu sử dụng CSDL mặc định thì khi tắt chương trình, dữ liệu sẽ không được lưu lại). 

## Tác giả 
    
[Nguyễn Phúc Bình](https://github.com/leesoonduck3009)

[Phan Tuấn Thành](https://github.com/thanhpt1110)

[Lê Thanh Tuấn](https://github.com/thtuanlegithub)
