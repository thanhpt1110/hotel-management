CREATE DATABASE HotelManagement
GO
USE HotelManagement
GO
SET DATEFORMAT DMY
CREATE TABLE NhanVien(
    "MaNV" NVARCHAR(5) PRIMARY KEY,
    "TenNV" NVARCHAR(50) NOT NULL,
    "ChucVu" NVARCHAR(50) NOT NULL,
    "Luong" MONEY NOT NULL,
    "SDT" NVARCHAR(10) NOT NULL UNIQUE,
    "CCCD" NVARCHAR(12) NOT NULL UNIQUE,
    "NgaySinh" DATE NOT NULL,
    "GioiTinh" NVARCHAR(3) NOT NULL,
    "DiaChi" NVARCHAR(100) NOT NULL,
     Email NVARCHAR(100) UNIQUE,
	 "DaXoa" BIT
);
CREATE TABLE TaiKhoan
(
    TenTK NVARCHAR(50) NOT NULL PRIMARY KEY,
    Password NVARCHAR(1000) NOT NULL,	
    "CapDoQuyen" INT NOT NULL,
    "MaNV" NVARCHAR(5) NOT NULL,
	"DaXoa" BIT DEFAULT 0
);
CREATE TABLE "KhachHang"(
    "MaKH" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "TenKH" NVARCHAR(50) NOT NULL,
    "SDT" NVARCHAR(10),
    "CCCD/Passport" NVARCHAR(12) NOT NULL UNIQUE,
    "QuocTich" NVARCHAR(30) NOT NULL,
    "GioiTinh" NVARCHAR(3) NOT NULL,
	"DaXoa" BIT
);
CREATE TABLE "Phong"(
    "MaPH" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "TTPH" NVARCHAR(20) NOT NULL,
    "TTDD" NVARCHAR(20) NOT NULL,
     GhiChu NVARCHAR(100),
    "MaLPH" NVARCHAR(5) NOT NULL,
	"DaXoa" BIT

);
CREATE TABLE "CTDP"(
    "MaCTDP" NVARCHAR(7) PRIMARY KEY,
    "SoNguoi" INT,
    "MaPT" NVARCHAR(5) NOT NULL,
    "MaPH" NVARCHAR(5) NOT NULL,
    "CheckIn" SMALLDATETIME NOT NULL,
    "CheckOut" SMALLDATETIME NOT NULL,
    "TrangThai" NVARCHAR(20) NOT NULL,
	"DonGia" MONEY,
    "ThanhTien" MONEY DEFAULT 0,
	"DaXoa" BIT DEFAULT 0,
	"TheoGio" BIT DEFAULT 0
);
CREATE TABLE "PhieuThue"(
    "MaPT" NVARCHAR(5) NOT NULL PRIMARY KEY,
    "NgPT" SMALLDATETIME NOT NULL,
    "MaKH" NVARCHAR(5) NOT NULL,
    "MaNV" NVARCHAR(5) NOT NULL,
	"DaXoa" BIT DEFAULT 0
);

CREATE TABLE "HoaDon"(
    "MaHD" NVARCHAR(5) PRIMARY KEY,
    "NgHD" SMALLDATETIME ,
    "TriGia" MONEY DEFAULT 0,
    "MaNV" NVARCHAR(5),
    "TrangThai" NVARCHAR(20) NOT NULL,
    "MaCTDP" NVARCHAR(7) NOT NULL,
	"DaXoa" BIT DEFAULT 0
);
CREATE TABLE "TienNghi"(
    "MaTN" NVARCHAR(5) PRIMARY KEY,
    "TenTN" NVARCHAR(50) NOT NULL,
	"DaXoa" BIT
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
    "SL" INT DEFAULT -1,
	"DaXoa" BIT DEFAULT 0
    CONSTRAINT PK_CTTN PRIMARY KEY(MaLPH,MaTN)
);
CREATE TABLE "DichVu"(
    "MaDV" NVARCHAR(5) PRIMARY KEY,
    "TenDV" NVARCHAR(20) NOT NULL,
    "DonGia" MONEY NOT NULL,
    "SLConLai" INT DEFAULT -1,
    "LoaiDV" NVARCHAR(20) NOT NULL,
	"DaXoa" BIT

);
CREATE TABLE "CTDV"(
    "MaCTDP" NVARCHAR(7) NOT NULL,
    "MaDV" NVARCHAR(5) NOT NULL,
	"DonGia" MONEY NOT NULL,
    "SL" INT NOT NULL,
	"DaXoa" BIT DEFAULT 0,
    "ThanhTien" MONEY DEFAULT 0,
    CONSTRAINT PK_CTDV PRIMARY KEY("MaCTDP",MaDV,DonGia)
);
-- Nhân viên
	ALTER TABLE
    "TaiKhoan" ADD CONSTRAINT "TaiKhoan_manv_foreign" FOREIGN KEY("MaNV") REFERENCES "NhanVien"("MaNV");
ALTER TABLE
    "HoaDon" ADD CONSTRAINT "hoadon_manv_foreign" FOREIGN KEY("MaNV") REFERENCES "NhanVien"("MaNV");
ALTER TABLE
	"HoaDon" ADD CONSTRAINT "hoadon_MaCTDP_foreign" FOREIGN KEY("MaCTDP") REFERENCES "CTDP"("MaCTDP");
ALTER TABLE
    "PhieuThue" ADD CONSTRAINT "phieuthue_makh_foreign" FOREIGN KEY("MaKH") REFERENCES "KhachHang"("MaKH");
ALTER TABLE
    "PhieuThue" ADD CONSTRAINT "phieuthue_manv_foreign" FOREIGN KEY("MaNV") REFERENCES "NhanVien"("MaNV");
ALTER TABLE
    "Phong" ADD CONSTRAINT "phong_malph_foreign" FOREIGN KEY("MaLPH") REFERENCES "LoaiPhong"("MaLPH");
ALTER TABLE 
	"CTDP" ADD CONSTRAINT "CTDP_MaPT_Forein" FOREIGN  KEY("MaPT") REFERENCES "PhieuThue"("MaPT")
ALTER TABLE 
	"CTDP" ADD CONSTRAINT "CTDP_MaPH_Forein" FOREIGN  KEY("MaPH") REFERENCES "Phong"("MaPH")

ALTER TABLE 
	"CTTN" ADD CONSTRAINT "CTTN_MaLPH_foreign" FOREIGN KEY ("MaLPH") REFERENCES LoaiPhong("MaLPH")
ALTER TABLE 
	"CTTN" ADD CONSTRAINT "CTTN_MaTN_foreign" FOREIGN KEY ("MaTN") REFERENCES TienNghi(MaTN)
ALTER TABLE
	"CTDV" ADD CONSTRAINT "CTDV_MaCTDP_foreign" FOREIGN KEY ("MaCTDP") REFERENCES CTDP("MaCTDP")
ALTER TABLE 
	"CTDV" ADD CONSTRAINT "CTDV_MaDV_foreign" FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)


GO
-- Trigger Update Giá phòng
CREATE TRIGGER CapNhatGiaCTDP ON CTDP FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MaPhong NVARCHAR(5)
	SET @MaPhong = (SELECT MaPH FROM inserted)
	DECLARE @MaCTDP NVARCHAR(7)
	SET @MaCTDP = (SELECT MaCTDP FROM inserted)
	DECLARE @GiaNgay MONEY
	SET @GiaNgay = (SELECT  LoaiPhong.GiaNgay
					FROM Phong JOIN LoaiPhong ON Phong.MaLPH=LoaiPhong.MaLPH
					WHERE Phong.MaPH=@MaPhong
					)
	DECLARE @GiaGio MONEY
	SET @GiaGio = (SELECT  LoaiPhong.GiaGio
					FROM Phong JOIN LoaiPhong ON Phong.MaLPH=LoaiPhong.MaLPH
					WHERE Phong.MaPH=@MaPhong
					)
	DECLARE @CheckIn SMALLDATETIME, @CheckOut SMALLDATETIME,@KhoangTGNgay INT, @KhoangTGGio INT
	SET @CheckIn = (SELECT CheckIn FROM inserted)
	SET @CheckOut = (SELECT CheckOut FROM inserted)
	SET @KhoangTGNgay=  (SELECT DATEDIFF(DAY, @CheckIn, @CheckOut))
	IF @KhoangTGNgay < 1
	BEGIN
	SET @KhoangTGGio=  (SELECT DATEDIFF(HOUR, @CheckIn, @CheckOut))		
		IF @KhoangTGGio < 4
			BEGIN
				DECLARE @DonGia MONEY
				SET @DonGia = (SELECT GiaGio FROM LoaiPhong JOIN Phong ON LoaiPhong.MaLPH = Phong.MaLPH JOIN CTDP ON CTDP.MaPH=Phong.MaPH WHERE CTDP.MaCTDP=@MaCTDP) 
				UPDATE CTDP
				SET "ThanhTien"= @KhoangTGGio * @GiaGio
				WHERE @MaCTDP = MaCTDP
				UPDATE CTDP
				SET "TheoGio"= 1
				WHERE @MaCTDP = MaCTDP
				UPDATE CTDP
				SET "DonGia"= @DonGia
				WHERE @MaCTDP = MaCTDP
			END
		ELSE
			BEGIN
				UPDATE CTDP
				SET "ThanhTien"= @GiaNgay
				WHERE @MaCTDP = MaCTDP
			END
	END
	ELSE
	BEGIN
		UPDATE CTDP
		SET "DonGia"= @GiaNgay
		WHERE @MaCTDP = MaCTDP
		UPDATE CTDP
		SET "ThanhTien"= @KhoangTGNgay * @GiaNgay
		WHERE @MaCTDP = MaCTDP
	END
END
-- Trigger update Gia CTDV
GO 
CREATE TRIGGER CapNhatGiaDV ON CTDV FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MaCTDP NVARCHAR(7), @MaDV NVARCHAR(5), @GiaTien MONEY, @SL INT
	SET @MaCTDP = (SELECT MaCTDP FROM inserted)
	SET @MaDV = (SELECT MaDV FROM inserted)
	SET @GiaTien = (SELECT DonGia FROM DichVu WHERE DichVu.MaDV=@MaDV)
	SET @SL = (SELECT SL FROM inserted)
	UPDATE CTDV
	SET DonGia=@GiaTien
	WHERE "MaDV" = @MaDV AND MaCTDP = @MaCTDP
	UPDATE CTDV
	SET ThanhTien= @SL * @GiaTien
	WHERE "MaDV" = @MaDV AND MaCTDP = @MaCTDP
END
-- TRIGGER udpate giá trị hóa đơn
GO
CREATE TRIGGER CapNhatGiaTriHoaDon ON HoaDon FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MaHD NVARCHAR(5), @MaCTDP NVARCHAR(7), @TongTienHD MONEY, @TongTienDV MONEY, @TongTienPhong MONEY
	SET @MaHD = (SELECT MaHD FROM inserted)
	SET @MaCTDP = (SELECT MaCTDP FROM inserted)
	SET @TongTienDV = 0
	SET @TongTienDV = (SELECT SUM(ThanhTien) FROM CTDV WHERE MaCTDP = @MaCTDP GROUP BY MaCTDP)
	SET @TongTienPhong = (SELECT ThanhTien FROM CTDP WHERE MaCTDP=@MaCTDP)
	IF ( NOT EXISTS( SELECT * FROM CTDV WHERE MaCTDP = @MaCTDP))
	BEGIN 
		SET @TongTienDV = 0
	END
	UPDATE HoaDon
	SET TriGia = @TongTienDV+@TongTienPhong
	WHERE MaHD=@MaHD
END
GO
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('AD001',N'Nguyễn Phúc Bình', '30/09/2003', N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','40000000',N'Quản lý', '072000001212','0907219273','21520638@gm.uit.edu.vn',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('AD002',N'Phan Tuấn Thành', '11/10/2003',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','45000000',N'Quản lý', '072000001213','071223431','21520455@gm.uit.edu.vn',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('AD003',N'Lê Thanh Tuấn', '10/06/1989', N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','50000000',N'Quản lý', '072000001214','010311231','21520519@gm.uit.edu.vn',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('QL001',N'Phạm Thị A', '09/03/1995',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Tiếp tân', '072000001215','095411231','NV215235119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV001',N'Trần Thị B', '23/01/1993',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Tiếp tân', '072000001217','091311231','NV545205119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV002',N'Nguyễn Phuc C ', '21/11/1986',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Tiếp tân', '072000001220','092311231','NV6152051@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV003',N'Lê Văn D', '05/7/1990',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Tiếp tân', '072000001221','090317231','NV2152119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV004',N'Hồ Văn E', '27/10/2000',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Bảo vệ', '072000001282','090312231','NV715205119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV005',N'Nguyễn Văn F', '24/02/1998',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Nhân viên vệ sinh', '072000009012','090111231','NV52015119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV006',N'Phạm Thị P', '02/08/2001',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nữ','5500000',N'Nhân viên vệ sinh', '072000002134','090311232','NV15205119@gmail.com',0)
INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,DiaChi, GioiTinh,Luong,ChucVu,CCCD,SDT,Email,"DaXoa") VALUES ('NV007',N'Nguyễn Văn G', '12/09/2002',N'Đường Hàn Thuyên, khu phố 6, Thủ Đức, Thành phố Hồ Chí Minh', N'Nam','5500000',N'Bảo vệ', '072000028912','090311233','NV215595119@gmail.com',0)

-- Tai Khoan
	
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin','1234','AD001',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin1','1234','AD002',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('admin2','1234','AD003',3) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('Quanly','1234','QL001',2) 
	INSERT INTO TaiKhoan (TenTK,Password,MaNV,"CapDoQuyen") VALUES ('NhanVien','1234','NV001',1) 

-- Khach Hang
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH001',N'Nguyễn Văn A', N'Nam', N'Việt Nam', '072001056912', '092391233',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH002',N'Nguyễn Văn B', N'Nam', N'Việt Nam', '072001056913', '092391234',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH003',N'Nguyễn Văn C', N'Nam', N'Việt Nam', '072001056914', '092391235',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH004',N'Phạm Thi P', N'Nữ', N'Việt Nam', '072001546231', '092361213',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH005',N'Phạm Thi G', N'Nữ', N'Việt Nam', '072001012231', '082361233',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH006',N'Nguyễn Văn D', N'Nam', N'Việt Nam', '072001056952', '092391236',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH007',N'Nguyễn Văn E', N'Nam', N'Việt Nam', '072001056911', '092391237',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH008',N'Phạm Thi H', N'Nữ', N'Việt Nam', '072001078231', '096361233',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH009',N'Nguyễn Văn F', N'Nam', N'Việt Nam', '072001056976', '092391238',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH010',N'Nguyễn Văn G', N'Nam', N'Việt Nam', '072001056919', '092391229',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH011',N'Phạm Thi U', N'Nữ', N'Việt Nam', '072071756231', '071236123',0)
	INSERT INTO KhachHang (MaKH,TenKH, GioiTinh, QuocTich, "CCCD/Passport", SDT, "DaXoa") VALUES ('KH012',N'Phạm Thi T', N'Nữ', N'Việt Nam', '072041056231', '022361233',0)
-- Dich Vu
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV01', N'Nước suối', N'Thức uống', '100','10000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV02', N'Coca cola', N'Thức uống', '100','15000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV03', N'Pepsi', N'Thức uống', '100','15000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV04', N'Bia Sài Gòn', N'Thức uống', '100','20000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV05', N'Mì ăn liền', N'Đồ ăn', '100','15000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV06', N'Đưa đón', N'Dịch vụ', '-1','100000',0)
	INSERT INTO DiCHVU (MaDV,"TenDV",LoaiDV,"SLConLai",DonGia,"DaXoa") VALUES ('DV07', N'Giặt ủi', N'Dịch vụ', '-1','25000',0)

-- Loai Phong
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('VIP01', N'VIP đơn','1','2', '500000', '150000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('VIP02', N'VIP đôi','2','4', '700000', '200000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('NOR01', N'Thường đơn','1','2', '300000', '80000')
	INSERT INTO LOAIPHONG ("MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", GiaNgay, GiaGio) VALUES ('NOR02', N'Thường đôi','2','4', '400000', '120000')
-- Phong
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P101', 'NOR01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P102', 'NOR01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P103', 'NOR02', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD", "GhiChu","DaXoa") VALUES ('P104', 'NOR01', N'Đang sửa chữa', N'Đã dọn dẹp', N'Hư điều hòa',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P105', 'NOR02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P106', 'VIP01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P201', 'NOR02', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P202', 'NOR01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P203', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P204', 'VIP02', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P301', 'VIP01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P302', 'NOR01', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P303', 'NOR02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P304', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P305', 'VIP01', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P401', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P402', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P403', 'VIP01', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P404', 'VIP01', N'Bình thường', N'Chưa dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P501', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
	INSERT INTO PHONG ("MaPH", "MaLPH", "TTPH", "TTDD","DaXoa") VALUES ('P502', 'VIP02', N'Bình thường', N'Đã dọn dẹp',0)
-- Tiện nghi	
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN001', N'Máy lạnh',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN002', N'Máy quạt',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN003', N'Tủ lạnh',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN004', N'Tivi',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN005', N'Đèn ngủ',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN006', N'Bàn',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN007', N'Ghế',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN008', N'Bàn trang điểm',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN009', N'Bồn tắm',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN010', N'Vòi sen',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN011', N'Máy sấy tóc',0)
	INSERT INTO TienNghi (MaTN,TenTN,"DaXoa") VALUES ('TN012', N'Máy nước nóng',0)
	

-- CTTN
	-- Phòng Thường 1 giường
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN002','2') -- Máy quạt
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN004','1') -- Tivi
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN005','1') -- Đèn ngủ
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN006','1') -- Bàn 
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN007','1') -- Ghế
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN010','1') -- Vòi sen
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN011','1') -- Máy sấy tóc
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR01','TN012','1') -- Máy nước nóng
	-- Phòng thường 2 giường
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN002','3') -- Máy quạt
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN004','1') -- Tivi
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN005','2') -- Đèn ngủ
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN006','1') -- Bàn 
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN007','2') -- Ghế
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN010','1') -- Vòi sen
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN011','1') -- Máy sấy tóc
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'NOR02','TN012','1') -- Máy nước nóng
	-- Phòng VIP 1 giường
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN001','1') -- Máy lạnh
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN004','1') -- Tivi
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN005','1') -- Đèn ngủ
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN006','1') -- Bàn 
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN007','1') -- Ghế
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN009','1') -- Bồn tắm
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN010','1') -- Vòi sen
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN011','1') -- Máy sấy tóc
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP01','TN012','1') -- Máy nước nóng
	-- Phòng VIP 2 giường
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN001','1') -- Máy lạnh
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN004','1') -- Tivi
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN005','2') -- Đèn ngủ
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN006','1') -- Bàn 
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN007','2') -- Ghế
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN009','1') -- Bồn tắm
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN010','1') -- Vòi sen
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN011','2') -- Máy sấy tóc
	INSERT INTO CTTN ("MaLPH","MaTN", "SL") VALUES ( 'VIP02','TN012','1') -- Máy nước nóng
-- Phiếu Thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT001', '10/05/2022','KH002','NV002') -- Đã thuê xong
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT002', '12/06/2022','KH004','QL001') -- Đã thuê xong
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT003', '15/07/2022','KH003','NV001') -- Đã thuê xong
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT004', '28/11/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT005', '28/08/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT006', '28/05/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT007', '28/03/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT008', '05/01/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT009', '03/02/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT010', '04/02/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT011', '06/01/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT012', '08/02/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT013', '09/02/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT014', '10/02/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT015', '28/12/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT016', '11/11/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT017', '15/10/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT018', '18/09/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT019', '30/08/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT020', '26/01/2023','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT021', '27/11/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT022', '11/06/2022','KH001','NV001') -- Đang thuê
	INSERT INTO PhieuThue("MaPT","NgPT","MaKH","MaNV") VALUES ('PT023', '11/11/2022','KH001','NV001') -- Đang thuê

-- CTDP
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP001','PT001','P101','11/05/2022','15/05/2022',N'Đã xong',1200000,300000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP002','PT001','P103','11/06/2022','15/06/2022',N'Đã xong',1600000,400000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP003','PT002','P201','15/07/2022','18/07/2022',N'Đã xong',1200000,400000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP004','PT003','P104','16/09/2022','20/09/2022',N'Đã xong',1200000,300000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP005','PT003','P204','01/12/2022','06/12/2022',N'Đã xong',1500000,300000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP006','PT004','P105','08/11/2022','10/12/2022',N'Đã xong',600000,300000,2) -- Đã thuê xong
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP007','PT023','P101','10/12/2022','20/12/2022',N'Đã xong',3000000,300000,2) -- Đang thuê
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP008','PT022','P301','17/12/2022','20/12/2022', N'Đã xong',900000,300000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP009','PT005','P201','30/09/2022','05/10/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP010','PT006','P101','03/12/2022','20/12/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP011','PT007','P301','20/12/2022','25/12/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP012','PT008','P401','08/08/2022','15/08/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP013','PT008','P501','09/10/2022','11/10/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP014','PT009','P202','18/07/2022','20/07/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP015','PT010','P203','11/11/2022','20/11/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP017','PT012','P105','17/09/2022','21/09/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP018','PT013','P302','01/01/2023','03/01/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP019','PT014','P303','15/12/2022','20/12/2022', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP020','PT015','P102','04/02/2023','07/02/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP021','PT016','P101','03/02/2023','07/02/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP022','PT017','P105','02/02/2023','08/02/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP023','PT018','P202','03/02/2023','09/02/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP024','PT019','P303','15/01/2023','17/01/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP025','PT020','P401','17/01/2023','19/01/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước
	INSERT INTO CTDP("MaCTDP","MaPT","MaPH","CheckIn","CheckOut","TrangThai","ThanhTien","DonGia",SoNguoi) VALUES('CTDP026','PT021','P302','20/01/2023','25/01/2023', N'Đã xong',1200000,400000,2) -- Đang đặt trước



--CTDV
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP001','DV01','2','20000','10000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP001','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP001','DV06','1','100000','100000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP002','DV01','1','10000','10000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP002','DV04','1','20000','20000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP002','DV06','1','100000','100000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP003','DV04','1','20000','20000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP004','DV07','1','25000','25000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP005','DV04','2','40000','20000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP007','DV01','2','20000','10000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP008','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP008','DV03','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP009','DV01','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP010','DV05','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP011','DV04','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP012','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP013','DV07','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP014','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP015','DV06','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP017','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP018','DV03','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP015','DV01','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP019','DV06','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP020','DV05','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP021','DV04','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP022','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP023','DV05','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP024','DV03','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP025','DV02','2','30000','15000')
	INSERT INTO CTDV("MaCTDP","MaDV","SL",ThanhTien,"DonGia") VALUES('CTDP025','DV01','2','30000','15000')




-- HoaDon
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD001','15/05/2022','NV001','CTDP001',N'Đã thanh toán','1350000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD002','15/06/2022','NV001','CTDP002',N'Đã thanh toán','1730000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD003','18/07/2022','NV001','CTDP003',N'Đã thanh toán','1730000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD004','20/09/2022','NV001','CTDP004',N'Đã thanh toán','1225000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD005','06/12/2022','NV001','CTDP005',N'Đã thanh toán','1540000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD006','10/12/2022','NV001','CTDP006',N'Đã thanh toán','600000') -- Update Tri gia sau
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD007','20/12/2022','NV001','CTDP007',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD008','20/12/2022','NV001','CTDP008',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD009','05/10/2022','NV001','CTDP009',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD010','20/12/2022','NV001','CTDP010',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD011','25/12/2022','NV001','CTDP011',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD012','18/12/2022','NV001','CTDP012',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD013','15/08/2022','NV001','CTDP013',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD014','20/07/2022','NV001','CTDP014',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD015','20/11/2022','NV001','CTDP015',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD018','03/01/2023','NV001','CTDP018',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD019','20/12/2022','NV001','CTDP019',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD020','07/02/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD021','07/02/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD022','08/02/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD023','09/02/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD024','17/01/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD025','19/01/2023','NV001','CTDP020',N'Đã thanh toán','0')
	INSERT INTO HoaDon("MaHD","NgHD","MaNV","MaCTDP","TrangThai","TriGia") VALUES('HD026','25/01/2023','NV001','CTDP020',N'Đã thanh toán','0')



