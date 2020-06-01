Create procedure dangnhap_dangnhap
@taikhoan nvarchar(40),
@matkhau nvarchar(40)
as
begin 
select *from nhanvien where taikhoan =@taikhoan and matkhau = @matkhau
end
go

CREATE PROCEDURE sp_select_nhanvien 
 as 
 begin 
select * from nhanvien 
end
go

CREATE  PROCEDURE sp_insert_nhanvien 
 @tennv nvarchar(40),
 @ngaysinh nvarchar(40),
 @diachi nvarchar(40),
 @sdt nvarchar(40),
 @chucvu nvarchar(40),
 @taikhoan nvarchar(40),
 @matkhau nvarchar(40)
 as 
 begin 
insert  into nhanvien(tennv,ngaysinh,diachi,sdt,chucvu,taikhoan,matkhau) values(@tennv,@ngaysinh,@diachi,@sdt,@chucvu,@taikhoan,@matkhau) 
select @@IDENTITY
end
go

CREATE  PROCEDURE sp_update_nhanvien 
 @manv int,
 @tennv nvarchar(40),
 @ngaysinh nvarchar(40),
 @diachi nvarchar(40),
 @sdt nvarchar(40),
 @chucvu nvarchar(40),
 @taikhoan nvarchar(40),
 @matkhau nvarchar(40)
 as 
 begin 
UPDATE nhanvien set tennv =  @tennv,ngaysinh =  @ngaysinh,diachi =  @diachi,sdt =  @sdt,chucvu =  @chucvu,taikhoan =  @taikhoan,matkhau =  @matkhau where manv =  @manv  
end
go

CREATE  PROCEDURE sp_delete_nhanvien 
 @manv int
 as 
 begin 
delete from nhanvien where manv = @manv 
end
go

create  procedure nhanvien_tim
@tennv nvarchar(40),
@chucvu nvarchar(40)
as
begin 
select * from nhanvien where  CAST(tennv as nvarchar(32)) LIKE @tennv + '%' or  CAST(chucvu as nvarchar(40)) like @chucvu + '%'
end
go

 /* procedure  du an*/
CREATE  PROCEDURE sp_select_duan 
 as 
 begin 
 select * from duan 
end
go

CREATE PROCEDURE sp_insert_duan 
 @tenda nvarchar(40),
 @noidung nvarchar(40),
 @ngaybd nvarchar(40),
 @thoihan nvarchar(40),
 @hoanthanh nvarchar(40)
 as 
 begin 
	insert into duan(tenda,noidung,ngaybd,thoihan,hoanthanh) values(@tenda,@noidung,@ngaybd,@thoihan,@hoanthanh)
	
	SELECT @@IDENTITY 
end
go

go
CREATE  PROCEDURE sp_update_duan 
 @mada int,
 @tenda nvarchar(40),
 @noidung nvarchar(40),
 @ngaybd nvarchar(40),
 @thoihan nvarchar(40),
 @hoanthanh nvarchar(40)
 as 
 begin 
UPDATE duan set tenda =  @tenda,noidung =  @noidung,ngaybd =  @ngaybd,thoihan =  @thoihan,hoanthanh =  @hoanthanh where mada =  @mada  
end
go

CREATE  PROCEDURE sp_delete_duan 
 @mada int
 as 
 begin 
delete from duan where mada = @mada 
end
go
create procedure duan_tim
@tenda nvarchar(40),
@noidung nvarchar(40)
as
begin 
select * from duan where  CAST(tenda as nvarchar(32)) LIKE @tenda + '%' or  CAST(noidung as nvarchar(40)) like @noidung + '%'
end
go
/* procedure  cong viec */
CREATE  PROCEDURE sp_select_congviec 
 as 
 begin 
select *, tenda  from congviec, duan where congviec.mada = duan.mada 
end
go


CREATE  PROCEDURE sp_insert_congviec 
 @mada int,
 @noidung nvarchar(40),
 @ngaybd nvarchar(40),
 @tencv nvarchar(40),
 @thoihan nvarchar(40)
 as 
 begin 
insert into congviec(mada,noidung,ngaybd,tencv,thoihan) values(@mada,@noidung,@ngaybd,@tencv,@thoihan) 
SELECT @@IDENTITY
end
go

CREATE  PROCEDURE sp_update_congviec 
 @macv int,
 @mada int,
 @noidung nvarchar(40),
 @ngaybd nvarchar(40),
 @tencv nvarchar(40),
 @thoihan nvarchar(40)
 as 
 begin 
UPDATE congviec set mada =  @mada,noidung =  @noidung,ngaybd =  @ngaybd,tencv =  @tencv,thoihan =  @thoihan where macv =  @macv  
end
go

CREATE  PROCEDURE sp_delete_congviec 
 @macv int
 as 
 begin 
delete from congviec where macv = @macv 
end
go


create  procedure congviec_tim
@tencv nvarchar(40),
@noidung nvarchar(40)
as
begin 
select * from congviec where  CAST(tencv as nvarchar(32)) LIKE @tencv + '%' or  CAST(noidung as nvarchar(40)) like @noidung + '%'
end
go
/* procedure thanh vien */
CREATE  PROCEDURE sp_select_thanhvien 
 as 
 begin 
select * from thanhvien 
end
go

CREATE  PROCEDURE sp_insert_thanhvien 
 @manv int,
 @mada int,
 @chucvu nvarchar(40),
 @congviec nvarchar(40)
 as 
 begin 
insert into thanhvien(manv,mada,chucvu,congviec) values(@manv,@mada,@chucvu,@congviec) 
select @@IDENTITY
end
go


CREATE  PROCEDURE sp_update_thanhvien 
 @matv int,
 @manv int,
 @mada int,
 @chucvu nvarchar(40),
 @congviec nvarchar(40)
 as 
 begin 
UPDATE thanhvien set manv =  @manv,mada =  @mada,chucvu =  @chucvu,congviec =  @congviec where matv =  @matv  
end
go

CREATE  PROCEDURE sp_delete_thanhvien 
 @matv int
 as 
 begin 
delete from thanhvien where matv = @matv 
end
go
create  procedure thanhvien_tim
@chucvu nvarchar(40),
@congviec nvarchar(40)
as
begin 
select * from thanhvien where  CAST(congviec as nvarchar(32)) LIKE @congviec + '%' or  CAST(chucvu as nvarchar(40)) like @chucvu + '%'
end
go
/*  procedure phan cong */
CREATE  PROCEDURE sp_select_phancong 
 as 
 begin 
select * from phancong 
end
go

CREATE  PROCEDURE sp_insert_phancong 
 @manv int,
 @macv int
 as 
 begin 
insert into phancong(manv,macv) values(@manv,@macv) 
end
go


CREATE  PROCEDURE sp_update_phancong 
 @manv int,
 @macv int
 as 
 begin 
UPDATE phancong set macv =  @macv where manv =  @manv  
end
go

CREATE PROCEDURE sp_delete_phancong 
 @manv int
 as 
 begin 
delete from phancong where manv = @manv 
end
go

/* procedure danh gia */
CREATE PROCEDURE sp_select_danhgia 
 as 
 begin 
select * from danhgia 
end
go

CREATE   PROCEDURE sp_insert_danhgia 
 @manv int,
 @manhiemv int,
 @tiendo nvarchar(40)
 as 
 begin 
insert into danhgia(manv,manhiemv,tiendo) values(@manv,@manhiemv,@tiendo) 
select @@IDENTITY
end
go

CREATE  PROCEDURE sp_update_danhgia 
 @madg int,
 @manv int,
 @manhiemv int,
 @tiendo nvarchar(40)
 as 
 begin 
UPDATE danhgia set manv =  @manv,manhiemv =  @manhiemv,tiendo =  @tiendo where madg =  @madg  
end
go

CREATE  PROCEDURE sp_delete_danhgia 
 @madg int
 as 
 begin 
delete from danhgia where madg = @madg 
end
go
 
 /*bao caos tuan */
  CREATE  PROCEDURE sp_select_baocaotuan 
 as 
 begin 
select * from baocaotuan 
end
go

CREATE  PROCEDURE sp_insert_baocaotuan 
 @macv int,
 @manv int,
 @ngay nvarchar(40),
 @tiendo nvarchar(40),
 @ghichu nvarchar(40),
 @dexuat nvarchar(40)
 as 
 begin 
insert into baocaotuan(macv,manv,ngay,tiendo,ghichu,dexuat) values(@macv,@manv,@ngay,@tiendo,@ghichu,@dexuat) 
select @@IDENTITY
end
go

CREATE  PROCEDURE sp_update_baocaotuan 
 @mabcn int,
 @macv int,
 @manv int,
 @ngay nvarchar(40),
 @tiendo nvarchar(40),
 @ghichu nvarchar(40),
 @dexuat nvarchar(40)
 as 
 begin 
UPDATE baocaotuan set macv =  @macv,manv =  @manv,ngay =  @ngay,tiendo =  @tiendo,ghichu =  @ghichu,dexuat =  @dexuat where mabcn =  @mabcn  
end
go


CREATE   PROCEDURE sp_delete_baocaotuan 
 @mabcn int
 as 
 begin 
delete from baocaotuan where mabcn = @mabcn 
end
go

/* bap cpa tong hop */
CREATE  PROCEDURE sp_select_baocaotonghop 
 as 
 begin 
select * from baocaotonghop 
end
go

CREATE  PROCEDURE sp_insert_baocaotonghop 
 @mada int,
 @matv int,
 @tondong nvarchar(40),
 @ngayht nvarchar(40),
 @dexuat nvarchar(40)
 as 
 begin 
insert into baocaotonghop(mada,matv,tondong,ngayht,dexuat) values(@mada,@matv,@tondong,@ngayht,@dexuat) 
end
go

CREATE  PROCEDURE sp_update_baocaotonghop 
 @mabcth int,
 @mada int,
 @matv int,
 @tondong nvarchar(40),
 @ngayht nvarchar(40),
 @dexuat nvarchar(40)
 as 
 begin 
UPDATE baocaotonghop set mada =  @mada,matv =  @matv,tondong =  @tondong,ngayht =  @ngayht,dexuat =  @dexuat where mabcth =  @mabcth  
end
go

CREATE or alter PROCEDURE sp_delete_baocaotonghop 
 @mabcth int
 as 
 begin 
delete from baocaotonghop where mabcth = @mabcth 
end
go
/* view dự án*/
create or alter procedure viewduan
@id int
as
begin
SELECT tenda,Tennv,thanhvien.chucvu,thanhvien.congviec,noidung,ngaybd,thoihan,hoanthanh,tondong,dexuat
from duan LEFT JOIN baocaotonghop on duan.mada=baocaotonghop.mada
          LEFT JOIN thanhvien on duan.mada = thanhvien.mada
		  LEFT JOIN nhanvien on thanhvien.manv = nhanvien.manv
		  where duan.mada = @id
end
go
/*****/
create or alter procedure viewthanhvien
@id int
as
begin
SELECT tenda,Tennv,thanhvien.chucvu,thanhvien.congviec,noidung,ngaybd,thoihan,hoanthanh,tondong,dexuat
from thanhvien LEFT JOIN baocaotonghop on thanhvien.mada=baocaotonghop.mada
          LEFT JOIN duan on duan.mada = thanhvien.mada
		  LEFT JOIN nhanvien on thanhvien.manv = nhanvien.manv
		  where thanhvien.matv = @id
end
go
/* view cong viec cho du an*/
create or alter procedure viewcongviec
@Id int
as
begin 
select tenda,tencv,tennv,congviec.noidung,congviec.ngaybd,congviec.thoihan,danhgia.tiendo,baocaotuan.tiendo,baocaotuan.ghichu,baocaotuan.dexuat,baocaotuan.ngay
from congviec LEFT JOIN duan on congviec.mada = duan.mada
              LEFT JOIN danhgia on congviec.macv = danhgia.manhiemv
              LEFT JOIN nhanvien on danhgia.manv = nhanvien.manv
			  LEFT JOIN baocaotuan on congviec.macv =baocaotuan.macv
             where congviec.macv = @Id 
end
go
/* in báo cáo tuần */
create or alter procedure inbaocaotuan
@id int 
as
begin 
select tennv,baocaotuan.ngay,congviec.tencv,baocaotuan.tiendo,baocaotuan.ghichu,baocaotuan.dexuat,congviec.noidung,congviec.ngaybd,congviec.thoihan
from baocaotuan LEFT JOIN nhanvien on baocaotuan.manv = nhanvien.manv
                LEFT JOIN congviec on baocaotuan.macv = congviec.macv
where baocaotuan.mabcn = @id
end
go
/*in báo cáo tổng hợp */
create or alter procedure inbaocaotonghop
@id int
as
begin
select tennv,tenda,thanhvien.chucvu,thanhvien.congviec,duan.ngaybd,duan.thoihan,baocaotonghop.ngayht,baocaotonghop.dexuat,baocaotonghop.tondong
from baocaotonghop
        LEFT JOIN duan on duan.mada = baocaotonghop.mada
		LEFT JOIN thanhvien on thanhvien.matv = baocaotonghop.matv
		LEFT JOIN nhanvien on nhanvien.manv = thanhvien.matv
where baocaotonghop.mabcth = @id
end
go