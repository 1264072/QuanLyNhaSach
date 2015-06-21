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
            TabItem tabThongtin = new TabItem();
            tabThongtin.Name = "ThongTin";
            tabThongtin.Header = "Thông tin nhân viên";
            tabThongtin.Focusable = true;
            tabThongtin.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabThongtin.Name)).SingleOrDefault() != null)
            {
                tabThongtin.IsSelected = true;
                tabThongtin.Focus();
            }
            else
            {
                ContentControl.Items.Add(tabThongtin);
                tabThongtin.IsSelected = true;
            }
        }

        private void btnDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            DoiMatKhau obj = new DoiMatKhau();
            TabItem tabDoiMK = new TabItem();
            tabDoiMK.Name = "DoiMK";
            tabDoiMK.Header = "Đổi mật khẩu";
            tabDoiMK.Focusable = true;
            tabDoiMK.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabDoiMK.Name)).SingleOrDefault() != null)
            {
                tabDoiMK.Focus();
                tabDoiMK.IsSelected = true; 
            }
            else
            {
                ContentControl.Items.Add(tabDoiMK);
                tabDoiMK.IsSelected = true;
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
            TabItem tabLaphoadon = new TabItem();
            tabLaphoadon.Name = "LapHoaDon";
            tabLaphoadon.Header = "Lập hóa đơn";
            tabLaphoadon.Focusable = true;
            tabLaphoadon.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabLaphoadon.Name)).SingleOrDefault() != null)
            {
                tabLaphoadon.Focus();
                tabLaphoadon.IsSelected = true;
            }
            else
            {
                ContentControl.Items.Add(tabLaphoadon);
                tabLaphoadon.IsSelected = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TraCuuDauSach obj = new TraCuuDauSach();
            TabItem tabTracuudausach = new TabItem();
            tabTracuudausach.Name = "TraCuuDauSach";
            tabTracuudausach.Header = "Tra cứu đầu sách";
            tabTracuudausach.Focusable = true;
            tabTracuudausach.Content = obj;
            if (ContentControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabTracuudausach.Name)).SingleOrDefault() != null)
            {
                tabTracuudausach.Focus();
                tabTracuudausach.IsSelected = true;
            }
            else
            {
                ContentControl.Items.Add(tabTracuudausach);
                tabTracuudausach.IsSelected = true;
            }
        }

        private void btnQLKH_Click(object sender, RoutedEventArgs e)
        {
            /////lấy form ông....
        }
    }
}
