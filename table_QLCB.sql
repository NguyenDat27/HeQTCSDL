CREATE DATABASE QUAN_LI_CHUYEN_BAY
GO
USE QUAN_LI_CHUYEN_BAY
GO

CREATE TABLE dn_admin
(
	TKadmin varchar(10),
	MKadmin varchar(10),
	CONSTRAINT pk_dn_admin PRIMARY KEY (TKadmin)
)
GO
INSERT INTO dn_admin VALUES ('admin', 'admin')
GO
CREATE TABLE dn_hk
(
	TKhk varchar(10),
	MKhk varchar(10),
	CONSTRAINT pk_dn_hk PRIMARY KEY (TKhk)
)
INSERT INTO dn_hk VALUES ('user', 'user')
GO

CREATE TABLE HANHKHACH
(
CMND_HK varchar(10) ,
HotenHK varchar(50) ,
NgaySinhHK DATE,
DiachiHK varchar(50),
SdtHK varchar(11) ,
CONSTRAINT pk_HANHKHACH PRIMARY KEY(CMND_HK)
);
CREATE TABLE PHICONG
(
MaPC varchar(10) ,
TenPC varchar(30) ,
DiaChiPC varchar(50),
SDT_Phi_cong varchar(11) ,
Luong_Phi_cong Float,
Gio_bay float,
CONSTRAINT pk_PHICONG PRIMARY KEY (MaPC)
);

CREATE TABLE LOAIMAYBAY
(
MaLoaiMayBay varchar(10) ,
HangSanXuat varchar(50) ,
CONSTRAINT pk_LOAIMAYBAY PRIMARY KEY (MaLoaiMayBay));

CREATE TABLE KHANANG
(
MAPC varchar(10) ,
MaLoaiMayBay varchar(10)  ,
CONSTRAINT pk_KHANANG PRIMARY KEY(MaPC,MaLoaiMayBay),
CONSTRAINT  fk_KHANANG_PHICONG FOREIGN KEY(MAPC)
REFERENCES PHICONG(MAPC),
CONSTRAINT  fk_KHANANG_LOAIMAYBAY FOREIGN KEY(MaLoaiMayBay)
REFERENCES LOAIMAYBAY(MaLoaiMayBay)
);

CREATE TABLE MAYBAY
(
SoHieu Varchar(10),
MaLoaiMayBay varchar(10),
SoLuongGheToiDa INT ,
CONSTRAINT pk_MAYBAY PRIMARY KEY(SoHieu),
CONSTRAINT fk_MAYBAY_LOAIMAYBAY FOREIGN KEY(MaLoaiMayBay)
REFERENCES LOAIMAYBAY(MaLoaiMayBay)
);
CREATE TABLE LICHBAY
(
MaCB varchar(10) ,
SoHieu Varchar(10),
ThoiGianCatCanh DATETIME ,
ThoiGianHaCanh DATETIME ,
SanBayDi varchar(50) CHECK ( SanBayDi IN('HCM','Ha Noi','Da Nang')),
SanBayDen varchar(50)CHECK ( SanBayDen IN('HCM','Ha Noi','Da Nang')),
TrangThaiMayBay varchar(30) CHECK ( TrangThaiMayBay IN ('landing','flying','take off','delay','cancel',NULL)), /* 4
Trang thai : cat canh , ha canh, dang bay,delay,cancel,NULL chua hoat dong */
So_ghe_con_trong int,
MaPC varchar(10) ,
CONSTRAINT pk_LICHBAY PRIMARY KEY(MaCB, ThoiGianCatCanh, ThoiGianHaCanh),
CONSTRAINT fK_LICHBAY_MAYBAY FOREIGN KEY(SoHieu )
REFERENCES MAYBAY (SoHieu),
CONSTRAINT fK_LICHBAY_PC FOREIGN KEY(MaPC)
REFERENCES PHICONG (MaPC) 
);

CREATE TABLE VE
(
MaVe int IDENTITY(1,1) ,
CMND_HK varchar(10) ,
MaCB varchar(10) ,
ThoiGianDatVe DATETIME,
ThoiGianCatCanh DATETIME ,
ThoiGianHaCanh DATETIME ,
Ngay_can_bay DATE,/* bs*/
Noi_Di varchar(50)CHECK ( Noi_Di IN('HCM','Ha Noi','Da Nang')),
Noi_Den varchar(50) CHECK ( Noi_Den IN('HCM','Ha Noi','Da Nang')),
TrangThaiVe varchar(30) CHECK (TrangThaiVe IN('exchanged','Paid') ), /* trang thai : da mua , doi tra*/
SoGhe int,
GiaVe float  check (Giave>0),
PhiPhatsinh float check(PhiPhatsinh>=0),
KhuyenMai float check(KhuyenMai <=0),/* khuyen mai luon am */
TongGiaVe Float check (TongGiaVe >= 0),
CONSTRAINT pk_VE PRIMARY KEY (MaVe),
CONSTRAINT fk_VE_LICHBAY FOREIGN KEY(MaCB, ThoiGianCatCanh, ThoiGianHaCanh)
REFERENCES LICHBAY(MaCB, ThoiGianCatCanh, ThoiGianHaCanh),
CONSTRAINT fk_VE_HANHKHACH FOREIGN KEY(CMND_HK)
REFERENCES HANHKHACH(CMND_HK)
);