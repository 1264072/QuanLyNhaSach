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

namespace GUI
{
    /// <summary>
    /// Interaction logic for ChiTietHoaDon.xaml
    /// </summary>
    public partial class ChiTietHoaDon : Window
    {
        public HoaDonDTO HdDTO { get; set; }
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MaHD.Text = HdDTO.MAHD;
            MaKH.Text = HdDTO.MAKH;
            TongTien.Text = HdDTO.TONGTIEN.ToString("0");
            NgayLap.Text = HdDTO.NGAYLAP.ToShortDateString();
            TenKH.Text = HdDTO.TENKH;
            TenNV.Text = HdDTO.TENNV;

            List<ChiTietHoaDonDTO> lst = ChiTietHoaDonBUS.LayChiTietTheoMaHD(HdDTO);
            dgvChiTiet.DataContext = lst;
            dgvChiTiet.IsReadOnly = true;
        }
    }
}
