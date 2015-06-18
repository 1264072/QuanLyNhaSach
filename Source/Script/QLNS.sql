USE [master]
GO
/****** Object:  Database [DOAN_QUANLYNHASACH_NHOM14]    Script Date: 18/06/2015 3:33:12 PM ******/
CREATE DATABASE [DOAN_QUANLYNHASACH_NHOM14]
GO
USE [DOAN_QUANLYNHASACH_NHOM14]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 18/06/2015 3:33:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MAHD] [varchar](100) NOT NULL,
	[MADS] [varchar](100) NOT NULL,
	[MATL] [varchar](100) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [money] NOT NULL,
	[THANHTIEN] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MAPN] [varchar](100) NOT NULL,
	[MADS] [varchar](100) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [money] NOT NULL,
	[THANHTIEN] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MACV] [varchar](100) NOT NULL,
	[TENCV] [nvarchar](100) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONGNO]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONGNO](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [varchar](100) NOT NULL,
	[NGAYPHATSINH] [date] NOT NULL,
	[NODAU] [money] NOT NULL,
	[PHATSINH] [money] NOT NULL,
	[NOCUOI] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MADS] [int] IDENTITY(1,1) NOT NULL,
	[TENSACH] [nvarchar](200) NOT NULL,
	[MATL] [varchar](100) NOT NULL,
	[TACGIA] [nvarchar](100) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [money] NOT NULL,
 CONSTRAINT [PK_DAUSACH] PRIMARY KEY CLUSTERED 
(
	[MADS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [varchar](100) NOT NULL,
	[MAKH] [varchar](100) NOT NULL,
	[NGAYLAP] [date] NOT NULL,
	[MANV] [varchar](100) NOT NULL,
	[TONGTIEN] [money] NOT NULL,
	[TIENTRA] [money] NOT NULL,
	[TIENNO] [money] NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](100) NOT NULL,
	[HOTEN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[NO] [bit] NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [varchar](100) NOT NULL,
	[TENNCC] [nvarchar](100) NULL,
	[SDT] [varchar](15) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [varchar](100) NOT NULL,
	[HOTEN] [nvarchar](100) NULL,
	[SDT] [varchar](15) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
	[MACV] [varchar](100) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUCHI]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUCHI](
	[MAPC] [varchar](100) NOT NULL,
	[MANV] [varchar](100) NOT NULL,
	[NGAYLAP] [date] NOT NULL,
	[TIENCHI] [money] NOT NULL,
	[MAPN] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [varchar](100) NOT NULL,
	[NGAYLAP] [date] NOT NULL,
	[MANV] [varchar](100) NOT NULL,
	[MANCC] [varchar](100) NOT NULL,
	[TONGTIEN] [money] NOT NULL,
	[CONNO] [money] NOT NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHUNO]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHUNO](
	[MAPT] [varchar](100) NOT NULL,
	[MAKH] [varchar](100) NOT NULL,
	[NGAYLAP] [date] NOT NULL,
	[TIENNO] [money] NOT NULL,
	[TIENTHU] [money] NOT NULL,
	[CONNO] [money] NOT NULL,
	[MANV] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[NHAPTOITHIEU] [int] NOT NULL,
	[TONTRUOCNHAP] [int] NOT NULL,
	[TONSAUBAN] [int] NOT NULL,
	[NOTOIDA] [money] NOT NULL,
	[THUQUANO] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[USERNAME] [varchar](100) NOT NULL,
	[PASSWORD] [varchar](100) NULL,
	[MANV] [varchar](100) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATL] [varchar](100) NOT NULL,
	[TENTL] [nvarchar](100) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MATL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TONKHO]    Script Date: 18/06/2015 3:33:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TONKHO](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[MADS] [varchar](100) NOT NULL,
	[NGAYPHATSINH] [date] NOT NULL,
	[TONDAU] [int] NOT NULL,
	[PHATSINH] [int] NOT NULL,
	[TONCUOI] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'NVBH', N'Nhân viên bán hàng')
GO
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'NVQL', N'Nhân viên quản lý')
GO
SET IDENTITY_INSERT [dbo].[DAUSACH] ON 

GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [MATL], [TACGIA], [SOLUONG], [DONGIA]) VALUES (1, N'Bảy bước nhảy tới mùa hè', N'TL004', N'Nguyễn Nhật Ánh', 100, 70000.0000)
GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [MATL], [TACGIA], [SOLUONG], [DONGIA]) VALUES (2, N'Thám tử lừng danh Conan', N'TL003', N'Aoyama Gosho', 200, 16000.0000)
GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [MATL], [TACGIA], [SOLUONG], [DONGIA]) VALUES (3, N'Sherlock Holmes', N'TL002', N'Arthur Conan Doyle', 100, 100000.0000)
GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [MATL], [TACGIA], [SOLUONG], [DONGIA]) VALUES (4, N'Còn chút gì để nhớ', N'TL004', N'Nguyễn Nhật Ánh', 100, 80000.0000)
GO
INSERT [dbo].[DAUSACH] ([MADS], [TENSACH], [MATL], [TACGIA], [SOLUONG], [DONGIA]) VALUES (5, N'Hướng dẫn học tốt Anh văn lớp 8', N'TL001', N'Phạm Thu Phương', 100, 50000.0000)
GO
SET IDENTITY_INSERT [dbo].[DAUSACH] OFF
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SDT], [EMAIL], [NO]) VALUES (N'KH001', N'Nguyễn Xuân Hải', N'Bảo Lộc, Lâm Đồng', N'01663983626', N'hai@gmail.com', 0)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SDT], [EMAIL], [NO]) VALUES (N'KH002', N'Châu Quang Nhân', N'TP.HCM', N'0986742042', N'nhan@gmail.com', 0)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SDT], [EMAIL], [NO]) VALUES (N'KH003', N'Đặng Thanh Tòng', N'TP.HCM', N'01215776229', N'tong@gmail.com', 0)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SDT], [EMAIL], [NO]) VALUES (N'KH004', N'Nguyễn Thu Trinh', N'Quảng Ngãi', N'0983821524', N'trinh@gmail.com', 0)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SDT], [EMAIL], [NO]) VALUES (N'KH005', N'Phạm Tú', N'TP.HCM', N'0169983146', N'tu@gmail.com', 0)
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [DIACHI], [EMAIL]) VALUES (N'NCC001', N'Nhà xuất bản Kim Đồng', N'999999999', N'TP HCM', N'kimdong@gmail.com')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [DIACHI], [EMAIL]) VALUES (N'NCC002', N'Nhà xuất bản Phương Nam', N'888888888', N'Hà Nội', N'phuongnam@gmail.com')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [DIACHI], [EMAIL]) VALUES (N'NCC003', N'Nhà xuất bản Đại học quốc gia', N'777777777', N'TP HCM', N'dhquocgia@gmail.com')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [DIACHI], [EMAIL]) VALUES (N'NCC004', N'Nhà xuất bản Văn hóa', N'666666666', N'TP HCM', N'vanhoa@gmail.com')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [DIACHI], [EMAIL]) VALUES (N'NCC005', N'Nhà xuất bản trẻ', N'555555555', N'Hà Nội', N'tre@gmail.com')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV001', N'Hoàng Chi', N'01663983625', N'TP HCM', N'chi@gmail.com', N'NVQL')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV002', N'Xuân Hải', N'0983821524', N'TP HCM', N'hai@gmail.com', N'NVQL')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV003', N'Quang Nhân', N'0123456780', N'TP HCM', N'nhan@gmail.com', N'NVQL')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV004', N'Nguyễn Nguyên Thủy', N'0983123456', N'TP HCM', N'thuy@gmail.com', N'NVBH')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV005', N'Đặng Văn Ba', N'0462482847', N'TP HCM', N'ba@gmail.com', N'NVBH')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [SDT], [DIACHI], [EMAIL], [MACV]) VALUES (N'NV006', N'Nguyễn Thủy Tiên', N'0169837462', N'TP HCM', N'tien@gmail.com', N'NVBH')
GO
INSERT [dbo].[QUYDINH] ([NHAPTOITHIEU], [TONTRUOCNHAP], [TONSAUBAN], [NOTOIDA], [THUQUANO]) VALUES (150, 300, 20, 20000.0000, 0)
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'hoangchi', N'hoangchi', N'NV001')
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'nguyenthuy', N'nguyenthuy', N'NV004')
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'quangnhan', N'quangnhan', N'NV003')
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'thuytien', N'thuytien', N'NV006')
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'vanba', N'vanba', N'NV005')
GO
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [MANV]) VALUES (N'xuanhai', N'xuanhai', N'NV002')
GO
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'TL001', N'Tham khảo')
GO
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'TL002', N'Trinh thám')
GO
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'TL003', N'Truyện tranh')
GO
INSERT [dbo].[THELOAI] ([MATL], [TENTL]) VALUES (N'TL004', N'Truyện ngắn')
GO
USE [master]
GO
ALTER DATABASE [DOAN_QUANLYNHASACH_NHOM14] SET  READ_WRITE 
GO
