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
    /// Interaction logic for Them_ChinhSuaDauSach.xaml
    /// </summary>
    public partial class Them_ChinhSuaDauSach : Window
    {
        public int Option { get; set; }
        public DauSachDTO DsDTO { get; set; }
        public Them_ChinhSuaDauSach()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Option == 0)
            {
                Title = "Thêm đầu sách";
            }
            else
            {
                Title = "Chỉnh sửa thông tin";
                TenSach.Text = DsDTO.TENSACH;
                TheLoai.SelectedValue = DsDTO.MATL;
                TacGia.Text = DsDTO.TACGIA;
                SoLuong.Value = DsDTO.SOLUONG;
                DonGia.Value = DsDTO.DONGIA;
            }
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {
                DsDTO.TENSACH = TenSach.Text;
                DsDTO.MATL = TheLoai.SelectedValue.ToString();
                DsDTO.TACGIA = TacGia.Text;
                DsDTO.SOLUONG = SoLuong.Value.Value;
                DsDTO.DONGIA = DonGia.Value.Value;
                if (Option == 0)
                {
                    int i = DauSachBUS.ThemDauSach(DsDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã thêm đầu sách vào danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Không thể thêm đầu sách.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    int i = DauSachBUS.CapNhatDauSach(DsDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin đầu sách thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
            if (string.IsNullOrWhiteSpace(TenSach.Text))
            {
                ThongBao.Text = "* Tên sách không được để trống";
                return false;
            }
            ThongBao.Text = "";
            return true;
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
