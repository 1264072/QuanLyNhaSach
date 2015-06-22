using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for NhanVienQuanLy.xaml
    /// </summary>
    public partial class NhanVienQuanLy : Window
    {
        private NhanVienDTO nhanVienDTO;
        private NhoMatKhauDTO nhoMatKhauDTO;

        public NhanVienQuanLy()
        {
            InitializeComponent();
        }

        public NhanVienQuanLy(NhanVienDTO nhanVienDTO, NhoMatKhauDTO nhoMatKhauDTO)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.nhanVienDTO = nhanVienDTO;
            this.nhoMatKhauDTO = nhoMatKhauDTO;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = nhanVienDTO.HOTEN + " - Nhân viên quản lý";
            
        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn thoát chương trình ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                DangNhap obj = new DangNhap();
                obj.Show();
                this.Close();
            }
        }

        private void btnThongTinNhanVien_Click(object sender, RoutedEventArgs e)
        {
            ThongTinNhanVien obj = new ThongTinNhanVien(nhanVienDTO);
            ClosableTab tabThongTin = new ClosableTab();
            tabThongTin.Name = "ThongTin";
            tabThongTin.Title = "Thông tin nhân viên";
            tabThongTin.Focusable = true;
            tabThongTin.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongTin.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongTin.Name);
            }
            else
            {
                ContentControl.Items.Add(tabThongTin);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongTin.Name);
            }
        }

        private void btnDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            DoiMatKhau obj = new DoiMatKhau(nhoMatKhauDTO);
            ClosableTab tabMatKhau = new ClosableTab();
            tabMatKhau.Title = "Đổi mật khẩu";
            tabMatKhau.Name = "DoiMatKhau";
            tabMatKhau.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabMatKhau.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabMatKhau.Name);
            }
            else
            {
                ContentControl.Items.Add(tabMatKhau);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabMatKhau.Name);
            }
        }

        private void btnKhachHang_Click(object sender, RoutedEventArgs e)
        {
            KhachHang obj = new KhachHang();
            ClosableTab tabKhachHang = new ClosableTab();
            tabKhachHang.Content = obj;
            tabKhachHang.Title = "Quản lý khách hàng";
            tabKhachHang.Name = "KhachHang";
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabKhachHang.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabKhachHang.Name);
            }
            else
            {
                ContentControl.Items.Add(tabKhachHang);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabKhachHang.Name);
            }
        }

        private void btnNhaCungCap_Click(object sender, RoutedEventArgs e)
        {
            NhaCungCap obj = new NhaCungCap();
            ClosableTab tabNhaCungCap = new ClosableTab();
            tabNhaCungCap.Name = "NhaCungCap";
            tabNhaCungCap.Title = "Quản lý nhà cung cấp";
            tabNhaCungCap.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhaCungCap.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhaCungCap.Name);
            }
            else
            {
                ContentControl.Items.Add(tabNhaCungCap);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhaCungCap.Name);
            }
        }

        private void btnDauSach_Click(object sender, RoutedEventArgs e)
        {
            DauSach obj = new DauSach();
            ClosableTab tabDauSach = new ClosableTab();
            tabDauSach.Name = "DauSach";
            tabDauSach.Title = "Quản lý đầu sách";
            tabDauSach.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDauSach.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDauSach.Name);
            }
            else
            {
                ContentControl.Items.Add(tabDauSach);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDauSach.Name);
            }
        }

        private void btnDonHang_Click(object sender, RoutedEventArgs e)
        {
            DonHang obj = new DonHang();
            ClosableTab tabDonHang = new ClosableTab();
            tabDonHang.Title = "Quản lý đơn hàng";
            tabDonHang.Name = "DonHang";
            tabDonHang.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDonHang.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDonHang.Name);
            }
            else
            {
                ContentControl.Items.Add(tabDonHang);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDonHang.Name);
            }
        }

        private void btnNhapSach_Click(object sender, RoutedEventArgs e)
        {
            NhapSach obj = new NhapSach(nhanVienDTO);
            ClosableTab tabNhapSach = new ClosableTab();
            tabNhapSach.Title = "Lập phiếu nhập";
            tabNhapSach.Name = "NhapSach";
            tabNhapSach.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhapSach.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhapSach.Name);
            }
            else
            {
                ContentControl.Items.Add(tabNhapSach);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhapSach.Name);
            }
        }

        private void btnThuTien_Click(object sender, RoutedEventArgs e)
        {
            ThuTien obj = new ThuTien();
            ClosableTab tabThuTien = new ClosableTab();
            tabThuTien.Title = "Lập phiếu thu tiền";
            tabThuTien.Name = "ThuTien";
            tabThuTien.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThuTien.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThuTien.Name);
            }
            else
            {
                ContentControl.Items.Add(tabThuTien);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThuTien.Name);
            }
        }

        private void btnChiTien_Click(object sender, RoutedEventArgs e)
        {
            ChiTien obj = new ChiTien();
            ClosableTab tabChiTien = new ClosableTab();
            tabChiTien.Title = "Lập phiếu chi tiền";
            tabChiTien.Name = "ChiTien";
            tabChiTien.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabChiTien.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabChiTien.Name);
            }
            else
            {
                ContentControl.Items.Add(tabChiTien);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabChiTien.Name);
            }
        }
    }
}
