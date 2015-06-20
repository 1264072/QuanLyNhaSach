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
using BUS;
using DTO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<KhachHangDTO> lst = KhachHangBUS.LayDanhSach();
            dgvKhachHang.DataContext = lst;
            dgvKhachHang.IsReadOnly = true;
            dgvKhachHang.SelectionMode = DataGridSelectionMode.Single;
            dgvKhachHang.SelectionUnit = DataGridSelectionUnit.FullRow;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Them_ChinhSuaKhachHang window = new Them_ChinhSuaKhachHang();
            window.Option = 0;
            if (window.ShowDialog().Value)
            {
                UserControl_Loaded(null, null);
            }
        }

        private void btnChinhSua_Click(object sender, RoutedEventArgs e)
        {
            if (dgvKhachHang.SelectedItem != null)
            {
                KhachHangDTO khDTO = (KhachHangDTO)dgvKhachHang.SelectedItem;
                Them_ChinhSuaKhachHang window = new Them_ChinhSuaKhachHang();
                window.Option = 1;
                window.khDTO = khDTO;
                window.ShowDialog();
                if (window.ShowDialog().Value)
                {
                    UserControl_Loaded(null, null);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khách hàng cần chỉnh sửa thông tin !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgvKhachHang.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa dữ liệu khách hàng này ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    KhachHangDTO khDTO = (KhachHangDTO)dgvKhachHang.SelectedItem;
                    int i = KhachHangBUS.XoaKhachHang(khDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã xóa khách hàng ra khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                MessageBox.Show("Chưa chọn khách hàng cần xóa khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
