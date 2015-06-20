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
using BUS;
using System.Text.RegularExpressions;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Them_ChinhSuaNhaCungCap.xaml
    /// </summary>
    public partial class Them_ChinhSuaNhaCungCap : Window
    {
        public int Option { get; set; }
        public NhaCungCapDTO NccDTO { get; set; }
        public Them_ChinhSuaNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {
                NccDTO = new NhaCungCapDTO()
                {
                    MANCC = MaNCC.Text,
                    TENNCC = TenNCC.Text,
                    DIACHI = DiaChi.Text,
                    SDT = SDT.Text,
                    EMAIL = Email.Text
                };
                if (Option == 0)
                {
                    int i = NhaCungCapBUS.ThemNhaCungCap(NccDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã thêm nhà cung cấp vào danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Mã nhà cung cấp đã tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    int i = NhaCungCapBUS.ChinhSuaNhaCungCap(NccDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Cập nhật thông tin nhà cung cấp thất bại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Option == 0)
                Title = "Thêm nhà cung cấp";
            else
            {
                Title = "Chỉnh sửa thông tin";
                MaNCC.IsReadOnly = true;
                MaNCC.Text = NccDTO.MANCC;
                TenNCC.Text = NccDTO.TENNCC;
                DiaChi.Text = NccDTO.DIACHI;
                SDT.Text = NccDTO.SDT;
                Email.Text = NccDTO.EMAIL;
            }
        }

        private bool KiemTraDauVao()
        {
            if (string.IsNullOrWhiteSpace(MaNCC.Text))
            {
                ThongBao.Text = "* Chưa nhập mã nhà cung cấp";
                return false;
            }
            if (string.IsNullOrWhiteSpace(TenNCC.Text))
            {
                ThongBao.Text = "* Chưa nhập tên nhà cung cấp";
                return false;
            }
            if (string.IsNullOrWhiteSpace(DiaChi.Text))
            {
                ThongBao.Text = "* Chưa nhập địa chỉ nhà cung cấp";
                return false;
            }
            if (string.IsNullOrWhiteSpace(SDT.Text))
            {
                ThongBao.Text = "* Chưa nhập số điện thoại nhà cung cấp";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                ThongBao.Text = "* Chưa nhập email nhà cung cấp";
                return false;
            }
            if (!Regex.IsMatch(SDT.Text, @"^(0\d{9,10})$"))
            {
                ThongBao.Text = "* Số điện thoại không hợp lệ. \r\n  Phải có dạng 0** và độ dài từ 10-11 số.";
                return false;
            }
            if (!Regex.IsMatch(Email.Text, @"^(\w+.@\w+.\w{2,4})$"))
            {
                ThongBao.Text = "* Email không hợp lệ. \r\n  Phải có dạng abc@abc.xyz";
                return false;
            }
            ThongBao.Text = "";
            return true;
        }
    }
}
