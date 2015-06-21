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
using DTO;
using BUS;

namespace GUI
{
    /// <summary>
    /// Interaction logic for DauSach.xaml
    /// </summary>
    public partial class DauSach : UserControl
    {
        public DauSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Them_ChinhSuaDauSach window = new Them_ChinhSuaDauSach();
            window.Option = 0;
            Nullable<bool> result = window.ShowDialog();
            if (result == true)
            {
                UserControl_Loaded(null, null);
            }
            
        }

        private void btnChinhSua_Click(object sender, RoutedEventArgs e)
        {
            if (dgvDauSach.SelectedItem != null)
            {
                DauSachDTO dsDTO = (DauSachDTO)dgvDauSach.SelectedItem;
                Them_ChinhSuaDauSach window = new Them_ChinhSuaDauSach();
                window.Option = 1;
                window.DsDTO = dsDTO;
                Nullable<bool> result = window.ShowDialog();
                if (result == true)
                {
                    UserControl_Loaded(null, null);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đầu sách cần chỉnh sửa thông tin !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgvDauSach.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa dữ liệu đầu sách này ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DauSachDTO dsDTO = (DauSachDTO)dgvDauSach.SelectedItem;
                    int i = DauSachBUS.XoaDauSach(dsDTO);
                    if (i > 0)
                    {
                        MessageBox.Show("Đã xóa đầu sách ra khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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
                MessageBox.Show("Chưa chọn đầu sách cần xóa khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<DauSachDTO> lst = DauSachBUS.LayDanhSach();
            dgvDauSach.DataContext = lst;
            dgvDauSach.IsReadOnly = true;
        }
    }
}
