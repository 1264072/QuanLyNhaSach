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
    /// Interaction logic for DonHang.xaml
    /// </summary>
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<HoaDonDTO> lst = HoaDonBUS.LayDanhSach();
            dgvDonHang.DataContext = lst;
            dgvDonHang.SelectionMode = DataGridSelectionMode.Single;
            dgvDonHang.SelectionUnit = DataGridSelectionUnit.FullRow;
        }

        private void dgvDonHang_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGrid dgv = sender as DataGrid;
                if (dgv != null && dgv.SelectedItem != null)
                {
                    HoaDonDTO hd = (HoaDonDTO)dgv.SelectedItem;
                    ChiTietHoaDon window = new ChiTietHoaDon();
                    window.HdDTO = hd;
                    window.Show();
                }
            }
        }
    }
}
