CREATE DATABASE QuanLyMauKiemDinhMoiTruong;
GO
USE QuanLyMauKiemDinhMoiTruong;
GO
use master
drop database QuanLyMauKiemDinhMoiTruong;
-- Bảng Quanlydangnhap
CREATE TABLE Quanlydangnhap (
    Madangnhap INT NOT NULL IDENTITY PRIMARY KEY,
    Taikhoan VARCHAR(50) NOT NULL,
	Email VARCHAR(255) UNIQUE NOT NULL,
    Mocthoigian DATETIME DEFAULT GETDATE(),
    Matkhau VARCHAR(255) NOT NULL
);
GO

-- Bảng Nhanvien
CREATE TABLE Nhanvien (
    Manhanvien VARCHAR(10) NOT NULL PRIMARY KEY,
    Hovaten NVARCHAR(100) NOT NULL,
    Ngaysinh DATE NOT NULL,
    Sodienthoai VARCHAR(15) NOT NULL,
    Chucvu NVARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL
);
GO

-- Bảng Quanly
CREATE TABLE Quanly (
    Maquanly VARCHAR(10) NOT NULL PRIMARY KEY,
    Hovaten NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Sodienthoai VARCHAR(15) NOT NULL
);
GO

-- Bảng Quanly_Nhanvien (Quan hệ nhiều-nhiều giữa Quanly và Nhanvien)
CREATE TABLE Quanly_Nhanvien (
    Maquanly VARCHAR(10) NOT NULL,
    Manhanvien VARCHAR(10) NOT NULL,
    PRIMARY KEY (Maquanly, Manhanvien),
    FOREIGN KEY (Maquanly) REFERENCES Quanly(Maquanly),
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Saoluudulieu
CREATE TABLE Saoluudulieu (
    Masoluu INT NOT NULL IDENTITY PRIMARY KEY,
    Tenbangcanluu VARCHAR(100) NOT NULL,
    Macanluu VARCHAR(10) NOT NULL,
    Tentruongcanluu VARCHAR(100) NOT NULL,
    Giatribandau VARCHAR(255) NOT NULL,
    Giatrithaydoi VARCHAR(255) NOT NULL,
    Loaichinhsua VARCHAR(50) NOT NULL,
    Ngaychinhsua DATE NOT NULL,
    Manguoisua VARCHAR(10) NOT NULL,
    FOREIGN KEY (Manguoisua) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Yeucauchinhsua
CREATE TABLE Yeucauchinhsua (
    Mayeucau INT NOT NULL IDENTITY PRIMARY KEY,
    Loaiyeucau VARCHAR(100) NOT NULL,
    Manhanvien VARCHAR(10) NOT NULL,
    Ngayyeucau DATE NOT NULL,
    Ngayxuly DATE,
    Trangthai VARCHAR(50) NOT NULL,
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Chatbot
CREATE TABLE Chatbot (
    Machatbot INT NOT NULL IDENTITY PRIMARY KEY,
    Tenchatbot VARCHAR(100) NOT NULL UNIQUE,
    Manhanvien VARCHAR(10) NOT NULL,
    LoaiThongbao VARCHAR(255) NOT NULL,
    ThoiGianThongBao DATETIME NOT NULL,
    Lich DATETIME NOT NULL,
    Noidung NTEXT NOT NULL,
    Trangthai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Quanlykhachhang
CREATE TABLE Quanlykhachhang (
    Makhachhang VARCHAR(10) NOT NULL PRIMARY KEY,
    Tencongty NVARCHAR(100) NOT NULL,
	Nguoidaidien NVARCHAR(100) NOT NULL,
    Diachi NVARCHAR(255) NOT NULL,
    Mahopdong VARCHAR(10) NOT NULL,
    Sodienthoai VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL
);
GO

-- Bảng Quanlyhopdong
CREATE TABLE Quanlyhopdong (
    Mahopdong VARCHAR(10) NOT NULL PRIMARY KEY,
    Makhachhang VARCHAR(10) NOT NULL,
    Manhanvien VARCHAR(10) NOT NULL,
    Quy FLOAT NOT NULL,
    Trangthai NVARCHAR(50) NOT NULL,
    Ngaylap DATE NOT NULL,
    Ngaytra DATE NOT NULL,
    Vieccanlam NVARCHAR(255) NOT NULL,
    FOREIGN KEY (Makhachhang) REFERENCES Quanlykhachhang(Makhachhang),
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Hopdong_Nhanvien (Quan hệ nhiều-nhiều giữa Hopdong và Nhanvien)
CREATE TABLE Hopdong_Nhanvien (
    Mahopdong VARCHAR(10) NOT NULL,
    Manhanvien VARCHAR(10) NOT NULL,
    PRIMARY KEY (Mahopdong, Manhanvien),
    FOREIGN KEY (Mahopdong) REFERENCES Quanlyhopdong(Mahopdong),
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Quanlymauquantrac (Đổi tên từ Quanlymauthu)
CREATE TABLE Quanlymauquantrac (
    Mamau VARCHAR(10) NOT NULL PRIMARY KEY,
    Mahopdong VARCHAR(10) NOT NULL,
    Tenmau NVARCHAR(100) NOT NULL,
    Noidung NVARCHAR(MAX) NOT NULL,
	Ngaylay DATE NOT NULL,							
    Ngaytra DATE NOT NULL,
    Manhanvien VARCHAR(10) NOT NULL,
    FOREIGN KEY (Mahopdong) REFERENCES Quanlyhopdong(Mahopdong),
    FOREIGN KEY (Manhanvien) REFERENCES Nhanvien(Manhanvien)
);
GO

-- Bảng Phieuketqua
CREATE TABLE Phieuketqua (
    Maphieuketqua INT NOT NULL IDENTITY PRIMARY KEY,
    Mamauthu VARCHAR(10) NOT NULL,
    Mahopdong VARCHAR(10) NOT NULL,
	Ngaylaymau DATE NOT NULL,
    Ngaytraketqua DATE NOT NULL,
    Trangthaiketquaphantich NVARCHAR(MAX) NOT NULL,
	Trangthaixuly NVARCHAR(30),
    FOREIGN KEY (Mamauthu) REFERENCES Quanlymauquantrac(Mamau),
    FOREIGN KEY (Mahopdong) REFERENCES Quanlyhopdong(Mahopdong)
);
GO
-- bảng chi tiết thông số
CREATE TABLE Chitietthongso (
	ID INT NOT NULL IDENTITY PRIMARY KEY,
	Maphieuketqua INT NOT NULL,
	Thongso NVARCHAR(100) NOT NULL,
	Donvi NVARCHAR(50) NOT NULL,
	Phuongphapphantich NVARCHAR(200) NOT NULL,
	KetquaPTN NVARCHAR(MAX) NULL, -- Kết quả PTN
    KetquaHT NVARCHAR(MAX) NULL,  -- Kết quả HT
	Quychuansosanh NVARCHAR(MAX) NOT NULL,
	FOREIGN KEY (Maphieuketqua) REFERENCES Phieuketqua(Maphieuketqua)

);
go
--Phần thêm sao lưu dữ liệu
CREATE TABLE QuanLyMauQuanTrac_History (
    Mamau VARCHAR(10),
    Mahopdong VARCHAR(10),
    Tenmau NVARCHAR(100),
    Noidung NVARCHAR(MAX),
	Ngaylay DATE,
    Ngaytra DATE,
    Manhanvien VARCHAR(10),
    Hanhdong NVARCHAR(10), -- Loại hành động (UPDATE, DELETE)
    Ngaychinhsua DATETIME DEFAULT GETDATE(), -- Thời gian hành động
	Banggoc NVARCHAR(100),
	Khoachinh NVARCHAR(100),
    PRIMARY KEY (Mamau, Ngaychinhsua)
);
GO
CREATE TABLE QuanLyKhachHang_History (
    Makhachhang VARCHAR(10),
    Tencongty NVARCHAR(100),
	Nguoidaidien NVARCHAR(50),
    Diachi NVARCHAR(255),   
    Mahopdong VARCHAR(10),
    Sodienthoai VARCHAR(15),
    Email NVARCHAR(100),
    Hanhdong NVARCHAR(10), -- Loại hành động (UPDATE, DELETE)
    Ngaychinhsua DATETIME DEFAULT GETDATE(), -- Thời gian hành động
	Banggoc NVARCHAR(100),
	Khoachinh NVARCHAR(100),
    PRIMARY KEY (Makhachhang, Ngaychinhsua)
);
GO
CREATE TABLE QuanLyHopDong_History (
    Mahopdong VARCHAR(10),
    Makhachhang VARCHAR(10),
    Manhanvien VARCHAR(10),
    Quy FLOAT,
    Trangthai NVARCHAR(50),
    Ngaylap DATE,
    Ngaytra DATE,
    Vieccanlam NVARCHAR(255),
    Hanhdong NVARCHAR(10), -- Loại hành động (UPDATE, DELETE)
    Ngaychinhsua DATETIME DEFAULT GETDATE(), -- Thời gian hành động
	Banggoc NVARCHAR(100),
	Khoachinh NVARCHAR(100),
    PRIMARY KEY (Mahopdong, Ngaychinhsua)
);
GO
CREATE TABLE PhieuKetQua_History (
    Maphieuketqua INT,
    Mamauthu VARCHAR(10),
    Mahopdong VARCHAR(10),
	Ngaylaymau DATE,
    Ngaytraketqua DATE,
    Trangthaiketquaphantich NVARCHAR(MAX),
	Trangthaixuly NVARCHAR(30),
    Hanhdong NVARCHAR(10), -- Loại hành động (UPDATE, DELETE)
    Ngaychinhsua DATETIME DEFAULT GETDATE(), -- Thời gian hành động
	Banggoc NVARCHAR(100),
	Khoachinh NVARCHAR(100),
    PRIMARY KEY (Maphieuketqua, Ngaychinhsua)
);
GO


----------------------------------
-- Thêm dữ liệu vào bảng Nhanvien
INSERT INTO Nhanvien (Manhanvien, Hovaten, Ngaysinh, Sodienthoai, Chucvu, Email) VALUES
('CVQ', N'Cao Văn Quân', '1995-01-01', '0912355236', N'Nhân viên', 'Caoquan415@gmail.com'),
('NVH', N'Nguyễn Văn Hùng', '1990-01-01', '0912345678', N'Nhân viên', 'nguyenvanhung@gmail.com'),
('TTM', N'Trần Thị Mai', '1985-05-12', '0923456789', N'Nhân viên', 'tranthimai@gmail.com'),
('LHA', N'Lê Hoàng Anh', '1992-08-20', '0934567890', N'Nhân viên', 'lehoanganh@gmail.com'),
('LNHV', N'Lê Nguyễn Hoàng Vương', '1995-12-15', '0945678901', N'Nhân viên', 'lenguyenhoangvuong81@gmail.com');
GO

-- Thêm dữ liệu vào bảng Quanly
INSERT INTO Quanly (Maquanly, Hovaten, Email, Sodienthoai) VALUES
('CMQ', N'Cao Minh Quân', '415quancao@gmail.com', '0353670210');
GO
-- Thêm dữ liệu vào bảng Quanly_Nhanvien
INSERT INTO Quanly_Nhanvien (Maquanly, Manhanvien) VALUES
('CMQ', 'CVQ'),
('CMQ', 'NVH'),
('CMQ', 'TTM'),
('CMQ', 'LHA'),
('CMQ', 'LNHV');
GO

-- Thêm dữ liệu vào bảng Quanlydangnhap
INSERT INTO Quanlydangnhap (Taikhoan, Matkhau, Email) VALUES
('CVQ', 'Caovanquan123', 'Caoquan415@gmail.com'),
('NVH', 'Nguyenvanhung123', 'nguyenvanhung@gmail.com'),
('TTM', 'Tranthimai123', 'tranthimai@gmail.com'),
('LHA', 'Lehoanganh123', 'lehoanganh@gmail.com'),
('LNHV', 'Lenguyenhoangvuong123', 'lenguyenhoangvuong81@gmail.com'),
('CMQ', 'Caoquan123', '415quancao@gmail.com');
GO
-- Thêm dữ liệu vào bảng Quanlykhachhang
INSERT INTO Quanlykhachhang (Makhachhang, Tencongty, Diachi, Nguoidaidien, Mahopdong, Sodienthoai, Email)
VALUES 
('KH001', N'Công ty ABC', N'123 Đường ABC, Quận 1, TP.HCM', N'Nguyễn Gia Hà', '24.001', '0912214394', 'abc@company.com'),
('KH002', N'Công ty BCD', N'734 Đường Trần Hưng Đạo, Quận Bình Thạnh, Đà Nẵng', N'Phan Minh Khánh', '24.002', '0977431659', 'bcd@company.com'),
('KH003', N'Công ty CDE', N'822 Đường Lê Lợi, Quận 3, TP.HCM', N'Trần Thị Dương', '24.003', '0981674672', 'cde@company.com'),
('KH004', N'Công ty DEF', N'941 Đường Phạm Ngũ Lão, Quận 7, Hà Nội', N'Hoàng Minh Cường', '24.004', '0888195492', 'def@company.com');
GO

-- Thêm dữ liệu vào bảng Quanlyhopdong
INSERT INTO Quanlyhopdong (Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam)
VALUES 
('24.001', 'KH001', 'CVQ', 1, N'Đã hoàn thành', '2024-02-01', '2024-02-15', N'Dịch vụ kiểm tra chất lượng tại khu vực A'),
('24.002', 'KH002', 'NVH', 1, N'Đã hoàn thành', '2024-01-01', '2024-01-20', N'Dịch vụ kiểm tra chất lượng tại khu vực B'),
('24.003', 'KH003', 'TTM', 1, N'Đã hoàn thành', '2024-01-14', '2024-01-21', N'Dịch vụ kiểm tra chất lượng tại khu vực C'),
('24.004', 'KH004', 'LNHV', 1, N'Đã hoàn thành', '2024-02-25', '2024-03-15', N'Dịch vụ kiểm tra chất lượng tại khu vực D'),

--dữ liệu mẫu cho CVQ quý 1
('24.005', 'KH001', 'CVQ', 1, N'Đã hoàn thành', '2024-01-10', '2024-01-15', N'Dịch vụ kiểm tra chất lượng tại khu vực A1'),
('24.006', 'KH001', 'CVQ', 1, N'Đã hoàn thành', '2024-01-08', '2024-01-25', N'Dịch vụ kiểm tra chất lượng tại khu vực A2'),
('24.007', 'KH001', 'CVQ', 1, N'Đã hoàn thành', '2024-01-03', '2024-01-10', N'Dịch vụ kiểm tra chất lượng tại khu vực A3'),
('24.008', 'KH001', 'CVQ', 1, N'Đã trễ hạn', '2024-01-01', '2024-01-02', N'Dịch vụ kiểm tra chất lượng tại khu vực A4'),

--dữ liệu mẫu cho CVQ quý 2, 3 k có hợp đồng nào
-- dữ liệu mẫu cho CVQ quý 4
('24.009', 'KH001', 'CVQ', 4, N'Đã hoàn thành', '2024-10-10', '2024-10-25', N'Dịch vụ kiểm tra chất lượng tại khu vực A5'),
('24.010', 'KH001', 'CVQ', 4, N'Đang hoạt động', '2024-11-07', '2024-12-15', N'Dịch vụ kiểm tra chất lượng tại khu vực A6'),
('24.011', 'KH001', 'CVQ', 4, N'Đang hoạt động', '2024-12-04', '2024-12-22', N'Dịch vụ kiểm tra chất lượng tại khu vực A7'),
('24.012', 'KH001', 'CVQ', 4, N'Đang hoạt động', '2024-11-28', '2024-12-07', N'Dịch vụ kiểm tra chất lượng tại khu vực A8'),

-- dữ liệu mẫu cho NVH quý 1 k có hợp đồng nào
('24.013', 'KH002', 'NVH', 2, N'Đã hoàn thành', '2024-04-10', '2024-04-15', N'Dịch vụ kiểm tra chất lượng tại khu vực B1'),
('24.014', 'KH002', 'NVH', 2, N'Đã hoàn thành', '2024-04-10', '2024-05-15', N'Dịch vụ kiểm tra chất lượng tại khu vực B2'),
('24.015', 'KH002', 'NVH', 2, N'Đã hoàn thành', '2024-05-05', '2024-06-20', N'Dịch vụ kiểm tra chất lượng tại khu vực B3'),
-- dữ liệu mẫu cho NVH quý 3
('24.016', 'KH002', 'NVH', 3, N'Đã hoàn thành', '2024-07-07', '2024-07-15', N'Dịch vụ kiểm tra chất lượng tại khu vực B4'),
('24.017', 'KH002', 'NVH', 3, N'Đã hoàn thành', '2024-08-10', '2024-08-22', N'Dịch vụ kiểm tra chất lượng tại khu vực B5'),
-- dữ liệu mẫu cho NVH quý 4
('24.018', 'KH002', 'NVH', 4, N'Đã trễ hạn', '2024-10-02', '2024-10-18', N'Dịch vụ kiểm tra chất lượng tại khu vực B6'),
('24.019', 'KH002', 'NVH', 4, N'Đang hoạt động', '2024-11-10', '2024-12-10', N'Dịch vụ kiểm tra chất lượng tại khu vực B7'),
('24.020', 'KH002', 'NVH', 4, N'Đã hoàn thành', '2024-08-10', '2024-08-22', N'Dịch vụ kiểm tra chất lượng tại khu vực B8');

-- LHA chưa có hd nào, còn lại các nhân viên mỗi người ít nhất 1 cái
GO
-- Thêm dữ liệu vào bảng Quanlymauquantrac
INSERT INTO Quanlymauquantrac(Mamau, Mahopdong, Tenmau, Noidung, Ngaylay, Ngaytra, Manhanvien)
VALUES 
('KK1', '24.001', N'Mẫu quan trắc không khí tại khu vực A', N'Mẫu không khí lấy tại khu vực A', '2024-02-02','2024-02-10', 'CVQ'), -- đã có dữ liệu chi tiết
('KK2', '24.002', N'Mẫu quan trắc không khí tại khu vực B', N'Mẫu không khí lấy tại khu vực B', '2024-01-01','2024-01-18', 'NVH'), -- đã có dữ liệu chi tiết
('KK3', '24.003', N'Mẫu quan trắc không khí tại khu vực C', N'Mẫu không khí lấy tại khu vực C', '2024-01-15','2024-01-20', 'TTM'), -- đã có dữ liệu chi tiết
('KK4', '24.004', N'Mẫu quan trắc không khí tại khu vực D', N'Mẫu không khí lấy tại khu vực D', '2024-02-27','2024-03-10', 'LNHV'), -- đã có dữ liệu chi tiết
('KK5', '24.005', N'Mẫu quan trắc không khí tại khu vực A1', N'Mẫu không khí lấy tại khu vực A1', '2024-01-12','2024-01-14', 'CVQ'), -- đã có dữ liệu chi tiết
('KK6', '24.006', N'Mẫu quan trắc không khí tại khu vực A2', N'Mẫu không khí lấy tại khu vực A2', '2024-01-12','2024-01-20', 'CVQ'), -- đã có dữ liệu chi tiết
('KK7', '24.007', N'Mẫu quan trắc không khí tại khu vực A3', N'Mẫu không khí lấy tại khu vực A3', '2024-01-05','2024-01-09', 'CVQ'), -- đã có dữ liệu chi tiết
('KK8', '24.008', N'Mẫu quan trắc không khí tại khu vực A4', N'Mẫu không khí lấy tại khu vực A4', '2024-02-02','2024-02-05', 'CVQ'), --K có dữ liệu chi tiết
('KK9', '24.009', N'Mẫu quan trắc không khí tại khu vực A5', N'Mẫu không khí lấy tại khu vực A5', '2024-10-11','2024-10-23', 'CVQ'), -- đã có dữ liệu chi tiết
('KK10', '24.010', N'Mẫu quan trắc không khí tại khu vực A6', N'Mẫu không khí lấy tại khu vực A6', '2024-11-10','2024-12-10', 'CVQ'), -- chưa có dữ liệu chi tiết
('KK11', '24.011', N'Mẫu quan trắc không khí tại khu vực A7', N'Mẫu không khí lấy tại khu vực A7', '2024-12-07','2024-12-20', 'CVQ'), -- chưa có dữ liệu chi tiết
('KK12', '24.012', N'Mẫu quan trắc không khí tại khu vực A8', N'Mẫu không khí lấy tại khu vực A8', '2024-11-30','2024-12-05', 'CVQ'), -- chưa có dữ liệu chi tiết
('KK13', '24.013', N'Mẫu quan trắc không khí tại khu vực B1', N'Mẫu không khí lấy tại khu vực B1', '2024-04-12','2024-04-15', 'NVH'), -- đã có dữ liệu chi tiết
('KK14', '24.014', N'Mẫu quan trắc không khí tại khu vực B2', N'Mẫu không khí lấy tại khu vực B2', '2024-04-15','2024-05-10', 'NVH'), -- đã có dữ liệu chi tiết
('KK15', '24.015', N'Mẫu quan trắc không khí tại khu vực B3', N'Mẫu không khí lấy tại khu vực B3', '2024-05-07','2024-06-18', 'NVH'), -- đã có dữ liệu chi tiết
('KK16', '24.016', N'Mẫu quan trắc không khí tại khu vực B4', N'Mẫu không khí lấy tại khu vực B4', '2024-07-10','2024-07-12', 'NVH'), -- đã có dữ liệu chi tiết
('KK17', '24.017', N'Mẫu quan trắc không khí tại khu vực B5', N'Mẫu không khí lấy tại khu vực B5', '2024-08-14','2024-08-20', 'NVH'), -- đã có dữ liệu chi tiết
('KK18', '24.018', N'Mẫu quan trắc không khí tại khu vực B6', N'Mẫu không khí lấy tại khu vực B6', '2024-10-02','2024-10-18', 'NVH'), -- k có dữ liệu chi tiết
('KK19', '24.019', N'Mẫu quan trắc không khí tại khu vực B7', N'Mẫu không khí lấy tại khu vực B7', '2024-11-15','2024-12-08', 'NVH'), -- chưa có dữ liệu chi tiết 
('KK20', '24.020', N'Mẫu quan trắc không khí tại khu vực B8', N'Mẫu không khí lấy tại khu vực B8', '2024-08-12','2024-08-20', 'NVH'); -- đã có dữ liệu chi tiết
GO

-- Thêm dữ liệu vào bảng Phieuketqua
INSERT INTO Phieuketqua(Mamauthu, Mahopdong, Ngaylaymau, Ngaytraketqua, Trangthaiketquaphantich, Trangthaixuly)
VALUES 
('KK1', '24.001', '2024-02-02','2024-02-10', N'Đã có kết quả', N'Đã xử lý'),
('KK2', '24.002', '2024-01-01','2024-01-18', N'Đã có kết quả', N'Đã xử lý'),
('KK3', '24.003', '2024-01-15','2024-01-20', N'Đã có kết quả', N'Đã xử lý'),
('KK4', '24.004', '2024-02-27','2024-03-10', N'Đã có kết quả', N'Đã xử lý'),
('KK5', '24.005', '2024-01-12','2024-01-14', N'Đã có kết quả', N'Đã xử lý'),
('KK6', '24.006', '2024-01-12','2024-01-20', N'Đã có kết quả', N'Đã xử lý'),
('KK7', '24.007', '2024-01-05','2024-01-09', N'Đã có kết quả', N'Đã xử lý'),
('KK8', '24.008', '2024-02-02','2024-02-05', N'Chưa có kết quả', N'Chưa xử lý'),
('KK9', '24.009', '2024-10-11','2024-10-23', N'Đã có kết quả', N'Đã xử lý'),
('KK10', '24.010', '2024-11-10','2024-12-10', N'Chưa có kết quả', N'Chưa xử lý'),
('KK11', '24.011', '2024-12-07','2024-12-20', N'Chưa có kết quả', N'Chưa xử lý'),
('KK12', '24.012', '2024-11-30','2024-12-05', N'Chưa có kết quả', N'Chưa xử lý'),
('KK13', '24.013', '2024-04-12','2024-04-15', N'Đã có kết quả', N'Đã xử lý'),
('KK14', '24.014', '2024-04-15','2024-05-10', N'Đã có kết quả', N'Đã xử lý'),
('KK15', '24.015', '2024-05-07','2024-06-18', N'Đã có kết quả', N'Đã xử lý'),
('KK16', '24.016', '2024-07-10','2024-07-12', N'Đã có kết quả', N'Đã xử lý'),
('KK17', '24.017', '2024-07-10','2024-07-12', N'Đã có kết quả', N'Đã xử lý'),
('KK18', '24.018', '2024-10-02','2024-10-18', N'Chưa có kết quả', N'Chưa xử lý'),
('KK19', '24.019', '2024-11-15','2024-12-08', N'Chưa có kết quả', N'Chưa xử lý'),
('KK20', '24.020', '2024-08-12','2024-08-20', N'Đã có kết quả', N'Đã xử lý');


go

-- thêm dữ liệu vào bảng Chitietthongso
INSERT INTO Chitietthongso(Maphieuketqua,Thongso, Donvi, Phuongphapphantich, KetquaPTN, KetquaHT, Quychuansosanh)
VALUES
(1, N'Nhiệt độ', N'°C', N'TCVN 3129:2009', '30', '37', 'KPT'),
(1, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(2, N'Nhiệt độ', N'°C', N'TCVN 3129:2009', '30', '37', 'KPT'),

(3, N'CO', N'ppb', N'TCVN 3129:2009', '2,234', '2,000', 'KPT'),

(4, N'Nhiệt độ', N'°C', N'TCVN 3129:2009', '30', '37', 'KPT'),

(5, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(6, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(7, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(9, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(13, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(14, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(15, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(16, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(17, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT'),

(20, N'NO₂', N'µg/Nm³', N'TCVN 3128:2009', '2,234', '4,234', 'KPT');

go
-- Thêm dữ liệu vào bảng Yeucauchinhsua
--INSERT INTO Yeucauchinhsua (Loaiyeucau, Manhanvien, Ngayyeucau, Ngayxuly, Trangthai) VALUES
--(N'Cập nhật thông tin nhân viên', 'NVH', '2024-02-01', '2024-02-02', N'Đã xử lý'),
--(N'Thay đổi chức vụ', 'LHA', '2024-02-05', NULL, N'Đang xử lý'),
--(N'Cập nhật email nhân viên', 'LNHV', '2024-02-10', '2024-02-12', N'Đã xử lý'),
--(N'Đề nghị kết thúc hợp đồng', 'TTM', '2024-02-15', NULL, N'Chưa xử lý'),
--(N'Yêu cầu điều tra mẫu', 'CMQ', '2024-02-20', NULL, N'Đang xử lý');
--GO

-- Thêm dữ liệu vào bảng Chatbot
INSERT INTO Chatbot (Tenchatbot, Manhanvien, LoaiThongbao, ThoiGianThongBao, Lich, Noidung, Trangthai) VALUES
(N'BotThôngBáoNV', 'LNHV', N'Thông báo nhân viên', '2024-06-01 08:00:00', '2024-06-01 08:00:00', N'Họp giao ban đầu tháng', N'Chưa thông báo'),
(N'BotThôngBáoKH', 'LNHV', N'Thông báo khách hàng', '2024-06-05 10:00:00', '2024-06-05 10:00:00', N'Cập nhật tiến độ dự án', N'Đã thông báo');
GO
--procedure chatbot
CREATE PROCEDURE sp_GetContractsDueSoon
AS
BEGIN
    SELECT 
        Mahopdong,
        Trangthai,
        Ngaytra
    FROM 
        Quanlyhopdong
    WHERE 
        (Trangthai = N'Đang hoạt động' AND DATEDIFF(DAY, GETDATE(), Ngaytra) BETWEEN 0 AND 7)
        OR (Trangthai = N'Đã trễ hạn')
    ORDER BY 
        Ngaytra ASC;
END;
GO



-- 1. Thêm nhân viên
CREATE PROCEDURE dbo.sp_AddEmployee
    @Manhanvien VARCHAR(10),
    @Hovaten NVARCHAR(100),
    @Ngaysinh DATE,
    @Chucvu NVARCHAR(50),
    @Sodienthoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    INSERT INTO Nhanvien (Manhanvien, Hovaten, Ngaysinh, Chucvu, Sodienthoai, Email)
    VALUES (@Manhanvien, @Hovaten, @Ngaysinh, @Chucvu, @Sodienthoai, @Email);
    PRINT 'Them nhan vien thanh cong';
END;
GO

-- 2. Thêm quản lý
CREATE PROCEDURE dbo.sp_AddManager
    @Maquanly VARCHAR(10),
    @Hovaten NVARCHAR(100),
    @Sodienthoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    INSERT INTO Quanly (Maquanly, Hovaten, Sodienthoai, Email)
    VALUES (@Maquanly, @Hovaten, @Sodienthoai, @Email);
    PRINT 'Them quan ly thanh cong';
END;
GO

-- 3. Cập nhật thông tin nhân viên
CREATE PROCEDURE dbo.sp_UpdateEmployee
    @Manhanvien VARCHAR(10),
    @Hovaten NVARCHAR(100),
    @Ngaysinh DATE,
    @Chucvu NVARCHAR(50),
    @Sodienthoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    UPDATE Nhanvien
    SET Hovaten = @Hovaten,
        Ngaysinh = @Ngaysinh,
        Chucvu = @Chucvu,
        Sodienthoai = @Sodienthoai,
        Email = @Email
    WHERE Manhanvien = @Manhanvien;
    PRINT 'Cap nhat thong tin nhan vien thanh cong';
END;
GO

-- 4. Cập nhật thông tin quản lý
CREATE PROCEDURE dbo.sp_UpdateManager
    @Maquanly VARCHAR(10),
    @Hovaten NVARCHAR(100),
    @Sodienthoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    UPDATE Quanly
    SET Hovaten = @Hovaten,
        Sodienthoai = @Sodienthoai,
        Email = @Email
    WHERE Maquanly = @Maquanly;
    PRINT 'Cap nhat thong tin quan ly thanh cong';
END;
GO

-- 5. Lấy danh sách nhân viên của một quản lý
CREATE PROCEDURE dbo.sp_GetEmployeesByManager
    @Maquanly VARCHAR(10)
AS
BEGIN
    SELECT NV.Manhanvien, NV.Hovaten, NV.Chucvu, NV.Sodienthoai, NV.Email
    FROM Quanly_Nhanvien QN
    INNER JOIN Nhanvien NV ON QN.Manhanvien = NV.Manhanvien
    WHERE QN.Maquanly = @Maquanly;
    PRINT 'Danh sach nhan vien duoc quan ly boi quan ly chi dinh';
END;
GO

-- 6. Lấy thông tin chi tiết của nhân viên
CREATE PROCEDURE dbo.sp_GetEmployeeDetails
    @Manhanvien VARCHAR(10)
AS
BEGIN
    SELECT Hovaten, Ngaysinh, Chucvu, Sodienthoai, Email
    FROM Nhanvien
    WHERE Manhanvien = @Manhanvien;
    PRINT 'Thong tin chi tiet cua nhan vien';
END;
GO

-- 7. Thêm khách hàng
CREATE PROCEDURE dbo.sp_AddCustomer
    @Makhachhang VARCHAR(10),
    @Tencongty NVARCHAR(100),
    @Diachi NVARCHAR(255),
    @Nguoidaidien NVARCHAR(50),
    @Mahopdong VARCHAR(10),
    @Sodienthoai VARCHAR(15),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Quanlykhachhang (Makhachhang, Tencongty, Diachi, Nguoidaidien, Mahopdong, Sodienthoai, Email)
    VALUES (@Makhachhang, @Tencongty, @Diachi, @Nguoidaidien, @Mahopdong, @Sodienthoai, @Email);
    PRINT 'Them khach hang thanh cong';
END;
GO

-- 8. Xóa khách hàng
CREATE PROCEDURE dbo.sp_DeleteCustomer
    @Makhachhang VARCHAR(10)
AS
BEGIN
    DELETE FROM Quanlykhachhang
    WHERE Makhachhang = @Makhachhang;
    PRINT 'Xoa khach hang thanh cong';
END;
GO



--thêm trigger dùng cho sao lưu dữ liệu
CREATE TRIGGER trg_Update_QuanLyHopDong
ON QuanLyHopDong
AFTER UPDATE
AS
BEGIN
    INSERT INTO QuanLyHopDong_History (Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Mahopdong, d.Makhachhang, d.Manhanvien, d.Quy, d.Trangthai, d.Ngaylap, d.Ngaytra, d.Vieccanlam,
        'UPDATE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyHopDong' AS Banggoc,
        CAST(d.Mahopdong AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Delete_QuanLyHopDong
ON QuanLyHopDong
AFTER DELETE
AS
BEGIN
    INSERT INTO QuanLyHopDong_History (Mahopdong, Makhachhang, Manhanvien, Quy, Trangthai, Ngaylap, Ngaytra, Vieccanlam, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Mahopdong, d.Makhachhang, d.Manhanvien, d.Quy, d.Trangthai, d.Ngaylap, d.Ngaytra, d.Vieccanlam,
        'DELETE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyHopDong' AS Banggoc,
        CAST(d.Mahopdong AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Update_QuanLyKhachHang
ON QuanLyKhachHang
AFTER UPDATE
AS
BEGIN
    INSERT INTO QuanLyKhachHang_History (Makhachhang, Tencongty, Diachi, Nguoidaidien, Mahopdong, Sodienthoai, Email, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Makhachhang, d.Tencongty, d.Diachi, d.Nguoidaidien, d.Mahopdong, d.Sodienthoai, d.Email,
        'UPDATE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyKhachHang' AS Banggoc,
        CAST(d.Makhachhang AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Delete_QuanLyKhachHang
ON QuanLyKhachHang
AFTER DELETE
AS
BEGIN
    INSERT INTO QuanLyKhachHang_History (Makhachhang, Tencongty, Diachi, Nguoidaidien, Mahopdong, Sodienthoai, Email, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Makhachhang, d.Tencongty, d.Diachi, d.Nguoidaidien, d.Mahopdong, d.Sodienthoai, d.Email,
        'DELETE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyKhachHang' AS Banggoc,
        CAST(d.Makhachhang AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Update_QuanLyMauQuanTrac
ON Quanlymauquantrac
AFTER UPDATE
AS
BEGIN
    INSERT INTO QuanLyMauQuanTrac_History (Mamau, Mahopdong, Tenmau, Noidung,Ngaylay, Ngaytra, Manhanvien, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Mamau, d.Mahopdong, d.Tenmau, d.Noidung,d.Ngaylay, d.Ngaytra, d.Manhanvien,
        'UPDATE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyMauQuanTrac' AS Banggoc,
        CAST(d.Mamau AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
GO


CREATE TRIGGER trg_Delete_QuanLyMauQuanTrac
ON Quanlymauquantrac
AFTER DELETE
AS
BEGIN
    INSERT INTO QuanLyMauQuanTrac_History (Mamau, Mahopdong, Tenmau, Noidung,Ngaylay, Ngaytra, Manhanvien, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Mamau, d.Mahopdong, d.Tenmau, d.Noidung,d.Ngaylay, d.Ngaytra, d.Manhanvien,
        'DELETE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'QuanLyMauQuanTrac' AS Banggoc,
        CAST(d.Mamau AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Update_PhieuKetQua
ON PhieuKetQua
AFTER UPDATE
AS
BEGIN
    INSERT INTO PhieuKetQua_History (Maphieuketqua, Mamauthu, Mahopdong,Ngaylaymau, Ngaytraketqua, Trangthaiketquaphantich,Trangthaixuly, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Maphieuketqua, d.Mamauthu, d.Mahopdong,d.Ngaylaymau, d.Ngaytraketqua,d.Trangthaixuly, d.Trangthaiketquaphantich,
        'UPDATE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'PhieuKetQua' AS Banggoc,
        CAST(d.Maphieuketqua AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go

CREATE TRIGGER trg_Delete_PhieuKetQua
ON PhieuKetQua
AFTER DELETE
AS
BEGIN
    INSERT INTO PhieuKetQua_History (Maphieuketqua, Mamauthu, Mahopdong,Ngaylaymau, Ngaytraketqua, Trangthaiketquaphantich,Trangthaixuly, Hanhdong, Ngaychinhsua, Banggoc, Khoachinh)
    SELECT 
        d.Maphieuketqua, d.Mamauthu, d.Mahopdong,d.Ngaylaymau, d.Ngaytraketqua,d.Trangthaixuly, d.Trangthaiketquaphantich,
        'DELETE' AS Hanhdong,
        GETDATE() AS Ngaychinhsua,
        'PhieuKetQua' AS Banggoc,
        CAST(d.Maphieuketqua AS NVARCHAR(100)) AS Khoachinh
    FROM deleted d;
END;
go


use QuanLyMauKiemDinhMoiTruong;
select * from Quanlyhopdong;

use	QuanLyMauKiemDinhMoiTruong;
select * from Nhanvien;

use QuanLyMauKiemDinhMoiTruong;
select * from Quanlymauquantrac;

use QuanLyMauKiemDinhMoiTruong;
select * from Phieuketqua;

use QuanLyMauKiemDinhMoiTruong;
select * from Chitietthongso;

use QuanLyMauKiemDinhMoiTruong;
select * from Quanlykhachhang;

use QuanLyMauKiemDinhMoiTruong;
select * from Quanlydangnhap;

EXEC sp_GetContractsDueSoon;
DELETE FROM Chitietthongso;
