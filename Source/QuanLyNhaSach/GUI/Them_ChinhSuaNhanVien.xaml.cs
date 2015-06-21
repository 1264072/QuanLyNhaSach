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
    /// Interaction logic for Them_ChinhSuaNhanVien.xaml
    /// </summary>
    public partial class Them_ChinhSuaNhanVien : Window
    {
        public int Option { get; set; }
        public NhanVienDTO NvDTO { get; set; }
        public Them_ChinhSuaNhanVien()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ChucVuDTO> lst = ChucVuBUS.LayDanhSach();
            cbChucVu.DataContext = lst;
            if (Option == 0)
            {
                Title = "Thêm nhân viên";
                cbChucVu.SelectedIndex = 0;
            }
            else
            {
                Title = "Chỉnh sửa thông tin";
                MaNV.IsReadOnly = true;
                HoTen.Text = NvDTO.HOTEN;
                MaNV.Text = NvDTO.MANV;
                DiaChi.Text = NvDTO.DIACHI;
                Email.Text = NvDTO.EMAIL;
                SDT.Text = NvDTO.SDT;
                cbChucVu.SelectedValue = NvDTO.MACV;
            }
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {
                NvDTO = new NhanVienDTO()
                {
                    MANV = MaNV.Text,
                    HOTEN = HoTen.Text,
                    DIACHI = DiaChi.Text,
                    EMAIL = Email.Text,
                    SDT = SDT.Text,
                    MACV = cbChucVu.SelectedValue.ToString(),
                    TENCV = cbChucVu.Text
                };
                if (Option == 0)
                {
                    int i = NhanVienBUS.ThemNhanVien(NvDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã thêm nhân viên vào danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Mã nhân viên đã tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    int i = NhanVienBUS.CapNhatNhanVien(NvDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Cập nhật thông tin nhân viên thất bại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private bool KiemTraDauVao()
        {
            if (string.IsNullOrWhiteSpace(MaNV.Text))
            {
                ThongBao.Text = "* Chưa nhập mã nhân viên";
                return false;
            }
            if (string.IsNullOrWhiteSpace(HoTen.Text))
            {
                ThongBao.Text = "* Chưa nhập tên nhân viên";
                return false;
            }
            if (string.IsNullOrWhiteSpace(DiaChi.Text))
            {
                ThongBao.Text = "* Chưa nhập địa chỉ nhân viên";
                return false;
            }
            if (string.IsNullOrWhiteSpace(SDT.Text))
            {
                ThongBao.Text = "* Chưa nhập số điện thoại nhân viên";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                ThongBao.Text = "* Chưa nhập email nhân viên";
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
