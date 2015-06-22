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
using BUS;
using Microsoft.Win32;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private NhanVienDTO nhanVienDTO;
        private NhoMatKhauDTO nhoMatKhauDTO;

        public Admin()
        {
            InitializeComponent();
        }
        public Admin(NhanVienDTO nhanVienDTO, NhoMatKhauDTO nhoMatKhauDTO)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.nhanVienDTO = nhanVienDTO;
            this.nhoMatKhauDTO = nhoMatKhauDTO;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = nhanVienDTO.HOTEN + " - Quản trị viên";
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

        private void btnNhanVien_Click(object sender, RoutedEventArgs e)
        {
            NhanVien obj = new NhanVien();
            ClosableTab tabNhanVien = new ClosableTab();
            tabNhanVien.Name = "NhanVien";
            tabNhanVien.Title = "Quản lý nhân viên";
            tabNhanVien.Content = obj;
            if (ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhanVien.Name) != null)
            {
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhanVien.Name);
            }
            else
            {
                ContentControl.Items.Add(tabNhanVien);
                ContentControl.SelectedItem = ContentControl.Items.OfType<TabItem>().SingleOrDefault(n => n.Name == tabNhanVien.Name);
            }
        }

        private void btnSaoLuu_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BAK file (*.bak)|*.bak";
            if (saveFileDialog.ShowDialog() == true)
            {
                string path = saveFileDialog.FileName;
                int i = DuLieuBUS.SaoLuu(path);
                if (i < 0)
                {
                    MessageBox.Show("Sao lưu dữ liệu thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (i == 2)
                {
                    MessageBox.Show("Xảy ra lỗi ! Hệ quản trị không đủ quyền lưu tại vị trí này ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi ! Sao lưu thất bại !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnPhucHoi_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BAK file (*.bak)|*.bak";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;
                int i = DuLieuBUS.PhucHoi(path);
                if (i < 0)
                {
                    MessageBox.Show("Phục hồi dữ liệu thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi ! Phục hồi thất bại !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
