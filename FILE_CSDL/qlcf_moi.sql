USE [quanliquancoffee50]
GO
/****** Object:  Table [dbo].[ThucAn]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[idLoaiThucAn] [int] NOT NULL,
	[price] [float] NOT NULL,
	[Trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ThucAn] ON
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (1, N'coca', 1, 10000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (2, N'coca', 1, 10, 0)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (3, N'Tra dao', 2, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (4, N'Tra sua', 2, 18000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (5, N'coffee sua', 3, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (6, N'coffee den', 3, 12, 0)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (7, N'Banh mi cha ca', 4, 10000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (8, N'Com tam', 4, 25000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (9, N'coffee den', 3, 12000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (10, N'Banh mi truyen thong', 4, 10000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (13, N'coffee sua', 5, 15, 0)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (19, N'Com tam', 4, 25000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (21, N'Tra dao', 3, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (25, N'sting', 1, 12000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (26, N'coffee sua', 3, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (30, N'Com tam', 4, 25000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (31, N'Com tam', 30, 25, 0)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (32, N'coffee sua da', 3, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (35, N'sting', 1, 10000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (36, N'banh mi xa xiu', 4, 15000, 1)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (37, N'', 0, 0, 0)
INSERT [dbo].[ThucAn] ([id], [Ten], [idLoaiThucAn], [price], [Trangthai]) VALUES (38, N'coca', 0, 10000, 1)
SET IDENTITY_INSERT [dbo].[ThucAn] OFF
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Tendangnhap] [nvarchar](100) NOT NULL,
	[Matkhau] [nvarchar](1000) NULL,
	[Loai] [nvarchar](12) NULL,
	[Trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Tendangnhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([Tendangnhap], [Matkhau], [Loai], [Trangthai]) VALUES (N'halinh01', N'123', N'Nhan vien', 1)
INSERT [dbo].[TaiKhoan] ([Tendangnhap], [Matkhau], [Loai], [Trangthai]) VALUES (N'sangminh01', N'123', N'Nhan vien', 1)
INSERT [dbo].[TaiKhoan] ([Tendangnhap], [Matkhau], [Loai], [Trangthai]) VALUES (N'sangpham01', N'123', N'Nhan vien', 1)
INSERT [dbo].[TaiKhoan] ([Tendangnhap], [Matkhau], [Loai], [Trangthai]) VALUES (N'tranvinh01', N'123', N'Quan li', 1)
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tendangnhap] [nvarchar](100) NOT NULL,
	[Hoten] [nvarchar](100) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Dienthoai] [nvarchar](11) NULL,
	[Chucvu] [nvarchar](100) NULL,
	[Trangthai] [int] NOT NULL,
	[Matkhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (1, N'tranvinh01dsafsad', N'Vinh', N'Nam', N'0868420530', N'Quan li', 0, N'123')
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (2, N'halinh01', N'Ha Linh', N'Nu', N'0994202550', N'Nhan vien', 0, N'123')
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (3, N'sangpham01', N'Pham Sang', N'Nam', N'0915475005', N'Quan li', 1, N'123')
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (4, N'sangminh01', N'Minh Sang', N'Nam', N'0981338326', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (5, N'd', N'd', N'Nam', N'0123456789', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (6, N's', N'd', N'Nam', N'd111', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (7, N'd', N'd', N'Nu', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (8, N'', N'', N'Nu', N'', N'Quan li', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (9, N'', N'', N'Nu', N'', N'Quan li', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (10, N'', N'', N'Nu', N'', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (11, N'd', N'fffff', N'Nam', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (12, N'halinh01', N'Ha Linh', N'Nam', N'0994202550', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (13, N'dsads', N'', N'Nam', N'', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (15, N'd', N'd', N'Nu', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (16, N'd', N'd', N'Nu', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (17, N'dsads', N'', N'Nu', N'', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (18, N'halinh01', N'Ha Linh', N'Nam', N'0994202550', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (19, N'd', N'd', N'Nam', N'qs', N'qd', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (20, N'd', N'd', N'Nam', N'qs', N'qd', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (21, N'd', N'd', N'Nu', N'086897562', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (22, N'sangpham01', N'Pham Sang', N'Nu', N'0915475005', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (23, N'sangpham01', N'Pham Sang', N'Nam', N'0915475005', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (24, N'sangpham01', N'Pham Sang vv', N'Nam', N'0915475005', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (25, N'sangpham01', N'Pham Sang vv quy', N'Nam', N'0915475005', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (26, N'quy', N'ien', N'Nam', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (27, N'quydasfas asd ADSA ', N'D ASD SA DAS', N'Nu', N'086897562', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (28, N'sangpham01', N'dss', N'Nam', N'0915475005', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (29, N'd', N'd', N'Nu', N'086897562', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (30, N'', N'', N'Nam', N'', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (31, N'huy', N'', N'Nam', N'', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (32, N'huy', N'', N'Nam', N'', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (33, N'', N'', N'Nu', N'', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (34, N'sangminh01', N'Minh Sang', N'Nam', N'0981338326', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (35, N'tranvinh01dsafsad', N'Vinh', N'Nam', N'0868420530', N'Quan li', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (36, N'', N'', N'Nam', N'', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (38, N'tranvinh01dsafsad', N'Vinh', N'Nam', N'0868420530', N'Quan li', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (39, N'tranvinh01', N'Vinh', N'Nam', N'0868420530', N'Quan li', 1, N'123')
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (40, N'tranvinh01dsafsad', N'Vinh', N'Nam', N'0868420530', N'Quan li', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (41, N'', N'', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (42, N'', N'', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (43, N'kkkgk,k', N'gfhhnvhh', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (44, N'hjgj', N'', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (45, N'tantien', N'tien', N'Nam', N'0123456', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (46, N'', N'', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (47, N'tantien', N'tien', N'Nam', N'0123789', N'Nhan vien', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (48, N'', N'', N'Nam', N'', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (49, N'v', N'', N'Nam', N'', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (50, N'', N'', N'Nam', N'', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (51, N'sangpham01', N'Pham Sang', N'Nam', N'0915475005', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (52, N'', N'', N'Nam', N'', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (53, N'sangpham01', N'Pham Sang vv quy', N'Nam', N'0915475005', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (54, N'd', N'd', N'Nu', N'086897562', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (55, N'sdfsfdsf', N'dsfdsf', N'Nam', N'1111111111', N'Nhan vien', 1, NULL)
INSERT [dbo].[NhanVien] ([id], [Tendangnhap], [Hoten], [Gioitinh], [Dienthoai], [Chucvu], [Trangthai], [Matkhau]) VALUES (56, N'minh', N'tran', N'Nam', N'', N'', 1, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  Table [dbo].[LoaiThucAn]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[Trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoaiThucAn] ON
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (1, N'', 0)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (2, N'Tra', 1)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (3, N'Coffee', 1)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (4, N'Diem tam', 1)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (5, N'Trasacascsac', 0)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (6, N'Diem tam', 1)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (7, N'Diem tamc', 1)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (8, N'Trasacascsac', 0)
INSERT [dbo].[LoaiThucAn] ([id], [Ten], [Trangthai]) VALUES (9, N'', 0)
SET IDENTITY_INSERT [dbo].[LoaiThucAn] OFF
/****** Object:  Table [dbo].[HoaDon]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NULL,
	[TongTien] [int] NULL,
	[Trangthai] [int] NOT NULL,
	[Ban] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON
INSERT [dbo].[HoaDon] ([id], [NgayLap], [TongTien], [Trangthai], [Ban]) VALUES (383, CAST(0x0000ABFF000BB640 AS DateTime), 0, 1, N'Ban 1')
INSERT [dbo].[HoaDon] ([id], [NgayLap], [TongTien], [Trangthai], [Ban]) VALUES (384, CAST(0x0000ABFF000FAD63 AS DateTime), 60000, 1, N'Ban 5')
INSERT [dbo].[HoaDon] ([id], [NgayLap], [TongTien], [Trangthai], [Ban]) VALUES (385, CAST(0x0000AC0000CFF30C AS DateTime), NULL, 1, N'Ban 5')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[count] [int] NOT NULL,
	[Thanhtien] [float] NULL,
	[Food] [nvarchar](50) NULL,
	[Trangthai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON
INSERT [dbo].[ChiTietHoaDon] ([id], [idBill], [count], [Thanhtien], [Food], [Trangthai]) VALUES (394, 383, 5, 10000, N'Banh mi truyen thong', 1)
INSERT [dbo].[ChiTietHoaDon] ([id], [idBill], [count], [Thanhtien], [Food], [Trangthai]) VALUES (395, 383, 9, 50000, N'Banh mi cha ca', 1)
INSERT [dbo].[ChiTietHoaDon] ([id], [idBill], [count], [Thanhtien], [Food], [Trangthai]) VALUES (396, 384, 9, 108000, N'coffee den', 1)
INSERT [dbo].[ChiTietHoaDon] ([id], [idBill], [count], [Thanhtien], [Food], [Trangthai]) VALUES (397, 384, 1, 25000, N'Com tam', 1)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
/****** Object:  Table [dbo].[BanAn]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NULL,
	[Trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (48, N'Ban 1', N'1', 1)
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (49, N'Ban 2', N'1', 1)
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (50, N'Ban 3', N'1', 1)
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (51, N'Ban 4', N'1', 0)
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (52, N'Ban 5', N'1', 1)
INSERT [dbo].[BanAn] ([id], [Ten], [status], [Trangthai]) VALUES (53, N'Ban 6', N'1', 1)
SET IDENTITY_INSERT [dbo].[BanAn] OFF
/****** Object:  StoredProcedure [dbo].[USP_TableFood]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_TableFood]
  AS SELECT* FROM dbo.BanAn
GO
/****** Object:  StoredProcedure [dbo].[Getlistaccount]    Script Date: 07/27/2020 23:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Getlistaccount]
  @tenDangNhap nvarchar(100)
  AS
  BEGIN
        SELECT * FROM dbo.TaiKhoan WHERE Tendangnhap = @tenDangNhap
  END
GO
/****** Object:  Default [DF__BanAn__Ten__145C0A3F]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT (N'ten') FOR [Ten]
GO
/****** Object:  Default [DF__BanAn__status__15502E78]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT (N'Ban trong') FOR [status]
GO
/****** Object:  Default [DF__BanAn__Trangthai__286302EC]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__ChiTietHo__count__5DCAEF64]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [count]
GO
/****** Object:  Default [DF__ChiTietHo__Trang__60A75C0F]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__HoaDon__Trangtha__628FA481]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__LoaiThucAn__Ten__08EA5793]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[LoaiThucAn] ADD  DEFAULT (N'Chua co ten') FOR [Ten]
GO
/****** Object:  Default [DF__LoaiThucA__Trang__2B3F6F97]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[LoaiThucAn] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__NhanVien__Trangt__267ABA7A]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__TaiKhoan__Trangt__276EDEB3]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
/****** Object:  Default [DF__ThucAn__Ten__0DAF0CB0]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[ThucAn] ADD  DEFAULT (N'Chua co ten') FOR [Ten]
GO
/****** Object:  Default [DF__ThucAn__price__0EA330E9]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[ThucAn] ADD  DEFAULT ((0)) FOR [price]
GO
/****** Object:  Default [DF__ThucAn__Trangtha__2C3393D0]    Script Date: 07/27/2020 23:54:16 ******/
ALTER TABLE [dbo].[ThucAn] ADD  DEFAULT ((1)) FOR [Trangthai]
GO
