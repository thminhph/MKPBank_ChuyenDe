CREATE DATABASE QLNganHang

use QLNganHang;

CREATE TABLE LoaiKhachHang(
	IdLoaiKH int identity(1,1) primary key,
	TenLoai nvarchar(255)
);
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
	NhanVienLV varchar(20),
	IdLoaiKH int 
);

CREATE TABLE TaiKhoan(
	IdTaiKhoan bigint primary key,
	IdKhachHang int,
	IdLoai int not null,
	TienTe nvarchar(50),
	TieuDeTK nvarchar(255),
	TieuDeNgan nvarchar(50),
	NhanVienLV varchar(20),
	PhiMa nvarchar(255),
	Matkhau char (255) not null,
	IdTaiKhoanLV bigint
);

CREATE TABLE SoDuTinDung(
	IdTaiKhoan bigint  primary key,
	SoDuTK dec,
	NgayGiaTri date,
	NgayDaoHan date,
	LaiSuat float,
);

CREATE TABLE LoaiTaiKhoan(
	IdLoai int identity(1,1) primary key,
	TenLoai nvarchar(100)
);

CREATE TABLE ThamGiaTK(
	IdTaiKhoan bigint,
	IdKhachHang int  not null,
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
	MaGD bigint identity(070000654321,10) primary key,
	SoTKNguoiChuyen bigint  not null,
	SoTKNguoiNhan bigint   not null,
	SoTien dec not null,
	NgayGio datetime not null,
	DienGia nvarchar(255)
);

CREATE TABLE LoaiGiaoDich(
	IdLoaiGD int identity(1,1) primary key,
	TenLoaiGD nvarchar(255) unique
)

CREATE TABLE GiaoDich(
	IdGiaoDich varchar(255) primary key,
	IdTaiKhoan bigint,
	IdLoaiGD int,
	SoGiaoDich dec,
	SoDu dec,
	NoiDung nvarchar(255),
	NgayGiaoDich datetime,
	foreign key(IdTaiKhoan) references TaiKhoan(IdTaiKhoan),
	foreign key(IdLoaiGD) references LoaiGiaoDich(IdLoaiGD)
);


--Liên kết khóa phụ vào bảng Khách hàng
ALTER TABLE KhachHang
ADD CONSTRAINT fk_khnganh FOREIGN KEY(NganhChinh) REFERENCES NganhChinh(IdNganhChinh)

ALTER TABLE KhachHang
ADD CONSTRAINT fk_khnganhphu FOREIGN KEY(IdNganh) REFERENCES Nganh(IdNganh)

ALTER TABLE KhachHang
ADD CONSTRAINT fk_khloaiw FOREIGN KEY(IdLoaiKH) REFERENCES LoaiKhachHang(IdLoaiKH)

--Liên kết khóa phụ vào bảng Tài khoản
ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_tkkh FOREIGN KEY(IdKhachHang) REFERENCES KhachHang(IdKhachHang)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_nvlvtk FOREIGN KEY (NhanVienLV) REFERENCES NhanVien(IdNhanVien)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_loaitk FOREIGN KEY (IdLoai) REFERENCES LoaiTaiKhoan(IdLoai)

ALTER TABLE TaiKhoan
ADD CONSTRAINT fk_tklv FOREIGN KEY (IdTaiKhoanLV) REFERENCES TaiKhoan(IdTaiKhoan)

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

INSERT INTO LoaiTaiKhoan(TenLoai) VALUES
(N''),
(N'Tiền gửi thanh toán'),
(N'Tiết kiệm không kỳ hạn');
INSERT INTO LoaiTaiKhoan(TenLoai) VALUES
(N'Tiết kiệm có kỳ hạn');

INSERT INTO LoaiKhachHang VALUES
(''),
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


INSERT INTO KhachHang (IdKhachHang ,TenKhachHang,Avarta, NgaySinh, DiaChi, SoDienThoai, QuocGia, QuocTich, LoaiGiayTo, SoGiayTo, NgayCap, NgayHetHan, NoiCap, Email, NganhChinh, IdNganh, NhanVienLV,IdLoaiKH) VALUES
(112345,N'Nguyễn Văn A',null , '1985-01-15', N'Số 123, Đường A, Quận 1', '0123456789', N'Việt Nam', N'Việt', N'CMND', '123456789', '2010-05-20', '2030-05-20', N'Công an TP.HCM', 'nguyenvana@example.com', 1, 1, 'NV001',2),
(112344,N'Trần Thị B', null ,'1990-02-20', N'Số 456, Đường B, Quận 2', '0123456780', N'Việt Nam', N'Việt', N'CMND', '987654321', '2015-08-15', '2035-08-15', N'Công an TP.HCM', 'tranthib@example.com', 1, 2, 'NV002',2),
(123456,N'Phạm Văn C',null , '1988-03-10', N'Số 789, Đường C, Quận 3', '0123456781', N'Việt Nam', N'Việt', N'CMND', '192837465', '2012-03-12', '2032-03-12', N'Công an TP.HCM', 'phamvanc@example.com', 2, 1, 'NV003',2),
(112354,N'Lê Thị D', null ,'1992-04-25', N'Số 321, Đường D, Quận 4', '0123456782', N'Việt Nam', N'Việt', N'CMND', '564738291', '2018-11-11', '2038-11-11', N'Công an TP.HCM', 'lethid@example.com', 2, 2, 'NV004',2),
(112352,N'Nguyễn Văn E',null , '1980-05-30', N'Số 654, Đường E, Quận 5', '0123456783', N'Việt Nam', N'Việt', N'CMND', '182736454', '2011-06-25', '2031-06-25', N'Công an TP.HCM', 'nguyenvane@example.com', 1, 1, 'NV005',2),
(112351,N'Trần Văn F', null,'1975-06-15', N'Số 987, Đường F, Quận 6', '0123456784', N'Việt Nam', N'Việt', N'CMND', '987123456', '2009-04-30', '2029-04-30', N'Công an TP.HCM', 'tranvanf@example.com', 1, 2, 'NV006',2),
(112357,N'Phạm Thị G',null , '1995-07-20', N'Số 258, Đường G, Quận 7', '0123456785', N'Việt Nam', N'Việt', N'CMND', '456789123', '2016-07-01', '2036-07-01', N'Công an TP.HCM', 'phamthig@example.com', 2, 1, 'NV007',2),
(112358,N'Lê Văn H', null,'1983-08-05', N'Số 369, Đường H, Quận 8', '0123456786', N'Việt Nam', N'Việt', N'CMND', '321654987', '2013-09-20', '2033-09-20', N'Công an TP.HCM', 'levanh@example.com', 2, 2, 'NV008',2),
(112359,N'Nguyễn Thị I',null , '1989-09-10', N'Số 159, Đường I, Quận 9', '0123456787', N'Việt Nam', N'Việt', N'CMND', '753951486', '2014-10-10', '2034-10-10', N'Công an TP.HCM', 'nguyenthi@example.com', 1, 1, 'NV009',2),
(112355,N'Trần Văn J', null,'1993-10-30', N'Số 753, Đường J, Quận 10', '0123456788', N'Việt Nam', N'Việt', N'CMND', '654321789', '2019-02-14', '2039-02-14', N'Công an TP.HCM', 'tranvanj@example.com', 1, 2, 'NV010',2);

--INSERT INTO TaiKhoan (IdKhachHang, IdLoai, TienTe, TieuDeTK, TieuDeNgan, NhanVienLV, PhiMa,Matkhau)
--VALUES 
--(112345, 2, 'VND', 'Primary Account', 'Main', 'NV001', 'PM001','123'),
--(112344, 2, 'VND', 'Backup Fund', 'Emergency', 'NV002', 'PM002','123'),
--(123456, 2, 'USD', 'Investment Account', 'Stocks', 'NV003', 'PM003','123'),
--(112354, 2, 'VND', 'Everyday Expenses', 'Daily', 'NV004', 'PM004','123'),
--(112352, 2, 'VND', 'Travel Expenses', 'Travel', 'NV005', 'PM005','123'),
--(112351, 2, 'USD', 'Property Investments', 'Real Estate', 'NV006', 'PM006','123'),
--(112357, 2, 'VND', 'Business Expenses', 'Business', 'NV007', 'PM007','123'),
--(112358, 2, 'VND', 'Education Expenses', 'Education', 'NV008', 'PM008','123'),
--(112359, 2, 'USD', 'Mutual Fund Investments', 'Mutual Funds', 'NV009', 'PM009','123'),
--(112355, 2, 'VND', 'Miscellaneous Expenses', 'Misc', 'NV010', 'PM010','123');

--INSERT INTO SoDuTinDung ( IdTaiKhoan,SoDuTK)
--VALUES
--(70000123456,500000),
--(70000123469,100000000),
--(70000123482,200000),
--(70000123495,82000000),
--(70000123508,92000000),
--(70000123521,72000000),
--(70000123534,62000000),
--(70000123547,52000000),
--(70000123560,200000000),
--(70000123573,320000000)







select * from SoDuTinDung


select * from SoDuTinDung

INSERT INTO TaiKhoan ( IdLoai, Matkhau, TienTe, IdKhachHang)
VALUES ( 1, 'password123', 'VND', 1);
select * from SoDuTinDung

select * from KhachHang, TaiKhoan
where KhachHang.SoDienThoai like '09321098765' and TaiKhoan.IdKhachHang like KhachHang.IdKhachHang

SELECT 
    s.Avarta,
    s.TenKhachHang
FROM 
    KhachHang s
JOIN 
    TaiKhoan tk ON s.IdKhachHang = tk.IdKhachHang
WHERE 
    tk.IdTaiKhoan = 70000123456;

-- Sử dụng tham số @stk cho giá trị biến

SELECT SoDuTK
FROM SoDuTinDung s
INNER JOIN TaiKhoan k ON s.IdTaiKhoan = k.IdTaiKhoan
WHERE k.IdTaiKhoan = s.IdTaiKhoan;

select * from TaiKhoan

SELECT *
FROM ChiTietGD s
INNER JOIN TaiKhoan b ON s.SoTKNguoiChuyen = b.IdTaiKhoan
WHERE s.NgayGio = '2024-11-08 13:33:58.093'

SELECT s.*
FROM ChiTietGD s
INNER JOIN TaiKhoan tk ON s.SoTKNguoiChuyen = tk.IdTaiKhoan
WHERE s.SoTKNguoiNhan = 70000123521;