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
            TabItem tabThongTin = new TabItem();
            tabThongTin.Name = "ThongTin";
            tabThongTin.Header = "Thông tin nhân viên";
            tabThongTin.Focusable = true;
            tabThongTin.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabThongTin.Name)).SingleOrDefault() != null)
            {
                tabThongTin.IsSelected = true;
                tabThongTin.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabThongTin);
            }
        }

        private void btnDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            DoiMatKhau obj = new DoiMatKhau(nhoMatKhauDTO);
            TabItem tabMatKhau = new TabItem();
            tabMatKhau.Header = "Đổi mật khẩu";
            tabMatKhau.Name = "DoiMatKhau";
            tabMatKhau.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabMatKhau.Name)).SingleOrDefault() != null)
            {
                tabMatKhau.IsSelected = true;
                tabMatKhau.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabMatKhau);
            }
        }

        private void btnKhachHang_Click(object sender, RoutedEventArgs e)
        {
            KhachHang obj = new KhachHang();
            TabItem tabKhachHang = new TabItem();
            tabKhachHang.Content = obj;
            tabKhachHang.Header = "Quản lý khách hàng";
            tabKhachHang.Name = "KhachHang";
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabKhachHang.Name)).SingleOrDefault() != null)
            {
                tabKhachHang.IsSelected = true;
                tabKhachHang.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabKhachHang);
            }
        }

        private void btnNhaCungCap_Click(object sender, RoutedEventArgs e)
        {
            NhaCungCap obj = new NhaCungCap();
            TabItem tabNhaCungCap = new TabItem();
            tabNhaCungCap.Name = "NhaCungCap";
            tabNhaCungCap.Header = "Quản lý nhà cung cấp";
            tabNhaCungCap.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabNhaCungCap.Name)).SingleOrDefault() != null)
            {
                tabNhaCungCap.IsSelected = true;
                tabNhaCungCap.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabNhaCungCap);
            }
        }

        private void btnNhanVien_Click(object sender, RoutedEventArgs e)
        {
            NhanVien obj = new NhanVien();
            TabItem tabNhanVien = new TabItem();
            tabNhanVien.Name = "NhanVien";
            tabNhanVien.Header = "Quản lý nhân viên";
            tabNhanVien.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabNhanVien.Name)).SingleOrDefault() != null)
            {
                tabNhanVien.IsSelected = true;
                tabNhanVien.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabNhanVien);
            }
        }

        private void btnDauSach_Click(object sender, RoutedEventArgs e)
        {
            DauSach obj = new DauSach();
            TabItem tabDauSach = new TabItem();
            tabDauSach.Name = "DauSach";
            tabDauSach.Header = "Quản lý đầu sách";
            tabDauSach.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabDauSach.Name)).SingleOrDefault() != null)
            {
                tabDauSach.IsSelected = true;
                tabDauSach.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabDauSach);
            }
        }

        private void btnDonHang_Click(object sender, RoutedEventArgs e)
        {
            DonHang obj = new DonHang();
            TabItem tabDonHang = new TabItem();
            tabDonHang.Header = "Quản lý đơn hàng";
            tabDonHang.Name = "DonHang";
            tabDonHang.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabDonHang.Name)).SingleOrDefault() != null)
            {
                tabDonHang.IsSelected = true;
                tabDonHang.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabDonHang);
            }
        }

        private void btnNhapSach_Click(object sender, RoutedEventArgs e)
        {
            NhapSach obj = new NhapSach();
            TabItem tabNhapSach = new TabItem();
            tabNhapSach.Header = "Lập phiếu nhập";
            tabNhapSach.Name = "NhapSach";
            tabNhapSach.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabNhapSach.Name)).SingleOrDefault() != null)
            {
                tabNhapSach.IsSelected = true;
                tabNhapSach.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabNhapSach);
            }
        }

        private void btnThuTien_Click(object sender, RoutedEventArgs e)
        {
            ThuTien obj = new ThuTien();
            TabItem tabThuTien = new TabItem();
            tabThuTien.Header = "Lập phiếu thu tiền";
            tabThuTien.Name = "ThuTien";
            tabThuTien.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabThuTien.Name)).SingleOrDefault() != null)
            {
                tabThuTien.IsSelected = true;
                tabThuTien.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabThuTien);
            }
        }

        private void btnChiTien_Click(object sender, RoutedEventArgs e)
        {
            ChiTien obj = new ChiTien();
            TabItem tabChiTien = new TabItem();
            tabChiTien.Header = "Lập phiếu chi tiền";
            tabChiTien.Name = "ChiTien";
            tabChiTien.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabChiTien.Name)).SingleOrDefault() != null)
            {
                tabChiTien.IsSelected = true;
                tabChiTien.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabChiTien);
            }
        }
    }
}
