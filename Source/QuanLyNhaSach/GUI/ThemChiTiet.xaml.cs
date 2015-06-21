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
using System.ComponentModel;
namespace GUI
{
    /// <summary>
    /// Interaction logic for ChiTietHoadon.xaml
    /// </summary>
    public partial class ThemChiTiet : Window
    {
        public List<ChiTietHoaDonDTO> lst { get; set; }
        List<ChiTietHoaDonDTO> lstDSCTHD = new List<ChiTietHoaDonDTO>();

        public ThemChiTiet()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
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

        private void btnThemHD_Click_1(object sender, RoutedEventArgs e)
       {
            int count = 0;
            DauSachDTO ds = (DauSachDTO)lstDS.SelectedItems[0];
            ChiTietHoaDonDTO select = new ChiTietHoaDonDTO()
            {
                SOLUONG = 1,
                TENDAUSACH = ds.TENSACH,
                DONGIA = ds.DONGIA,
                TENTL = ds.TENTL,
                MADS = ds.MADS,
                MATL = ds.MATL,
                THANHTIEN = ds.DONGIA,
                MAHD = "" 
            };

            if (lstDSCTHD.Count != 0)
            {
                foreach (ChiTietHoaDonDTO item in lstDSCTHD)
                {
                    if (item.MADS == ds.MADS) {
                        item.SOLUONG += 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        break;
                    }
                    count++;
                }
                if (count == lstDSCTHD.Count()) 
                    lstDSCTHD.Add(select);                
            }
            else            
                lstDSCTHD.Add(select);
            lstDSCT.DataContext = lstDSCTHD;
            ICollectionView view = CollectionViewSource.GetDefaultView(lstDSCT.ItemsSource);
            view.Refresh();
        }

        private void btnThemHoaDon_Click_1(object sender, RoutedEventArgs e)
        {
            lst = lstDSCTHD;
            foreach (ChiTietHoaDonDTO item in lst) {
                item.THANHTIEN = item.SOLUONG * item.DONGIA;
            }
            this.Close();
        }
    }
}
