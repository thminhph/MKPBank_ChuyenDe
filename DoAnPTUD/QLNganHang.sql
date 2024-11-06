CREATE DATABASE QLNganHang

use QLNganHang;

CREATE TABLE KhachHang(
	IdKhachHang int primary key,
	TenKhachHang nvarchar(255) not null,
	Avarta image,
	NgaySinh datetime not null,
	DiaChi nvarchar(255) not null,
	SoDienThoai nvarchar(20) not null,
	QuocGia nvarchar(50),
	QuocTich nvarchar(50),
	LoaiGiayTo nvarchar(50) not null,
	SoGiayTo varchar(50) not null,
	NgayCap datetime not null,
	NgayHetHan datetime,
	NoiCap nvarchar(255) not null,
	Email varchar(255),
	NganhChinh int not null,
	IdNganh int not null,
	NhanVienLV varchar(20) not null,
	IdLoaiKH int
);

CREATE TABLE LoaiKhachHang(
	IdLoaiKH int identity(1,1) primary key,
	TenLoai nvarchar(255)
);

--CREATE TABLE ChiTietKHCN(
--	IdKhachHangCN int,
--	IdLoaiKH int,
--	GioiTinh nvarchar(10),
--	XungHo nvarchar(20),
--	TTHonNhan nvarchar(50),
--	QuanHe nvarchar(255),
--	SoVanPhong varchar(50),
--	SoNguoiPT int,
--	SoHuuNha nvarchar(50),
--	LHCuChu nvarchar(50),
--	TinhTrangViecLam nvarchar(50),
--	TenCty nvarchar(255),
--	ThuNhapHangThang float,
--	DiaChiCty nvarchar(255),
--	primary key(IdKhachHangCN, IdLoaiKH)
--);

--CREATE TABLE ChiTietKHDN(
--	IdKhachHangDN int,
--	IdLoaiKH int,
--	NgayTao datetime,
--	QuanHe nvarchar(255),
--	SoVanPhong varchar(50),
--	TongVon float,
--	TongTaiSan float,
--	TongDoanhThu float,
--	SoLuongNhanVien int,
--	NguoiLH nvarchar(50),
--	ChucVu nvarchar(50),
--	primary key(IdKhachHangDN, IdLoaiKH)
--);

CREATE TABLE TaiKhoan(
	IdTaiKhoan bigint identity(070000123456,13) primary key,
	IdKhachHang int,
	IdLoai int not null,
	TenTaiKhoan nvarchar(255),
	TienTe nvarchar(50) not null,
	TieuDeTK nvarchar(255),
	TieuDeNgan nvarchar(50),
	NhanVienLV varchar(20) not null,
	PhiMa nvarchar(255),
	Matkhau char (255) not null
);

CREATE TABLE SoDuTinDung(
	IdTaiKhoan bigint primary key,
	SoDuTK float
);

CREATE TABLE LoaiTaiKhoan(
	IdLoai int identity(1,1) primary key,
	TenLoai nvarchar(100)
);

CREATE TABLE ThamGiaTK(
	IdTaiKhoan bigint not null,
	IdKhachHang int not null,
	QuanHe nvarchar(255),
	GhiChu ntext,
	primary key(IdTaiKhoan,IdKhachHang)
);

CREATE TABLE NhanVien(
	IdNhanVien varchar(20) primary key,
	HoTen nvarchar(255) not null,
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(255) not null,
	SoDienThoai char(11) not null,
	Email varchar(255),
	CMND varchar(50) not null,
	ChucVu nvarchar(50),
	PhongBan nvarchar(50),
	NgayLV datetime,
	TrangThai nvarchar(50)
);

CREATE TABLE NganhChinh(
	IdNganhChinh int identity(1,1) primary key,
	TenNganh nvarchar(255) not null
);

CREATE TABLE Nganh(
	IdNganh int identity(1,1) primary key,
	TenNganh nvarchar(255) not null,
	IdNganhChinh int
);

CREATE TABLE ChiTietGD(
MaGD  bigint identity(070000654321,10) primary key,
SoTKNguoiChuyen bigint  not null,
SoTKNguoiNhan bigint   not null,
SoTien float not null,
NgayGio datetime not null,
DienGia nvarchar (300) not null
);

--Liên kết khóa phụ vào bảng Khách hàng
ALTER TABLE KhachHang
ADD CONSTRAINT fk_khnganh FOREIGN KEY(NganhChinh) REFERENCES NganhChinh(IdNganhChinh)

ALTER TABLE KhachHang
ADD CONSTRAINT fk_khnganhphu FOREIGN KEY(IdNganh) REFERENCES Nganh(IdNganh)

ALTER TABLE KhachHang
ADD CONSTRAINT fk_khloaiw FOREIGN KEY(IdLoaiKH) REFERENCES LoaiKhachHang(IdLoaiKH)

--Liên kết khóa phụ vào bảng ChiTietKHCN
--ALTER TABLE ChiTietKHCN
--ADD CONSTRAINT fk_ctkhcn FOREIGN KEY(IdKhachHangCN) REFERENCES KhachHang(IdKhachHang)

--ALTER TABLE ChiTietKHCN
--ADD CONSTRAINT fk_ctkhloai FOREIGN KEY(IdLoaiKH) REFERENCES LoaiKhachHang(IdLoaiKH)

--Liên kết khóa phụ vào bảng ChiTietKHDN
--ALTER TABLE ChiTietKHDN
--ADD CONSTRAINT fk_ctkhdn FOREIGN KEY(IdKhachHangDN) REFERENCES KhachHang(IdKhachHang)

--ALTER TABLE ChiTietKHDN
--ADD CONSTRAINT fk_ctkhdnloai FOREIGN KEY(IdLoaiKH) REFERENCES LoaiKhachHang(IdLoaiKH)

--Liên kết khóa phụ vào bảng Tài khoản
ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_tkkh FOREIGN KEY(IdKhachHang) REFERENCES KhachHang(IdKhachHang)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_nvlvtk FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_loaitk FOREIGN KEY (IdLoai) REFERENCES LoaiTaiKhoan(IdLoai)

ALTER TABLE ChiTietGD -- phú
ADD CONSTRAINT fk_ctgd_nc  FOREIGN KEY (SoTKNguoiChuyen) REFERENCES TaiKhoan(IdTaiKhoan)

--Liên kết khóa phụ vào bảng ThamGiaTK
ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtkkh FOREIGN KEY (IdKhachHang) REFERENCES KhachHang(IdKhachHang)

ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtk FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(IdTaiKhoan)

--Liên kết khóa phụ vào bảng Số dư tín dụng
ALTER TABLE SoDuTinDung --phú
ADD CONSTRAINT fk_sdtd FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(IdTaiKhoan)

--Thêm khóa ngoại bảng ngành
ALTER TABLE Nganh --phú
ADD CONSTRAINT fk_nganh FOREIGN KEY (IdNganhChinh) REFERENCES NganhChinh(IdNganhChinh)

INSERT INTO NganhChinh VALUES
(N''),
(N'Nông nghiệp và Lâm nghiệp'),
(N'Công nghiệp và Sản xuất'),
(N'Xây dựng'),
(N'Công nghệ thông tin và Viễn thông'),
(N'Tài chính và Ngân hàng'),
(N'Dịch vụ Y tế và Chăm sóc sức khỏe'),
(N'Giáo dục và Đào tạo'),
(N'Du lịch và Khách sạn'),
(N'Bán lẻ và Thương mại'),
(N'Năng lượng'),
(N'Vận tải và Logistics'),
(N'Bất động sản'),
(N'Giải trí và Truyền thông'),
(N'Dịch vụ công và Chính phủ');

INSERT INTO Nganh VALUES
(N'',1),
(N'Trồng trọt', 2),
(N'Chăn nuôi', 2),
(N'Lâm nghiệp', 2),
(N'Sản xuất ô tô', 3),
(N'Sản xuất máy móc', 3),
(N'Công nghiệp thực phẩm', 3),
(N'Xây dựng dân dụng', 4),
(N'Xây dựng công nghiệp', 4),
(N'Phần mềm và dịch vụ CNTT', 5),
(N'Phát triển ứng dụng di động', 5),
(N'Ngân hàng thương mại', 6),
(N'Bảo hiểm', 6),
(N'Bệnh viện và phòng khám', 7),
(N'Dịch vụ chăm sóc tại nhà', 7),
(N'Trường học và đại học', 8),
(N'Dịch vụ lưu trú', 9),
(N'Nhà hàng và ẩm thực', 9),
(N'Siêu thị và cửa hàng tiện lợi', 10),
(N'Thương mại điện tử', 10),
(N'Điện lực', 11),
(N'Năng lượng tái tạo', 11),
(N'Vận tải đường bộ', 12),
(N'Vận tải hàng không', 12),
(N'Phát triển bất động sản', 13),
(N'Môi giới bất động sản', 13),
(N'Phim ảnh và truyền hình', 14),
(N'Âm nhạc', 14),
(N'Quản lý hành chính công', 15),
(N'An ninh và quốc phòng', 15);

INSERT INTO LoaiTaiKhoan VALUES
(N'1000 - Tiền gửi thanh toán'),
(N'2000 - Tiết kiệm không kỳ hạn');

INSERT INTO LoaiKhachHang VALUES
(N'Khách hàng cá nhân'),
(N'Khách hàng doanh nghiệp');

INSERT INTO NhanVien (IdNhanVien, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, CMND, ChucVu, PhongBan, NgayLV, TrangThai) VALUES
('NV001', N'Nguyễn Văn An', '1990-01-01', N'Nam', N'123 ABC Street', '01234567891', 'an.nguyen@gmail.com', '123456789', N'Nhân viên', N'Phòng Kế toán', '2015-06-15', N'Đang làm'),
('NV002', N'Trần Thị Bích', '1985-03-10', N'Nữ', N'456 DEF Avenue', '01234567892', 'bich.tran@yahoo.com', '223456789', N'Nhân viên', N'Phòng Hành chính', '2014-03-20', N'Đang làm'),
('NV003', N'Hoàng Minh Quân', '1992-11-25', N'Nam', N'789 GHI Road', '01234567893', 'quan.hoang@outlook.com', '323456789', N'Quản lý', N'Phòng Kinh doanh', '2013-09-01', N'Đang làm'),
('NV004', N'Lê Thanh Hương', '1988-05-15', N'Nữ', N'123 JKL Street', '01234567894', 'huong.le@gmail.com', '423456789', N'Trưởng phòng', N'Phòng Nhân sự', '2011-01-10', N'Đang làm'),
('NV005', N'Phạm Văn Bình', '1993-07-19', N'Nam', N'456 MNO Avenue', '01234567895', 'binh.pham@zmail.com', '523456789', N'Nhân viên', N'Phòng Kỹ thuật', '2016-02-18', N'Đang làm'),
('NV006', N'Ngô Lan Phương', '1991-02-28', N'Nữ', N'789 PQR Road', '01234567896', 'phuong.ngo@gmail.com', '623456789', N'Nhân viên', N'Phòng Kế toán', '2015-04-22', N'Nghỉ việc'),
('NV007', N'Đinh Công Hoàng', '1989-09-30', N'Nam', N'123 STU Street', '01234567897', 'hoang.dinh@gmail.com', '723456789', N'Quản lý', N'Phòng Kinh doanh', '2012-11-05', N'Đang làm'),
('NV008', N'Vũ Thị Hằng', '1990-12-12', N'Nữ', N'456 VWX Avenue', '01234567898', 'hang.vu@ymail.com', '823456789', N'Nhân viên', N'Phòng Hành chính', '2014-08-30', N'Đang làm'),
('NV009', N'Bùi Văn Tùng', '1987-06-07', N'Nam', N'789 YZ Road', '01234567899', 'tung.bui@hmail.com', '923456789', N'Trưởng phòng', N'Phòng Kỹ thuật', '2010-10-12', N'Đang làm'),
('NV010', N'Phạm Thị Mai', '1995-04-04', N'Nữ', N'123 ABC Road', '01234567890', 'mai.pham@pmail.com', '023456789', N'Nhân viên', N'Phòng Nhân sự', '2017-06-01', N'Đang làm');
select * from TaiKhoan
SELECT khachHang.*, chiTiet.*
FROM KhachHang AS khachHang
JOIN ChiTietKHCN AS chiTiet
ON khachHang.IdKhachHang = chiTiet.IdKhachHangCN
WHERE chiTiet.IdKhachHangCN = 100756;
select * from SoDuTinDung
SELECT 
    kh.IdKhachHang AS [Mã khách hàng],
    kh.TenKhachHang AS [Tên khách hàng],
    CASE 
        WHEN LEN(kh.DiaChi) - LEN(REPLACE(kh.DiaChi, ',', '')) >= 2 
        THEN LTRIM(RIGHT(kh.DiaChi, CHARINDEX(',', REVERSE(kh.DiaChi), CHARINDEX(',', REVERSE(kh.DiaChi)) + 1) - 1))
        ELSE ''
    END AS [Thành phố/Tỉnh],
    kh.QuocTich AS [Quốc tịch],
    nc.TenNganh AS [Ngành công nghiệp chính],
    kh.SoGiayTo AS [Số giấy tờ]
FROM 
    KhachHang kh
INNER JOIN 
    NganhChinh nc ON kh.NganhChinh = nc.IdNganhChinh
WHERE 
    kh.IdLoaiKH = 1;