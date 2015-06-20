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
using BUS;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
            if (TaiKhoanBUS.LayTaiKhoan() != null)
            {
                if (TaiKhoanBUS.LayTaiKhoan().TRANGTHAI)
                {
                    txtTenDangNhap.Text = TaiKhoanBUS.LayTaiKhoan().USERNAME;
                    txtMatKhau.Password = TaiKhoanBUS.LayTaiKhoan().PASSWORD;
                    chkGhiNho.IsChecked = true;
                }
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Password;

            if (TaiKhoanBUS.DangNhap(username, password))
            {
                if (chkGhiNho.IsChecked == true)
                    TaiKhoanBUS.GhiNhoTaiKhoan(username, password, true);
                else
                    TaiKhoanBUS.GhiNhoTaiKhoan(username, password, false);

                lbWarning.Text = "";

                string chucVu = NhanVienBUS.LayNhanVienTheoTaiKhoan(username).MACV;
                if (chucVu == "NVBH")
                {
                    MessageBox.Show("Đây là nhân viên bán hàng");                    
                }
                if (chucVu == "NVQL")
                {
                    NhanVienQuanLy obj = new NhanVienQuanLy(NhanVienBUS.LayNhanVienTheoTaiKhoan(username));
                    obj.Show();
                    this.Close();
                }

            }
            else
            {
                lbWarning.Text = "Sai tài khoản hoặc mật khẩu";
            }
        }
    }
}
