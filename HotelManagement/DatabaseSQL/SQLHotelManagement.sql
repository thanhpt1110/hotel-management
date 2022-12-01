CREATE DATABASE HotelManangement
GO
USE HotelManangement
GO
SET DATEFORMAT DMY
CREATE TABLE NhanVien(
    "MaNV" NVARCHAR(5) PRIMARY KEY,
    "TenNV" NVARCHAR(50) NOT NULL,
    "ChucVu" NVARCHAR(50) NOT NULL,
    "Luong" MONEY NOT NULL,
    "SDT" NCHAR(10) NOT NULL UNIQUE,
    "CCCD" NCHAR(12) NOT NULL UNIQUE,
    "NgaySinh" DATE NOT NULL,
    "GioiTinh" NVARCHAR(3) NOT NULL,
    "DiaChi" NVARCHAR(100) NOT NULL,
	 Email NVARCHAR(100) UNIQUE
   -- "TenTK" NVARCHAR(50)  UNIQUE,
);
CREATE TABLE TaiKhoan
(
    TenTK NVARCHAR(50) NOT NULL PRIMARY KEY,
	Password NVARCHAR(1000) NOT NULL,	
    "CapDoQuyen" INT NOT NULL,
    "MaNV" NVARCHAR(5) NOT NULL
);
CREATE TABLE "KhachHang"(
    "MaKH" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "TenKH" NVARCHAR(50) NOT NULL,
    "SDT" NCHAR(10) UNIQUE,
    "CCCD/Passport" NCHAR(12) NOT NULL UNIQUE,
    "QuocTich" NVARCHAR(30) NOT NULL,
    "GioiTinh" NVARCHAR(3) NOT NULL,
   -- "DiaChi" NVARCHAR(100) ,
);
CREATE TABLE "Phong"(
    "MaPH" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "TTPH" NVARCHAR(20) NOT NULL,
    "TTDD" NVARCHAR(20) NOT NULL,
	GhiChu NVARCHAR(100),
    "MaLPH" NVARCHAR(5) NOT NULL,
);
CREATE TABLE "CTDP"(
	"MaCTDP" NVARCHAR(7) PRIMARY KEY,
    "MaPT" NVARCHAR(5) NOT NULL,
    "MaPH" NVARCHAR(5) NOT NULL,
    "CheckIn" SMALLDATETIME NOT NULL,
    "CheckOut" SMALLDATETIME NOT NULL,
	"ThanhTien" MONEY DEFAULT 0
	--CONSTRAINT PK_CTDP PRIMARY KEY("MaPT",MaPH)
);
CREATE TABLE "PhieuThue"(
    "MaPT" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "NgPT" SMALLDATETIME NOT NULL,
    "MaKH" NVARCHAR(5) NOT NULL,
    "MaNV" NVARCHAR(5) NOT NULL
);

CREATE TABLE "HoaDon"(
    "MaHD" NVARCHAR(5) PRIMARY KEY,
    "NgHD" SMALLDATETIME ,
    "TriGia" MONEY DEFAULT 0,
    "MaNV" NVARCHAR(5),
    --"MaPH" NVARCHAR(5) NOT NULL,
    --"MaPT" NVARCHAR(5) NOT NULL,
	"TrangThai" NVARCHAR(20) NOT NULL,
	"MaCTDP" NVARCHAR(7) NOT NULL
);
CREATE TABLE "TienNghi"(
    "MaTN" NVARCHAR(5) PRIMARY KEY,
    "TenTN" NVARCHAR(50) NOT NULL
);
CREATE TABLE "LoaiPhong"(
    "MaLPH" NVARCHAR(5) PRIMARY KEY,
    "TenLPH" NVARCHAR(20) NOT NULL,
    "SoGiuong" INT NOT NULL,
	"SoNguoiToiDa" INT NOT NULL,
    "GiaNgay" MONEY NOT NULL,
    "GiaGio" MONEY NOT NULL
);
CREATE TABLE "CTTN"(
    "MaLPH" NVARCHAR(5) NOT NULL,
    "MaTN" NVARCHAR(5) NOT NULL,
    "SL" INT DEFAULT -1
	CONSTRAINT PK_CTTN PRIMARY KEY(MaLPH,MaTN)
);
--CREATE TABLE "LoaiDichVu"(
--  "MaLDV" NVARCHAR(5) PRIMARY KEY,
--"TenLDV" NVARCHAR(20) NOT NULL
--);
CREATE TABLE "DichVu"(
    "MaDV" NVARCHAR(5) PRIMARY KEY,
    "TenDV" NVARCHAR(20) NOT NULL,
    "DonGia" MONEY NOT NULL,
	"SLConLai" INT DEFAULT -1,
    "LoaiDV" NVARCHAR(20) NOT NULL
);
CREATE TABLE "CTDV"(
    "MaHD" NVARCHAR(5) NOT NULL,
    "MaDV" NVARCHAR(5) NOT NULL,
    "SL" INT NOT NULL,
	"ThanhTien" MONEY DEFAULT 0,
	CONSTRAINT PK_CTDV PRIMARY KEY(MaHD,MaDV)
);
-- Nhân viên

INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('QL001',N'Nguyễn Phúc Bình', '30/09/2003', N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','40000000',N'Quản lý', '072000001212','0907219273','nguyen.phucbinh445@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('QL002',N'Phan Tuấn Thành', '11/10/2003',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','45000000',N'Quản lý', '072000001213','071223431','21520455@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('QL003',N'Lê Thanh Tuấn', '10/06/1989', N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','50000000',N'Quản lý', '072000001214','010311231','215205119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV001',N'Phạm Thị A', '09/03/1995',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Tiếp tân', '072000001215','095411231','NV215235119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV002',N'Trần Thị B', '23/01/1993',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Tiếp tân', '072000001217','091311231','NV545205119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV003',N'Nguyễn Phuc C ', '21/11/1986',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Tiếp tân', '072000001220','092311231','NV6152051@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV004',N'Lê Văn D', '05/7/1990',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Tiếp tân', '072000001221','090317231','NV2152119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV005',N'Hồ Văn E', '27/10/2000',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Bảo vệ', '072000001282','090312231','NV715205119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV006',N'Nguyễn Văn F', '24/02/1998',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Nhân viên vệ sinh', '072000009012','090111231','NV52015119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV007',N'Phạm Thị P', '02/08/2001',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Nhân viên vệ sinh', '072000002134','090311232','NV15205119@gmail.com')
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email) VALUES ('NV008',N'Nguyễn Văn G', '12/09/2002',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Bảo vệ', '072000028912','090311233','NV215595119@gmail.com')

-- Tai Khoan
	
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin','1234','QL001',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin1','5678','QL002',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin2','3456','QL003',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('Quanly','1234','NV001',2) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('NhanVien','1234','NV002',1) 

-- Khach Hang
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH001',N'Nguyễn Văn A', N'Nam', 'Việt Nam', '072001056912', '092391233')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH002',N'Nguyễn Văn B', N'Nam', 'Việt Nam', '072001056913', '092391234')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH003',N'Nguyễn Văn C', N'Nam', 'Việt Nam', '072001056914', '092391235')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH004',N'Phạm Thi P', N'Nữ', 'Việt Nam', '072001546231', '092361213')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH005',N'Phạm Thi G', N'Nữ', 'Việt Nam', '072001012231', '082361233')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH006',N'Nguyễn Văn D', N'Nam', 'Việt Nam', '072001056952', '092391236')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH007',N'Nguyễn Văn E', N'Nam', 'Việt Nam', '072001056911', '092391237')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH008',N'Phạm Thi H', N'Nữ', 'Việt Nam', '072001078231', '096361233')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH009',N'Nguyễn Văn F', N'Nam', 'Việt Nam', '072001056976', '092391238')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH010',N'Nguyễn Văn G', N'Nam', 'Việt Nam', '072001056919', '092391229')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH011',N'Phạm Thi U', N'Nữ', 'Việt Nam', '072071756231', '071236123')
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT) VALUES ('KH012',N'Phạm Thi T', N'Nữ', 'Việt Nam', '072041056231', '022361233')
-- Dich Vu
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV01', N'Nước suối', N'Thức uống', '100','10000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV02', N'Coca cola', N'Thức uống', '100','15000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV03', N'Pepsi', N'Thức uống', '100','15000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV04', N'Bia Sài Gòn', N'Thức uống', '100','20000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV05', N'Mì ăn liền', N'Đồ ăn', '100','15000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV06', N'Đưa đón', N'Dịch vụ', '-1','100000')
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia) VALUES ('DV07', N'Giặt ủi', N'Dịch vụ', '-1','25000')

-- Loai Phong
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('VIP01', N'VIP đơn','1','2', '500000', '150000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('VIP02', N'VIP đôi','2','4', '700000', '200000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('NOR01', N'Thường đơn','1','2', '300000', '80000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('NOR02', N'Thường đôi','2','4', '400000', '120000')
-- Phong
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P101', 'NOR01', N'Phòng đang thuê', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P102', 'NOR01', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P103', 'NOR02', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P104', 'NOR01', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P105', 'NOR02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P201', 'NOR02', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P202', 'NOR01', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P203', 'VIP02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P204', 'VIP02', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P301', 'VIP01', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P302', 'NOR01', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P303', 'NOR02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P304', 'VIP02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P305', 'VIP01', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P401', 'VIP02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P402', 'VIP02', N'Phòng trống', N'Đã dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P403', 'VIP01', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P404', 'VIP01', N'Phòng trống', N'Chưa dọn dẹp')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P501', 'VIP02', N'Phòng trống', N'Sửa chữa')
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD") VALUES ('P502', 'VIP02', N'Phòng trống', N'Sửa chữa')

-- Tiện nghi