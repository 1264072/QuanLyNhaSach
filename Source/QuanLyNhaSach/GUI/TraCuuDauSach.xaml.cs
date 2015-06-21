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
    /// Interaction logic for TraCuuDauSach.xaml
    /// </summary>
    public partial class TraCuuDauSach : UserControl
    {
        public TraCuuDauSach()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            cbTheLoai.DataContext = TheLoaiBUS.LayDanhSach();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TheLoaiDTO itemtl = (TheLoaiDTO)cbTheLoai.SelectedItem;
            ComboBoxItem itemdg = (ComboBoxItem)cbPrice.SelectedItem;
            DauSachDTO ds = new DauSachDTO
            {
                TENSACH = txtTenDauSach.Text,
                MATL = itemtl.MATL,
                DONGIA = decimal.Parse(itemdg.Tag.ToString()),
            };
            lstDS.DataContext = DauSachBUS.SearchDauSach(ds);
        }
    }
}
