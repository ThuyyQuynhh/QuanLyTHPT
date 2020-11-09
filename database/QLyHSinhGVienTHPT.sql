CREATE DATABASE QLHSinhGVienTHPT
GO
create table admin
(
	Taikhoan nvarchar(100) primary key,
	Password varchar(10) not null default '123'
)
create table Khoi 
(
	MaKhoi varchar(10) primary key,
	TenKhoi nvarchar(10) not null
)
create table MonHoc
(
	MaMon varchar(10) primary key,
	TenMon nvarchar(50) not null,
	
)
create table GiaoVien
(
	MaGV varchar(10) primary key,
	TenGV nvarchar(50) not null,
	GioiTinh nvarchar(3) not null,
	NgaySinh date not null default getdate(),
	DiaChi nvarchar(100) not null,
	SDT varchar(10) not null
	
)
create table Lop
(
	MaLop varchar(10) primary key,
	TenLop nvarchar(100) not null,
	MaKhoi varchar(10) not null,
	MaGVCN varchar(10) not null,
	foreign key (MaKhoi) references Khoi(maKhoi),
	foreign key (MaGVCN) references GiaoVien(MaGV)
)
create table HocSinh
(
	MaHS varchar(10) primary key,
	TenHS nvarchar(100) not null,
	GioiTinh nvarchar(3) not null,
	NgaySinh date not null default getdate(),
	DiaChi nvarchar(100) not null,
	MaLop varchar(10) not null,
	foreign key (MaLop) references Lop(MaLop)
	
)

create table Diem
(
	MaHS varchar(10) not null,
	MaMon varchar(10) not null,
	MaGV varchar(10) not null,
	Diem int not null,
	foreign key (MaGV) references GiaoVien(MaGV),
	foreign key (MaHS) references HocSinh(MaHS),
	foreign key (MaMon) references MonHoc(MaMon)
)
--------ADMIN---------------------
insert into Admin values (N'Admin','123')

--------------KHOI------------
insert into Khoi values ('K0', N'Khối 10')
insert into Khoi values ('K1', N'Khối 11')
insert into Khoi values ('K2', N'Khối 12')
-----------------GIAOVIEN-------------
insert into GiaoVien values ('GV01', N'Chu Thị Hường', N'Nam', '1978/1/2',N'Hoàn Kiếm, Hà Nội', '0976543987')
insert into GiaoVien values ('GV02', N'Tăng Văn Hạ', N'Nam', '1985/11/2',N'Hoàng Mai, Hà Nội', '0987654321')
insert into GiaoVien values ('GV03', N'Nguyễn Mậu Uyên', N'Nam', '1988/4/9',N'Cầu Giấy, Hà Nội', '0976444565')
insert into GiaoVien values ('GV04', N'Vũ Thị Ly', N'Nam', '1988/5/9',N'Hà Đông, Hà Nội', '0934213456')
insert into GiaoVien values ('GV05', N'Nguyễn Lương Bình', N'Nam', '1980/12/13',N'Ba Đình, Hà Nội', '0934213456')
insert into GiaoVien values ('GV06', N'Nguyễn Thị Hiền', N'Nam', '1991/2/4',N'Cầu Giấy, Hà Nội', '0956789234')
insert into GiaoVien values ('GV07', N'Phạm Văn Việt', N'Nam', '1970/4/5',N'Thanh Xuân, Hà Nội', '0958949378')
insert into GiaoVien values ('GV08', N'Chu Thị Hường', N'Nữ', '1988/5/6',N'Thanh Xuân, Hà Nội', '0846378564')
insert into GiaoVien values ('GV09', N'Trần Văn An', N'Nữ', '1986/6/7',N'Hoài Đức, Hà Nội', '0836245895')
insert into GiaoVien values ('GV10', N'Nguyễn Hoài Anh', N'Nữ', '1980/4/7',N'Cầu Giấy, Hà Nội', '0824367589')
insert into GiaoVien values ('GV11', N'Nguyễn Văn Giang', N'Nam', '1982/3/5',N'Ba Đình, Hà Nội', '0937213786')
insert into GiaoVien values ('GV12', N'Hoa Tất Thắng', N'Nam', '1987/2/8',N'Hoàn Kiếm, Hà Nội', '0748345879')
insert into GiaoVien values ('GV13', N'Lê Văn Nam', N'Nam', '1988/5/23',N'Hoàn Kiếm, Hà Nội', '0746787689')
insert into GiaoVien values ('GV14', N'Lê Thị Thuỳ Linh', N'Nữ', '1990/6/12',N'Cầu Giấy, Hà Nội', '0673862846')
insert into GiaoVien values ('GV15', N'Vũ Quang Tuấn', N'Nam', '1976/5/8',N'Ba Đình, Hà Nội', '0647287689')
insert into GiaoVien values ('GV16', N'Đặng Giáp Trường', N'Nam', '1980/7/9',N'Hà Đông, Hà Nội', '0678492620')
insert into GiaoVien values ('GV17', N'Phan Nguyên Hải', N'Nam', '1975/3/12',N'Thanh Xuân, Hà Nội', '0675394726')
insert into GiaoVien values ('GV18', N'Nguyễn Quốc Khánh', N'Nam', '1987/6/11',N'Hoài Đức, Hà Nội', '0647283644')
----------------LOP-----------------
insert into Lop values ('L10A1', N'10 Chuyên Toán', 'K0', 'GV01')
insert into Lop values ('L10A2', N'10 Chuyên Tin', 'K0', 'GV02')
insert into Lop values ('L10A3', N'10 Chuyên Lý', 'K0', 'GV03')
insert into Lop values ('L10A4', N'10 Chuyên Hoá', 'K0', 'GV04')
insert into Lop values ('L10A5', N'10 Chuyên Sinh', 'K0', 'GV05')
insert into Lop values ('L10A6', N'10 Chuyên Văn', 'K0', 'GV06')
insert into Lop values ('L11A1', N'11 Chuyên Toán', 'K1', 'GV07')
insert into Lop values ('L11A2', N'11 Chuyên Tin', 'K1', 'GV08')
insert into Lop values ('L11A3', N'11 Chuyên Lý', 'K1', 'GV09')
insert into Lop values ('L11A4', N'11 Chuyên Hoá', 'K1', 'GV10')
insert into Lop values ('L11A5', N'11 Chuyên Sinh', 'K1', 'GV11')
insert into Lop values ('L11A6', N'11 Chuyên Văn', 'K1', 'GV12')
insert into Lop values ('L12A1', N'12 Chuyên Toán', 'K2', 'GV13')
insert into Lop values ('L12A2', N'12 Chuyên Tin', 'K2', 'GV14')
insert into Lop values ('L12A3', N'12 Chuyên Lý', 'K2', 'GV15')
insert into Lop values ('L12A4', N'12 Chuyên Hoá', 'K2', 'GV16')
insert into Lop values ('L12A5', N'12 Chuyên Sinh', 'K2', 'GV17')
insert into Lop values ('L12A6', N'12 Chuyên Văn', 'K2', 'GV18')
------------------HOCSINH----------
insert into HocSinh values ('HS01', N'Nguyễn Trường An', N'Nam', '2005/12/3',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS02', N'Dương Đức Anh', N'Nam', '2005/11/11',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS03', N'Bùi Văn Dương', N'Nam', '2005/3/4',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS04', N'Nguyễn Anh Dũng', N'Nam', '2005/4/5',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS05', N'Nguyễn Đình Đại', N'Nam', '2005/5/6',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS06', N'ĐInh Viết Đức', N'Nam', '2005/9/9',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS07', N'Nguyễn Ngọc Hưng', N'Nam', '2005/6/7',N'Cầu Giấy, Hà Nội', 'L10A1')
insert into HocSinh values ('HS08', N'Nguyễn Văn Kiên', N'Nam', '2004/7/8',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS09', N'Nguyễn Quốc Khánh', N'Nam', '2004/8/9',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS10', N'Nguyễn Thị Kim Khánh', N'Nam', '2004/9/10',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS11', N'Phạm Trọng Linh', N'Nam', '2004/10/11',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS12', N'Lê Thị Linh', N'Nam', '2004/11/12',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS13', N'Trần Thị Quỳnh Nga', N'Nam', '2004/12/13',N'Cầu Giấy, Hà Nội', 'L11A1')
insert into HocSinh values ('HS14', N'Nguyễn Thị Thuý Quỳnh', N'Nam', '2003/2/4',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS15', N'Huỳnh Văn Tá', N'Nam', '2003/5/8',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS16', N'Lê Anh Thắng', N'Nam', '2003/9/7',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS17', N'Nguyễn Thị Thanh Thuỳ', N'Nam', '2003/12/12',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS18', N'Dương Đình Tuấn', N'Nam', '2003/5/14',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS19', N'Thái Bá Tuyên', N'Nam', '2003/6/17',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS20', N'Đào Anh Tú', N'Nam', '2003/9/18',N'Cầu Giấy, Hà Nội', 'L12A1')
insert into HocSinh values ('HS21', N'Nguyễn Trọng Quyết', N'Nam', '2003/10/10',N'Cầu Giấy, Hà Nội', 'L12A1')

------------MONHOC--------
insert into MonHoc values ('M1', N'Toán')
insert into MonHoc values ('M2', N'Tin')
insert into MonHoc values ('M3', N'Lý')
insert into MonHoc values ('M4', N'Hoá')
insert into MonHoc values ('M5', N'Sinh')
insert into MonHoc values ('M6', N'Văn')
--------------DIEM--------------
insert into Diem values ('HS01', 'M1','GV01',9)
insert into Diem values ('HS01', 'M2','GV02',8)
insert into Diem values ('HS01', 'M3','GV03',9)
insert into Diem values ('HS01', 'M4','GV04',8)
insert into Diem values ('HS01', 'M5','GV05',9)
insert into Diem values ('HS01', 'M6','GV06',8)
insert into Diem values ('HS08', 'M1','GV07',9)
insert into Diem values ('HS08', 'M2','GV08',8)
insert into Diem values ('HS08', 'M3','GV09',9)
insert into Diem values ('HS08', 'M4','GV10',8)
insert into Diem values ('HS08', 'M5','GV11',9)
insert into Diem values ('HS08', 'M6','GV12',8)
insert into Diem values ('HS14', 'M1','GV13',9)
insert into Diem values ('HS14', 'M2','GV14',8)
insert into Diem values ('HS14', 'M3','GV15',9)
insert into Diem values ('HS14', 'M4','GV16',8)
insert into Diem values ('HS14', 'M5','GV17',9)
insert into Diem values ('HS14', 'M6','GV18',8)
insert into Diem values ('HS02', 'M1','GV01',9)
insert into Diem values ('HS02', 'M2','GV02',8)
insert into Diem values ('HS02', 'M3','GV03',9)
insert into Diem values ('HS02', 'M4','GV04',8)
insert into Diem values ('HS02', 'M5','GV05',9)
insert into Diem values ('HS02', 'M6','GV06',9)


delete from GiaoVien where MaGV = 'GV01'