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
    /// Interaction logic for NhaCungCap.xaml
    /// </summary>
    public partial class NhaCungCap : UserControl
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<NhaCungCapDTO> lstDTO = NhaCungCapBUS.LayDanhSach();
            dgvNhaCungCap.DataContext = lstDTO;
            dgvNhaCungCap.IsReadOnly = true;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Them_ChinhSuaNhaCungCap window = new Them_ChinhSuaNhaCungCap();
            window.Option = 0;
            Nullable<bool> result = window.ShowDialog();
            if (result == true)
            {
                UserControl_Loaded(null, null);
            }
        }

        private void btnChinhSua_Click(object sender, RoutedEventArgs e)
        {
            if (dgvNhaCungCap.SelectedItem != null)
            {
                NhaCungCapDTO NCC = (NhaCungCapDTO)dgvNhaCungCap.SelectedItem;
                Them_ChinhSuaNhaCungCap window = new Them_ChinhSuaNhaCungCap();
                window.Option = 1;
                window.NccDTO = NCC;
                Nullable<bool> result = window.ShowDialog();
                if (result == true)
                {
                    UserControl_Loaded(null, null);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhà cung cấp cần chỉnh sửa thông tin !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgvNhaCungCap.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa dữ liệu khách hàng này ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    NhaCungCapDTO NCC = (NhaCungCapDTO)dgvNhaCungCap.SelectedItem;
                    int i = NhaCungCapBUS.XoaNhaCungCap(NCC);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã xóa nhà cung cấp ra khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                MessageBox.Show("Chưa chọn nhà cung cấp cần xóa khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
