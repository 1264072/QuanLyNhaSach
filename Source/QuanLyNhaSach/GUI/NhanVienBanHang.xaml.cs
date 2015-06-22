using DTO;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for NhanVienBanHang.xaml
    /// </summary>
    /// 
    public partial class NhanVienBanHang : Window
    {
        private NhanVienDTO nhanVienDTO;

        public NhanVienBanHang()
        {
            InitializeComponent();
        }

        public NhanVienBanHang(NhanVienDTO nhanVienDTO)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.nhanVienDTO = nhanVienDTO;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title =  " Nhân viên bán hàng - " + nhanVienDTO.HOTEN ;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ThongTinNhanVien obj = new ThongTinNhanVien(nhanVienDTO);
            ClosableTab tabThongtin = new ClosableTab();
            tabThongtin.Name = "ThongTin";
            tabThongtin.Title = "Thông tin nhân viên";
            tabThongtin.Focusable = true;
            tabThongtin.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongtin.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongtin.Name);
            }
            else
            {
                ContentControl.Items.Add(tabThongtin);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabThongtin.Name);
            }
        }

        private void btnDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            DoiMatKhau obj = new DoiMatKhau();
            ClosableTab tabDoiMK = new ClosableTab();
            tabDoiMK.Name = "DoiMK";
            tabDoiMK.Title = "Đổi mật khẩu";
            tabDoiMK.Focusable = true;
            tabDoiMK.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDoiMK.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDoiMK.Name);
            }
            else
            {
                ContentControl.Items.Add(tabDoiMK);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabDoiMK.Name);
            }
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

        private void btnLapHoaDon_Click(object sender, RoutedEventArgs e)
        {
            LapHoaDon obj = new LapHoaDon();
            obj.nv = nhanVienDTO;
            ClosableTab tabLaphoadon = new ClosableTab();
            tabLaphoadon.Name = "LapHoaDon";
            tabLaphoadon.Title = "Lập hóa đơn";
            tabLaphoadon.Focusable = true;
            tabLaphoadon.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabLaphoadon.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabLaphoadon.Name);
            }
            else
            {
                ContentControl.Items.Add(tabLaphoadon);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabLaphoadon.Name);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TraCuuDauSach obj = new TraCuuDauSach();
            ClosableTab tabTracuudausach = new ClosableTab();
            tabTracuudausach.Name = "TraCuuDauSach";
            tabTracuudausach.Title = "Tra cứu đầu sách";
            tabTracuudausach.Focusable = true;
            tabTracuudausach.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabTracuudausach.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabTracuudausach.Name);
            }
            else
            {
                ContentControl.Items.Add(tabTracuudausach);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabTracuudausach.Name);
            }
        }

        private void btnQLKH_Click(object sender, RoutedEventArgs e)
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
    }
}
