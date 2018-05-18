create database QLGara
USE QLGara

create table TaiKhoan(
TaiKhoan nvarchar(50) primary key,
MatKhau nvarchar(50)
)
go


create table KHACHHANG
(
	MaKH int primary key,
	HoTen nvarchar(50),
	SDT int,
	Email varchar(50),
	DiaChi nvarchar(50)
)
go
create table THONGTINXE
(
	BienSoXe varchar(50) primary key,
	HangXe nvarchar(50),
	DoiXe nvarchar(50),
	SoKhung nvarchar(50),
	SoMay nvarchar(50),
	SoKM int
)
go
create table PHIEUKHAOSAT
(
	MaPhieuKhaoSat int primary key,
	MaKH int references KHACHHANG(MaKH),
	BienSoXe varchar(50) references ThongTinXe(BienSoXe),
	YeuCau ntext,
)
go
create table PHIEUDANHGIA
(
	MaPhieuDanhGia int primary key,
	MaPhieuKhaoSat int references PhieuKhaoSat(MaPhieuKhaoSat),
	TinhTrangXe ntext,
	ThongBaoGiaSua int,
)
go
create table NHACUNGCAP
(
	TenNhaCungCap nvarchar(50) primary key,
	DiaChi nvarchar(50),
	Email varchar(50),
	SDT int,
	Website varchar(50)
)
go
create table PHIEUVATTU
(
	MaPhieuVatTu int primary key,
	MaPhieuKhaoSat int references PhieuKhaoSat(MaPhieuKhaoSat),
	TenVatLieu nvarchar(50),
	NhaCungCap nvarchar(50) references NhaCungCap(TenNhaCungCap),
	SoLuong int,
	SoTien int,
)
select MAPHIEUVATTU AS ' MaPhuTung', TenVatLieu,NhaCungCap,SoLuong,SoTien  from PHIEUVATTU
go
create table XUONG
(
	TenXuong nvarchar(50) primary key,
	DiaChi nvarchar(50),
	Email varchar(50),
	Website varchar(50),
	MaNguoiPhuTrach int,
	MaPhieuDanhGia int references PHIEUDANHGIA(MaPhieuDanhGia)
)
go
create table NHANVIEN
(
	MaNV int primary key,
	HoTen nvarchar(50),
	SDT int,
	NgaySinh date,
	GioiTinh nchar(3),
	DiaChi nvarchar(50),
	TenXuong nvarchar(50) references XUONG(TenXuong)
)


create table HOADON
(
	Ma int primary key,
	MaPhieuVatTu int references PHIEUVATTU(MaPhieuVatTu),
	TenHoaDon nvarchar(50),
	MaNguoiPhuTrach int,
	CongSua int,
	TongTienThanhToan INT,
    TenXuong nvarchar(50) references XUONG(TenXuong),
	DateCheckIn date not null default getdate(),
	DateCheckOut date,
)

go

alter table HOADON drop column CongSua

--Thủ tục----
insert into TaiKhoan
values ('admin','admin')
go
--Thêm khách hàng
create proc ThemKH(@MaKH int, @HoTen nvarchar(50), @SDT int, @Email varchar(50), @DiaChi nvarchar(50))
as
	begin
		insert into KHACHHANG(MaKH, HoTen, SDT, Email, DiaChi) values (@MaKH, @HoTen, @SDT, @Email, @DiaChi)
	end
go
ThemKH '1', 'Nguyen Van Long', '01654320189', 'nvlong@gmail.com', 'Ha Noi'
go
ThemKH '2', 'Nguyen Tien Dung', '01644521089', 'ntdung@gmail.com', 'Ho CHi Minh'
go
ThemKH '3', 'Le Ba Quan', '0986654321', 'lbquan@gmail.com', 'Thai Binh'
go
ThemKH '4', 'Pham Hong Thai', '01652430187', 'phthai@gmail.com', 'Ha Noi'
go
ThemKH '5', 'Bui Huy Hoang', '01624625232', 'bhhoang@gmail.com', 'Hung Yen'
go
ThemKH '6', 'Truong Thi Trang', '0163576425', 'tttrang@gmail.com', 'Ha Nam'
go

--Thêm Xe
create proc ThemXe(@BienSo varchar(50), @HangXe nvarchar(50), @DoiXe nvarchar(50), @SoKhung nvarchar(50), @SoMay nvarchar(50), @SoKm int)
as
	begin
		insert into THONGTINXE(BienSoXe, HangXe, DoiXe, SoKhung, SoMay, SoKM) 
		values (@BienSo, @HangXe, @DoiXe, @SoKhung, @SoMay, @SoKm)
	end
go
ThemXe '89B-532.12', 'Toyota', 'Toyota Vios 1.5E 2018', 'ZXLGG3HX7EV007862', 'ZZL2814925', 1320
go
ThemXe '87B-243.22', 'Lexus', 'Lexus ES 250', 'BXLGG3HX7EV002836', 'ABL2814925', 1020
go
ThemXe '78A-915.23', 'Toyota', 'Toyota Altis 1.8G CVT', 'XLWT3HD2TV873629', 'AXH28349382', 3012
go
ThemXe '89b-621.76', 'Toyota', 'Toyota Fortuner 2.7 V 4x2', 'HDGXB3DF6YV283749', 'HBL1927364', 1200
go
ThemXe '89b-332.56', 'Audi', 'Audi Q3 2.0L 7AT', 'HDXT2TX7EV007862', 'LKD2839183', 4512
go
ThemXe '72b-551.34', 'Hyundai', 'Hyundai Grand I10 sedan 1.2 MT', 'BRTX4TY3XV007862', 'KHJ1827391', 3018
go
ThemXe '29b-325.14', 'BMW', 'BMW 320i', 'NBTX4TY3XV293849', 'KLA9304827', 2917
go

--Khảo sát
create proc KhaoSat(@MaPhieuKhaoSat int, @MaKH int, @BienSoXe varchar(50), @YeuCau ntext)
as
	begin
		insert into PHIEUKHAOSAT(MaPhieuKhaoSat, MaKH, BienSoXe, YeuCau)
		values (@MaPhieuKhaoSat, @MaKH, @BienSoXe, @YeuCau)
	end
go
KhaoSat 1, 1, '89B-532.12', 'Sua chua'
go
KhaoSat 2, 2, '87B-243.22', 'Sua chua'
go
KhaoSat 3, 3, '78A-915.23', 'Mua trang thiet bi'
go
KhaoSat 4, 4, '89b-621.76', 'Mua trang thiet bi'
go
KhaoSat 5, 5, '89b-332.56', 'Sua chua'
go
KhaoSat 6, 6, '72b-551.34', 'Sua chua'
go
KhaoSat 7, 6, '29b-325.14', 'Sua chua'
go

--Nhà cung cấp
create proc ThemNCC(@TenNCC nvarchar(50), @DC nvarchar(50), @Email varchar(50), @SDT int, @Web varchar(50))
as
	begin
		insert into NHACUNGCAP (TenNhaCungCap, DiaChi, Email, SDT, Website) values (@TenNCC, @DC, @Email, @SDT, @Web)
	end
go
ThemNCC 'NCC1', 'Ha Noi', 'NCC1@gmail.com', 0968686868, 'ncc1.com.vn'
go
ThemNCC 'NCC2', 'Da Nang', 'NCC2@gmail.com', 01688866668,'ncc2.com.vn'
go
ThemNCC 'NCC3', 'TP. Ho Chi Minh', 'NCC3@gmail.com', 01622694888,'ncc3.com.vn'
go
ThemNCC 'NCC4', 'Bac Ninh', 'NCC4@gmail.com', 01666159333,'ncc4.com.vn'
go
ThemNCC 'NCC5', 'Ha Noi', 'NCC5@gmail.com', 0866668968,'ncc5.com.vn'
go
ThemNCC 'NCC6', 'Bac Giang', 'NCC6@gmail.com', 026666888,'ncc6.com.vn'
go

--Phieusu vật tư
create proc ThemPVT(@MaPVT int, @MaPKS int, @TenVatLieu nvarchar(50), @NCC nvarchar(50), @SL int, @SoTien int)
as
	begin
		insert into PHIEUVATTU (MaPhieuVatTu, MaPhieuKhaoSat, TenVatLieu, NhaCungCap, SoLuong, SoTien) values (@MaPVT, @MaPKS, @TenVatLieu, @NCC, @SL, @SoTien)
	end
go
ThemPVT 1,1,'Dau nhot', 'NCC1', 10, 1000000
go
ThemPVT 2,2,'Vanh xe', 'NCC2', 10, 600000000
go
ThemPVT 3,3,'Lop', 'NCC3', 11, 1200000
go
ThemPVT 4,4,'Kinh chan gio', 'NCC4', 12, 1500000
go
ThemPVT 5,5,'Bugi', 'NCC5', 16, 1600000
go
ThemPVT 6,6,'Den', 'NCC6', 20, 1900000
go

--Hóa đơn
CREATE proc ThemHoaDon(@Ma int, @MaPVT int, @TenHD nvarchar(50), @MaNPT int,@CongSua INT, @TongTien INT,@TenXuong NVARCHAR(50),@DateCheckIn DATE,@DateCheckOut DATE)
as
	begin
		insert into HOADON (Ma, MaPhieuVatTu, TenHoaDon, MaNguoiPhuTrach,CongSua, TongTienThanhToan, TenXuong,DateCheckIn,DateCheckOut) values (@Ma, @MaPVT, @TenHD, @MaNPT,@CongSua, @TongTien,@TenXuong,@DateCheckIn,@DateCheckOut)
	end
go
ThemHoaDon 1, 1, 'HD1', 1,500000, 10000000,'Xuong A','2018/3/3','2018/3/6'
go
ThemHoaDon 2, 2, 'HD2', 2,200000, 9000000,'Xuong B','2018/2/3','2018/2/6'
go
ThemHoaDon 3, 3, 'HD3', 3,1000000, 15000000,'Xuong C','2018/2/8','2018/2/15'
go
ThemHoaDon 4, 4, 'HD4', 4,800000, 8000000,'Xuong D','2018/2/16','2018/2/20'
go
ThemHoaDon 5, 5, 'HD5', 5,600000, 5000000,'Xuong A','2018/2/21','2018/2/25'
go
ThemHoaDon 6, 6, 'HD6', 6,500000, 4000000,'Xuong F','2018/2/26','2018/3/1'
go

--Phiếu đánh giá
create proc ThemPDG(@MaPhieuDanhGia int,@MaPhieuKhaoSat INT,@TinhTrangXe NTEXT,@ThongBaoGiaSua int)
as
	begin 
		insert into PHIEUDANHGIA(MaPhieuDanhGia,MaPhieuKhaoSat,TinhTrangXe,ThongBaoGiaSua)values(@MaPhieuDanhGia,@MaPhieuKhaoSat,@TinhTrangXe,@ThongBaoGiaSua)
	end
GO
exec ThemPDG '1','001','Hong','1000000'
go
exec ThemPDG '2','002','Bao Duong','15000000'
go
exec ThemPDG '3','003','Bao Duong','10000000'
go
exec ThemPDG '4','004','Thay the phu kien','12000000'
go
exec ThemPDG '5','005','Hong','16000000'
go
exec ThemPDG '6','006','Hong','15000000'
go

--Xưởng
create proc ThemXuong(@TenXuong nvarchar(50),@DiaChi nvarchar(50),@Email nvarchar(50),@Website nvarchar(50),@MaNguoiPhuTrach int,@MaPhieuDanhGia int)
as
	begin 
		insert into XUONG(TenXuong,DiaChi,Email,Website,MaNguoiPhuTrach,MaPhieuDanhGia)values(@TenXuong,@DiaChi,@Email,@Website,@MaNguoiPhuTrach,@MaPhieuDanhGia)
	end
go
exec ThemXuong 'Xuong A','Bac Giang','Bg@gmail.com','Gara.com.vn','111','001'
go
exec ThemXuong 'Xuong B','Ha Noi','Hn@gmail.com','Gara.com.vn','112','002'
go
exec ThemXuong 'Xuong C','Thai Binh','Tb@gmail.com','Gara.com.vn','113','003'
go
exec ThemXuong 'Xuong D','Hung Yen','Hy@gmail.com','Gara.com.vn','114','004'
go
exec ThemXuong 'Xuong E','Bac Ninh','Bn@gmail.com','Gara.com.vn','115','005'
go
exec ThemXuong 'Xuong F','Hai Phong','Hp@gmail.com','Gara.com.vn','116','006'
go

--them nhan vien
create proc ThemNV(@MaNV int,@HoTen nvarchar(50),@SDT int,@NgaySinh date,@GT nchar(3),@DiaChi nvarchar(50),@TenXuong nvarchar(50))
as
	begin 
		insert into NHANVIEN(MaNV ,HoTen,SDT,NgaySinh,GioiTinh,DiaChi,TenXuong)values(@MaNV,@HoTen,@SDT,@NgaySinh,@GT,@DiaChi,@TenXuong)
	end
go
exec ThemNV '1', 'Nguyen Van A','0949438001','1997-12-01','Nam','Bac Giang','Xuong A'
go
exec ThemNV '2', 'Nguyen Van B','0949438002','1997-10-21','Nam','Bac Ninh','Xuong B'
go
exec ThemNV '3', 'Nguyen Van C','0949438003','1995-2-01','Nam','Ha noi','Xuong C'
go
exec ThemNV '4', 'Nguyen Van D','0949438004','1997-7-01','Nam','Ha Nam','Xuong D'
go
exec ThemNV '5', 'Nguyen Van E','0949438005','1997-8-01','Nam','Lao Cai','Xuong E'
go
exec ThemNV '6', 'Nguyen Van F','0949438006','1997-9-11','Nam','Hai phong','Xuong F'
go
exec ThemNV '7', 'Nguyen Van AA','0949438007','1996-2-11','Nam','Bac Giang','Xuong A'
go


--Xem thông tin khách hàng và xe của người đó
create proc XemKH(@Ma int)
as
	begin
		select kh.MaKH, kh.HoTen, xe.BienSoXe, xe.HangXe, xe.DoiXe
		from KHACHHANG kh, THONGTINXE xe, PHIEUKHAOSAT ks
		where kh.MaKH = ks.MaKH and xe.BienSoXe = ks.BienSoXe and kh.MaKH = @Ma
	end
go
exec XemKH '6'
go

--Xóa nhân viên
create proc XoaNV(@Ma int)
as
	begin
		delete from NHANVIEN
		where MaNV = @Ma
	end
go

--Hàm thống kê số lượng xe của 1 khách hàng mang đến sửa
create function Xe_KH(@Ma int) 
returns @BangThongKe table
(
	MaKH int,
	SoXe int
)as
begin
	if(@Ma is null) or (@Ma = '')
	insert into @BangThongKe
		select MaKH, count(BienSoXe)
		from PHIEUKHAOSAT
		group by MaKH
	else
	insert into @BangThongKe
		select MaKH, count(BienSoXe)
		from PHIEUKHAOSAT
		where MaKH = @Ma
		group by MaKH
	return
end
go
select * from Xe_KH('6')
go

--Hàm hiển thị thông tin xe của từng khách hàng
create function Hienthi_Xe(@Ma int)
returns @HienThi table
(
	MaKH int,
	HoTen nvarchar(50),
	BienSoXe varchar(50),
	HangXe nvarchar(50),
	DoiXe nvarchar(50)
)as
begin
	if(@Ma is null) or (@Ma = '')
	insert into @HienThi
		select kh.MaKH, kh.HoTen, xe.BienSoXe, xe.HangXe, xe.DoiXe
		from KHACHHANG kh, THONGTINXE xe, PHIEUKHAOSAT ks
		where kh.MaKH = ks.MaKH and xe.BienSoXe = ks.BienSoXe
	else
	insert into @HienThi
		select kh.MaKH, kh.HoTen, xe.BienSoXe, xe.HangXe, xe.DoiXe
		from KHACHHANG kh, THONGTINXE xe, PHIEUKHAOSAT ks
		where kh.MaKH = ks.MaKH and xe.BienSoXe = ks.BienSoXe and kh.MaKH = @Ma
	return
end
go
select * from Hienthi_Xe('6')
go


--------trigger---------

--Thêm dữ liệu
create trigger trig_ThemKH on KHACHHANG for insert
as
	declare @MaKH int
	begin
		select @MaKH = MaKH from inserted
		print 'Ma khach hang vua them la:' + convert(varchar(50), @MaKH)
	end
go

create trigger trig_ThemXe on THONGTINXE for insert
as
	declare @BienSoXe varchar(50)
	begin
		select @BienSoXe = BienSoXe from inserted
		print 'Bien so xe vua them la: ' + @BienSoXe
	end
go

create trigger trig_ThongTin on PHIEUKHAOSAT for insert
as
	declare @Ma int
	begin
		select @Ma = MaPhieuKhaoSat from inserted
		print 'Ma phieu khao sat vua them la: ' + convert(varchar(50), @Ma)
	end
go
--nhanvien
create trigger trig_ThemNV on NHANVIEN for insert
as
	declare @MaNV int
	begin
		select @MaNV = MaNV from inserted
		print 'Ma nhan vien vua them la:' + convert(varchar(50), @MaNV)
	end
go
--xuong
create trigger trig_ThemXuong on XUONG for insert
as
	declare @TenXuong varchar(50)
	begin
		select @TenXuong = TenXuong from inserted
		print 'Ten Xuong vua them la: ' + @TenXuong
	end
go
--PhieuDanhGia
create trigger trig_ThemPDG on PHIEUDANHGIA for insert
as
	declare @MaPhieuDanhGia INT
	begin
		select @MaPhieuDanhGia = MaPhieuDanhGia from inserted
		print 'Ma phieu danh gia vua them la: ' +convert(varchar(50) ,@MaPhieuDanhGia)
	end
go
--phieu vat tu
create trigger trig_ThemPVT on PHIEUVATTU for insert
as
	declare @MaPhieuVatTu INT
	begin
		select @MaPhieuVatTu = MaPhieuVatTu from inserted
		print 'Ma phieu vat tu vua them la: ' +convert(varchar(50) ,@MaPhieuVatTu)
	end
go
--them nha cung cap
create trigger trig_ThemNCC on NHACUNGCAP for insert
as
	declare @TenNhaCungCap varchar(50)
	begin
		select @TenNhaCungCap=TenNhaCungCap from inserted
		print 'Ten nha cung cap vua them la:' +@TenNhaCungCap
	end
go
--them hoa don
create trigger trig_ThemHoaDon on HOADON for insert
as
	declare @MaHD int
	begin
		select @MaHD=Ma from inserted
		print 'Ma hoa don vua them vao la:' +convert(varchar(50),@MaHD)
	end
go


--Thêm vào bảng PHIEUKHAOSAT tự động thêm vào bảng bảng PHIEUDANHGIA và PHIEUVATTU

--Xóa
alter trigger trig_XoaThongTinXe on THONGTINXE instead of delete
as
	declare @Ma varchar(50)
	begin
		select @Ma = BienSoXe from deleted

		delete from PHIEUKHAOSAT
		where BienSoXe = @Ma

		delete from THONGTINXE
		where BienSoXe = @Ma

		print 'Xe vua xoa co bien so la : '+@Ma
	end
go

alter trigger trig_XoaKhachHang on KHACHHANG instead of delete
as
	declare @Ma int
	begin
		select @Ma = MaKH from deleted

		delete from PHIEUKHAOSAT
		where MaKH = @Ma

		delete from KHACHHANG
		where MaKH = @Ma

		print 'Ma khach hang vua xoa la : '+convert(varchar(50),@Ma)
	end
go

--XOA NHAN VIEN
alter proc XoaNV(@Ma int)
as
	begin
		delete from NHANVIEN
		where MaNV = @Ma

		print 'Ma Nhan vien vua xoa la : '+convert(varchar(50),@Ma)
	end
go
EXEC XoaNV '6'
--XOA XUONG
alter trigger trig_XoaXuong on XUONG instead of delete
as
declare @TenXuong nvarchar(50)
begin
	select @TenXuong=TenXuong from deleted

	delete from NHANVIEN 
	where TenXuong=@TenXuong

	delete from XUONG 
	where TenXuong=@TenXuong
	print 'Ten xuong vua xoa la : ' +@TenXuong
end
go
--
delete from XUONG
WHERE	TenXuong='Xuong A'
--XOA PHIEU DANH GIA
alter trigger trig_XoaPhieuDanhGia on PHIEUDANHGIA instead of delete
as
declare @MaPDG  int
begin 
	select @MaPDG=MaPhieuDanhGia from deleted

	delete from XUONG
	where MaPhieuDanhGia=@MaPDG

	delete from PHIEUDANHGIA
	where MaPhieuDanhGia=@MaPDG

	print 'Phieu danh gia vua xoa la : '+convert(varchar(50),@MaPDG)
end
go
DELETE FROM PHIEUDANHGIA
WHERE MaPhieuDanhGia='1'
GO 
select TenXuong from Xuong
Go
CREATE PROC USP_GetListHoaDonByDate
@checkIn date,@checkOut date
AS
BEGIN
	SELECT TenHoaDon as [Hóa Đơn],XUONG.TenXuong as [Xưởng],DateCheckIn as [Ngày vào],DateCheckOut as [Ngày ra],HOADON.MaNguoiPhuTrach as [Mã người phụ trách],TongTienThanhToan as [Tổng Tiền Thanh Toán]
	FROM  HOADON,XUONG
	WHERE DateCheckIn >= @checkIn and DateCheckOut <= @checkOut
END

GO

exec USP_GetListHoaDonByDate '20170101','20171001'
exec USP_GetListHoaDonByDate '20171101','20171230'
GO 
select * from HOADON
GO
use QLGara
go
--thu tuc load du lieu len datagirdview
create PROC LayDanhSachHoaDonTheoNgay
@checkIn date,@checkOut date
AS
BEGIN
	SELECT TenHoaDon as [Hóa Đơn],TenXuong as [Xưởng],DateCheckIn as [Ngày vào],DateCheckOut as [Ngày ra],TongTienThanhToan as [Tổng Tiền]
	FROM  HOADON
	WHERE DateCheckIn >= @checkIn and DateCheckOut <= @checkOut
END
GO
GO

CREATE PROC SpThem(@bensoxe varchar(50),@hangxe nvarchar(100),@doixe nvarchar(100),@sokhung nvarchar(100),@somay nvarchar(100),@sokm int)
AS
BEGIN
	INSERT INTO dbo.THONGTINXE 
	        ( BienSoXe ,
	          HangXe ,
	          DoiXe ,
	          SoKhung ,
	          SoMay ,
	          SoKM
	        )
	VALUES  ( @bensoxe, -- BienSoXe - varchar(50)
	          @hangxe , -- HangXe - nvarchar(50)
	          @doixe , -- DoiXe - nvarchar(50)
	          @sokhung , -- SoKhung - nvarchar(50)
			@somay, -- SoMay - nvarchar(50)
	          @sokm  -- SoKM - int
	        )
END

INSERT INTO dbo.THONGTINXE( BienSoXe , HangXe ,DoiXe ,SoKhung , SoMay , SoKM)VALUES  ( '' ,N'' ,N'' ,N'' , N'' ,  0  )
GO
SELECT DISTINCT HangXe FROM dbo.THONGTINXE
GO
SELECT * FROM dbo.THONGTINXE
GO 
--thu tuc update bieu do
create proc updatebieudo
as
begin
	declare @month_pay int= 1;
	declare @money int;
	while @month_pay <= 12
	begin
	select @money=sum(Tongtienthanhtoan) from HOADON where MONTH(DateCheckOut)=@month_pay;
	update tbBieuDo set doanhthu=@money where thang=@month_pay
	set @month_pay=@month_pay+1;
	end
END
GO 
--thu tuc show bieu do
create proc bieudo
as
begin
	select thang as [Tháng],doanhthu as [Tổng Tiền] from tbBieuDo
end
GO 
exec bieudo
GO 
--thu tuc xoa 1 hoa don tren datagirdview
create proc XoaHoaDon
@ten nvarchar(50)
as
begin
	delete from HOADON where Ma in (select Ma from HOADON where TenHoaDon=@ten);
END
GO 
--tao bang bieu do
create table tbBieuDo
(
thang int primary key,
doanhthu int
)
GO 
