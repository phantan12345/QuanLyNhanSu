USE [master]
GO
/****** Object:  Database [NhanSu]    Script Date: 4/23/2023 6:22:24 PM ******/
CREATE DATABASE [NhanSu]
 ON  PRIMARY 
( NAME = N'NhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\NhanSu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\NhanSu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NhanSu] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [NhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [NhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NhanSu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NhanSu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [NhanSu] SET QUERY_STORE = ON
GO
ALTER DATABASE [NhanSu] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [NhanSu]
GO
/****** Object:  Table [dbo].[BangCong]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCong](
	[MaBangCong] [char](10) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayLam] [int] NULL,
	[ThangLam] [int] NULL,
	[NamLam] [int] NULL,
	[Active] [bit] NULL,
	[SoGioTangCa] [int] NULL,
	[MaNV] [char](10) NULL,
 CONSTRAINT [PK_BangCong] PRIMARY KEY CLUSTERED 
(
	[MaBangCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MaLuong] [char](10) NOT NULL,
	[PCPhongBan] [float] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[MaNV] [char](10) NULL,
	[PCChucVu] [float] NULL,
	[SoNgayNghi] [int] NULL,
	[SoNgayLam] [int] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[Thuong] [float] NULL,
	[KyLuat] [float] NULL,
	[SoGioTangCa] [int] NULL,
	[LuongTotal] [float] NULL,
	[BaoHiem] [float] NULL,
 CONSTRAINT [PK_BangLuong] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoHiem]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHiem](
	[MaBH] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[ThangDong] [int] NULL,
	[NamDong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_BaoHiem] PRIMARY KEY CLUSTERED 
(
	[MaBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[MaBoPhan] [char](10) NULL,
	[MaPhong] [char](10) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[TTHonNhan] [bit] NULL,
	[CCCD] [char](10) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[ThoiGian] [int] NULL,
	[NgayKy] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[SoDienThoai] [char](10) NULL,
	[MaPhieuThaiSan] [char](10) NULL,
	[username] [char](10) NULL,
	[password] [char](15) NULL,
	[role] [bit] NULL,
	[active] [bit] NULL,
	[email] [nvarchar](50) NULL,
	[LCB] [float] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [char](10) NOT NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[NgayThanhLap] [datetime] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[MaBoPhan] [char](10) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TangLuong]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TangLuong](
	[MaPhieu] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[LCB] [float] NULL,
	[LCBMoi] [float] NULL,
	[NgaySua] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TangLuong] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangLuong] ([MaLuong], [PCPhongBan], [GhiChu], [MaNV], [PCChucVu], [SoNgayNghi], [SoNgayLam], [Thang], [Nam], [Thuong], [KyLuat], [SoGioTangCa], [LuongTotal], [BaoHiem]) VALUES (N'ML1       ', NULL, NULL, N'NV1       ', 500, 3, NULL, 3, 2023, 0, 0, NULL, 2200, NULL)
INSERT [dbo].[BangLuong] ([MaLuong], [PCPhongBan], [GhiChu], [MaNV], [PCChucVu], [SoNgayNghi], [SoNgayLam], [Thang], [Nam], [Thuong], [KyLuat], [SoGioTangCa], [LuongTotal], [BaoHiem]) VALUES (N'ML2       ', NULL, NULL, N'NV1       ', 500, 3, NULL, 4, 2023, 0, 0, NULL, 2500, NULL)
INSERT [dbo].[BangLuong] ([MaLuong], [PCPhongBan], [GhiChu], [MaNV], [PCChucVu], [SoNgayNghi], [SoNgayLam], [Thang], [Nam], [Thuong], [KyLuat], [SoGioTangCa], [LuongTotal], [BaoHiem]) VALUES (N'ML3       ', NULL, NULL, N'NV2       ', 400, 4, NULL, 3, 2023, 0, 0, NULL, 1700, NULL)
INSERT [dbo].[BangLuong] ([MaLuong], [PCPhongBan], [GhiChu], [MaNV], [PCChucVu], [SoNgayNghi], [SoNgayLam], [Thang], [Nam], [Thuong], [KyLuat], [SoGioTangCa], [LuongTotal], [BaoHiem]) VALUES (N'ML4       ', NULL, NULL, N'NV2       ', 400, 3, NULL, 4, 2023, 0, 0, NULL, 1600, NULL)
GO
INSERT [dbo].[BaoHiem] ([MaBH], [MaNV], [ThangDong], [NamDong], [GhiChu], [TiLe]) VALUES (N'BH1       ', N'NV1       ', 3, 2023, N'0', 10)
INSERT [dbo].[BaoHiem] ([MaBH], [MaNV], [ThangDong], [NamDong], [GhiChu], [TiLe]) VALUES (N'BH2       ', N'NV1       ', 4, 2023, N'0', 10)
INSERT [dbo].[BaoHiem] ([MaBH], [MaNV], [ThangDong], [NamDong], [GhiChu], [TiLe]) VALUES (N'BH3       ', N'NV1       ', 3, 2024, N'0', 10)
INSERT [dbo].[BaoHiem] ([MaBH], [MaNV], [ThangDong], [NamDong], [GhiChu], [TiLe]) VALUES (N'BH4       ', N'NV2       ', 3, 2023, N'0', 10)
INSERT [dbo].[BaoHiem] ([MaBH], [MaNV], [ThangDong], [NamDong], [GhiChu], [TiLe]) VALUES (N'BH5       ', N'NV2       ', 4, 2023, N'0', 10)
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [SoDienThoai], [MaPhieuThaiSan], [username], [password], [role], [active], [email], [LCB]) VALUES (N'NV1       ', N'Đặng Văn Mãi', NULL, N'PB1       ', CAST(N'2001-12-19T00:00:00.000' AS DateTime), 0, NULL, N'2323232323', NULL, N'Team Lead', NULL, NULL, CAST(N'2023-01-19T00:00:00.000' AS DateTime), NULL, N'0987654321', NULL, N'admin     ', N'admin          ', 0, 1, N'mai.dv@gmai.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [SoDienThoai], [MaPhieuThaiSan], [username], [password], [role], [active], [email], [LCB]) VALUES (N'NV2       ', N'Nguyễn Hồng Sơn', NULL, N'PB1       ', CAST(N'2002-01-01T00:00:00.000' AS DateTime), 1, NULL, N'2333333333', NULL, N'Nhân Viên', NULL, NULL, CAST(N'2023-01-19T00:00:00.000' AS DateTime), NULL, N'0987654321', NULL, N'admin1    ', N'admin1         ', 1, 1, N'son.nh@gmail.com', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [SoDienThoai], [MaPhieuThaiSan], [username], [password], [role], [active], [email], [LCB]) VALUES (N'NV3       ', N'Phan Nhựt Tân', NULL, N'PB1       ', CAST(N'2002-01-01T00:00:00.000' AS DateTime), 0, NULL, N'3434343434', NULL, N'Nhân Viên', NULL, NULL, NULL, NULL, N'0909090909', NULL, N'admin2    ', N'admin2         ', 1, 1, N'tan.pn@gmail.com', NULL)
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [NgayThanhLap], [GhiChu], [MaBoPhan]) VALUES (N'PB1       ', N'DEV', NULL, NULL, NULL)
GO
INSERT [dbo].[TangLuong] ([MaPhieu], [MaNV], [LCB], [LCBMoi], [NgaySua], [GhiChu]) VALUES (N'GL1       ', N'NV1       ', 3000, 2800, CAST(N'2023-04-23T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TangLuong] ([MaPhieu], [MaNV], [LCB], [LCBMoi], [NgaySua], [GhiChu]) VALUES (N'TL1       ', N'NV1       ', 2500, 3000, CAST(N'2023-01-23T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TangLuong] ([MaPhieu], [MaNV], [LCB], [LCBMoi], [NgaySua], [GhiChu]) VALUES (N'TL2       ', N'nv1       ', 2800, 3200, CAST(N'2023-04-25T00:00:00.000' AS DateTime), NULL)
GO
ALTER TABLE [dbo].[BangCong]  WITH CHECK ADD  CONSTRAINT [FK_BangCong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BangCong] CHECK CONSTRAINT [FK_BangCong_NhanVien]
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD  CONSTRAINT [FK_BangLuong_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BangLuong] CHECK CONSTRAINT [FK_BangLuong_NhanVien1]
GO
ALTER TABLE [dbo].[BaoHiem]  WITH CHECK ADD  CONSTRAINT [FK_BaoHiem_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BaoHiem] CHECK CONSTRAINT [FK_BaoHiem_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[TangLuong]  WITH CHECK ADD  CONSTRAINT [FK_TangLuong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TangLuong] CHECK CONSTRAINT [FK_TangLuong_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[proc_logic]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_logic]
    @user nCHAR(50),
    @pass nCHAR(50),
    @role bit
AS
BEGIN
    SELECT * FROM NhanVien WHERE username = @user AND password = @pass AND role = @role
END
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 4/23/2023 6:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[proc_login] 
@user nchar(10),
@pass nchar(15)
as 
begin 
	select * from NhanVien a where a.username = @user and a.password = @pass
end
GO
USE [master]
GO
ALTER DATABASE [NhanSu] SET  READ_WRITE 
GO
