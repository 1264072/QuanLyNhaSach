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
using System.Text.RegularExpressions;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Them_ChinhSuaKhachHang.xaml
    /// </summary>
    public partial class Them_ChinhSuaKhachHang : Window
    {
        public int Option { get; set; }
        public KhachHangDTO khDTO { get; set; }
        public Them_ChinhSuaKhachHang()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {
                khDTO = new KhachHangDTO()
                {
                    MAKH = MaKH.Text,
                    HOTEN = HoTen.Text,
                    DIACHI = DiaChi.Text,
                    SDT = SDT.Text,
                    EMAIL = Email.Text
                };
                if (Option == 0)
                {
                    int i = KhachHangBUS.ThemKhachHang(khDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã thêm khách hàng vào danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Mã khách hàng đã tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    int i = KhachHangBUS.CapNhatKhachHang(khDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Cập nhật thông tin thất bại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private bool KiemTraDauVao()
        {
            if (string.IsNullOrWhiteSpace(MaKH.Text))
            {
                ThongBao.Text = "* Chưa nhập mã khách hàng";
                return false;
            }
            if (string.IsNullOrWhiteSpace(HoTen.Text))
            {
                ThongBao.Text = "* Chưa nhập họ tên khách hàng";
                return false;
            }
            if (string.IsNullOrWhiteSpace(DiaChi.Text))
            {
                ThongBao.Text = "* Chưa nhập địa chỉ khách hàng";
                return false;
            }
            if (string.IsNullOrWhiteSpace(SDT.Text))
            {
                ThongBao.Text = "* Chưa nhập số điện thoại khách hàng";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                ThongBao.Text = "* Chưa nhập email khách hàng";
                return false;
            }
            if (!Regex.IsMatch(SDT.Text, @"^(0\d{9,10})$"))
            {
                ThongBao.Text = "* Số điện thoại không hợp lệ. \r\nPhải có dạng 0** và độ dài từ 10-11 số.";
                return false;
            }
            if (!Regex.IsMatch(Email.Text, @"^(\w+.@\w+.\w{2,4})$"))
            {
                ThongBao.Text = "* Email không hợp lệ. \r\nPhải có dạng abc@abc.xyz";
                return false;
            }
            ThongBao.Text = "";
            return true;
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Option == 0)
                Title = "Thêm khách hàng";
            else
            {
                Title = "Chỉnh sửa thông tin";
                MaKH.IsReadOnly = true;
                MaKH.Text = khDTO.MAKH;
                HoTen.Text = khDTO.HOTEN;
                DiaChi.Text = khDTO.DIACHI;
                SDT.Text = khDTO.SDT;
                Email.Text = khDTO.EMAIL;
            }
        }
    }
}
