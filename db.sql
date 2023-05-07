create database QuanLiTrungTam
use QuanLiTrungTam

create table NguoiDung(
	MaND varchar(50) primary key,
	HoTen nvarchar(100),
	DiaChi nvarchar(100),
	Sdt text,
	Taikhoan varchar(50),
	MatKhau varchar(50),
	Quyen nvarchar(50),
	NgaySinh date,
	ViTriLamViec nvarchar(50),
	Email varchar(50)
)
select *from NguoiDung

create table KiThi(
	MaKiThi varchar(50) primary key,
	TenKiThi nvarchar(100),
	ThoiGianBatDau time,
	ThoiGianKetThuc time,
	MoTa nvarchar(100)
)

create table ChungNhan(
	MaChungNhan varchar(50) primary key,
	TenChungNhan nvarchar(100),
	NgayCap date,
	XepLoai nvarchar(50)
)

create table HocVien(
	MaHocVien varchar(50) primary key,
	HoTen nvarchar(100),
	NgaySinh date,
	SDTGiaDinh text,
	SDTCaNhan text,
	MaChungNhan varchar(50),
	Anh image,
	foreign key (MaChungNhan) references ChungNhan(MaChungNhan)
)

create table DiemThi(
	MaHocVien varchar(50),
	MaKiThi varchar(50),
	NgayThi date,
	KetQuaThi float,
	DiemDanh text,
	primary key (MaHocVien,MaKiThi),
	foreign key (MaHocVien) references HocVien(MaHocVien),
	foreign key (MaKiThi) references KiThi(MaKiThi)
)

create table HopDong(
	MaHopDong varchar(50) primary key,
	TenHopDong nvarchar(100),
	NoiDung nvarchar(1000),
	NgayLap date,
	ThoiHan date
)



create table LopHoc(
	MaLop varchar(50) primary key,
	TenLop nvarchar(100),
	TenPhongHoc nvarchar(100),
	NgayBatDau date
)


/*create table LopHoc_HocVien(
	MaLop varchar(50),
	MaHocVien varchar(50),
	NgayThamGia date,
	DiemDanh text,
	primary key(MaLop,MaHocVien),
	foreign key (MaHocVien) references HocVien(MaHocVien),
	foreign key (MaLop) references LopHoc(MaLop)
)*/

create table KhoaHoc(
	MaKH varchar(50) primary key,
	TenKhoaHoc nvarchar(100),
	CapDo nvarchar(50),
	SoBuoi smallint,
	HocPhi int,
	MaLop varchar(50),
	foreign key (MaLop) references LopHoc(MaLop)
)

create table GiaoVien(
	MaGiaoVien varchar(50) primary key,
	HoTen nvarchar(100),
	DiaChi nvarchar(100),
	Sdt text,
	NgaySinh date,
	NgayVaoLam date,
	ChuyenMon nvarchar(50),
	BangCap nvarchar(50),
	MaHopDong varchar(50),
	MaLop varchar(50),
	Anh image,
	foreign key (MaLop) references LopHoc(MaLop),
	foreign key (MaHopDong) references HopDong(MaHopDong)
)