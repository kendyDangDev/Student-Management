use UTEHY

CREATE DATABASE UTEHY


CREATE TABLE KHOA(
    STT INT IDENTITY(1,1),
    MAKHOA VARCHAR(10) PRIMARY KEY,
    TENKHOA NVARCHAR(50) NOT NULL, 
    SDT VARCHAR(10) NOT NULL,
    Email NVARCHAR(50) NOT NULL
)
GO

Create table NGANH(
    STT INT IDENTITY(1,1),
    MANGANH VARCHAR(10) PRIMARY KEY,
    TENNGANH NVARCHAR(50) NOT NULL,
    MAKHOA VARCHAR(10),
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA) ON DELETE CASCADE ON UPDATE CASCADE
)


CREATE TABLE CHUYENNGANH(
    STT INT IDENTITY(1,1),
    MACHUYENNGANHNGANH VARCHAR(10) PRIMARY KEY,
    TENCHUYENNGANH NVARCHAR(50) DEFAULT 'Công Nghệ Web',
    THOIGIANDAOTAO INT,
    MANGANH VARCHAR(10) DEFAULT 'KCNTT',
    FOREIGN KEY(MANGANH) REFERENCES NGANH(MANGANH) ON DELETE CASCADE ON UPDATE CASCADE
)
GO


CREATE TABLE GIANGVIEN(
    STT INT IDENTITY(1,1),
    MAGIANGVIEN VARCHAR(10) PRIMARY KEY,
    TENGIANGVIEN NVARCHAR(50),
    GIOITINH NVARCHAR(10),
    NGAYSINH DATETIME,
    TRINHDO NVARCHAR(50),
    DIACHI NVARCHAR(50),
    CCCD VARCHAR(20) UNIQUE,
    SODIENTHOAI VARCHAR(20),
    MAKHOA VARCHAR(10),
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA) ON DELETE CASCADE ON UPDATE CASCADE
)
GO


CREATE TABLE LOPHOC(
    STT INT IDENTITY(1,1),
    MALOP VARCHAR(10) PRIMARY KEY,
    TENLOP NVARCHAR(50) NOT NULL DEFAULT '12522W.2',
    HEDAOTAO NVARCHAR(50),
    SISO INT,
    MACHUYENNGANHNGANH VARCHAR(10) DEFAULT 'CNWeb',
    MAGIANGVIEN VARCHAR(10),
    FOREIGN KEY(MAGIANGVIEN) REFERENCES GIANGVIEN(MAGIANGVIEN),
    FOREIGN KEY(MACHUYENNGANHNGANH) REFERENCES CHUYENNGANH(MACHUYENNGANHNGANH) ON DELETE CASCADE ON UPDATE CASCADE
)
GO


CREATE TABLE SinhVien(
    STT INT IDENTITY(1,1),
    MASV VARCHAR(10) PRIMARY KEY,
    HOTEN NVARCHAR(50) NOT NULL,
    GIOITINH NVARCHAR(10)  ,
    DANTOC NVARCHAR(10) DEFAULT 'Kinh',
    NGAYSINH DATETIME,
    DIACHI NVARCHAR(100) NOT NULL,
    SODIENTHOAI VARCHAR(20),
    DIACHIEMAIL VARCHAR(50),
    CCCD VARCHAR(20) UNIQUE,
    NIENKHOA VARCHAR(10),
    NAMNHAPHOC VARCHAR(10),
    MALOP VARCHAR(10),
    FOREIGN KEY(MALOP) REFERENCES LOPHOC(MALOP) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

CREATE TABLE NGUOITHAN(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    HOTEN NVARCHAR(50),
    QUANHE NVARCHAR(50),
    NGAYSINH DATETIME,
    SODIENTHOAI VARCHAR(20),
    MASV VARCHAR(10),
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

CREATE TABLE HOCPHAN(
    STT INT IDENTITY(1,1),
    MAHOCPHAN VARCHAR(10) PRIMARY KEY,
    TENHOCPHAN NVARCHAR(50) NOT NULL,
    SOTC INT,
    SOTIET as sotc * 15,
    LOAIHP  NVARCHAR(50),
    MAKHOA VARCHAR(10) DEFAULT 'KCNTT',
    FOREIGN KEY(MAKHOA) REFERENCES KHOA(MAKHOA) ON DELETE CASCADE ON UPDATE CASCADE
)
GO

CREATE TABLE GIANGDAY(
    STT INT IDENTITY(1,1),
    MaGiangVien VARCHAR(10),
    MaHocPhan VARCHAR(10),
    PRIMARY KEY (MaGiangVien, MaHocPhan),
    FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien) ,
    FOREIGN KEY (MaHocPhan) REFERENCES HocPhan(MaHocPhan)
)

CREATE TABLE DIEMTHI(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    DIEMGHP FLOAT NOT NULL DEFAULT 0 CHECK(DIEMGHP >= 0 AND DIEMGHP <= 10),
    DIEMKTHP FLOAT NOT NULL DEFAULT 0 CHECK(DIEMKTHP >= 0 AND DIEMKTHP <= 10),
    DIEMTBC AS (DIEMGHP + DIEMKTHP)/2,
    UNIQUE(masv, mahocphan),    
    MASV VARCHAR(10),
    MAHOCPHAN VARCHAR(10),
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(MAHOCPHAN) REFERENCES HOCPHAN(MAHOCPHAN) 
)
GO 


CREATE TABLE ThoiKhoaBieu (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Thu INT, 
    Tuan INT,
    TietHoc VARCHAR(10),
    PhongHoc NVARCHAR(50),
    MaLop VARCHAR(10),
    MaHocPhan VARCHAR(10),
    Magiangvien VARCHAR(10),
    FOREIGN KEY(MAGIANGVIEN) REFERENCES GIANGVIEN(MAGIANGVIEN),
    FOREIGN KEY (MaLop) REFERENCES LOPHOC(MALOP), -- Khóa ngoại tham chiếu đến bảng LopHoc
    FOREIGN KEY (MaHocPhan) REFERENCES HOCPHAN(MAHOCPHAN) -- Khóa ngoại tham chiếu đến bảng HocPhan
);

CREATE TABLE TAIKHOAN(
    ID INT IDENTITY PRIMARY KEY,
    USERNAME NVARCHAR(50),
    PASSWORD NVARCHAR(50),
    PHONENUMBER VARCHAR(20),
    EMAILADDRESS VARCHAR(50),
    ACCOUNTTYPE NVARCHAR(10), --admin or user
    NGAYTAO DATETIME DEFAULT GETDATE(),
    LOGINLOG DATETIME
)
GO

INSERT INTO TAIKHOAN (USERNAME, PASSWORD, PHONENUMBER, EMAILADDRESS, ACCOUNTTYPE, LOGINLOG)
VALUES 
('admin', 'admin', '0363969923', 'admin@gmail.com', 'Admin', GETDATE()),
('user', 'user', '0982055841', 'user@gmail.com', 'User', GETDATE());

go
INSERT INTO KHOA (MAKHOA, TENKHOA, SDT, Email)
VALUES 
('CNTT', N'Công Nghệ Thông Tin', '0123451111', 'KhoaCongNgheThongTin@utehy.edu.vn'),
('NN', N'Ngoại Ngữ', '0123452222', 'KhoaNgoaiNgu@utehy.edu.vn'),
('MM', N'May Mặc', '0123453333', 'KhoaMayMac@utehy.edu.vn'),
('HH', N'Hóa Học', '0123454444', 'KhoaHoaHoc@utehy.edu.vn'),
('DDT', N'Điện - Điện Tử', '0123455555', 'KhoaDienDienTu@utehy.edu.vn'),
('SP', N'Sư Phạm', '0123456666', 'KhoaSuPham@utehy.edu.vn'),
('KT', N'Kinh Tế', '0123457777', 'KhoaKinhTe@utehy.edu.vn'),
('CNO', N'Công Nghệ Oto', '0123458888', 'KhoaCongNgheOto@utehy.edu.vn')

go
INSERT INTO NGANH (MANGANH, TENNGANH, MAKHOA)
VALUES 
('KTPM', N'Kỹ Thuật phần mềm', 'CNTT'),
('CNTT', N'Công nghệ Thông Tin', 'CNTT'),
('KHMT', N'Khoa Học Máy Tính', 'CNTT'),
('NNA', N'Ngôn Ngữ Anh', 'NN'),
('NNT', N'Ngôn Ngữ Trung', 'NN'),
('NNN', N'Ngôn Ngữ Nhật', 'NN'),
('NNH', N'Ngôn Ngữ Hàn', 'NN'),
('CNM', N'Công Nghệ May', 'MM'),
('KDTTVDM', N'Kinh Doanh Thời Trang và Dệt May', 'MM'),
('QTKD', N'Quản trị Kinh Doanh', 'KT'),
('KT', N'Kinh Tế', 'KT'),
('CNKTDDT', N'Công Nghệ Kỹ Thuật Điện và Điện Tử', 'DDT'),
('CNKTDKTDH', N'Công Nghệ Kỹ Thuật Điều Khiển và Tự Động hóa', 'DDT'),
('SP', N'Sư Phạm', 'SP')


go
INSERT INTO CHUYENNGANH (MACHUYENNGANHNGANH, TENCHUYENNGANH, THOIGIANDAOTAO, MANGANH)
VALUES 
('DHDPT', N'Đồ Họa Đa Phương Tiện', 4, 'CNTT'),
('TTNTKHDL', N'Trí Tuệ Nhân Tạo và Khoa Học Dữ Liệu', 4, 'KHMT'),
('TTNTXLNNTN', N'Trí Tuệ Nhân Tạo và Xử Lý Ngôn Ngữ Tự Nhiên', 4, 'KHMT'),
('TTNTNDHA', N'Trí tuệ nhân tạo và Nhận dạng hình ảnh', 4, 'KHMT'),
('KTDBCLPM', N'Kiểm thử và Đảm bảo chất lượng phần mềm', 4, 'KTPM'),
('CNDD', N'Công nghệ di động', 4, 'KTPM'),
('CNW', N'Công nghệ Web', 4, 'KTPM'),
('TATM', N'Tiếng Anh Thương Mại', 4, 'NNA'),
('BPD', N'Biên Phiên Dịch', 4, 'NNA'),
('NNA', N'Ngôn Ngữ Anh', 4, 'NNA'),
('NNT', N'Ngôn Ngữ Trung', 4, 'NNT'),
('NNN', N'Ngôn Ngữ Nhật', 4, 'NNN'),
('NNH', N'Ngôn Ngữ Hàn', 4, 'NNH'),
('CNM', N'Công Nghệ May', 4, 'CNM'),
('TKTT', N'Thiết Kế Thời Trang', 4, 'CNM'),
('KTDT', N'Kinh Tế Đầu Tư', 4, 'KT'),
('KTDLCNDD', N'Kỹ Thuật Điện Lạnh Công Nghiệp và Dân Dụng', 4, 'CNKTDDT'),
('DTCN', N' Điện tử công nghiệp', 4, 'CNKTDDT'),
('DTVT', N'Điện tử viễn thông', 4, 'CNKTDDT'),
('DCN', N'Điện công nghiệp', 4, 'CNKTDDT'),
('MSPDV', N'Marketing sản phẩm và dịch vụ', 4, 'QTKD'),
('QTKDCN', N'Quản trị kinh doanh công nghiệ', 4, 'QTKD');


go
INSERT INTO GIANGVIEN (MAGIANGVIEN, TENGIANGVIEN, GIOITINH, NGAYSINH, TRINHDO, DIACHI, CCCD, SODIENTHOAI, MAKHOA)
VALUES 
('GV001', N'Đỗ Đặng Thắng', 'Nam', '1977-12-12', N'Giáo Sư', N'Hưng Yên', '033204005287', '0363969923','CNTT'),
('GV002', N'Nguyễn Thị Hương', N'Nữ', '1985-05-20', N'Tiến Sĩ', N'Hà Nội', '023301007888', '0987654321', 'NN'),
('GV003', N'Lê Văn An', N'Nam', '1980-09-10', N'Thạc Sĩ', N'Hà Nam', '034202006565', '0978543210', 'MM'),
('GV004', N'Trần Thanh Hải', N'Nam', '1975-07-15', N'Giáo Sư', N'Hải Phòng', '013207008976', '0934567890', 'KT'),
('GV005', N'Lê Thị Mai', N'Nữ', '1982-03-18', N'Thạc Sĩ', N'Bắc Ninh', '023401009654', '0912345678', 'DDT'),
('GV006', N'Phạm Văn Tuấn', N'Nam', '1978-11-30', N'Cử Nhân', N'Hà Nam', '033208006547', '0965432109', 'SP'),
('GV007', N'Nguyễn Thị Hoa', N'Nữ', '1987-02-25', N'Tiến Sĩ', N'Hải Dương', '013305005478', '0943216789', 'KT'),
('GV008', N'Hồ Văn Long', N'Nam', '1974-06-22', N'Giáo Sư', N'Bắc Giang', '023209007895', '0987123456', 'CNO'),
('GV009', N'Trần Thị Lan', N'Nữ', '1983-08-05', N'Thạc Sĩ', N'Hà Nam', '034203006523', '0978965432', 'HH'),
('GV010', N'Vũ Văn Đức', N'Nam', '1979-04-14', N'Cử Nhân', N'Thái Bình', '033301007844', '0932109876', 'CNTT'),
('GV011', N'Lê Thị Hương', N'Nữ', '1986-01-08', N'Thạc Sĩ', N'Bắc Ninh', '023401008963', '0987654321', 'NN'),
('GV012', N'Nguyễn Văn Hùng', N'Nam', '1973-10-02', N'Giáo Sư', N'Hưng Yên', '013205007452', '0965432109', 'MM'),
('GV013', N'Phạm Thị Thu', N'Nữ', '1981-06-28', N'Tiến Sĩ', N'Thái Bình', '023304009874', '0943216789', 'KT'),
('GV014', N'Lê Văn Thanh', N'Nam', '1976-09-16', N'Cử Nhân', N'Hải Phòng', '013204006532', '0987123456', 'DDT'),
('GV015', N'Trần Thị Hà', N'Nữ', '1984-11-10', N'Thạc Sĩ', N'Hà Nội', '023302008547', '0978965432', 'SP'),
('GV016', N'Hoàng Văn Tâm', N'Nam', '1978-07-20', N'Giáo Sư', N'Bắc Giang', '033206005874', '0932109876', 'KT'),
('GV017', N'Đỗ Thị Thủy', N'Nữ', '1980-03-25', N'Tiến Sĩ', N'Hải Dương', '013305009632', '0987654321', 'CNO'),
('GV018', N'Nguyễn Văn Anh', N'Nam', '1975-12-18', N'Cử Nhân', N'Bắc Ninh', '023401007489', '0943216789', 'HH'),
('GV019', N'Vũ Thị Lan', N'Nữ', '1982-08-04', N'Thạc Sĩ', N'Hưng Yên', '013205008765', '0978965432', 'CNTT'),
('GV020', N'Trần Văn Đức', N'Nam', '1977-05-14', N'Giáo Sư', N'Thái Bình', '033304007812', '0987123456', 'NN');

go
INSERT INTO LOPHOC (MALOP, TENLOP, HEDAOTAO, SISO, MACHUYENNGANHNGANH, MAGIANGVIEN)
VALUES
('W.1', N'Lập Trình Web 1', 'Chính quy', 0, 'CNW', 'GV001'),
('W.2', N'Lập Trình Web 2', 'Chính quy', 0, 'CNW', 'GV001'),
('W.3', N'Lập Trình Web 3', 'Chính quy', 0, 'CNW', 'GV002'),
('W.4', N'Lập Trình Web 4', 'Chính quy', 0, 'CNW', 'GV002'),

('T.1', N'Kiểm Thử Phần Mềm 1', 'Chính quy', 0, 'KTDBCLPM', 'GV003'),
('T.2', N'Kiểm Thử Phần Mềm 2', 'Chính quy', 0, 'KTDBCLPM', 'GV003'),
('T.3', N'Kiểm Thử Phần Mềm 3', 'Chính quy', 0, 'KTDBCLPM', 'GV003'),

('Data.1', N'Trí Tuệ Nhân Tạo và Khoa Học Dữ Liệu', 'Chính quy', 0, 'TTNTKHDL', 'GV004'),
('Data.2', N'Trí Tuệ Nhân Tạo và Khoa Học Dữ Liệu', 'Chính quy', 0, 'TTNTKHDL', 'GV004'),
('HA.1', N'Trí Tuệ Nhân Tạo và Nhận Dạng Hình Ảnh', 'Chính quy', 0, 'TTNTNDHA', 'GV004'),
('NN.1', N'Trí Tuệ Nhân Tạo và Xử Lý Ngôn Ngữ Tự Nhiên', 'Chính quy', 0, 'TTNTKHDL', 'GV004'),

('TA.1', N'Tiếng Anh Thương Mại 1', 'Chính Quy', 0, 'TATM', 'GV005'),
('TA.2', N'Tiếng Anh Thương Mại 2', 'Chính Quy', 0, 'TATM', 'GV005'),
('TA.3', N'Tiếng Anh Thương Mại 3', 'Từ xa', 0, 'TATM', 'GV005'),

('BPD.1', N'Biên Phiên Dịch 1', 'Chính Quy', 0, 'BPD', 'GV005'),
('BPD.2', N'Biên Phiên Dịch 1', 'Từ xa', 0, 'BPD', 'GV005'),

('N.1', N'Ngôn Ngữ Nhật 1', 'Chính Quy', 0, 'NNN', 'GV006'),
('N.2', N'Ngôn Ngữ Nhật 2', 'Từ xa', 0, 'NNN', 'GV006'),
('H.1', N'Ngôn Ngữ Hàn 1', 'Chính Quy', 0, 'NNH', 'GV006'),
('H.2', N'Ngôn Ngữ Hàn 2', 'Từ xa', 0, 'NNH', 'GV006'),

('TK.1', N'Thiết Kế Thời Trang 1', 'Chính quy', 0, 'TKTT', 'GV007'),
('TK.2', N'Thiết Kế Thời Trang 2', 'Chính quy', 0, 'TKTT', 'GV007'),
('TK.3', N'Thiết Kế Thời Trang 3', 'Chính quy', 0, 'TKTT', 'GV007')


--sinh viên
go
INSERT INTO SinhVien (MASV, HOTEN, GIOITINH, DANTOC, NGAYSINH, DIACHI, SODIENTHOAI, DIACHIEMAIL, CCCD, NIENKHOA, NAMNHAPHOC, MALOP)
VALUES
('SV001', N'Nguyễn Văn Thành', N'Nam', N'Kinh', '2006-03-15', N'Hà Nội', '0987654321', 'NguyenVanThanh@gmail.com', '0332456789', 'K22', '2024', 'W.1'),
('SV002', N'Nguyễn Thị Hồng', N'Nữ', N'Kinh', '2005-09-28', N'Hồ Chí Minh', '0123456789', 'NguyenThiHong@gmail.com', '033543211122', 'K21', '2023', 'W.2'),
('SV003', N'Trần Văn Nam', N'Nam', N'Mường', '2004-11-10', N'Hải Phòng', '0365987412', 'TranVanNam@gmail.com', '0337891232', 'K20', '2022', 'W.3'),
('SV004', N'Nguyễn Thị Lan', N'Nữ', N'Mường', '2003-07-17', N'Đà Nẵng', '0654321987', 'NguyenThiLan@gmail.com', '0331234567', 'K19', '2021', 'W.4'),
('SV005', N'Lê Văn Tuấn', N'Nam', N'Thái', '2002-05-20', N'Cần Thơ', '0789456123', 'LeVanTuan@gmail.com', '0333578523', 'K18', '2020', 'T.1'),
('SV006', N'Phạm Thị Mai', N'Nữ', N'Thái', '2001-08-03', N'Hà Nội', '0258963741', 'PhamThiMai@gmail.com', '0339514566', 'K17', '2019', 'T.2'),
('SV007', N'Trần Văn Đức', N'Nam', N'Mông', '2000-10-25', N'Hồ Chí Minh', '0369842571', 'TranVanDuc@gmail.com', '0337413698', 'K16', '2018', 'T.3'),
('SV008', N'Hoàng Thị Hương', N'Nữ', N'Mông', '2006-02-08', N'Hải Phòng', '0147852369', 'HoangThiHuong@gmail.com', '0333258147', 'K21', '2023', 'Data.1'),
('SV009', N'Đặng Văn Hải', N'Nam', N'Kinh', '2005-04-30', N'Đà Nẵng', '0325879416', 'DangVanHai@gmail.com', '033258369', 'K21', '2023', 'Data.2'),
('SV010', N'Lê Thị Kim Ngân', N'Nữ', N'Kinh', '2004-06-22', N'Cần Thơ', '0569871234', 'LeThiKimNgan@gmail.com', '03331472588', 'K20', '2022', 'HA.1'),
('SV011', N'Nguyễn Văn Lâm', N'Nam', N'Kinh', '2003-12-04', N'Hà Nội', '0236985471', 'NguyenVanLam@gmail.com', '0333654322', 'K19', '2021', 'NN.1'),
('SV012', N'Lê Thị Thu Hà', N'Nữ', N'Kinh', '2002-01-18', N'Hồ Chí Minh', '0321654987', 'LeThiThuHa@gmail.com', '0331237898', 'K18', '2020', 'TA.1'),
('SV013', N'Trần Văn Đạt', N'Nam', N'Kinh', '2001-04-11', N'Hải Phòng', '0147852369', 'TranVanDat@gmail.com', '0333987456', 'K17', '2019', 'TA.2'),
('SV014', N'Hoàng Thị Phương', N'Nữ', N'Kinh', '2000-08-29', N'Đà Nẵng', '0369854712', 'HoangThiPhuong@gmail.com', '0333654123', 'K16', '2018', 'TA.3'),

('SV015', N'Trần Thị Hằng', N'Nữ', N'Kinh', '2005-03-15', N'Hà Nội', '0987654321', 'TranThiHang@gmail.com', '0332457789', 'K21', '2023', 'W.1'),
('SV016', N'Phạm Văn Đức', N'Nam', N'Kinh', '2004-09-28', N'Hồ Chí Minh', '0123456789', 'PhamVanDuc@gmail.com', '03354321333', 'K20', '2022', 'W.2'),
('SV017', N'Nguyễn Thị Hà', N'Nữ', N'Kinh', '2003-11-10', N'Hải Phòng', '0365987412', 'NguyenThiHa@gmail.com', '0337891233', 'K19', '2021', 'W.3'),
('SV018', N'Trần Văn Tú', N'Nam', N'Mường', '2002-07-17', N'Đà Nẵng', '0654321987', 'TranVanTu@gmail.com', '0331234565', 'K18', '2020', 'W.4'),
('SV019', N'Hoàng Thị Mai', N'Nữ', N'Mường', '2001-05-20', N'Cần Thơ', '0789456123', 'HoangThiMai@gmail.com', '0333578522', 'K17', '2019', 'T.1'),
('SV020', N'Nguyễn Văn Nam', N'Nam', N'Thái', '2000-08-03', N'Hà Nội', '0258963741', 'NguyenVanNam@gmail.com', '0339514567', 'K16', '2018', 'T.2'),
('SV021', N'Lê Thị Phương', N'Nữ', N'Thái', '2006-10-25', N'Hồ Chí Minh', '0369842571', 'LeThiPhuong@gmail.com', '0337413699', 'K22', '2024', 'T.3'),
('SV022', N'Trần Văn Hải', N'Nam', N'Mông', '2005-02-08', N'Hải Phòng', '0147852369', 'TranVanHai@gmail.com', '03332581477', 'K21', '2023', 'Data.1'),
('SV023', N'Phạm Thị Lan', N'Nữ', N'Mông', '2004-04-30', N'Đà Nẵng', '0325879416', 'PhamThiLan@gmail.com', '0332583698', 'K20', '2022', 'Data.2'),
('SV024', N'Lê Văn Đức', N'Nam', N'Kinh', '2003-06-22', N'Cần Thơ', '0569871234', 'LeVanDuc@gmail.com', '0333147258', 'K19', '2021', 'HA.1'),
('SV025', N'Nguyễn Thị Thanh', N'Nữ', N'Kinh', '2002-12-04', N'Hà Nội', '0236985471', 'NguyenThiThanh@gmail.com', '0333654311', 'K18', '2020', 'NN.1'),
('SV026', N'Trần Văn Long', N'Nam', N'Kinh', '2001-01-18', N'Hồ Chí Minh', '0321654987', 'TranVanLong@gmail.com', '0331237899', 'K17', '2019', 'TA.1'),
('SV027', N'Phạm Thị Hương', N'Nữ', N'Kinh', '2000-04-11', N'Hải Phòng', '0147852369', 'PhamThiHuong@gmail.com', '03339874566', 'K16', '2018', 'TA.2'),
('SV028', N'Nguyễn Văn Đạt', N'Nam', N'Kinh', '1999-08-29', N'Đà Nẵng', '0369854712', 'NguyenVanDat@gmail.com', '03336541223', 'K15', '2017', 'TA.3'),
('SV029', N'Trần Thị Thảo', N'Nữ', N'Kinh', '2006-03-15', N'Hà Nội', '0987654321', 'TranThiThao@gmail.com', '0332456689', 'K22', '2024', 'W.1'),
('SV030', N'Phạm Văn An', N'Nam', N'Kinh', '2005-09-28', N'Hồ Chí Minh', '0123456789', 'PhamVanAn@gmail.com', '03354321234', 'K21', '2023', 'W.2'),
('SV031', N'Nguyễn Thị Hạnh', N'Nữ', N'Kinh', '2004-11-10', N'Hải Phòng', '0365987412', 'NguyenThiHanh@gmail.com', '0337891231', 'K20', '2022', 'W.3'),
('SV032', N'Trần Văn Tuấn', N'Nam', N'Mường', '2003-07-17', N'Đà Nẵng', '0654321987', 'TranVanTuan@gmail.com', '03312345632', 'K19', '2021', 'W.4'),
('SV033', N'Hoàng Thị Hà', N'Nữ', N'Mường', '2002-05-20', N'Cần Thơ', '0789456123', 'HoangThiHa@gmail.com', '0333578521', 'K18', '2020', 'T.1'),
('SV034', N'Nguyễn Văn Đông', N'Nam', N'Thái', '2001-08-03', N'Hà Nội', '0258963741', 'NguyenVanDong@gmail.com', '0339514565', 'K17', '2019', 'T.2'),
('SV035', N'Lê Thị Thu', N'Nữ', N'Thái', '2000-10-25', N'Hồ Chí Minh', '0369842571', 'LeThiThu@gmail.com', '0337413690', 'K16', '2018', 'T.3'),

('SV036', N'Trần Thị Mai', N'Nữ', N'Kinh', '2006-02-15', N'Hà Nội', '0987654321', 'TranThiMai@gmail.com', '0332457899', 'K22', '2024', 'W.1'),
('SV037', N'Phạm Văn Anh', N'Nam', N'Kinh', '2005-08-28', N'Hồ Chí Minh', '0123456789', 'PhamVanAnh@gmail.com', '033543211133', 'K21', '2023', 'W.2'),
('SV038', N'Nguyễn Thị Hằng', N'Nữ', N'Kinh', '2004-10-10', N'Hải Phòng', '0365987412', 'NguyenThiHang@gmail.com', '033789123', 'K20', '2022', 'W.3'),
('SV039', N'Trần Văn Tâm', N'Nam', N'Mường', '2003-06-17', N'Đà Nẵng', '0654321987', 'TranVanTam@gmail.com', '03312345678', 'K19', '2021', 'W.4'),
('SV040', N'Hoàng Thị Hương', N'Nữ', N'Mường', '2002-04-20', N'Cần Thơ', '0789456123', 'HoangThiHuong@gmail.com', '03335785246', 'K18', '2020', 'T.1'),
('SV041', N'Nguyễn Văn Long', N'Nam', N'Thái', '2001-07-03', N'Hà Nội', '0258963741', 'NguyenVanLong@gmail.com', '0339514564', 'K17', '2019', 'T.2'),
('SV042', N'Lê Thị Thu', N'Nữ', N'Thái', '2000-09-25', N'Hồ Chí Minh', '0369842571', 'LeThiThu@gmail.com', '0337413694', 'K16', '2018', 'T.3'),
('SV043', N'Trần Văn Hải', N'Nam', N'Mông', '2006-01-08', N'Hải Phòng', '0147852369', 'TranVanHai@gmail.com', '03332581476', 'K22', '2024', 'Data.1'),
('SV044', N'Phạm Thị Lan', N'Nữ', N'Mông', '2005-03-30', N'Đà Nẵng', '0325879416', 'PhamThiLan@gmail.com', '0332583699', 'K21', '2023', 'Data.2'),
('SV045', N'Lê Văn Đức', N'Nam', N'Kinh', '2004-05-22', N'Cần Thơ', '0569871234', 'LeVanDuc@gmail.com', '03331472580', 'K20', '2022', 'HA.1'),
('SV046', N'Nguyễn Thị Thanh', N'Nữ', N'Kinh', '2003-11-04', N'Hà Nội', '0236985471', 'NguyenThiThanh@gmail.com', '0333654321', 'K19', '2021', 'NN.1'),
('SV047', N'Trần Văn Tuấn', N'Nam', N'Kinh', '2002-12-18', N'Hồ Chí Minh', '0321654987', 'TranVanTuan@gmail.com', '0331237896', 'K18', '2020', 'TA.1'),
('SV048', N'Phạm Thị Hương', N'Nữ', N'Kinh', '2001-04-11', N'Hải Phòng', '0147852369', 'PhamThiHuong@gmail.com', '03339874556', 'K17', '2019', 'TA.2'),
('SV049', N'Nguyễn Văn Đạt', N'Nam', N'Kinh', '2000-08-29', N'Đà Nẵng', '0369854712', 'NguyenVanDat@gmail.com', '03336541233', 'K16', '2018', 'TA.3'),
('SV050', N'Trần Thị Thảo', N'Nữ', N'Kinh', '2006-03-15', N'Hà Nội', '0987654321', 'TranThiThao@gmail.com', '0332456759', 'K22', '2024', 'W.1'),
('SV051', N'Phạm Văn Anh', N'Nam', N'Kinh', '2005-09-28', N'Hồ Chí Minh', '0123456789', 'PhamVanAnh@gmail.com', '03354321678', 'K21', '2023', 'W.2'),
('SV052', N'Nguyễn Thị Hạnh', N'Nữ', N'Kinh', '2004-11-10', N'Hải Phòng', '0365987412', 'NguyenThiHanh@gmail.com', '03378912345', 'K20', '2022', 'W.3'),
('SV053', N'Trần Văn Tâm', N'Nam', N'Mường', '2003-07-17', N'Đà Nẵng', '0654321987', 'TranVanTam@gmail.com', '0331234566', 'K19', '2021', 'W.4'),
('SV054', N'Hoàng Thị Hương', N'Nữ', N'Mường', '2002-05-20', N'Cần Thơ', '0789456123', 'HoangThiHuong@gmail.com', '03335785221', 'K18', '2020', 'T.1'),
('SV055', N'Nguyễn Văn Long', N'Nam', N'Thái', '2001-08-03', N'Hà Nội', '0258963741', 'NguyenVanLong@gmail.com', '0339514563', 'K17', '2019', 'T.2'),
('SV056', N'Lê Thị Thu', N'Nữ', N'Thái', '2000-10-25', N'Hồ Chí Minh', '0369842571', 'LeThiThu@gmail.com', '0337413695', 'K16', '2018', 'T.3'),

('SV057', N'Đặng Thị Ngọc', N'Nữ', N'Kinh', '2003-07-15', N'Hà Nội', '0987654321', 'DangThiNgoc@gmail.com', '0332256789', 'K20', '2022', 'HA.1'),
('SV058', N'Lê Văn An', N'Nam', N'Kinh', '2002-09-28', N'Hồ Chí Minh', '0123456789', 'LeVanAn@gmail.com', '0335432199', 'K19', '2021', 'NN.1'),
('SV059', N'Trần Thị Thu Hằng', N'Nữ', N'Kinh', '2001-11-10', N'Hải Phòng', '0365987412', 'TranThiThuHang@gmail.com', '03378912321', 'K18', '2020', 'TA.1'),
('SV060', N'Nguyễn Văn Tâm', N'Nam', N'Mường', '2000-05-17', N'Đà Nẵng', '0654321987', 'NguyenVanTam@gmail.com', '03312345665', 'K17', '2019', 'TA.2'),
('SV061', N'Trần Thị Mai', N'Nữ', N'Mường', '1999-03-20', N'Cần Thơ', '0789456123', 'TranThiMai@gmail.com', '03335785234', 'K16', '2018', 'TA.3'),
('SV062', N'Lê Văn Hải', N'Nam', N'Thái', '1998-07-03', N'Hà Nội', '0258963741', 'LeVanHai@gmail.com', '0339514568', 'K15', '2017', 'W.1'),
('SV063', N'Nguyễn Thị Lan', N'Nữ', N'Thái', '1997-09-25', N'Hồ Chí Minh', '0369842571', 'NguyenThiLan@gmail.com', '0337413696', 'K14', '2016', 'W.2'),
('SV064', N'Hoàng Văn Đức', N'Nam', N'Mông', '1996-01-08', N'Hải Phòng', '0147852369', 'HoangVanDuc@gmail.com', '03332581479', 'K13', '2015', 'W.3'),
('SV065', N'Phạm Thị Hương', N'Nữ', N'Mông', '1995-03-30', N'Đà Nẵng', '0325879416', 'PhamThiHuong@gmail.com', '0332583690', 'K12', '2014', 'W.4'),
('SV066', N'Lê Văn Nam', N'Nam', N'Kinh', '1994-05-22', N'Cần Thơ', '0569871234', 'LeVanNam@gmail.com', '03331472582', 'K11', '2013', 'T.1'),
('SV067', N'Nguyễn Thị Hằng', N'Nữ', N'Kinh', '1993-07-15', N'Hà Nội', '0987654321', 'NguyenThiHang@gmail.com', '03336543212', 'K10', '2012', 'T.2'),
('SV068', N'Trần Văn Tuấn', N'Nam', N'Kinh', '1992-09-28', N'Hồ Chí Minh', '0123456789', 'TranVanTuan@gmail.com', '0331237892', 'K9', '2011', 'T.3'),
('SV069', N'Hoàng Thị Phượng', N'Nữ', N'Kinh', '1991-11-10', N'Hải Phòng', '0365987412', 'HoangThiPhuong@gmail.com', '03339874456', 'K8', '2010', 'Data.1'),
('SV070', N'Đặng Văn Anh', N'Nam', N'Kinh', '1990-05-17', N'Đà Nẵng', '0654321987', 'DangVanAnh@gmail.com', '03336541123', 'K7', '2009', 'Data.2'),
('SV071', N'Lê Thị Hằng', N'Nữ', N'Kinh', '1989-03-20', N'Cần Thơ', '0789456123', 'LeThiHang@gmail.com', '03336543213', 'K6', '2008', 'HA.1'),
('SV072', N'Trần Văn Tâm', N'Nam', N'Kinh', '1988-07-03', N'Hà Nội', '0258963741', 'TranVanTam@gmail.com', '03336543214', 'K5', '2007', 'NN.1'),
('SV073', N'Nguyễn Thị Hạnh', N'Nữ', N'Kinh', '1987-09-25', N'Hồ Chí Minh', '0369842571', 'NguyenThiHanh@gmail.com', '03336543121', 'K4', '2006', 'TA.1'),
('SV074', N'Hoàng Văn Tú', N'Nam', N'Kinh', '1986-01-08', N'Hải Phòng', '0147852369', 'HoangVanTu@gmail.com', '03336543231', 'K3', '2005', 'TA.2'),
('SV075', N'Phạm Thị Thu', N'Nữ', N'Kinh', '1985-03-30', N'Đà Nẵng', '0325879416', 'PhamThiThu@gmail.com', '03336543291', 'K2', '2004', 'TA.3'),
('SV076', N'Lê Văn Hùng', N'Nam', N'Kinh', '1984-05-22', N'Cần Thơ', '0569871234', 'LeVanHung@gmail.com', '03336543215', 'K1', '2003', 'W.1');


--người thân
go
INSERT INTO NGUOITHAN (HOTEN, QUANHE, NGAYSINH, SODIENTHOAI, MASV)
VALUES
(N'Nguyễn Quang Thành', N'Bố', '1965-03-15', '0987654321', 'SV001'),
(N'Nguyễn Thị Hương', N'Mẹ', '1963-06-28', '0123456789', 'SV002'),
(N'Phạm Văn Đồng', N'Bố', '1970-09-10', '0987654321', 'SV003'),
(N'Trần Thị Lan', N'Mẹ', '1968-11-23', '0123456789', 'SV004'),
(N'Lê Thị Hà', N'Mẹ', '1962-05-18', '0987654321', 'SV005'),
(N'Nguyễn Văn Tuấn', N'Bố', '1960-08-01', '0123456789', 'SV006'),
(N'Phạm Thị Lan', N'Mẹ', '1968-12-20', '0987654321', 'SV007'),
(N'Nguyễn Văn Long', N'Bố', '1966-07-07', '0123456789', 'SV008'),
(N'Trần Thị Mai', N'Mẹ', '1964-04-30', '0987654321', 'SV009'),
(N'Lê Văn Đức', N'Bố', '1962-11-15', '0123456789', 'SV010'),
(N'Nguyễn Thị Thu', N'Mẹ', '1969-09-03', '0987654321', 'SV011'),
(N'Trần Văn Hoàng', N'Bố', '1967-02-18', '0123456789', 'SV012'),
(N'Phạm Thị Ngọc', N'Mẹ', '1975-11-28', '0987654321', 'SV013'),
(N'Lê Văn Hùng', N'Bố', '1973-08-09', '0123456789', 'SV014'),
(N'Nguyễn Thị Hà', N'Mẹ', '1971-10-10', '0987654321', 'SV015'),
(N'Nguyễn Văn Huy', N'Bố', '1969-03-25', '0123456789', 'SV016'),
(N'Trần Thị Ánh', N'Mẹ', '1974-06-13', '0987654321', 'SV017'),
(N'Nguyễn Văn Thanh', N'Bố', '1972-01-05', '0123456789', 'SV018'),
(N'Lê Thị Thúy', N'Mẹ', '1976-04-02', '0987654321', 'SV019'),
(N'Trần Văn Tùng', N'Bố', '1974-09-17', '0123456789', 'SV020'),

(N'Nguyễn Thị Lan', N'Mẹ', '1967-03-15', '0987654321', 'SV021'),
(N'Nguyễn Văn Tuấn', N'Bố', '1965-06-28', '0123456789', 'SV022'),
(N'Phạm Thị Hằng', N'Mẹ', '1972-09-10', '0987654321', 'SV023'),
(N'Trần Văn Hoàng', N'Bố', '1970-11-23', '0123456789', 'SV024'),
(N'Lê Thị Hương', N'Mẹ', '1964-05-18', '0987654321', 'SV025'),
(N'Lê Văn Sơn', N'Bố', '1962-08-01', '0123456789', 'SV026'),
(N'Phạm Thị Trang', N'Mẹ', '1970-12-20', '0987654321', 'SV027'),
(N'Nguyễn Văn Tú', N'Bố', '1968-07-07', '0123456789', 'SV028'),
(N'Trần Thị Lan', N'Mẹ', '1966-04-30', '0987654321', 'SV029'),
(N'Nguyễn Văn Hùng', N'Bố', '1964-11-15', '0123456789', 'SV030'),

(N'Nguyễn Thị Lan', N'Mẹ', '1967-03-15', '0987654321', 'SV031'),
(N'Nguyễn Văn Anh', N'Bố', '1965-06-28', '0123456789', 'SV032'),
(N'Trần Thị Hoài', N'Mẹ', '1972-09-10', '0987654321', 'SV033'),
(N'Trần Văn Hậu', N'Bố', '1970-11-23', '0123456789', 'SV034'),
(N'Lê Thị Hà', N'Mẹ', '1964-05-18', '0987654321', 'SV035'),
(N'Lê Văn Tâm', N'Bố', '1962-08-01', '0123456789', 'SV036'),
(N'Phạm Thị Hằng', N'Mẹ', '1970-12-20', '0987654321', 'SV037'),
(N'Phạm Văn Hoàng', N'Bố', '1968-07-07', '0123456789', 'SV038'),
(N'Trần Thị Thu', N'Mẹ', '1966-04-30', '0987654321', 'SV039'),
(N'Trần Văn Hùng', N'Bố', '1964-11-15', '0123456789', 'SV040'),
(N'Lê Thị Mai', N'Mẹ', '1971-09-03', '0987654321', 'SV041'),
(N'Lê Văn Đạt', N'Bố', '1969-02-18', '0123456789', 'SV042'),
(N'Nguyễn Thị Quỳnh', N'Mẹ', '1977-11-28', '0987654321', 'SV043'),
(N'Nguyễn Văn Quân', N'Bố', '1975-08-09', '0123456789', 'SV044'),
(N'Phạm Thị Huệ', N'Mẹ', '1973-10-10', '0987654321', 'SV045'),
(N'Phạm Văn Tú', N'Bố', '1971-03-25', '0123456789', 'SV046'),
(N'Lê Thị Thủy', N'Mẹ', '1975-06-13', '0987654321', 'SV047'),
(N'Lê Văn Dũng', N'Bố', '1973-01-05', '0123456789', 'SV048'),
(N'Trần Thị Loan', N'Mẹ', '1977-04-02', '0987654321', 'SV049'),
(N'Trần Văn Thanh', N'Bố', '1975-09-17', '0123456789', 'SV050'),

(N'Nguyễn Thị Hoa', N'Mẹ', '1966-03-15', '0987654321', 'SV051'),
(N'Nguyễn Văn Hùng', N'Bố', '1964-06-28', '0123456789', 'SV052'),
(N'Trần Thị Ngọc', N'Mẹ', '1971-09-10', '0987654321', 'SV053'),
(N'Trần Văn Tâm', N'Bố', '1969-11-23', '0123456789', 'SV054'),
(N'Lê Thị Lan', N'Mẹ', '1963-05-18', '0987654321', 'SV055'),
(N'Lê Văn Minh', N'Bố', '1961-08-01', '0123456789', 'SV056'),
(N'Phạm Thị Ngân', N'Mẹ', '1969-12-20', '0987654321', 'SV057'),
(N'Phạm Văn Tân', N'Bố', '1967-07-07', '0123456789', 'SV058'),
(N'Trần Thị Thúy', N'Mẹ', '1965-04-30', '0987654321', 'SV059'),
(N'Trần Văn Lợi', N'Bố', '1963-11-15', '0123456789', 'SV059'),
(N'Lê Thị Tuyết', N'Mẹ', '1970-09-03', '0987654321', 'SV060'),
(N'Lê Văn Dương', N'Bố', '1968-02-18', '0123456789', 'SV061'),
(N'Nguyễn Thị An', N'Mẹ', '1976-11-28', '0987654321', 'SV062'),
(N'Nguyễn Văn Tùng', N'Bố', '1974-08-09', '0123456789', 'SV063'),
(N'Phạm Thị Hạnh', N'Mẹ', '1972-10-10', '0987654321', 'SV064'),
(N'Phạm Văn Thanh', N'Bố', '1970-03-25', '0123456789', 'SV065'),
(N'Lê Thị Ngọc', N'Mẹ', '1974-06-13', '0987654321', 'SV066'),
(N'Lê Văn Hải', N'Bố', '1972-01-05', '0123456789', 'SV067'),
(N'Trần Thị Hường', N'Mẹ', '1978-04-02', '0987654321', 'SV068'),
(N'Trần Văn Hiếu', N'Bố', '1976-09-17', '0123456789', 'SV069'),

(N'Nguyễn Thị Mai', N'Mẹ', '1967-03-15', '0987654321', 'SV070'),
(N'Nguyễn Văn Quân', N'Bố', '1965-06-28', '0123456789', 'SV071'),
(N'Trần Thị Hằng', N'Mẹ', '1972-09-10', '0987654321', 'SV072'),
(N'Trần Văn Tài', N'Bố', '1970-11-23', '0123456789', 'SV073'),
(N'Lê Thị Nguyệt', N'Mẹ', '1964-05-18', '0987654321', 'SV074'),
(N'Lê Văn Hùng', N'Bố', '1962-08-01', '0123456789', 'SV075'),
(N'Phạm Thị Lan', N'Mẹ', '1970-12-20', '0987654321', 'SV076');

-- (N'Phạm Văn Tín', N'Bố', '1968-07-07', '0123456789', 'SV077'),
-- (N'Trần Thị Thanh', N'Mẹ', '1966-04-30', '0987654321', 'SV078')
-- (N'Trần Văn Sơn', N'Bố', '1964-11-15', '0123456789', 'SV079'),
-- (N'Lê Thị Hồng', N'Mẹ', '1971-09-03', '0987654321', 'SV056'),
-- (N'Lê Văn Bình', N'Bố', '1969-02-18', '0123456789', 'SV056'),
-- (N'Nguyễn Thị Anh', N'Mẹ', '1977-11-28', '0987654321', 'SV057'),
-- (N'Nguyễn Văn Hải', N'Bố', '1975-08-09', '0123456789', 'SV057'),
-- (N'Phạm Thị Thu', N'Mẹ', '1973-10-10', '0987654321', 'SV058'),
-- (N'Phạm Văn Hiệp', N'Bố', '1971-03-25', '0123456789', 'SV058'),
-- (N'Lê Thị Diễm', N'Mẹ', '1975-06-13', '0987654321', 'SV059'),
-- (N'Lê Văn Đức', N'Bố', '1973-01-05', '0123456789', 'SV059'),
-- (N'Trần Thị Thúy', N'Mẹ', '1979-04-02', '0987654321', 'SV060'),
-- (N'Trần Văn Huy', N'Bố', '1977-09-17', '0123456789', 'SV060'),
-- (N'Nguyễn Thị Kim', N'Mẹ', '1966-03-15', '0987654321', 'SV061'),
-- (N'Nguyễn Văn Đạt', N'Bố', '1964-06-28', '0123456789', 'SV061'),
-- (N'Trần Thị Hương', N'Mẹ', '1971-09-10', '0987654321', 'SV062'),
-- (N'Trần Văn Tâm', N'Bố', '1969-11-23', '0123456789', 'SV062'),
-- (N'Lê Thị Lan', N'Mẹ', '1963-05-18', '0987654321', 'SV063'),
-- (N'Lê Văn Minh', N'Bố', '1961-08-01', '0123456789', 'SV063'),
-- (N'Phạm Thị Ngân', N'Mẹ', '1969-12-20', '0987654321', 'SV064'),
-- (N'Phạm Văn Tân', N'Bố', '1967-07-07', '0123456789', 'SV064'),
-- (N'Trần Thị Thúy', N'Mẹ', '1965-04-30', '0987654321', 'SV065'),
-- (N'Trần Văn Lợi', N'Bố', '1963-11-15', '0123456789', 'SV065'),
-- (N'Lê Thị Tuyết', N'Mẹ', '1970-09-03', '0987654321', 'SV066'),
-- (N'Lê Văn Dương', N'Bố', '1968-02-18', '0123456789', 'SV066'),
-- (N'Nguyễn Thị An', N'Mẹ', '1976-11-28', '0987654321', 'SV067'),
-- (N'Nguyễn Văn Tùng', N'Bố', '1974-08-09', '0123456789', 'SV067'),
-- (N'Phạm Thị Hạnh', N'Mẹ', '1972-10-10', '0987654321', 'SV068'),
-- (N'Phạm Văn Thanh', N'Bố', '1970-03-25', '0123456789', 'SV068'),
-- (N'Lê Thị Ngọc', N'Mẹ', '1974-06-13', '0987654321', 'SV069'),
-- (N'Lê Văn Hải', N'Bố', '1972-01-05', '0123456789', 'SV069'),
-- (N'Trần Thị Hường', N'Mẹ', '1978-04-02', '0987654321', 'SV070'),
-- (N'Trần Văn Hiếu', N'Bố', '1976-09-17', '0123456789', 'SV070'),
-- (N'Nguyễn Thị Hòa', N'Mẹ', '1967-03-15', '0987654321', 'SV071'),
-- (N'Nguyễn Văn Long', N'Bố', '1965-06-28', '0123456789', 'SV071'),
-- (N'Trần Thị Hảo', N'Mẹ', '1972-09-10', '0987654321', 'SV072'),
-- (N'Trần Văn Sáng', N'Bố', '1970-11-23', '0123456789', 'SV072'),
-- (N'Lê Thị Hoa', N'Mẹ', '1964-05-18', '0987654321', 'SV073'),
-- (N'Lê Văn Hải', N'Bố', '1962-08-01', '0123456789', 'SV073'),
-- (N'Phạm Thị Huyền', N'Mẹ', '1970-12-20', '0987654321', 'SV074'),
-- (N'Phạm Văn Tú', N'Bố', '1968-07-07', '0123456789', 'SV074'),
-- (N'Trần Thị Lan', N'Mẹ', '1966-04-30', '0987654321', 'SV075'),
-- (N'Trần Văn Tuấn', N'Bố', '1964-11-15', '0123456789', 'SV075'),
-- (N'Lê Thị Huệ', N'Mẹ', '1971-09-03', '0987654321', 'SV076'),
-- (N'Lê Văn Hùng', N'Bố', '1969-02-18', '0123456789', 'SV076')

-- (N'Nguyễn Thị Hạnh', N'Mẹ', '1977-11-28', '0987654321', 'SV077'),
-- (N'Nguyễn Văn Đạt', N'Bố', '1975-08-09', '0123456789', 'SV077'),
-- (N'Phạm Thị Hoa', N'Mẹ', '1973-10-10', '0987654321', 'SV078'),
-- (N'Phạm Văn Tuấn', N'Bố', '1971-03-25', '0123456789', 'SV078'),
-- (N'Trần Thị Hiền', N'Mẹ', '1975-06-13', '0987654321', 'SV079'),
-- (N'Trần Văn Thịnh', N'Bố', '1973-01-05', '0123456789', 'SV079'),
-- (N'Lê Thị Thảo', N'Mẹ', '1970-04-02', '0987654321', 'SV080'),
-- (N'Lê Văn Hiệp', N'Bố', '1968-09-17', '0123456789', 'SV080'),
-- (N'Nguyễn Thị Thu', N'Mẹ', '1966-03-15', '0987654321', 'SV081'),
-- (N'Nguyễn Văn Quang', N'Bố', '1964-06-28', '0123456789', 'SV081'),
-- (N'Trần Thị Lan', N'Mẹ', '1971-09-10', '0987654321', 'SV082'),
-- (N'Trần Văn Tâm', N'Bố', '1969-11-23', '0123456789', 'SV082'),
-- (N'Lê Thị Diễm', N'Mẹ', '1963-05-18', '0987654321', 'SV083'),
-- (N'Lê Văn Thanh', N'Bố', '1961-08-01', '0123456789', 'SV083'),
-- (N'Phạm Thị Ngân', N'Mẹ', '1969-12-20', '0987654321', 'SV084'),
-- (N'Phạm Văn Tân', N'Bố', '1967-07-07', '0123456789', 'SV084'),
-- (N'Trần Thị Thúy', N'Mẹ', '1965-04-30', '0987654321', 'SV085'),
-- (N'Trần Văn Lợi', N'Bố', '1963-11-15', '0123456789', 'SV085'),
-- (N'Lê Thị Tuyết', N'Mẹ', '1970-09-03', '0987654321', 'SV086'),
-- (N'Lê Văn Dương', N'Bố', '1968-02-18', '0123456789', 'SV086'),
-- (N'Nguyễn Thị An', N'Mẹ', '1976-11-28', '0987654321', 'SV087'),
-- (N'Nguyễn Văn Tùng', N'Bố', '1974-08-09', '0123456789', 'SV087');


--học phần
go
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('CNTT-HP001', N'Toán cao cấp', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP002', N'Lập trình C', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP003', N'Cơ sở dữ liệu', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP004', N'Kỹ thuật lập trình', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP005', N'Hệ điều hành', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP006', N'An toàn thông tin', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP007', N'Truyền thông đa phương tiện', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP008', N'Mạng máy tính', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP009', N'Phân tích và thiết kế hệ thống', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP010', N'Kiến trúc máy tính', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP011', N'Thuật toán và phân tích thuật toán', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP012', N'Lập trình hướng đối tượng', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP013', N'Kỹ năng làm việc nhóm', 2, N'Bắt buộc', 'CNTT'),
('CNTT-HP014', N'Thực tập công nghệ thông tin', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP015', N'Tư duy thuật toán', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP016', N'Phát triển ứng dụng web', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP017', N'Lập trình di động', 4, N'Bắt buộc', 'CNTT'),
('CNTT-HP018', N'Khóa luận tốt nghiệp', 6, N'Bắt buộc', 'CNTT'),
('CNTT-HP019', N'Phát triển ứng dụng di động', 3, N'Bắt buộc', 'CNTT'),
('CNTT-HP020', N'Tiếng Anh chuyên ngành', 3, N'Bắt buộc', 'CNTT');

-- Thêm bản ghi cho 20 học phần thuộc khoa Ngoại ngữ (NN)
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('NN-HP001', N'Tiếng Anh cơ bản', 3, N'Bắt buộc', 'NN'),
('NN-HP002', N'Tiếng Anh nâng cao', 3, N'Bắt buộc', 'NN'),
('NN-HP003', N'Tiếng Hàn căn bản', 3, N'Bắt buộc', 'NN'),
('NN-HP004', N'Tiếng Hàn nâng cao', 3, N'Bắt buộc', 'NN'),
('NN-HP009', N'Tiếng Nhật căn bản', 3, N'Bắt buộc', 'NN'),
('NN-HP010', N'Tiếng Nhật nâng cao', 3, N'Bắt buộc', 'NN'),
('NN-HP011', N'Tiếng Trung căn bản', 3, N'Bắt buộc', 'NN'),
('NN-HP012', N'Tiếng Trung nâng cao', 3, N'Bắt buộc', 'NN')

-- Thêm 20 học phần cho khoa Điện - Điện tử (DDT)
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('DDT-HP001', N'Lập trình vi điều khiển', 3, N'Bắt buộc', 'DDT'),
('DDT-HP002', N'Vi xử lý và hệ thống nhúng', 4, N'Bắt buộc', 'DDT'),
('DDT-HP003', N'Kỹ thuật lập trình Assembly', 3, N'Bắt buộc', 'DDT'),
('DDT-HP004', N'Mạch điện', 4, N'Bắt buộc', 'DDT'),
('DDT-HP005', N'Điện tử cơ bản', 3, N'Bắt buộc', 'DDT'),
('DDT-HP006', N'Điện tử công suất', 4, N'Bắt buộc', 'DDT'),
('DDT-HP007', N'Điều khiển tự động', 3, N'Bắt buộc', 'DDT'),
('DDT-HP008', N'Điện tử công nghiệp', 4, N'Bắt buộc', 'DDT'),
('DDT-HP009', N'Kỹ thuật viễn thông', 3, N'Bắt buộc', 'DDT'),
('DDT-HP010', N'Điện tử công suất cao', 4, N'Bắt buộc', 'DDT'),
('DDT-HP011', N'Điện tử ứng dụng', 3, N'Bắt buộc', 'DDT'),
('DDT-HP012', N'Mạch số', 4, N'Bắt buộc', 'DDT'),
('DDT-HP013', N'Điện tử phục vụ', 3, N'Bắt buộc', 'DDT'),
('DDT-HP014', N'Hệ thống điều khiển', 4, N'Bắt buộc', 'DDT'),
('DDT-HP015', N'Mạch tích hợp và công nghệ IC', 3, N'Bắt buộc', 'DDT'),
('DDT-HP016', N'Robot và trí tuệ nhân tạo', 4, N'Bắt buộc', 'DDT'),
('DDT-HP017', N'Mạch điện tử số', 3, N'Bắt buộc', 'DDT'),
('DDT-HP018', N'Kỹ thuật dây và cáp quang', 4, N'Bắt buộc', 'DDT'),
('DDT-HP019', N'Điện tử ứng dụng trong truyền thông', 3, N'Bắt buộc', 'DDT'),
('DDT-HP020', N'Kỹ thuật an ninh mạng', 4, N'Bắt buộc', 'DDT');

-- Thêm 20 học phần cho khoa Kinh tế (KT)
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('KT-HP001', N'Kinh tế học cơ bản', 3, N'Bắt buộc', 'KT'),
('KT-HP002', N'Kế toán cơ bản', 4, N'Bắt buộc', 'KT'),
('KT-HP003', N'Quản trị kinh doanh', 3, N'Bắt buộc', 'KT'),
('KT-HP004', N'Marketing căn bản', 3, N'Bắt buộc', 'KT'),
('KT-HP005', N'Kinh tế vĩ mô', 4, N'Bắt buộc', 'KT'),
('KT-HP006', N'Phân tích tài chính', 4, N'Bắt buộc', 'KT'),
('KT-HP007', N'Tài chính doanh nghiệp', 3, N'Bắt buộc', 'KT'),
('KT-HP008', N'Quản lý nhân sự', 4, N'Bắt buộc', 'KT'),
('KT-HP009', N'Kinh doanh quốc tế', 3, N'Bắt buộc', 'KT'),
('KT-HP010', N'Tiếp thị quốc tế', 4, N'Bắt buộc', 'KT'),
('KT-HP011', N'Tài chính ngân hàng', 3, N'Bắt buộc', 'KT'),
('KT-HP012', N'Thuế và pháp lý doanh nghiệp', 4, N'Bắt buộc', 'KT'),
('KT-HP013', N'Kinh doanh điện tử', 3, N'Bắt buộc', 'KT'),
('KT-HP014', N'Quản trị chuỗi cung ứng', 4, N'Bắt buộc', 'KT'),
('KT-HP015', N'Phân tích dự án đầu tư', 3, N'Bắt buộc', 'KT'),
('KT-HP016', N'Kinh tế học lượng', 4, N'Bắt buộc', 'KT'),
('KT-HP017', N'Nghiên cứu thị trường', 3, N'Bắt buộc', 'KT'),
('KT-HP018', N'Quản trị rủi ro', 4, N'Bắt buộc', 'KT'),
('KT-HP019', N'Kinh doanh xã hội', 3, N'Bắt buộc', 'KT'),
('KT-HP020', N'Kinh tế học quốc tế', 4, N'Bắt buộc', 'KT');

-- Thêm 20 học phần cho khoa May mặc (MM)
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('MM-HP001', N'Công nghệ vải và da', 3, N'Bắt buộc', 'MM'),
('MM-HP002', N'Thể tích áo dài', 4, N'Bắt buộc', 'MM'),
('MM-HP003', N'Thiết kế thời trang', 3, N'Bắt buộc', 'MM'),
('MM-HP004', N'Sơ đồ mẫu', 3, N'Bắt buộc', 'MM'),
('MM-HP005', N'Kỹ thuật may', 4, N'Bắt buộc', 'MM'),
('MM-HP006', N'Công nghệ vải sợi', 4, N'Bắt buộc', 'MM'),
('MM-HP007', N'Kinh doanh may mặc', 3, N'Bắt buộc', 'MM'),
('MM-HP008', N'Quản lý sản xuất', 4, N'Bắt buộc', 'MM'),
('MM-HP009', N'Mô phỏng thời trang', 3, N'Bắt buộc', 'MM'),
('MM-HP010', N'Đồ họa thời trang', 4, N'Bắt buộc', 'MM'),
('MM-HP011', N'Tiếp thị thời trang', 3, N'Bắt buộc', 'MM'),
('MM-HP012', N'Trình diễn thời trang', 4, N'Bắt buộc', 'MM'),
('MM-HP013', N'May công nghiệp', 3, N'Bắt buộc', 'MM'),
('MM-HP014', N'Tiếp thị quốc tế', 4, N'Bắt buộc', 'MM'),
('MM-HP015', N'Thiết kế mẫu', 3, N'Bắt buộc', 'MM'),
('MM-HP016', N'Kỹ thuật in ấn', 4, N'Bắt buộc', 'MM'),
('MM-HP017', N'Thời trang thể thao', 3, N'Bắt buộc', 'MM'),
('MM-HP018', N'Quản lý chất lượng', 4, N'Bắt buộc', 'MM'),
('MM-HP019', N'Phát triển sản phẩm', 3, N'Bắt buộc', 'MM'),
('MM-HP020', N'Thiết kế trang phục', 4, N'Bắt buộc', 'MM');

-- Thêm 20 học phần cho khoa Sư phạm (SP)
INSERT INTO HOCPHAN (MAHOCPHAN, TENHOCPHAN, SOTC, LOAIHP, MAKHOA)
VALUES
('SP-HP001', N'Tâm lý học trong Giáo dục', 3, N'Bắt buộc', 'SP'),
('SP-HP002', N'Giáo dục Mầm non', 4, N'Bắt buộc', 'SP'),
('SP-HP003', N'Phát triển Chương trình', 3, N'Bắt buộc', 'SP'),
('SP-HP004', N'Đánh giá và Đánh giá trong Giáo dục', 3, N'Bắt buộc', 'SP'),
('SP-HP005', N'Phương pháp và Chiến lược Giảng dạy', 4, N'Bắt buộc', 'SP'),
('SP-HP006', N'Quản lý Lớp học', 4, N'Bắt buộc', 'SP'),
('SP-HP007', N'Công nghệ Giáo dục', 3, N'Bắt buộc', 'SP'),
('SP-HP008', N'Nhập môn về Đọc và Viết', 4, N'Bắt buộc', 'SP'),
('SP-HP009', N'Học và Phát triển Xã hội', 3, N'Bắt buộc', 'SP'),
('SP-HP010', N'Giảng dạy Đa dạng', 4, N'Bắt buộc', 'SP'),
('SP-HP011', N'Giáo dục Đặc biệt', 3, N'Bắt buộc', 'SP'),
('SP-HP012', N'Giáo dục Bao hàm', 4, N'Bắt buộc', 'SP'),
('SP-HP013', N'Giáo dục Đa Văn hóa', 3, N'Bắt buộc', 'SP'),
('SP-HP014', N'Phát triển Ngôn ngữ trong Giáo dục', 4, N'Bắt buộc', 'SP'),
('SP-HP015', N'Chính sách và Cải cách Giáo dục', 3, N'Bắt buộc', 'SP'),
('SP-HP016', N'Lãnh đạo trong Giáo dục', 4, N'Bắt buộc', 'SP'),
('SP-HP017', N'Giáo dục Mầm non', 3, N'Bắt buộc', 'SP'),
('SP-HP018', N'Quản trị Giáo dục Cao hơn', 4, N'Bắt buộc', 'SP'),
('SP-HP019', N'Phương pháp Nghiên cứu trong Giáo dục', 3, N'Bắt buộc', 'SP'),
('SP-HP020', N'Đạo đức trong Giáo dục', 4, N'Bắt buộc', 'SP');


--giảng dạy
-- Tạo 10 bản ghi cho bảng Giảng dạy
-- Mối quan hệ nhiều-nhiều giữa giảng viên và học phần
INSERT INTO GIANGDAY (MaGiangVien, MaHocPhan)
VALUES
('GV001', 'CNTT-HP001'),
('GV001', 'CNTT-HP002'),
('GV001', 'CNTT-HP003'),
('GV002', 'CNTT-HP004'),
('GV002', 'CNTT-HP005'),
('GV003', 'NN-HP001'),
('GV003', 'NN-HP002'),
('GV003', 'NN-HP003'),
('GV004', 'DDT-HP001'),
('GV004', 'DDT-HP002'),

('GV005', 'KT-HP001'),
('GV005', 'KT-HP002'),
('GV006', 'MM-HP001'),
('GV006', 'MM-HP002'),
('GV007', 'SP-HP001'),
('GV007', 'SP-HP002'),
('GV008', 'SP-HP003'),
('GV008', 'SP-HP004'),
('GV009', 'SP-HP005'),
('GV009', 'SP-HP006'), 

('GV011', 'CNTT-HP006'),
('GV011', 'CNTT-HP007'),
('GV012', 'CNTT-HP008'),
('GV012', 'CNTT-HP009'),
('GV013', 'CNTT-HP010'),
('GV013', 'CNTT-HP011'),
('GV014', 'NN-HP004'),
('GV014', 'NN-HP009'),
('GV015', 'DDT-HP003'),
('GV015', 'DDT-HP009'),

('GV016', 'CNTT-HP001'),
('GV016', 'CNTT-HP002'),
('GV017', 'CNTT-HP003'),
('GV017', 'CNTT-HP004'),
('GV018', 'CNTT-HP005'),
('GV018', 'CNTT-HP006'),
('GV019', 'CNTT-HP007'),
('GV019', 'CNTT-HP008'),
('GV020', 'CNTT-HP009'),
('GV020', 'CNTT-HP010');


select * from DIEMTHI
--điểm thi
-- Sinh viên SV001
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV001', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV001', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV001', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV001', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV001', 'CNTT-HP005');

-- Sinh viên SV002
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV002', 'NN-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV002', 'NN-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV002', 'NN-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV002', 'NN-HP004');

-- Sinh viên SV003
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV003', 'CNTT-HP016'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV003', 'CNTT-HP017'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV003', 'CNTT-HP018');

-- Sinh viên SV004
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV004', 'CNTT-HP013'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV004', 'CNTT-HP014'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV004', 'CNTT-HP015'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV004', 'CNTT-HP016'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV004', 'CNTT-HP017');

-- Sinh viên SV005
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV005', 'CNTT-HP018'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV005', 'CNTT-HP019'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV005', 'CNTT-HP020');

-- Sinh viên 006
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV006', 'CNTT-HP016'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV006', 'CNTT-HP017'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV006', 'CNTT-HP018'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV006', 'CNTT-HP019'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV006', 'CNTT-HP020');

-- Sinh viên SV007
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV007', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV007', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV007', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV007', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV007', 'CNTT-HP005');

-- Sinh viên SV008
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV008', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV008', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV008', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV008', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV008', 'CNTT-HP010');

-- Sinh viên SV009
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV009', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV009', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV009', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV009', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV009', 'CNTT-HP005');

-- Sinh viên SV010
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV010', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV010', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV010', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV010', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV010', 'CNTT-HP010');

-- Sinh viên SV011
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV011', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV011', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV011', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV011', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV011', 'CNTT-HP005');

-- Sinh viên SV012
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV012', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV012', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV012', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV012', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV012', 'CNTT-HP010');


-- Sinh viên SV013
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV013', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV013', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV013', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV013', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV013', 'CNTT-HP005');

-- Sinh viên SV014
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV014', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV014', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV014', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV014', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV014', 'CNTT-HP010');

-- Sinh viên SV015
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV015', 'CNTT-HP011'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV015', 'CNTT-HP012'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV015', 'CNTT-HP013'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV015', 'CNTT-HP014'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV015', 'CNTT-HP015');

-- Sinh viên 16
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV016', 'CNTT-HP016'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV016', 'CNTT-HP017'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV016', 'CNTT-HP018'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV016', 'CNTT-HP019'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV016', 'CNTT-HP020');

-- Sinh viên SV017
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV017', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV017', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV017', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV017', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV017', 'CNTT-HP005');

-- Sinh viên SV018
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV018', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV018', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV018', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV018', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV018', 'CNTT-HP010');

-- Sinh viên SV019
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV019', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV019', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV019', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV019', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV019', 'CNTT-HP005');

-- Sinh viên SV020
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV020', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV020', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV020', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV020', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV020', 'CNTT-HP010');

-- Sinh viên SV021
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV021', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV021', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV021', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV021', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV021', 'CNTT-HP005');

-- Sinh viên SV022
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV022', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV022', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV022', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV022', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV022', 'CNTT-HP010');

-- Sinh viên SV023
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV023', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV023', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV023', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV023', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV023', 'CNTT-HP005');

-- Sinh viên SV024
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV024', 'CNTT-HP006'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV024', 'CNTT-HP007'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV024', 'CNTT-HP008'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV024', 'CNTT-HP009'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV024', 'CNTT-HP010');

-- Sinh viên SV025
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV025', 'CNTT-HP001'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV025', 'CNTT-HP002'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV025', 'CNTT-HP003'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV025', 'CNTT-HP004'),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV025', 'CNTT-HP005');

select * from hocphan
-- Sinh viên SV026
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV026', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV026', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV026', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV026', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV026', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV027
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV027', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV027', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV027', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV027', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV027', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV028
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV028', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV028', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV028', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV028', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV028', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV029
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV029', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV029', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV029', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV029', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV029', CONCAT('CNTT-HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));


-- Sinh viên SV030
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV030', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV030', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV030', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV030', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV030', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV031
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV031', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV031', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV031', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV031', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV031', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV032
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV032', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV032', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV032', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV032', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV032', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV033
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV033', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV033', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV033', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV033', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV033', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV034
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV034', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV034', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV034', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV034', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV034', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

-- Sinh viên SV035
INSERT INTO DIEMTHI (DIEMGHP, DIEMKTHP, MASV, MAHOCPHAN)
VALUES
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV035', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV035', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV035', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV035', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3))),
(ROUND(RAND() * 10, 1), ROUND(RAND() * 10, 1), 'SV035', CONCAT('HP', RIGHT('00' + CAST(FLOOR(1 + RAND() * 20) AS VARCHAR), 3)));

--W2
INSERT INTO ThoiKhoaBieu (Thu, Tuan, TietHoc, PhongHoc, MaLop, MaHocPhan, Magiangvien)
VALUES
(2, 1, '1-3', '112', 'W.2', 'CNTT-HP001', 'GV001'),
(3, 1, '4-6', '201', 'W.2', 'CNTT-HP002', 'GV002'),
(4, 1, '7-9', '502', 'W.2', 'CNTT-HP003', 'GV003'),
(5, 1, '1-3', '204', 'W.2', 'CNTT-HP004', 'GV004'),
(6, 1, '4-6', '305', 'W.2', 'CNTT-HP005', 'GV005'),
(7, 1, '2-6', '308', 'W.2', 'CNTT-HP006', 'GV005'),

(2, 2, '7-9', '106', 'W.2', 'NN-HP001', 'GV006'),
(3, 2, '1-3', '207', 'W.2', 'NN-HP002', 'GV007'),
(4, 2, '4-6', '408', 'W.2', 'NN-HP003', 'GV008'),
(5, 2, '7-9', '509', 'W.2', 'NN-HP004', 'GV009'),
(6, 2, '10-11', '110', 'W.2', 'NN-HP010', 'GV010'),
(7, 2, '4-8', '404', 'W.2', 'CNTT-HP014', 'GV014'),


(2, 3, '6-10', '106', 'W.2', 'CNTT-HP016', 'GV016'),
(3, 3, '7-11', '207', 'W.2', 'CNTT-HP017', 'GV017'),
(4, 3, '1-5', '308', 'W.2', 'CNTT-HP018', 'GV018'),
(5, 3, '2-6', '409', 'W.2', 'CNTT-HP019', 'GV019'),
(6, 3, '3-7', '510', 'W.2', 'CNTT-HP020', 'GV020'),
(7, 3, '6-10', '106', 'W.2', 'CNTT-HP016', 'GV016'),

(2, 4, '1-5', '101', 'W.2', 'CNTT-HP011', 'GV011'),
(3, 4, '2-6', '202', 'W.2', 'CNTT-HP012', 'GV012'),
(4, 4, '3-7', '303', 'W.2', 'CNTT-HP013', 'GV013'),
(5, 4, '4-8', '404', 'W.2', 'CNTT-HP014', 'GV014'),
(6, 4, '5-9', '505', 'W.2', 'CNTT-HP015', 'GV015'),
(7, 4, '1-5', '101', 'W.2', 'CNTT-HP011', 'GV011'),

(2, 5, '6-10', '106', 'W.2', 'CNTT-HP016', 'GV016'),
(3, 5, '7-11', '207', 'W.2', 'CNTT-HP017', 'GV017'),
(4, 5, '1-5', '308', 'W.2', 'CNTT-HP018', 'GV018'),
(5, 5, '2-6', '409', 'W.2', 'CNTT-HP019', 'GV019'),
(6, 5, '3-7', '510', 'W.2', 'CNTT-HP020', 'GV020'),
(7, 5, '6-10', '106', 'W.2', 'CNTT-HP016', 'GV016');

--W1
INSERT INTO ThoiKhoaBieu (Thu, Tuan, TietHoc, PhongHoc, MaLop, MaHocPhan, Magiangvien)
VALUES
    (2, 1, '1-3', '112', 'W.1', 'CNTT-HP001', 'GV001'),
    (3, 1, '4-6', '201', 'W.1', 'CNTT-HP002', 'GV002'),
    (4, 1, '7-9', '502', 'W.1', 'CNTT-HP003', 'GV003'),
    (5, 1, '1-3', '204', 'W.1', 'CNTT-HP004', 'GV004'),
    (6, 1, '4-6', '305', 'W.1', 'CNTT-HP005', 'GV005'),
    (7, 1, '2-6', '308', 'W.1', 'CNTT-HP006', 'GV005'),

    (2, 2, '7-9', '106', 'W.1', 'NN-HP001', 'GV006'),
    (3, 2, '1-3', '207', 'W.1', 'NN-HP002', 'GV007'),
    (4, 2, '4-6', '408', 'W.1', 'NN-HP003', 'GV008'),
    (5, 2, '7-9', '509', 'W.1', 'NN-HP011', 'GV009'),
    (6, 2, '10-11', '110', 'W.1', 'NN-HP009', 'GV010'),
    (7, 2, '4-8', '404', 'W.1', 'CNTT-HP014', 'GV014'),

    (2, 3, '6-10', '106', 'W.1', 'CNTT-HP016', 'GV016'),
    (3, 3, '7-11', '207', 'W.1', 'CNTT-HP017', 'GV017'),
    (4, 3, '1-5', '308', 'W.1', 'CNTT-HP018', 'GV018'),
    (5, 3, '2-6', '409', 'W.1', 'CNTT-HP019', 'GV019'),
    (6, 3, '3-7', '510', 'W.1', 'CNTT-HP020', 'GV020'),
    (7, 3, '6-10', '106', 'W.1', 'CNTT-HP016', 'GV016'),

    (2, 4, '1-5', '101', 'W.1', 'CNTT-HP011', 'GV011'),
    (3, 4, '2-6', '202', 'W.1', 'CNTT-HP012', 'GV012'),
    (4, 4, '3-7', '303', 'W.1', 'CNTT-HP013', 'GV013'),
    (5, 4, '4-8', '404', 'W.1', 'CNTT-HP014', 'GV014'),
    (6, 4, '5-9', '505', 'W.1', 'CNTT-HP015', 'GV015'),
    (7, 4, '1-5', '101', 'W.1', 'CNTT-HP011', 'GV011'),

    (2, 5, '6-10', '106', 'W.1', 'CNTT-HP016', 'GV016'),
    (3, 5, '7-11', '207', 'W.1', 'CNTT-HP017', 'GV017'),
    (4, 5, '1-5', '308', 'W.1', 'CNTT-HP018', 'GV018'),
    (5, 5, '2-6', '409', 'W.1', 'CNTT-HP019', 'GV019'),
    (6, 5, '3-7', '510', 'W.1', 'CNTT-HP020', 'GV020'),
    (7, 5, '6-10', '106', 'W.1', 'CNTT-HP016', 'GV016');

INSERT INTO ThoiKhoaBieu (Thu, Tuan, TietHoc, PhongHoc, MaLop, MaHocPhan, Magiangvien)
VALUES
    (2, 1, '1-3', '112', 'Data.1', 'CNTT-HP020', 'GV001'),
    (3, 1, '4-6', '201', 'Data.1', 'CNTT-HP019', 'GV002'),
    (4, 1, '7-9', '502', 'Data.1', 'CNTT-HP018', 'GV003'),
    (5, 1, '1-3', '204', 'Data.1', 'CNTT-HP017', 'GV004'),
    (6, 1, '4-6', '305', 'Data.1', 'CNTT-HP016', 'GV005'),
    (7, 1, '2-6', '308', 'Data.1', 'CNTT-HP015', 'GV005'),

    (2, 2, '7-9', '106', 'Data.1', 'NN-HP009', 'GV006'),
    (3, 2, '1-3', '207', 'Data.1', 'NN-HP010', 'GV007'),
    (4, 2, '4-6', '408', 'Data.1', 'NN-HP011', 'GV008'),
    (5, 2, '7-9', '509', 'Data.1', 'NN-HP012', 'GV009'),
    (6, 2, '10-11', '110', 'Data.1', 'NN-HP002', 'GV010'),
    (7, 2, '4-8', '404', 'Data.1', 'CNTT-HP014', 'GV014'),

    (2, 3, '6-10', '106', 'Data.1', 'CNTT-HP013', 'GV016'),
    (3, 3, '7-11', '207', 'Data.1', 'CNTT-HP012', 'GV017'),
    (4, 3, '1-5', '308', 'Data.1', 'CNTT-HP011', 'GV018'),
    (5, 3, '2-6', '409', 'Data.1', 'CNTT-HP010', 'GV019'),
    (6, 3, '3-7', '510', 'Data.1', 'CNTT-HP009', 'GV020'),
    (7, 3, '6-10', '106', 'Data.1', 'CNTT-HP008', 'GV016'),

    (2, 4, '1-5', '101', 'Data.1', 'CNTT-HP007', 'GV011'),
    (3, 4, '2-6', '202', 'Data.1', 'CNTT-HP006', 'GV012'),
    (4, 4, '3-7', '303', 'Data.1', 'CNTT-HP005', 'GV013'),
    (5, 4, '4-8', '404', 'Data.1', 'CNTT-HP004', 'GV014'),
    (6, 4, '5-9', '505', 'Data.1', 'CNTT-HP003', 'GV015'),
    (7, 4, '1-5', '101', 'Data.1', 'CNTT-HP002', 'GV011'),

    (2, 5, '6-10', '106', 'Data.1', 'CNTT-HP001', 'GV016'),
    (3, 5, '7-11', '207', 'Data.1', 'CNTT-HP020', 'GV017'),
    (4, 5, '1-5', '308', 'Data.1', 'CNTT-HP019', 'GV018'),
    (5, 5, '2-6', '409', 'Data.1', 'CNTT-HP018', 'GV019'),
    (6, 5, '3-7', '510', 'Data.1', 'CNTT-HP017', 'GV020'),
    (7, 5, '6-10', '106', 'Data.1', 'CNTT-HP016', 'GV016');
INSERT INTO ThoiKhoaBieu (Thu, Tuan, TietHoc, PhongHoc, MaLop, MaHocPhan, Magiangvien)
VALUES
    (2, 1, '1-3', '112', 'Data.2', 'CNTT-HP016', 'GV001'),
    (3, 1, '4-6', '201', 'Data.2', 'CNTT-HP017', 'GV002'),
    (4, 1, '7-9', '502', 'Data.2', 'CNTT-HP018', 'GV003'),
    (5, 1, '1-3', '204', 'Data.2', 'CNTT-HP019', 'GV004'),
    (6, 1, '4-6', '305', 'Data.2', 'CNTT-HP020', 'GV005'),
    (7, 1, '2-6', '308', 'Data.2', 'CNTT-HP001', 'GV005'),

    (2, 2, '7-9', '106', 'Data.2', 'CNTT-HP002', 'GV006'),
    (3, 2, '1-3', '207', 'Data.2', 'CNTT-HP003', 'GV007'),
    (4, 2, '4-6', '408', 'Data.2', 'CNTT-HP004', 'GV008'),
    (5, 2, '7-9', '509', 'Data.2', 'CNTT-HP005', 'GV009'),
    (6, 2, '10-11', '110', 'Data.2', 'CNTT-HP006', 'GV010'),
    (7, 2, '4-8', '404', 'Data.2', 'CNTT-HP007', 'GV014'),

    (2, 3, '6-10', '106', 'Data.2', 'CNTT-HP008', 'GV016'),
    (3, 3, '7-11', '207', 'Data.2', 'CNTT-HP009', 'GV017'),
    (4, 3, '1-5', '308', 'Data.2', 'CNTT-HP010', 'GV018'),
    (5, 3, '2-6', '409', 'Data.2', 'CNTT-HP011', 'GV019'),
    (6, 3, '3-7', '510', 'Data.2', 'CNTT-HP012', 'GV020'),
    (7, 3, '6-10', '106', 'Data.2', 'CNTT-HP013', 'GV016'),

    (2, 4, '1-5', '101', 'Data.2', 'CNTT-HP014', 'GV011'),
    (3, 4, '2-6', '202', 'Data.2', 'CNTT-HP015', 'GV012'),
    (4, 4, '3-7', '303', 'Data.2', 'CNTT-HP016', 'GV013'),
    (5, 4, '4-8', '404', 'Data.2', 'CNTT-HP017', 'GV014'),
    (6, 4, '5-9', '505', 'Data.2', 'CNTT-HP018', 'GV015'),
    (7, 4, '1-5', '101', 'Data.2', 'CNTT-HP019', 'GV011'),

    (2, 5, '6-10', '106', 'Data.2', 'CNTT-HP020', 'GV016'),
    (3, 5, '7-11', '207', 'Data.2', 'CNTT-HP001', 'GV017'),
    (4, 5, '1-5', '308', 'Data.2', 'CNTT-HP002', 'GV018'),
    (5, 5, '2-6', '409', 'Data.2', 'CNTT-HP003', 'GV019'),
    (6, 5, '3-7', '510', 'Data.2', 'CNTT-HP004', 'GV020'),
    (7, 5, '6-10', '106', 'Data.2', 'CNTT-HP005', 'GV016');


--Procedure & trigger

select * from CHUYENNGANH
select * from diemthi   
select * from GIANGDAY
select * from GIANGVIEN
select * from HOCPHAN
select * from khoa
select * from LOPHOC
select * from NGANH
select * from NGUOITHAN
select * from SinhVien
select * from TAIKHOAN
select * from thoikhoabieu

--trigger update số lượng sinh viên của lớp
go
CREATE OR ALTER TRIGGER UpdateSISO
ON SINHVIEN
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Cập nhật cột SISO trong bảng LOPHOC
    UPDATE LOPHOC
    SET SISO = (
        SELECT COUNT(*)
        FROM INSERTED i
        WHERE LOPHOC.MALOP = i.MALOP
    )
    FROM LOPHOC
    INNER JOIN INSERTED ON LOPHOC.MALOP = INSERTED.MALOP;
END;
GO

--thông tin sinh viên
ALTER proc USP_ThongTinSinhVien
AS
BEGIN
    SELECT SinhVien.MASV AS [Mã SV], SINHVIEN.HOTEN [Họ Tên], GIOITINH [Giới Tính], DANTOC [Dân Tộc], 
    format(CAST(SinhVien.NGAYSINH AS DATE),'dd/MM/yyyy') [Ngày Sinh], DIACHI [Địa Chỉ], SINHVIEN.SODIENTHOAI [Số Điện Thoại], DIACHIEMAIL [Email],
    CCCD [Số CCCD], NienKhoa [Niên Khóa], NamNhapHoc [Năm Nhập Học], HeDaoTao [Hệ Đào Tạo], lophoc.MALOP [Lớp], TENCHUYENNGANH [Chuyên Ngành], 
    NGUOITHAN.HOTEN [Học Tên NT], QUANHE [Quan Hệ], format(CAST(NGUOITHAN.NGAYSINH AS DATE), 'dd/MM/yyyy') [Ngày sinh NT],
    NGUOITHAN.SODIENTHOAI [Số Điện Thoại NT]
    FROM SinhVien
    INNER JOIN NGUOITHAN ON SinhVien.MASV = NGUOITHAN.MASV
    INNER JOIN LOPHOC ON SinhVien.MALOP = LOPHOC.MALOP
    INNER JOIN CHUYENNGANH ON LOPHOC.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
END
GO

--thêm sinh viên mới
sp_helptext UPDATEsiso
SELECT * FROM SINHVIEN
SELECT * FROM LOPHOC
GO
ALTER PROC USP_AddHoSoSinhVien(
    @MASV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @DANTOC NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SDT VARCHAR(120),
    @EMAIL VARCHAR(120),
    @SOCCCD VARCHAR(20),
    @NIENKHOA NVARCHAR(20),
    @NAMNHAPHOC VARCHAR(10),
    @MALOP VARCHAR(10),

    @HOTENNT NVARCHAR(50),
    @QUANHE NVARCHAR(50),
    @NGAYSINHNT DATE,
    @SDTNT VARCHAR(20)
)
as
BEGIN
    INSERT INTO SinhVien (MASV, HOTEN, GIOITINH, DANTOC, NGAYSINH, DIACHI, SODIENTHOAI, DIACHIEMAIL, CCCD, NIENKHOA, NAMNHAPHOC, MALOP) VALUES
    (@MASV, @HOTEN, @GIOITINH, @DANTOC, @NGAYSINH, @DIACHI, @SDT, @EMAIL, @SOCCCD, @NIENKHOA, @NAMNHAPHOC, @MALOP)

    insert into NGUOITHAN(HOTEN, QUANHE, NGAYSINH, SODIENTHOAI, MASV) VALUES
    (@HOTENNT, @QUANHE, @NGAYSINHNT, @SDTNT, @MASV)

    INSERT INTO TAIKHOAN(USERNAME, [PASSWORD], PHONENUMBER, EMAILADDRESS, NGAYTAO)
    VALUES(@MASV, @MASV, @SDT, @EMAIL, GETDATE())
END
GO

select * from taikhoan
insert into TAIKHOAN(USERNAME, [PASSWORD], ACCOUNTTYPE, NGAYTAO) 
values('kd123', '123', 'User', GETDATE() )
end

AddNguoiThan 'dangthang', 'bo', '1965-03-15 00:00:00.000', '0354857345', 'sv001'
select * from SinhVien
GO

CREATE PROC USP_UPDATESTUDENT(
    @MASV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @DANTOC NVARCHAR(10),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SDT VARCHAR(120),
    @EMAIL VARCHAR(120),
    @SOCCCD VARCHAR(20),
    @NIENKHOA NVARCHAR(20),
    @NAMNHAPHOC VARCHAR(10),
    @MALOP VARCHAR(10),

    @HOTENNT NVARCHAR(50),
    @QUANHE NVARCHAR(50),
    @NGAYSINHNT DATE,
    @SDTNT VARCHAR(20)
)
AS
BEGIN
    UPDATE SinhVien
    SET HOTEN = @HOTEN, GIOITINH = @GIOITINH, DANTOC = @DANTOC, NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, SODIENTHOAI = @SDT, DIACHIEMAIL = @EMAIL,
    CCCD = @SOCCCD, NIENKHOA = @NIENKHOA, NAMNHAPHOC = @NAMNHAPHOC, MALOP = @MALOP
    WHERE MASV = @MASV
    UPDATE NGUOITHAN 
    SET HOTEN = @HOTENNT, QUANHE = @QUANHE, NGAYSINH = @NGAYSINHNT, SODIENTHOAI = @SDTNT
    WHERE MASV = @MASV
END
GO

alter PROCEDURE USP_DELETESTUDENT(
    @MASV VARCHAR(10)
)
AS
BEGIN
    DELETE FROM SinhVien
    WHERE MASV = @MASV

    delete from TAIKHOAN
    where USERNAME = @MASV
END
GO

select * from sinhvien

go

alter view v_SinhVien AS
SELECT SinhVien.MASV AS [Mã SV], SINHVIEN.HOTEN [Tên], GIOITINH [Giới Tính], DANTOC [Dân Tộc], 
    format(CAST(SinhVien.NGAYSINH AS DATE),'dd/MM/yyyy') [Ngày Sinh], DIACHI [Địa Chỉ], SINHVIEN.SODIENTHOAI [Số Điện Thoại], DIACHIEMAIL [Email],
    CCCD [Số CCCD], NienKhoa [Niên Khóa], NamNhapHoc [Năm Nhập Học], HeDaoTao [Hệ Đào Tạo], lophoc.MALOP [Lớp], TENCHUYENNGANH [Chuyên Ngành], 
    NGUOITHAN.HOTEN [Học Tên NT], QUANHE [Quan Hệ], format(CAST(NGUOITHAN.NGAYSINH AS DATE), 'dd/MM/yyyy') [Ngày sinh NT],
    NGUOITHAN.SODIENTHOAI [Số Điện Thoại NT]
    FROM SinhVien
    INNER JOIN NGUOITHAN ON SinhVien.MASV = NGUOITHAN.MASV
    INNER JOIN LOPHOC ON SinhVien.MALOP = LOPHOC.MALOP
    INNER JOIN CHUYENNGANH ON LOPHOC.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
GO


alter PROCEDURE USP_SEARCH_STUDENT
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX); 
    BEGIN
    SET @sql = 'SELECT * FROM v_sinhvien WHERE ' + '[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
        N'@SearchValue NVARCHAR(50)',
        @SearchValue;
    END
END
GO


--Giảng Viên
alter proc USP_GetAllGiangVien
AS
BEGIN
    select MAGIANGVIEN [Mã Giảng Viên], TENGIANGVIEN [Họ Tên], GIOITINH [Giới Tính], TRINHDO [Trình Độ], 
    format(CAST(NGAYSINH AS DATE),'dd/MM/yyyy') [Ngày Sinh], DIACHI [Địa Chỉ], CCCD [SỐ CCCD], SODIENTHOAI [Số Điện Thoại], MAKHOA [Mã Khoa]
    from GIANGVIEN
END 
GO

CREATE PROCEDURE USP_INSERT_GIANGVIEN
    @MAGV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @TRINHDO NVARCHAR(50),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SOCCCD VARCHAR(20),
    @SODIENTHOAI VARCHAR(20),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    INSERT INTO GiangVien (MAGIANGVIEN, TENGIANGVIEN, GIOITINH, TRINHDO, NGAYSINH, DIACHI, CCCD, SODIENTHOAI, MAKHOA)
    VALUES (@MAGV, @HOTEN, @GIOITINH, @TRINHDO, @NGAYSINH,  @DIACHI, @SOCCCD, @SODIENTHOAI, @MAKHOA);
END
GO

alter PROCEDURE USP_UPDATE_GIANGVIEN
    @MAGV VARCHAR(10),
    @HOTEN NVARCHAR(50),
    @GIOITINH NVARCHAR(10),
    @TRINHDO nvarchar(50),
    @NGAYSINH DATE,
    @DIACHI NVARCHAR(100),
    @SOCCCD VARCHAR(20),
    @SODIENTHOAI VARCHAR(20),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    UPDATE GiangVien
    SET 
        TENGIANGVIEN = @HOTEN,
        GIOITINH = @GIOITINH,
        TRINHDO = @TRINHDO,
        NGAYSINH = @NGAYSINH,
        DIACHI = @DIACHI,
        CCCD = @SOCCCD,
        SODIENTHOAI = @SODIENTHOAI,
        MAKHOA = @MAKHOA
    WHERE MAGIANGVIEN = @MAGV;
END
go

create proc USP_DeleteGiangVien(
    @magv varchar(10)
)
AS
BEGIN
    DELETE from GIANGVIEN where MAGIANGVIEN = @magv
END 
GO
alter view v_GiangVien AS
    select MAGIANGVIEN [Mã GV], TENGIANGVIEN [Họ Tên], GIOITINH [Giới Tính], TRINHDO [Trình Độ], 
    format(CAST(NGAYSINH AS DATE),'dd/MM/yyyy') [Ngày Sinh], DIACHI [Địa Chỉ], CCCD [SỐ CCCD], SODIENTHOAI [Số Điện Thoại], MAKHOA [Khoa]
    from GIANGVIEN
go


alter PROCEDURE USP_SearchLecture
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    BEGIN
    SET @sql = 'SELECT * FROM v_GiangVien WHERE ' +'[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
        N'@SearchValue NVARCHAR(50)',
        @SearchValue;
    END
END
GO

--
--
--
--
--ĐIỂM THi
alter proc USP_GetAllScore
AS
BEGIN
    select DIEMTHI.ID as STT, DIEMTHI.MASV [Mã SV], SinhVien.HOTEN [Họ Tên], NGAYSINH [Ngày Sinh], LOPHOC.MALOP [Lớp], HOCPHAN.TENHOCPHAN [Học Phần], 
    DIEMGHP [Điểm GHP], DIEMKTHP [Điểm KTHP], round(DIEMTBC,2) [Điểm TBC]
    from DIEMTHI
    INNER JOIN HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN
    INNER join SinhVien on SinhVien.MASV = DIEMTHI.MASV
    inner join LOPHOC on SinhVien.MALOP = LOPHOC.MALOP
END
GO


Create PROCEDURE USP_InsertScore
    @DIEMGHP FLOAT,
    @DIEMKTHP FLOAT,
    @MASINHVIEN VARCHAR(10),
    @MAHOCPHAN VARCHAR(10)
AS
BEGIN
    INSERT INTO DiemThi (DIEMGHP, DIEMKTHP, MASV, MaHocPhan)
    VALUES (@DIEMGHP, @DIEMKTHP, @MASINHVIEN, @MAHOCPHAN);
END
GO


Create PROCEDURE USP_UpdateScore
    @DIEMGHP FLOAT,
    @DIEMKTHP FLOAT,
    @MASINHVIEN VARCHAR(10),
    @MAHOCPHAN VARCHAR(10)
AS
BEGIN
    UPDATE DiemThi
    SET DIEMGHP = @DIEMGHP, DIEMKTHP = @DIEMKTHP
    WHERE MASV = @MASINHVIEN AND MaHocPhan = @MAHOCPHAN;
END
go

alter view v_DiemByLop as
    select DIEMTHI.ID as STT, DIEMTHI.MASV [Mã SV], SinhVien.HOTEN [Họ Tên], NGAYSINH [Ngày Sinh], LOPHOC.MALOP [Lớp], HOCPHAN.TENHOCPHAN [Học Phần], 
    DIEMGHP [Điểm GHP], DIEMKTHP [Điểm KTHP], round(DIEMTBC,2) [Điểm TBC]
    from DIEMTHI
    INNER JOIN HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN
    INNER join SinhVien on SinhVien.MASV = DIEMTHI.MASV
    inner join LOPHOC on SinhVien.MALOP = LOPHOC.MALOP
GO


alter view v_SearchByMonHoc as
    select DIEMTHI.ID as STT, DIEMTHI.MASV [Mã SV], SinhVien.HOTEN [Họ Tên], NGAYSINH [Ngày Sinh], LOPHOC.MALOP [Lớp], HOCPHAN.TENHOCPHAN [Học Phần], 
    DIEMGHP [Điểm GHP], DIEMKTHP [Điểm KTHP], round(DIEMTBC,2) [Điểm TBC]
    from DIEMTHI
    INNER JOIN HOCPHAN on DIEMTHI.MAHOCPHAN = HOCPHAN.MAHOCPHAN
    INNER join SinhVien on SinhVien.MASV = DIEMTHI.MASV
    inner join LOPHOC on SinhVien.MALOP = LOPHOC.MALOP
GO

select * from v_SearchByMonHoc
go
alter PROCEDURE USP_SearchScore
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    BEGIN
    SET @sql = 'SELECT * FROM v_SearchByMonHoc WHERE ' + '[' + @SearchColumn  +  ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END
GO

alter proc GetAllLopHoc
AS
BEGIN
    select MALOP [Mã Lớp], TENLOP [Tên Lớp], CHUYENNGANH.TENCHUYENNGANH [Chuyên Ngành], NGANH.TENNGANH [Ngành], HEDAOTAO [Hệ Đào Tạo], SISO [Sĩ Số]
    from LOPHOC
    inner join CHUYENNGANH on LOPHOC.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
    inner join NGANH on CHUYENNGANH.MANGANH = nganh.MANGANH
END
GO

go
alter proc USP_GetAllClass
AS
BEGIN
SELECT MALOP [Mã Lớp], TENLOP [Tên Lớp], GIANGVIEN.TENGIANGVIEN [GV Chủ Nhiệm], SODIENTHOAI [Số Điện Thoại], HEDAOTAO [Hệ Đào Tạo], SISO [Sĩ Số] ,
       TENCHUYENNGANH [Chuyên Ngành], TENNGANH [Ngành], THOIGIANDAOTAO [Thời Gian Đào Tạo(Năm)]
        FROM LOPHOC 
        INNER JOIN CHUYENNGANH ON LOPHOC.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
        inner join GIANGVIEN on GIANGVIEN.MAGIANGVIEN = LOPHOC.MAGIANGVIEN
        inner join NGANH on CHUYENNGANH.MANGANH = NGANH.MANGANH
END
GO

go
alter PROCEDURE USP_InsertClass
    @MALOP VARCHAR(10),
    @TENLOP NVARCHAR(50),
    @HEDAOTAO NVARCHAR(50),
    @MAGIANGVIEN VARCHAR(10),
    @MACHUYENNGANH VARCHAR(10)
AS
BEGIN
    INSERT INTO LOPHOC (MaLop, TenLop, HEDAOTAO, MAGIANGVIEN, MACHUYENNGANHNGANH)
    VALUES (@MALOP, @TENLOP, @HEDAOTAO, @MAGIANGVIEN, @MACHUYENNGANH);
END
GO

alter PROCEDURE USP_UpdateClass
    @MALOP VARCHAR(10),
    @TENLOP NVARCHAR(50),
    @HEDAOTAO NVARCHAR(50),
    @MAGIANGVIEN VARCHAR(10),
    @MACHUYENNGANH VARCHAR(10)
AS
BEGIN
    UPDATE LOPHOC
    SET TenLop = @TENLOP, HEDAOTAO = @HEDAOTAO, 
    MAGIANGVIEN = @MAGIANGVIEN, MACHUYENNGANHNGANH = @MACHUYENNGANH
    WHERE MaLop = @MALOP;
END
GO

create view v_LopHoc AS
SELECT MALOP [Mã Lớp], TENLOP [Tên Lớp], GIANGVIEN.TENGIANGVIEN [GV Chủ Nhiệm], SODIENTHOAI [Số Điện Thoại], HEDAOTAO [Hệ Đào Tạo], SISO [Sĩ Số] ,
       TENCHUYENNGANH as [Chuyên Ngành], TENNGANH [Ngành], THOIGIANDAOTAO [Thời Gian Đào Tạo(Năm)]
        FROM LOPHOC 
        INNER JOIN CHUYENNGANH ON LOPHOC.MACHUYENNGANHNGANH = CHUYENNGANH.MACHUYENNGANHNGANH
        inner join GIANGVIEN on GIANGVIEN.MAGIANGVIEN = LOPHOC.MAGIANGVIEN
        inner join NGANH on CHUYENNGANH.MANGANH = NGANH.MANGANH
GO


alter PROCEDURE USP_SearchClass
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    BEGIN
    SET @sql = 'SELECT * FROM v_LopHoc WHERE ' + '[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END


--Chuyên ngành
select * from chuyennganh
GO
alter proc USP_GetAllChuyenNganh
As
BEGIN
    SELECT CHUYENNGANH.STT, MACHUYENNGANHNGANH [Mã Chuyên Ngành], TENCHUYENNGANH [Tên Chuyên Ngành], 
    THOIGIANDAOTAO [Thời Gian Đào Tạo(Năm)], NGANH.TENNGANH [Ngành], TENKHOA [Khoa]
    from CHUYENNGANH 
    inner join NGANH on CHUYENNGANH.MANGANH = NGANH.MANGANH
    inner join KHOA on NGANH.MAKHOA = KHOA.MAKHOA
END 
GO


CREATE PROCEDURE USP_INSERT_CHUYENNGANH
    @MACHUYENNGANH VARCHAR(10),
    @TENCHUYENNGANH NVARCHAR(50),
    @THOIGIANDAOTAO INT,
    @MANGANH VARCHAR(10)
AS
BEGIN
    INSERT INTO ChuyenNganh (MACHUYENNGANHNGANH, TenChuyenNganh, THOIGIANDAOTAO, MANGANH)
    VALUES (@MACHUYENNGANH, @TENCHUYENNGANH, @THOIGIANDAOTAO, @MANGANH);
END

go
CREATE PROCEDURE USP_UPDATE_CHUYENNGANH
    @MACHUYENNGANH VARCHAR(10),
    @TENCHUYENNGANH NVARCHAR(50),
    @THOIGIANDAOTAO INT,
    @MANGANH VARCHAR(10)
AS
BEGIN
    UPDATE ChuyenNganh
    SET TenChuyenNganh = @TENCHUYENNGANH,
        THOIGIANDAOTAO = @THOIGIANDAOTAO,
        MANGANH = @MANGANH
    WHERE MACHUYENNGANHNGANH = @MACHUYENNGANH;
END
GO

CREATE VIEW v_SearchChuyenNganh
AS
    SELECT CHUYENNGANH.STT, MACHUYENNGANHNGANH [Mã Chuyên Ngành], TENCHUYENNGANH [Tên Chuyên Ngành], 
    THOIGIANDAOTAO [Thời Gian Đào Tạo(Năm)], NGANH.TENNGANH [Ngành], TENKHOA [Khoa]
    from CHUYENNGANH 
    inner join NGANH on CHUYENNGANH.MANGANH = NGANH.MANGANH
    inner join KHOA on NGANH.MAKHOA = KHOA.MAKHOA
go



alter PROCEDURE USP_SearchChuyenNganh
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    IF (@SearchColumn = 'Mã Chuyên Ngành')
    BEGIN
        select * from CHUYENNGANH where  MACHUYENNGANHNGANH = @SearchValue
    END
    ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_SearchChuyenNganh WHERE ' + '[' +  @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

select * from HOCPHAN
select * from GIANGVIEN


-----------------------------------------------------
--Học Phần
go
create proc USP_GetAllHocPhan
as
BEGIN
    select hocphan.STT, MAHOCPHAN as [Mã Học Phần],  TENHOCPHAN [Tên Học Phần], SOTC [Số Tín Chỉ], SOTIET [Số Tiết], LOAIHP [Loại Học Phần], TENKHOA [Khoa]
    from HOCPHAN 
    inner join KHOA on HOCPHAN.MAKHOA = KHOA.MAKHOA
end
go  

alter PROCEDURE USP_INSERT_HOCPHAN
    @MAHOCPHAN VARCHAR(10),
    @TENHOCPHAN NVARCHAR(50),
    @SOTINCHI INT,
    @LOAIHOCPHAN NVARCHAR(50),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    INSERT INTO HocPhan (MaHocPhan, TenHocPhan, SOTC, LOAIHP, MaKhoa)
    VALUES (@MAHOCPHAN, @TENHOCPHAN, @SOTINCHI, @LOAIHOCPHAN, @MAKHOA);
END
go      

alter PROCEDURE USP_UPDATE_HOCPHAN
    @MAHOCPHAN VARCHAR(10),
    @TENHOCPHAN NVARCHAR(50),
    @SOTINCHI INT,
    @LOAIHOCPHAN NVARCHAR(50),
    @MAKHOA VARCHAR(10)
AS
BEGIN
    UPDATE HocPhan
    SET TenHocPhan = @TENHOCPHAN,
        SOTC = @SOTINCHI,
        LOAIHP = @LOAIHOCPHAN,
        MaKhoa = @MAKHOA
    WHERE MaHocPhan = @MAHOCPHAN;
END
GO


CREATE proc USP_DeleteHocPhan(
    @mahp VARCHAR(10)
)
AS
BEGIN
    DELETE HOCPHAN
    where MAHOCPHAN = @mahp
END
GO


create view v_HocPhan AS    
    select hocphan.STT, MAHOCPHAN as [Mã Học Phần],  TENHOCPHAN [Tên Học Phần], SOTC [Số Tín Chỉ], SOTIET [Số Tiết], LOAIHP [Loại Học Phần], TENKHOA [Khoa]
    from HOCPHAN 
    inner join KHOA on HOCPHAN.MAKHOA = KHOA.MAKHOA
go


alter PROCEDURE USP_SearchSubject
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    -- IF (@SearchColumn = 'Mã Học Phần')
    -- BEGIN
    --     select * from v_HocPhan where  [Mã Học Phần] = @SearchValue
    -- END
    -- ELSE
    BEGIN
    SET @sql = 'SELECT * FROM v_HocPhan WHERE ' + '[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END
GO

------------------------------------
--Khoa
go
create proc USP_GetAllFaculty
as
BEGIN
    select STT, MAKHOA [Mã Khoa], TENKHOA [Tên Khoa], SDT [Số Điện Thoại], Email [Địa Chỉ Email]
    from KHOA
end
go  

Create PROCEDURE USP_InsertFaculty
    @MAKHOA VARCHAR(10),
    @TENKHOA NVARCHAR(50),
    @SDT INT,
    @EMAIL NVARCHAR(50)
AS
BEGIN
    INSERT INTO KHOA (MAKHOA, TENKHOA, SDT, Email)
    VALUES (@MAKHOA, @TENKHOA, @SDT, @EMAIL);
END
go      

Create PROCEDURE USP_UpdateFaculty
    @MAKHOA VARCHAR(10),
    @TENKHOA NVARCHAR(50),
    @SDT INT,
    @EMAIL NVARCHAR(50)
AS
BEGIN
    UPDATE KHOA
    SET TENKHOA = @TENKHOA,
        SDT = @SDT,
        Email = @EMAIL
    WHERE MAKHOA = @MAKHOA;
END
GO


CREATE proc USP_DeleteFaculty(
    @MAKHOA VARCHAR(10)
)
AS
BEGIN
    DELETE KHOA
    where MAKHOA = @MAKHOA
END
GO


create view v_Khoa AS    
    select STT, MAKHOA [Mã Khoa], TENKHOA [Tên Khoa], SDT [Số Điện Thoại], Email [Địa Chỉ Email]
    from KHOA
go


Create PROCEDURE USP_SearchFaculty
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    BEGIN
    SET @sql = 'SELECT * FROM v_Khoa WHERE ' + '[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END

select * from NGANH
--Ngành
go
create proc USP_GetAllNganh
as
BEGIN
    select NGANH.STT, MANGANH [Mã Ngành], TENNGANH [Tên Ngành], KHOA.TENKHOA [Khoa]
    from NGANH
    inner join KHOA on NGANH.MAKHOA = KHOA.MAKHOA
end
go  


alter PROCEDURE USP_InsertNganh
    @MANGANH VARCHAR(10),
    @TENNGANH NVARCHAR(50),
    @MAKHOA NVARCHAR(10)
AS
BEGIN
    INSERT INTO NGANH (MANGANH, TENNGANH, MAKHOA)
    VALUES (@MANGANH, @TENNGANH, @MAKHOA);
END
go      

Create PROCEDURE USP_UpdateNganh
    @MANGANH VARCHAR(10),
    @TENNGANH NVARCHAR(50),
    @MAKHOA NVARCHAR(10)
AS
BEGIN
    UPDATE NGANH
    SET TENNGANH = @TENNGANH,
        MAKHOA = @MAKHOA
    WHERE MANGANH = @MANGANH;
END
GO


CREATE proc USP_DeleteNganh(
    @MANGANH VARCHAR(10)
)
AS
BEGIN
    DELETE NGANH
    where MANGANH = @MANGANH
END
GO


create view v_Nganh AS    
    select NGANH.STT, MANGANH [Mã Ngành], TENNGANH [Tên Ngành], KHOA.TENKHOA [Khoa]
    from NGANH
    inner join KHOA on NGANH.MAKHOA = KHOA.MAKHOA
go


Create PROCEDURE USP_SearchNganh
    @SearchColumn NVARCHAR(50),
    @SearchValue NVARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    BEGIN
    SET @sql = 'SELECT * FROM v_Nganh WHERE ' + '[' + @SearchColumn + ']' + ' LIKE ''%'' + @SearchValue + ''%''';
    EXEC sp_executesql @sql,
       N'@SearchValue NVARCHAR(50)',
       @SearchValue;
    END
END
GO


alter Proc USP_GetAllAccount
As
BEGIN
    Select id [STT], USERNAME [UserName], PHONENUMBER [Số Điện Thoại], 
    EMAILADDRESS [Email], ACCOUNTTYPE [Loại Tài Khoản], NGAYTAO [Ngày Tạo], LOGINLOG [Đăng Nhập Cuối]
    from TAIKHOAN
end
select * from TAIKHOAN

go      
create proc USP_AddAccount(
    @Username nvarchar(50),
    @Password nvarchar(50),
    @sdt nvarchar(50),
    @email nvarchar(50)
)
As  
BEGIN   
    Insert into TAIKHOAN(USERNAME, [PASSWORD], PHONENUMBER, EMAILADDRESS, NGAYTAO)
    VALUES(@Username, @Password, @sdt, @email, GETDATE())
END 

go
create proc USP_GetAccountsLogin(
    @Username nvarchar(50),
    @Password nvarchar(50)
)
As
BEGIN
    select * from TAIKHOAN where USERNAME =@Username and PASSWORD = @Password
END
GO

create proc USP_UpdateLoginLog(
    @Username nvarchar(50)
)
As
BEGIN
    update TAIKHOAN
    set LOGINLOG = GETDATE()
    where Username = @Username
END
GO      

create proc CheckTypeAccount(
    @UserName varchar(10)
)
As
BEGIN
    select * from taikhoan
    where username = @UserName and ACCOUNTTYPE = 'admin' or ACCOUNTTYPE = 'user'
end
go          

create proc GetAccountType(
    @UserName varchar(10)
)
As
BEGIN
    select ACCOUNTTYPE from taikhoan
    where username = @UserName
end
GO

alter PROCEDURE USP_ForgotPassword 
    @Username NVARCHAR(50), 
    @PhoneNumber NVARCHAR(20),
    @email nvarchar(50)
AS 
BEGIN 
    SELECT [PASSWORD]
    FROM TAIKHOAN 
    WHERE USERNAME = @Username 
      AND PHONENUMBER = @PhoneNumber and EMAILADDRESS = @email
END;
GO  

create proc USP_CheckEmail(
    @username nvarchar(50), 
    @email nvarchar(50)
)
As
BEGIN
 select * from TAIKHOAN 
 where USERNAME = @username and EMAILADDRESS = @email
END
GO  

alter proc USP_CheckPhoneNumber(
    @username nvarchar(50), 
    @PhoneNumber nvarchar(50)
)
As
BEGIN
 select * from TAIKHOAN 
 where USERNAME = @username and PHONENUMBER = @PhoneNumber
END
GO

alter proc USP_CheckExist(
    @username nvarchar(50)
)
As
BEGIN
 select * from TAIKHOAN 
 where USERNAME = @username
END

USP_CheckExist 'admin'
select * from TAIKHOAN

sp_helptext USP_CheckExist

select accounttype from taikhoan where username = 'user1' and (accounttype = 'admin' or accounttype = 'User')

select * from taikhoan
GO

create proc USP_GrantPermission(
    @us nvarchar(50),
    @permission NVARCHAR(50)
)
AS
BEGIN
    update TAIKHOAN 
    set ACCOUNTTYPE = @permission 
    where USERNAME = @us
END

sp_rename USP_UpdateAccount, USP_GrantPermission

select * from v_sinhvien

USP_CheckExist admin

select * from thoikhoabieu
where tuan =1

select distinct phonghoc from thoikhoabieu

select * from thoikhoabieu
where Tuan = 1 and malop = 'w.2'
GO

alter view v_Schedule
AS
    select Thu [Thứ], Tuan [Tuần], TietHoc [Tiết Học], PhongHoc[Phòng Học], 
            MaLop [Lớp], HOCPHAN.TENHOCPHAN [Học Phần], GIANGVIEN.TENGIANGVIEN [Giảng Viên], GIANGVIEN.SODIENTHOAI [Số Điện Thoại]
    from ThoiKhoaBieu
    inner join HOCPHAN on ThoiKhoaBieu.MaHocPhan = HOCPHAN.MAHOCPHAN
    inner join GIANGVIEN on ThoiKhoaBieu.Magiangvien = giangvien.MAGIANGVIEN
GO  

select * from v_Schedule

go  
create proc USP_GetScheduleByWeekAndClass(
    @week int,
    @malop nvarchar(50)
)
as
BEGIN
    select *
    from v_Schedule 
    where [Tuần] = @week and [Lớp] = @malop
END

USP_GetScheduleByWeek 1, 'w.2'
GO

create proc USP_GetScheduleByWeek(
    @week int
)
as
BEGIN
    select *
    from v_Schedule 
    where [Tuần] = @week;
END

GO
create proc USP_GetScheduleByClass(
    @malop nvarchar(50)
)
as
BEGIN
    select *
    from v_Schedule 
    where  [Lớp] = @malop
END


select distinct phonghoc from thoikhoabieu


GO

alter proc USP_GetTietHoc(
    @malop NVARCHAR(50),
    @thu int,
    @tuan int
)
As
BEGIN
    select TietHoc from ThoiKhoaBieu
    where malop = @malop and thu = @thu and tuan = @tuan
END 

USP_GetTietHoc 'w.2',2,1

select * from thoikhoabieu
go

Create proc USP_GetPhongHoc(
    @malop NVARCHAR(50),
    @thu int,
    @tuan int,
    @phongHoc NVARCHAR(50)
)
As
BEGIN
    select phongHoc from ThoiKhoaBieu
    where malop = @malop and thu = @thu and tuan = @tuan and phongHoc = @phongHoc
END 
GO

Create proc USP_GetGV(
    @thu int,
    @tuan int,
    @tietHoc NVARCHAR(50),
    @maGV NVARCHAR(50)
)
As
BEGIN
    select magiangvien from ThoiKhoaBieu
    where thu = @thu and tuan = @tuan and TietHoc = @tietHoc and magiangvien = @maGV
END 

select * from thoikhoabieu
GO

create proc USP_InsertSchedule(
    @thu int,
    @tuan int,
    @tiethoc NVARCHAR(50),
    @phongHoc nvarchar(50),
    @malop NVARCHAR(50),
    @maHP nvarchar(50),
    @maGV nvarchar(50)
)
As
BEGIN
    insert into thoikhoabieu(thu, tuan, TietHoc, phongHoc, malop, mahocphan, magiangvien) 
    values(@thu, @tuan, @tietHoc, @phongHoc, @malop, @mahp, @magv)
end

select * from v_Schedule

select * from GIANGVIEN
select * from HOCPHAN

select * from GIANGDAY

select *
from GIANGVIEN
right join GIANGDAY on GIANGVIEN.MaGiangVien = GIANGDAY.MaGiangVien
right join HOCPHAN on GIANGDAY.MaHocPhan = HOCPHAN.MAHOCPHAN
where TENHOCPHAN = N'Toán Cao Cấp'
GO

alter proc USP_GetLectureBySubject(
    @tenHP nvarchar(50)
)
As
BEGIN
    select TENGIANGVIEN
    from GIANGVIEN
    right join GIANGDAY on GIANGVIEN.MaGiangVien = GIANGDAY.MaGiangVien
    right join HOCPHAN on GIANGDAY.MaHocPhan = HOCPHAN.MAHOCPHAN
    where TENHOCPHAN =  @tenHP
END

USP_GetLectureBySubject [Toán Cao Cấp]