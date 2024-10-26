CREATE DATABASE QLNganHang

use QLNganHang;

CREATE TABLE KhachHangCaNhan(
	IdKhachHangCN int primary key,
	TenKhachHang nvarchar(100) not null,
	NgaySinh datetime not null,
	DiaChi nvarchar(255) not null,
	SoDienThoai char(11) not null,
	QuocGia nvarchar(50),
	QuocTich nvarchar(50),
	LoaiGiayTo nvarchar(50) not null,
	SoGiayTo varchar(50) not null,
	NgayCap datetime not null,
	NgayHetHan datetime,
	NoiCap nvarchar(255) not null,
	Email varchar(255),
	NganhChinh int not null,
	Nganh int not null,
	NhanVienLV varchar(20) not null
);
--insert into KhachHangCaNhan
--values('123458','k',GETDATE(),'a','113456',null,null,'khk','1212',GETDATE(),null,'as',null,1,1,'NV002')

CREATE TABLE ChiTietKHCN(
	IdKhachHangCN int primary key,
	GioiTinh nvarchar(10),
	XungHo nvarchar(20),
	TTHonNhan nvarchar(50),
	QuanHe nvarchar(255),
	SoVanPhong varchar(50),
	SoNguoiPT int,
	SoHuuNha nvarchar(50),
	LHCuChu nvarchar(50),
	TinhTrangViecLam nvarchar(50),
	TenCty nvarchar(255),
	ThuNhapHangThang float,
	DiaChiCty nvarchar(255)
);
--insert into ChiTietKHCN
--values('123457',null,null,null,null,null,null,null,null,null,null,null,null)
CREATE TABLE KhachHangDoanhNghiep(
	IdKhachHangDN int primary key,
	TenVietTatDN nvarchar(255) not null,
	TenDayDuDN nvarchar(255) not null,
	NgayThanhLap datetime not null,
	DiaChi nvarchar(255) not null,
	QuocGia nvarchar(50),
	QuocTich nvarchar(50),
	NoiCuTru nvarchar(255),
	LoaiGiayTo nvarchar(50) not null,
	SoGiayTo varchar(50) not null,
	NgayCap datetime not null,
	NgayHetHan datetime,
	NoiCap nvarchar(255) not null,
	NguoiLH nvarchar(50),
	ChucVu nvarchar(50),
	Email varchar(255),
	SoDienThoai char(11),
	NganhChinh int not null,
	Nganh int not null,
	NhanVienLV varchar(20) not null 
);

CREATE TABLE ChiTietKHDN(
	IdKhachHangDN int primary key,
	NgayTao datetime,
	QuanHe nvarchar(255),
	SoVanPhong varchar(50),
	TongVon float,
	TongTaiSan float,
	TongDoanhThu float,
	SoLuongNhanVien int
);

CREATE TABLE TaiKhoan(
	IdTaiKhoan bigint identity(070000123456,13) primary key,
	MaKhachHang int not null,
	LoaiTaiKhoan nvarchar(255) not null,
	TenTaiKhoan nvarchar(255),
	TienTe nvarchar(50) not null,
	TieuDeTK nvarchar(255),
	TieuDeNgan nvarchar(50),
	NhanVienLV varchar(20) not null,
	PhiMa nvarchar(255),
	LoaiTK nvarchar(255)
);

CREATE TABLE SoDuTinDung(
	IdTaiKhoan bigint primary key,
	SoDuTK float
);

CREATE TABLE ThamGiaTK(
	IdTaiKhoan bigint not null,
	MaKhachHang int not null,
	QuanHe nvarchar(255),
	GhiChu ntext,
	primary key(IdTaiKhoan,MaKhachHang)
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

CREATE TABLE TaiKhoanTKDK(
	IdTaiKhoan bigint identity(070000654321,13) primary key,
	MaKhachHang int not null,
	LoaiTaiKhoan nvarchar(255) not null,
	TienTe nvarchar(50) not null,
	TieuDeTK nvarchar(255) not null,
	TieuDeNgan nvarchar(50),
	NhanVienLV varchar(20) not null,
	TenLoai nvarchar(255)
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
SoTKNguoiChuyen bigint identity(070000654321,13) not null,
SoTKNguoiNhan bigint identity(070000654321,13)  not null,
SoTien float not null,
NgayGio datetime not null,
DienGia nvarchar (300) not null

)
--Thêm khóa ngoại bảng khách hàng cá nhân
ALTER TABLE ChiTietKHCN
ADD CONSTRAINT fk_khcn FOREIGN KEY (IdKhachHangCN) REFERENCES KhachHangCaNhan(IdKhachHangCN)

ALTER TABLE ChiTietGD
ADD CONSTRAINT fk_ctgd_nc  FOREIGN KEY (SoTKNguoiChuyen) REFERENCES TaiKhoan(IdTaiKhoan)

ALTER TABLE ChiTietGD
ADD CONSTRAINT fk_ctgd_nn  FOREIGN KEY (SoTKNguoiNhan) REFERENCES TaiKhoan(IdTaiKhoan)

ALTER TABLE KhachHangCaNhan
ADD CONSTRAINT fk_nvlvcn FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

ALTER TABLE KhachHangCaNhan
ADD CONSTRAINT fk_khnganh FOREIGN KEY(NganhChinh) REFERENCES NganhChinh(IdNganhChinh)

ALTER TABLE KhachHangCaNhan
ADD CONSTRAINT fk_khnganhphu FOREIGN KEY(Nganh) REFERENCES Nganh(IdNganh)


--Thêm khóa ngoại bảng khách hàng doanh nghiệp
ALTER TABLE ChiTietKHDN
ADD CONSTRAINT fk_khdn FOREIGN KEY (IdKhachHangDN) REFERENCES KhachHangDoanhNghiep(IdKhachHangDN)

ALTER TABLE KhachHangDoanhNghiep
ADD CONSTRAINT fk_nvlvdn FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

ALTER TABLE KhachHangDoanhNghiep
ADD CONSTRAINT fk_khdnnganh FOREIGN KEY(NganhChinh) REFERENCES NganhChinh(IdNganhChinh)

ALTER TABLE KhachHangDoanhNghiep
ADD CONSTRAINT fk_khdnnganhphu FOREIGN KEY(Nganh) REFERENCES Nganh(IdNganh)

--Thêm khóa ngoại bảng tài khoản
ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_tkkhcn FOREIGN KEY (MaKhachHang) REFERENCES KhachHangCaNhan(IdKhachHangCN)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_tkkhdn FOREIGN KEY (MaKhachHang) REFERENCES KhachHangDoanhNghiep(IdKhachHangDN)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_nvlvtk FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

--Thêm khóa ngoại bảng tham gia tài khoản
ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtkchinh FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(IdTaiKhoan)

ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtkkh FOREIGN KEY (MaKhachHang) REFERENCES KhachHangCaNhan(IdKhachHangCN)

ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtkkhdn FOREIGN KEY (MaKhachHang) REFERENCES KhachHangDoanhNghiep(IdKhachHangDN)

ALTER TABLE ThamGiaTK
ADD CONSTRAINT fk_tgtktkdk FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoanTKDK(IdTaiKhoan)


--Thêm khóa ngoại bảng số dư tín dụng
ALTER TABLE SoDuTinDung
ADD CONSTRAINT fk_sdtd FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(IdTaiKhoan)

--Thêm khóa ngoại bảng tài khoản tiết kiệm
ALTER TABLE TaiKhoanTKDK
ADD CONSTRAINT fk_tkdkcn FOREIGN KEY (MaKhachHang) REFERENCES KhachHangCaNhan(IdKhachHangCN)

ALTER TABLE TaiKhoanTKDK
ADD CONSTRAINT fk_tkdkdn FOREIGN KEY (MaKhachHang) REFERENCES KhachHangDoanhNghiep(IdKhachHangDN)

ALTER TABLE TaiKhoanTKDK
ADD CONSTRAINT fk_tkdknv FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

--Thêm khóa ngoại bảng ngành
ALTER TABLE NGANH
ADD CONSTRAINT fk_nganh FOREIGN KEY (IdNganhChinh) REFERENCES NGANHCHINH(IdNganhChinh)

INSERT INTO NganhChinh VALUES
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
(N'Trồng trọt', 1),
(N'Chăn nuôi', 1),
(N'Lâm nghiệp', 1),
(N'Sản xuất ô tô', 2),
(N'Sản xuất máy móc', 2),
(N'Công nghiệp thực phẩm', 2),
(N'Xây dựng dân dụng', 3),
(N'Xây dựng công nghiệp', 3),
(N'Phần mềm và dịch vụ CNTT', 4),
(N'Phát triển ứng dụng di động', 4),
(N'Ngân hàng thương mại', 5),
(N'Bảo hiểm', 5),
(N'Bệnh viện và phòng khám', 6),
(N'Dịch vụ chăm sóc tại nhà', 6),
(N'Trường học và đại học', 7),
(N'Dịch vụ lưu trú', 8),
(N'Nhà hàng và ẩm thực', 8),
(N'Siêu thị và cửa hàng tiện lợi', 9),
(N'Thương mại điện tử', 9),
(N'Điện lực', 10),
(N'Năng lượng tái tạo', 10),
(N'Vận tải đường bộ', 11),
(N'Vận tải hàng không', 11),
(N'Phát triển bất động sản', 12),
(N'Môi giới bất động sản', 12),
(N'Phim ảnh và truyền hình', 13),
(N'Âm nhạc', 13),
(N'Quản lý hành chính công', 14),
(N'An ninh và quốc phòng', 14);

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
select * from ChiTietKHCN