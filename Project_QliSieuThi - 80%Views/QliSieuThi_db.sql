CREATE DATABASE QliSieuThi_db
--GO

USE QliSieuThi_db
GO

--quanli(maqli,tenql,tentk,mk,ngaysinh,diachi,sdt)
--nhanvien(manv,tennv,macv,ngaysinh,gioitinh,diachi,sdt)
--congviec(macv,tencv)
--sanpham(masp,tensp,soluong,dongiaban,dongianhap,malsp)
--loaisanpham(malsp,tenlsp)
--hoadon(mahd,manv,ngaylap,tongtien)
--cthd(mahd,masp,soluong,dongia,thanhtien)


--quanli(maqli,tenql,tentk,mk,ngaysinh,diachi,sdt)
CREATE TABLE quanli
(
	maql INT IDENTITY(1,1) NOT NULL,
	tenql NVARCHAR(100) NOT NULL,
	tentk NVARCHAR(100) NOT NULL,
	mk VARCHAR(30),
	ngaysinh DATEtime, --‘YYYY-MM-DD’
	sdt CHAR(10)
)
GO

alter table quanli
add constraint pk_quanli
	primary key (maql)

--congviec(macv,tencv)
CREATE TABLE congviec
(
	macv INT IDENTITY(1,1)NOT NULL,
	tencv NVARCHAR(100) NOT NULL,
)
GO
alter table congviec
add constraint pk_congviec
	primary key (macv)

--nhanvien(anh,manv,tennv,macv,ngaysinh,gioitinh,diachi,sdt)
CREATE TABLE nhanvien
(
	anh nvarchar(100),
	manv INT IDENTITY(1,1) NOT NULL,
	tennv NVARCHAR(100) ,
	macv INT,
	ngaysinh DATEtime , --‘YYYY-MM-DD’
	gioitinh nvarchar(3),
	diachi nvarchar(100),
	sdt CHAR(12)
)
GO
alter table nhanvien
add constraint pk_nhanvien
	primary key (manv)

alter table nhanvien
add constraint fk_nhanvien
	FOREIGN KEY (macv) REFERENCES congviec(macv)

--loaisanpham(malsp,tenlsp)
CREATE TABLE loaisanpham
(
	malsp INT IDENTITY(1,1) NOT NULL,
	tenlsp NVARCHAR(100) NOT NULL,
)
GO
alter table loaisanpham
add constraint pk_loaisp
	primary key (malsp)


--sanpham(masp,tensp,soluong,dongiaban,dongianhap,malsp)
CREATE TABLE sanpham
(
	anh NVARCHAR(100),
	masp INT IDENTITY(1,1) not null,
	tensp NVARCHAR(100) NOT NULL,
	malsp INT ,--FOREIGN KEY REFERENCES loaisanpham(malsp),
	soluong INT DEFAULT 0,
	dongiaban INT DEFAULT 0,
	dongianhap INT DEFAULT 0
)
GO
alter table sanpham
add constraint pk_sp
	primary key (masp)

alter table sanpham
add constraint fk_sp
	FOREIGN KEY (malsp) REFERENCES loaisanpham(malsp)

--hoadon(mahd,manv,ngaylap,tongtien)
CREATE TABLE hoadon
(
	
	mahd INT IDENTITY(1,1) not null,
	manv int,
	ngaylap DATETIME, 
	tongtien MONEY
)
GO
alter table hoadon
add constraint pk_hd
	primary key (mahd)

alter table hoadon
add constraint fk_hd
	FOREIGN KEY (manv) REFERENCES nhanvien(manv)


--cthd(mahd,masp,soluong,dongia,thanhtien)
CREATE TABLE cthd
(
	mahd INT not null, --FOREIGN KEY REFERENCES	hoadon(mahd),
	masp INT not null, --FOREIGN KEY REFERENCES sanpham(masp),
	soluong INT DEFAULT 0,
	dongia money,
	thanhtien money
)
GO
alter table cthd
add constraint pk_cthd
	primary key (mahd,masp)

alter table cthd
add constraint fk1_cthd
	FOREIGN KEY(mahd) REFERENCES hoadon(mahd)

alter table cthd
add constraint fk2_cthd 
	FOREIGN KEY(masp) REFERENCES sanpham(masp)


insert into quanli (tenql,tentk,mk,ngaysinh,sdt) values  (N'Nguyễn Tuấn Kiệt', 'kietbeve','kiet123','2/2/2005','012323434')
insert into quanli (tenql,tentk,mk,ngaysinh,sdt) values  (N'Nguyễn Hoàng Nam', 'nammo','nam123','1/3/2005','22323922')

insert into congviec (tencv) values (N'nhân viên bán hàng')
insert into congviec (tencv) values (N'nhân viên tư vấn')
insert into congviec (tencv) values (N'nhân viên kho hàng')
insert into congviec (tencv) values (N'nhân viên vệ sinh')


insert into nhanvien(tennv,macv,ngaysinh,gioitinh,diachi,sdt) values (N'Nguyễn Văn A', 1,'1/1/2000',N'Nam','tpHCM','219242443')
insert into nhanvien(tennv,macv,ngaysinh,gioitinh,diachi,sdt) values (N'Lê Thị B',4 ,'1/1/2004',N'Nữ','tpHCM','219242443')
insert into nhanvien(tennv,macv,ngaysinh,gioitinh,diachi,sdt) values (N'Nguyễn Thị C',2 ,'5/1/2002',N'Nữ','tpHCM','024538748')
insert into nhanvien(tennv,macv,ngaysinh,gioitinh,diachi,sdt) values (N'Nguyễn Văn M',3 ,'1/10/2004',N'Nam','tpHCM','031472834')


insert into loaisanpham(tenlsp) values (N'Nước giải khát')
insert into loaisanpham(tenlsp) values (N'Đồ ăn vặt')
insert into loaisanpham(tenlsp) values (N'Đồ dùng cá nhân')

insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values (N'Pessi', 1, 100, 7000, 5000)
insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values (N'bimbim', 2, 100, 10000, 5000)
insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values (N'kem đánh răng', 3, 100, 50000, 30000)
insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values (N'bàn chải đánh răng', 4, 100, 30000, 20000)

insert into hoadon(manv, ngaylap, tongtien) values (1, '1/5/2025',44000)
insert into hoadon(manv, ngaylap, tongtien) values (1, '1/5/2025',80000)
insert into hoadon(manv, ngaylap, tongtien) values (1, '1/5/2025',20000)

insert into cthd (mahd, masp, soluong, dongia, thanhtien) values (1,1,2,7000, 14000)
insert into cthd (mahd, masp, soluong, dongia, thanhtien) values (1,2,3,10000, 30000)
insert into cthd (mahd, masp, soluong, dongia, thanhtien) values (2,1,1,50000, 50000)
insert into cthd (mahd, masp, soluong, dongia, thanhtien) values (2,2,1,30000, 30000)
insert into cthd (mahd, masp, soluong, dongia, thanhtien) values (3,1,2,10000, 20000)

















