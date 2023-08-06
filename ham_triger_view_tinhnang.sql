USE QUAN_LI_CHUYEN_BAY
GO

--------------------------------------------------------------------/* Ham */--------------------------------------------------------------------------------------------------------------------------------------

CREATE FUNCTION hieu_luc_doi_ve
(@ma_ve int)
RETURNS INT
AS
BEGIN
DECLARE @Khoang_cach_dat_ve float
select @Khoang_cach_dat_ve=DATEDIFF(HOUR,VE.ThoiGianDatVe,VE.ThoiGianCatCanh) from VE
where VE.MaVe=@ma_ve
IF(@Khoang_cach_dat_ve <=24)
BEGIN
RETURN 0
END
RETURN 1
END
GO

CREATE FUNCTION funtion_ghe_toi_da
(@ID_VE int )
RETURNS INT
AS
BEGIN
DECLARE @So_ghe_toi_da int;
select @So_ghe_toi_da=MAYBAY.SoLuongGheToiDa from (VE inner join LICHBAY
on Ve.MaCB=LICHBAY.MaCB
and VE.ThoiGianCatCanh=LICHBAY.ThoiGianCatCanh
and VE.ThoiGianHaCanh=LICHBAY.ThoiGianHaCanh)
inner join MAYBAY
on MAYBAY.SoHieu=LICHBAY.SoHieu
Where VE.MaVe=@ID_VE
RETURN @So_ghe_toi_da
END
GO

CREATE FUNCTION [funtion_so_ghe_da_dat]
(@ID_VE int ) RETURNS INT AS BEGIN DECLARE @MaCB varchar(10) DECLARE @Thoigiancatcanh datetime DECLARE @thoigianhacanh datetime
select @MaCB=MaCB,@Thoigiancatcanh=VE.ThoiGianCatCanh,@thoigianhacanh=thoigianhacanh from VE
			  Where VE.MaVe=@ID_VE
DECLARE @soghedadat int
select @soghedadat=count(*) from VE
               where VE.MaCB=@MaCB
			   and format(VE.ThoiGianCatCanh,'YYYY-MM-DD hh:mm:ss')=format(@Thoigiancatcanh,'YYYY-MM-DD hh:mm:ss')
			   and format(VE.ThoiGianHaCanh,'YYYY-MM-DD hh:mm:ss')=format(@thoigianhacanh,'YYYY-MM-DD hh:mm:ss')
RETURN @soghedadat
END
GO

CREATE FUNCTION NgayCuoiThang ( @ThoiGianCatCanh DATE )
RETURNS INT
AS
BEGIN
DECLARE @CheckThang INT, @CheckNgay INT
SELECT @CheckThang = MONTH(@ThoiGianCatCanh), @CheckNgay = DAY(@ThoiGianCatCanh)
IF (@CheckNgay >= 30 and @CheckThang != 2) or (@CheckNgay >= 28 and @CheckThang = 2)
	RETURN 1
RETURN 0
END
GO


--------------------------------------------------------------------/* Ham */--------------------------------------------------------------------------------------------------------------------------------------



--------------------------------------------------------------------/* Trigger */--------------------------------------------------------------------------------------------------------------------------------------



CREATE TRIGGER Tinh_Gio_Bay_Insert
ON LICHBAY
FOR INSERT 
AS
BEGIN
PRINT N'Tinh Gio Bay Insert';
UPDATE PHICONG
SET Gio_bay = Gio_bay + (								
SELECT DATEDIFF(hour, ThoiGianCatCanh, ThoiGianHaCanh)
FROM inserted
WHERE inserted.MaPC = PHICONG.MaPC)					
FROM PHICONG
JOIN inserted ON PHICONG.MaPC = inserted.MaPC		   
END
GO


CREATE TRIGGER Tinh_Gio_Bay_Delete
ON LICHBAY
FOR DELETE
AS
BEGIN
PRINT N'Tinh Gio Bay Delete';
UPDATE PHICONG
SET Gio_bay = Gio_bay - (			
SELECT DATEDIFF(hour, ThoiGianCatCanh, ThoiGianHaCanh)
FROM deleted
WHERE deleted.MaPC = PHICONG.MaPC)		
FROM PHICONG
JOIN deleted ON PHICONG.MaPC = deleted.MaPC 
END
GO



CREATE TRIGGER Tinh_Luong
ON PHICONG
AFTER UPDATE
AS
BEGIN
PRINT N'Tinh Luong';
UPDATE PHICONG
SET Luong_Phi_cong = 1000 * PHICONG.Gio_bay /* 1h bay = 1000$ */
END
GO




CREATE TRIGGER Luong_Giobay_Bandau
ON PHICONG
FOR INSERT
AS
BEGIN
DECLARE @MaPC varchar(10)
SELECT @MaPC = i.MaPC
FROM inserted i
IF EXISTS (SELECT * FROM PHICONG WHERE MaPC = @MaPC)
BEGIN
UPDATE PHICONG
SET Luong_Phi_cong = 0,
Gio_bay = 0
WHERE MaPC = @MaPC
PRINT N'Thanh cong'
END
ELSE
ROLLBACK TRANSACTION
END
GO




CREATE TRIGGER [dbo].[UpdateBangVe] on [dbo].[VE]

FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @Action as char(1);
SET @Action = 'I'; -- Set Action to Insert by default.
IF EXISTS(SELECT * FROM DELETED)
BEGIN
SET @Action =
CASE
WHEN EXISTS(SELECT * FROM INSERTED) THEN 'U' -- Set Action to Updated.
END
END
END

UPDATE VE SET VE.ThoiGianDatVe=GETDATE(), Ve.KhuyenMai = 0, Ve.PhiPhatsinh = 0, Ve.TrangThaiVe = 'Paid' FROM VE inner join inserted on VE.MaVe=inserted.MaVe

DECLARE @newVe INT, @ThoiGianCatCanh DATE, @CheckGhe INT, @CheckGio INT, @CheckTrangThaiVe varchar(30), @SoGheToiDa INT

SELECT @newVe = ne.MaVe, @CheckTrangThaiVe = ne.TrangThaiVe,
@ThoiGianCatCanh = ne.ThoiGianCatCanh, @CheckGhe = ne.SoGhe, @SoGheToiDa = MAYBAY.SoLuongGheToiDa
FROM (inserted ne inner join LICHBAY on ne.MaCB = LICHBAY.MaCB AND ne.ThoiGianCatCanh = LICHBAY.ThoiGianCatCanh AND ne.ThoiGianHaCanh = LICHBAY.ThoiGianHaCanh) inner join MAYBAY on LICHBAY.SoHieu = MAYBAY.SoHieu

IF dbo.NgayCuoiThang(@ThoiGianCatCanh) = 1
BEGIN
UPDATE VE
SET KhuyenMai = KhuyenMai - 0.1 * GiaVe
WHERE VE.MaVe = @newVe
END

IF @Action = 'U' AND dbo.hieu_luc_doi_ve(@newVe) = 1
BEGIN
UPDATE VE
SET TrangThaiVe = 'exchanged',
PhiPhatsinh = PhiPhatsinh + 0.3 * GiaVe
WHERE VE.MaVe = @newVe
END
ELSE IF dbo.hieu_luc_doi_ve(@newVe) = 0
BEGIN
print 'Ve da het hieu luc doi'
ROLLBACK TRANSACTION
END
select @SoGheToiDa=[dbo].[funtion_ghe_toi_da] (@newVe)
IF @Action = 'I'
BEGIN
UPDATE VE
SET TrangThaiVe = 'Paid'
WHERE VE.MaVe = @newVe
END
IF ( SELECT COUNT(SoGhe) as SLGT FROM VE WHERE SoGhe = @CheckGhe ) > 1 
OR (@CheckGhe  > @SoGheToiDa )
BEGIN
print('Loi dat ghe')
ROLLBACK
END

UPDATE VE SET TongGiaVe = GiaVe + PhiPhatsinh + KhuyenMai WHERE VE.MaVe = @newVe
GO





CREATE TRIGGER [dbo].[trigger_Phan_cong_PC] on [dbo].[LICHBAY]
AFTER INSERT , UPDATE
AS
DECLARE @sochuyenbay_CB int
select @sochuyenbay_CB =count(*) from LICHBAY inner join inserted on
inserted.MaPC=LICHBAY.MaPC
where   FORMAT(LICHBAY.ThoiGianCatCanh, 'yyyy-MM-dd')  =FORMAT(inserted.ThoiGianCatCanh, 'yyyy-MM-dd')
IF(@sochuyenbay_CB >1 )
BEGIN
print'Pc da bay du chuyen trong ngay\n'
ROLLBACK TRANSACTION
END
GO

--------------------------------------------------------------------/* Trigger */--------------------------------------------------------------------------------------------------------------------------------------





--------------------------------------------------------------------/* View */--------------------------------------------------------------------------------------------------------------------------------------



CREATE VIEW Thong_Ke_Luong_PC AS
SELECT  TOP(99.99) PERCENT  MaPC,TenPC,Luong_Phi_cong    from PHICONG
ORDER BY Luong_Phi_cong
GO


CREATE VIEW Thong_Ke_SL_Ve AS
SELECT   TOP(99.99) PERCENT  YEAR(ThoiGianDatVe) AS Nam, MONTH(ThoiGianDatVe) AS Thang, COUNT(*) AS SoLuongVe
FROM VE
GROUP BY MONTH(ThoiGianDatVe), YEAR(ThoiGianDatVe)
ORDER BY MONTH(ThoiGianDatVe), YEAR(ThoiGianDatVe)
GO



CREATE VIEW  Thong_ke_PC_bay_nhieu_nhat_moi_thang
AS
select  TOP(99.99) PERCENT  YEAR(ThoiGianCatCanh) AS Nam, MONTH(ThoiGianCatCanh) AS Thang,MaPC ,COUNT(MaPC) AS SoLuongchuyenbay  from LICHBAY
group by MaPC,
MONTH(ThoiGianCatCanh),
YEAR(ThoiGianCatCanh)
ORDER BY MONTH(ThoiGianCatCanh), YEAR(ThoiGianCatCanh)
GO




CREATE VIEW SoLuongMayBay_View AS
SELECT HangSanXuat as HangMayBay, COUNT(*) as SoLuong
FROM dbo.MAYBAY, dbo.LOAIMAYBAY
WHERE LOAIMAYBAY.MaLoaiMayBay = MAYBAY.MaLoaiMayBay
GROUP BY HangSanXuat
GO




--------------------------------------------------------------------/* View */--------------------------------------------------------------------------------------------------------------------------------------



--------------------------------------------------------------------/* Thu tuc */--------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC INSERT_MAY_BAY
(
	@So_hieu varchar (10),
	@MaLoaiMayBay varchar (10),
	@Soghetoida int
)
AS
BEGIN
INSERT INTO MAYBAY VALUES (@So_hieu,@MaLoaiMayBay,@Soghetoida)
END
GO




CREATE PROC UPDATE_MAY_BAY
(
	@So_hieu varchar (10),
	@MaLoaiMayBay varchar (10),
	@Soghetoida int
)
AS
BEGIN
UPDATE MAYBAY SET
SoHieu=@So_hieu,
MaLoaiMayBay=@MaLoaiMayBay,
SoLuongGheToiDa=@Soghetoida
WHERE SoHieu= @So_hieu
END
GO



CREATE PROC DELETE_MAY_BAY
(@So_hieu varchar (10))
AS
BEGIN
DELETE MAYBAY WHERE SoHieu= @So_hieu
END
GO


CREATE PROC proc_goi_y_chuyen_bay
(
@Ngay_muon_bay date,
@Noi_di varchar(10),
@Noi_den varchar(10)
)
AS
BEGIN
SELECT MaCB,ThoiGianCatCanh,ThoiGianHaCanh from LICHBAY
Where LICHBAY.SanBayDi=@Noi_di
and LICHBAY.SanBayDen=@Noi_den
and FORMAT(LICHBAY.ThoiGianCatCanh,'yyyy-MM-dd')=@Ngay_muon_bay
and So_ghe_con_trong>0
END
GO



CREATE PROC INSERT_LOAIMAYBAY
(
	@Maloaimaybay varchar(10),
	@hangsanxuat varchar(50)
)
AS
BEGIN
INSERT INTO LOAIMAYBAY VALUES (@Maloaimaybay,@hangsanxuat)
END
GO



CREATE PROC UPDATE_LOAIMAYBAY
(
	@Maloaimaybay varchar(10),
	@hangsanxuat varchar(50)
)
AS
BEGIN
UPDATE LOAIMAYBAY SET
MaLoaiMayBay=@Maloaimaybay,
HangSanXuat=@hangsanxuat
WHERE MaLoaiMayBay =@Maloaimaybay
END
GO




CREATE PROC DELETE_LOAIMAYBAY
(@MaLoaiMayBay varchar (10))
AS
BEGIN
DELETE LOAIMAYBAY WHERE MaLoaiMayBay=@MaLoaiMayBay
END
GO

CREATE PROC proc_Thong_ke_tinh_trang_chuyen_bay_catcanh_tu_ngay_xy
(
	@Ngay_bat_dau date,
	@Ngay_ket_thuc date
)
AS
BEGIN
Select MaCB,ThoiGianCatCanh,ThoiGianHaCanh,SanBayDi,SanBayDen,TrangThaiMayBay From LICHBAY
Where  FORMAT(LICHBAY.ThoiGianCatCanh, 'yyyy-MM-dd') between @Ngay_bat_dau and  @Ngay_ket_thuc
END
GO



CREATE PROCEDURE Insert_HanhKhach
(
	@CMND_HK varchar(10) ,
	@HotenHK varchar(50) ,
	@NgaySinhHK DATE,
	@DiachiHK varchar(50),
	@SdtHK varchar(11)
)
AS
BEGIN
INSERT INTO [dbo].[HANHKHACH]
(
	[CMND_HK],
	[HotenHK],
	[NgaySinhHK],
	[DiachiHK],
	[SdtHK]
)
VALUES
(
	@CMND_HK,
	@HotenHK,
	@NgaySinhHK,
	@DiachiHK,
	@SdtHK
)
SELECT ERROR_MESSAGE = N'Thêm thành công'
END
GO


CREATE PROCEDURE Update_HanhKhach
(
	@CMND_HK varchar(10) ,
	@HotenHK varchar(50) ,
	@NgaySinhHK DATE,
	@DiachiHK varchar(50),
	@SdtHK varchar(11)
)
AS
BEGIN
UPDATE [dbo].[HANHKHACH]
SET
[HotenHK] = @HotenHK,
[NgaySinhHK] = @NgaySinhHK,
[DiachiHK] = @DiachiHK,
[SdtHK] = @SdtHK
WHERE
[CMND_HK] = @CMND_HK;
SELECT ERROR_MESSAGE = N'Sửa thành công'
END
GO



CREATE PROCEDURE Delete_HanhKhach
(
	@CMND_HK varchar(10)
)
AS
BEGIN
DELETE FROM [dbo].[HANHKHACH]
WHERE [CMND_HK] = @CMND_HK
SELECT ERROR_MESSAGE = N'Xóa thành công'
END
GO


CREATE PROCEDURE DS_HANHKHACH
(
	@MaCB nchar(10),
	@ThoiGianCatCanh DATETIME,
	@ThoiGianHaCanh DATETIME
)
AS
BEGIN
SELECT
HANHKHACH.CMND_HK as CMND,
HANHKHACH.HotenHK as HoTen,
HANHKHACH.NgaySinhHK as NgaySinh,
HANHKHACH.DiachiHK as DiaChi,
HANHKHACH.SdtHK as SDT
FROM ((LICHBAY
INNER JOIN VE ON LICHBAY.MaCB = VE.MaCB)
INNER JOIN HANHKHACH ON VE.CMND_HK = HANHKHACH.CMND_HK)
WHERE LICHBAY.MaCB = @MaCB
AND LICHBAY.ThoiGianCatCanh = @ThoiGianCatCanh
AND LICHBAY.ThoiGianHaCanh = @ThoiGianHaCanh
END
GO




CREATE PROCEDURE AddLichBay
@MaCB varchar(10),
@SoHieu Varchar(10),
@ThoiGianCatCanh DATETIME,
@ThoiGianHaCanh DATETIME,
@SanBayDi varchar(50),
@SanBayDen varchar(50),
@TrangThaiMayBay varchar(30),
@MaPC varchar(10)
AS
INSERT INTO LICHBAY (MaCB,SoHieu,ThoiGianCatCanh,ThoiGianHaCanh,SanBayDi,SanBayDen,TrangThaiMayBay,MaPC)
VALUES ( @MaCB, @SoHieu, @ThoiGianCatCanh, @ThoiGianHaCanh, @SanBayDi, @SanBayDen, @TrangThaiMayBay,  @MaPC)
GO






CREATE PROCEDURE UpdateLichBay 
@MaCB varchar(10),
@SoHieu Varchar(10), 
@ThoiGianCatCanh DATETIME, 
@ThoiGianHaCanh DATETIME, 
@SanBayDi varchar(50), 
@SanBayDen varchar(50), 
@TrangThaiMayBay varchar(30),  
@MaPC varchar(10)
AS
UPDATE LICHBAY
SET MaCB = @MaCB,
SoHieu = @SoHieu, 
ThoiGianCatCanh = @ThoiGianCatCanh,
ThoiGianHaCanh = @ThoiGianHaCanh,
SanBayDi = @SanBayDi,
SanBayDen = @SanBayDen, 
TrangThaiMayBay = @TrangThaiMayBay, 
MaPC = @MaPC
WHERE MaCB = @MaCB 
AND ThoiGianCatCanh = @ThoiGianCatCanh
AND ThoiGianHaCanh = @ThoiGianHaCanh
GO



CREATE PROCEDURE DeleteLichBay @MaCBCheck varchar(10), @ThoiGianCatCanhCheck DATETIME, @ThoiGianHaCanhCheck DATETIME
AS
DELETE LICHBAY
WHERE MaCB = @MaCBCheck 
AND ThoiGianCatCanh = @ThoiGianCatCanhCheck 
AND ThoiGianHaCanh = @ThoiGianHaCanhCheck
GO




CREATE PROC proc_quan_li_don_hang
@IDVE int
AS
Select MaVe,CMND_HK,ThoiGianDatVe,ThoiGianCatCanh,
ThoiGianHaCanh,ThoiGianHaCanh,Noi_Di,
Noi_Den,SoGhe,TongGiaVe from VE
where VE.MaVe=@IDVE
GO




CREATE PROC proc_insert_Ve
(
	@CMND_HK varchar(10) ,
	@MaCB varchar(10) ,
	@ThoiGianCatCanh DATETIME ,
	@ThoiGianHaCanh DATETIME ,
	@Ngay_can_bay DATE,
	@Noi_Di varchar(50),
	@Noi_Den varchar(50) ,
	@SoGhe int,
	@GiaVe float
)
AS
BEGIN
INSERT VE (CMND_HK,MaCB,ThoiGianCatCanh,ThoiGianHaCanh,Ngay_can_bay,Noi_Di,Noi_Den,SoGhe,GiaVe)
VALUES (@CMND_HK,@MaCB,@ThoiGianCatCanh,@ThoiGianHaCanh,@Ngay_can_bay,@Noi_Di,@Noi_Den,@SoGhe,@GiaVe)
END
go



CREATE PROC proc_update_Ve
(
	@MaVe int,
	@CMND_HK varchar(10) ,
	@MaCB varchar(10) ,
	@ThoiGianCatCanh DATETIME ,
	@ThoiGianHaCanh DATETIME ,
	@Ngay_can_bay DATE,
	@Noi_Di varchar(50),
	@Noi_Den varchar(50) ,
	@SoGhe int,
	@GiaVe float
)
AS
BEGIN
UPDATE VE
SET
CMND_HK=@CMND_HK,
MaCB=@MaCB ,
ThoiGianCatCanh=@ThoiGianCatCanh,
ThoiGianHaCanh=@ThoiGianHaCanh,
Ngay_can_bay=@Ngay_can_bay,
Noi_Di=@Noi_Di,
Noi_Den=@Noi_Den,
SoGhe=@SoGhe,
GiaVe=@GiaVe
WHERE MaVe=@MaVe
END
go



CREATE PROC proc_delete_Ve
@MaVe int
AS
BEGIN
DELETE FROM VE
WHERE MaVe=@MaVe
END
go

CREATE PROC proc_insert_KhaNang
(
	@MAPC varchar(10) ,
	@MaLoaiMayBay varchar(10)
)
AS
INSERT INTO [QUAN_LI_CHUYEN_BAY].[dbo].[KHANANG]
VALUES (@MAPC,@MaLoaiMayBay)
GO





CREATE PROC proc_delete_KhaNang
(
	@MAPC varchar(10) ,
	@MaLoaiMayBay varchar(10)
)
AS
DELETE FROM [QUAN_LI_CHUYEN_BAY].[dbo].[KHANANG]
Where MAPC=@MAPC
and MaLoaiMayBay=@MaLoaiMayBay
GO




CREATE PROC proc_insert_PC
(
@MaPC varchar(10) ,
@TenPC varchar(30) ,
@DiaChiPC varchar(50),
@SDT_Phi_cong varchar(11)
)
AS
INSERT INTO [QUAN_LI_CHUYEN_BAY].[dbo].[PHICONG]
(MaPC,TenPC,DiaChiPC,SDT_Phi_cong)
VALUES (@MaPC,@TenPC,@DiaChiPC,@SDT_Phi_cong)
GO


CREATE PROC proc_update_PC
(
@MaPC varchar(10) ,
@TenPC varchar(30) ,
@DiaChiPC varchar(50),
@SDT_Phi_cong varchar(11)
)
AS
UPDATE [QUAN_LI_CHUYEN_BAY].[dbo].[PHICONG]
SET
MaPC =@MaPC,
TenPC=@TenPC,
DiaChiPC=@DiaChiPC,
SDT_Phi_cong=@SDT_Phi_cong
Where MaPC=@MaPC
GO


CREATE PROC proc_delete_PC
@MaPC varchar(10)
AS
DELETE FROM [QUAN_LI_CHUYEN_BAY].[dbo].[PHICONG]
WHERE MaPC=@MaPC
GO


--------------------------------------------------------------------/* Thu tuc */--------------------------------------------------------------------------------------------------------------------------------------



--------------------------------------------------------------------/* tao user  + phan quyen ( USER + ADMIN) */--------------------------------------------------------------------------------------------------------------------------------------



CREATE TABLE tbUser
(
	UserID int IDENTITY(1,1) NOT NULL,
	Username varchar(10) NOT NULL,
	Passwords varchar(15) NOT NULL,
	Actions varchar(10) NOT NULL,
	CONSTRAINT pk_user PRIMARY KEY (UserID)
)
GO


ALTER TABLE tbUser ADD CONSTRAINT check_Action
CHECK (Actions LIKE 'QLNS' OR Actions LIKE 'QLDV')
GO


USE QUAN_LI_CHUYEN_BAY
CREATE LOGIN GIAMDOC WITH PASSWORD = '123'
CREATE USER GIAMDOC FOR LOGIN GIAMDOC
EXEC sp_addrolemember 'db_owner', 'GIAMDOC'
EXEC sp_addrole 'QLNS', 'GIAMDOC'
EXEC sp_addrole 'QLDV', 'GIAMDOC'
GO

CREATE PROCEDURE ChinhSuaQuyen
(
	@Username varchar(15),
	@Actions varchar(10)
)
AS
BEGIN
IF EXISTS (SELECT * FROM tbUser WHERE Username = @Username)
BEGIN
UPDATE tbUser
SET Actions = @Actions
WHERE Username = @Username
PRINT N'Thay đổi quyền thành công'
END
ELSE
BEGIN
SELECT ERROR_MESSAGE = N'Tài khoản không tồn tại'
END
END
GO

CREATE PROCEDURE ThemTaiKhoan
(
	@Username varchar(10),
	@Passwords varchar(15),
	@Actions varchar(10)
)
AS
BEGIN
IF NOT EXISTS (SELECT * FROM tbUser WHERE Username = @Username)
BEGIN
INSERT INTO tbUser
VALUES(@Username, @Passwords, @Actions)
PRINT N'Thêm tài khoản thành công'
END
ELSE
BEGIN
SELECT ERROR_MESSAGE = N'Thêm tài khoản thất bại'
END
END
GO

CREATE PROCEDURE XoaTaiKhoan
(
@Username varchar(10)
)
AS
BEGIN
IF EXISTS (SELECT * FROM tbUser WHERE Username = @Username)
BEGIN
DELETE FROM dbo.tbUser
WHERE Username = @Username;
PRINT N'Xóa tài khoản thành công'
END
ELSE
BEGIN
PRINT N'Xóa tài khoản thất bại'
END
END
GO

CREATE TRIGGER PQ_ThemTaiKhoan
ON tbUser
FOR INSERT
AS
BEGIN
DECLARE @sql varchar(max)
DECLARE @Username varchar(10), @Passwords varchar(15), @Actions varchar(10)
SELECT @Username = i.Username, @Passwords = i.Passwords, @Actions = i.Actions
FROM inserted i
-- Tài khoản là quản lí nhân sự --
IF (@Actions = 'QLNS')
BEGIN
PRINT N'Cấp quyền cho quản lí nhân sự'
SET @sql = '
USE [QUAN_LI_CHUYEN_BAY]
CREATE LOGIN ['+@Username+'] WITH PASSWORD = '''+@Passwords+'''
CREATE USER ['+@Username+'] FOR LOGIN ['+@Username+']
GRANT SELECT, INSERT, UPDATE, DELETE ON PHICONG TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON KHANANG TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON LOAIMAYBAY TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON MAYBAY TO QLNS
GRANT SELECT ON HANHKHACH TO QLNS
GRANT SELECT ON VE TO QLNS
GRANT SELECT ON LICHBAY TO QLNS
EXEC sp_addrolemember ''QLNS'', ['+@Username+']'
EXEC (@sql)
PRINT N'Thành công'
END
ELSE IF (@Actions = 'QLDV')
BEGIN
PRINT N'Cấp quyền cho quản lí dịch vụ'
SET @sql = '
USE [QUAN_LI_CHUYEN_BAY]
CREATE LOGIN ['+@Username+'] WITH PASSWORD = '''+@Passwords+'''
CREATE USER ['+@Username+'] FOR LOGIN ['+@Username+']
GRANT SELECT, INSERT, UPDATE, DELETE ON HANHKHACH TO QLDV
GRANT SELECT, INSERT, UPDATE, DELETE ON VE TO QLDV
GRANT SELECT, INSERT, UPDATE, DELETE ON LICHBAY TO QLDV
GRANT SELECT ON PHICONG TO QLDV
GRANT SELECT ON KHANANG TO QLDV
GRANT SELECT ON LOAIMAYBAY TO QLDV
GRANT SELECT ON MAYBAY TO QLDV
EXEC sp_addrolemember ''QLDV'', ['+@Username+']'
EXEC (@sql)
PRINT N'Thành công'
END
ELSE
ROLLBACK TRANSACTION
END
GO

CREATE TRIGGER PQ_ChinhSuaQuyen
ON tbUser
FOR UPDATE
AS
BEGIN
DECLARE @Username1 varchar(10), @Username2 varchar(10), @Actions varchar(10)
SELECT @Username1 = i.Username, @Actions = i.Actions
FROM inserted i
SELECT @Username2 = d.Username
FROM deleted d
DECLARE @sql varchar(max)
IF (@Username1 = @Username2)
-- Tài khoản là quản lí nhân sự --
IF (@Actions = 'QLNS')
BEGIN
PRINT N'Cấp quyền cho quản lí nhân sự'
SET @sql = '
USE [QUAN_LI_CHUYEN_BAY]
GRANT SELECT, INSERT, UPDATE, DELETE ON PHICONG TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON KHANANG TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON LOAIMAYBAY TO QLNS
GRANT SELECT, INSERT, UPDATE, DELETE ON MAYBAY TO QLNS
GRANT SELECT ON HANHKHACH TO QLNS
GRANT SELECT ON VE TO QLNS
GRANT SELECT ON LICHBAY TO QLNS
EXEC sp_addrolemember ''QLNS'', ['+@Username1+']'
EXEC (@sql)
PRINT N'Thành công'
END
ELSE IF (@Actions = 'QLDV')
BEGIN
PRINT N'Cấp quyền cho quản lí dịch vụ'
SET @sql = '
USE [QUAN_LI_CHUYEN_BAY]
GRANT SELECT, INSERT, UPDATE, DELETE ON HANHKHACH TO QLDV
GRANT SELECT, INSERT, UPDATE, DELETE ON VE TO QLDV
GRANT SELECT, INSERT, UPDATE, DELETE ON LICHBAY TO QLDV
GRANT SELECT ON PHICONG TO QLDV
GRANT SELECT ON KHANANG TO QLDV
GRANT SELECT ON LOAIMAYBAY TO QLDV
GRANT SELECT ON MAYBAY TO QLDV
EXEC sp_addrolemember ''QLDV'', ['+@Username1+']'
EXEC (@sql)
PRINT N'Thành công'
END
ELSE
ROLLBACK TRANSACTION
END
GO


CREATE TRIGGER PQ_XoaTaiKhoan
ON tbUser
FOR DELETE
AS
BEGIN
DECLARE @Username varchar(10)
SELECT @Username = d.Username
FROM deleted d
DECLARE @sql varchar(max)
SET @sql = '
DROP USER ['+@Username+']
DROP LOGIN ['+@Username+']'
EXEC(@sql)
PRINT N'thành công'
END
GO

CREATE PROCEDURE KiemTraDangNhap
(
@Username varchar(10),
@Passwords varchar(15)
)
AS
BEGIN
IF EXISTS (SELECT * FROM tbUser WHERE Username LIKE @Username AND Passwords LIKE @Passwords)
BEGIN
SELECT * FROM tbUser
WHERE Username LIKE @Username AND Passwords LIKE @Passwords
PRINT N'Tìm thấy tài khoản'
END
ELSE
BEGIN
SELECT ERROR_MESSAGE = N'Tài khoản không tồn tại'
END
END
GO


CREATE PROCEDURE KiemTraQuyen
@TenQuyen nvarchar(50)
AS
BEGIN
IF EXISTS (SELECT * FROM tbUser WHERE Actions = @TenQuyen)
BEGIN
SELECT * FROM tbUser
WHERE Actions = @TenQuyen
PRINT N'Tìm thấy các tài khoản thuộc quyền đã nhập'
END
ELSE
BEGIN
SELECT ERROR_MESSAGE = N'Sai tên quyền'
END
END
GO


CREATE PROCEDURE DoiMatKhau
(
@Username varchar(50),
@NewPassword varchar(50)
)
AS
BEGIN
IF EXISTS (SELECT * FROM tbUser WHERE Username = @Username)
BEGIN
UPDATE tbUser
SET Passwords = @NewPassword
WHERE Username = @Username
PRINT N'Đổi mật khẩu thành công'
END
ELSE
BEGIN
SELECT ERROR_MESSAGE = N'Đổi mật khẩu thất bại'
END
END
GO


CREATE TRIGGER PQ_DoiMatKhau
ON tbUser
FOR UPDATE
AS
BEGIN
DECLARE @Username1 varchar(10), @Username2 varchar(10), @Newpassword varchar(15)
SELECT @Username1 = i.Username, @Newpassword = i.Passwords
FROM inserted i
SELECT @Username2 = d.Username
FROM deleted d
DECLARE @sql varchar(max)
IF (@Username1 = @Username2)
BEGIN
SET @sql = '
ALTER LOGIN ['+@Username1+']
WITH PASSWORD = '''+@NewPassword+''' '
EXEC (@sql)
PRINT N'Đổi mật khẩu thành công'
END
ELSE
ROLLBACK TRANSACTION
END
GO


CREATE TRIGGER tg_CheckTaiKhoan
ON tbUser FOR INSERT, UPDATE
AS
BEGIN
DECLARE @Username varchar(50), @Temp int
SELECT @Username = inserted.Username FROM inserted
SELECT @Temp = COUNT(*) FROM tbUser
WHERE Username = @Username
IF (@Temp > 1)
BEGIN
PRINT N'Tài khoản đã tồn tại'
ROLLBACK TRANSACTION
END
END
GO

EXEC ThemTaiKhoan 'QLNS1', '123', 'QLNS'
GO

EXEC ThemTaiKhoan 'QLDV1', '123', 'QLDV'
GO



--------------------------------------------------------------------/* tao user  + phan quyen ( USER + ADMIN) */--------------------------------------------------------------------------------------------------------------------------------------
