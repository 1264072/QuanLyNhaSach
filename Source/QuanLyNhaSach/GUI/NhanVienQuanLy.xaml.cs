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

        public NhanVienQuanLy()
        {
            InitializeComponent();
        }

        public NhanVienQuanLy(NhanVienDTO nhanVienDTO)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.nhanVienDTO = nhanVienDTO;
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
            DoiMatKhau obj = new DoiMatKhau();
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
    }
}
