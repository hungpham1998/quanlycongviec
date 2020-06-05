create table nhanvien
(	
	manv int identity(1,1),
	tennv nvarchar(40),
	ngaysinh datetime,
	diachi nvarchar(40),
	sdt   nvarchar(40),
	chucvu nvarchar(40),
	taikhoan nvarchar(40),
        matkhau nvarchar(40),
	primary key(manv)
)


create table duan
(
	mada int identity(1,1),
	tenda nvarchar(40),
	noidung nvarchar(40), 
	ngaybd datetime,
	thoihan nvarchar(40),
	hoanthanh datetime,
	primary key(mada)
)
create table congviec
(
	macv int identity(1,1),
	mada int,
	noidung nvarchar(40),
	ngaybd datetime,
	tencv nvarchar(40),
	thoihan nvarchar(40),
	primary key(macv),
	foreign key (mada) references duan(mada)
)
create table thanhvien
(	
    matv int identity(1,1),
	manv int,
	mada int,
    chucvu nvarchar(40),
	congviec nvarchar(40),
	primary key(matv),
	foreign key (manv) references nhanvien(manv),
	foreign key (mada) references duan(mada)
)
create table phancong
(
	manv int,
	macv int,
	foreign key (manv) references nhanvien(manv),
	foreign key (macv) references congviec(macv)
)

create table danhgia 
(	
	madg int identity(1,1),
	manv int,
	manhiemv int,
    tiendo nvarchar(40),
	primary key(madg),
	foreign key (manv) references nhanvien(manv),
	foreign key (manhiemv) references congviec(macv)
)
create table baocaotuan
(
	mabcn int identity(1,1),
	macv int,
	manv int,
	ngay datetime,
	tiendo nvarchar(40),
	ghichu nvarchar(40),
	dexuat nvarchar(40),
	primary key(mabcn),
	foreign key (manv) references nhanvien(manv),
	foreign key (macv) references congviec(macv)
)
create table baocaotonghop
(
	mabcth int identity(1,1),
	mada int,
	matv int,
	tondong nvarchar(40),
	ngayht datetime,
	dexuat nvarchar(40),
	primary key(mabcth),
	foreign key (mada) references duan(mada),
	foreign key (matv) references thanhvien(matv)
)

INSERT INTO nhanvien (tennv, ngaysinh, sdt,diachi,chucvu,taikhoan,matkhau)
VALUES ('nobita','2015-12-17','0987654321','ha noi','quan tri vien','admin','admin');
INSERT INTO nhanvien (tennv, ngaysinh, sdt,diachi,chucvu,taikhoan,matkhau)
VALUES ('xuka','1998-12-17','0987654321','ha noi','quan tri vien','nobita','admin');
INSERT INTO nhanvien (tennv, ngaysinh, sdt,diachi,chucvu,taikhoan,matkhau)
VALUES ('chaen','1999-12-17','0987654321','ha nam','quan tri vien','chaen','admin');