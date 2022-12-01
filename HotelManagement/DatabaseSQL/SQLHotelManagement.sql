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