using BUS;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Them_ChinhSuaNhanVien window = new Them_ChinhSuaNhanVien();
            window.Option = 0;
            Nullable<bool> result = window.ShowDialog();
            if (result == true)
            {
                UserControl_Loaded(null, null);
            }
        }

        private void btnChinhSua_Click(object sender, RoutedEventArgs e)
        {
            if (dgvNhanVien.SelectedItem != null)
            {
                NhanVienDTO nvDTO = (NhanVienDTO)dgvNhanVien.SelectedItem;
                Them_ChinhSuaNhanVien window = new Them_ChinhSuaNhanVien();
                window.Option = 1;
                window.NvDTO = nvDTO;
                Nullable<bool> result = window.ShowDialog();
                if (result == true)
                {
                    UserControl_Loaded(null, null);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần chỉnh sửa thông tin !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgvNhanVien.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa dữ liệu khách hàng này ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    NhanVienDTO nvDTO = (NhanVienDTO)dgvNhanVien.SelectedItem;
                    int i = NhanVienBUS.XoaNhanVien(nvDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã xóa nhân viên ra khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        UserControl_Loaded(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần xóa khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<NhanVienDTO> lstDTO = NhanVienBUS.LayDanhSach();
            dgvNhanVien.DataContext = lstDTO;
            dgvNhanVien.IsReadOnly = true;
        }
    }
}
