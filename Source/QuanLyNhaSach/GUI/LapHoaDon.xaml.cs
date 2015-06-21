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
using System.ComponentModel;
namespace GUI
{
    /// <summary>
    /// Interaction logic for LapHoaDon.xaml
    /// </summary>
    public partial class LapHoaDon : UserControl
    {
        public NhanVienDTO nv { get; set; }
        TheLoaiBUS cate = new TheLoaiBUS();
        List<ChiTietHoaDonDTO> lst = new List<ChiTietHoaDonDTO>();
        decimal tongtien;
        public LapHoaDon()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            cbMaKH.DataContext = KhachHangBUS.LayDanhSach();
            txtMaNV.Text = nv.MANV;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int count ;
            tongtien = 0;
            ThemChiTiet obj = new ThemChiTiet();
            obj.ShowDialog();
            if (obj.lst != null)
            {
                if( lst.Count == 0 ) {
                    lst = obj.lst;
                    lstDS.DataContext = lst;
                    foreach (ChiTietHoaDonDTO item in lst)
                    {
                        tongtien += item.THANHTIEN;
                    }
                    txtTongTien.Text = string.Format("{0:N0}", tongtien);
                }
                else {
                    foreach (ChiTietHoaDonDTO itemCT in obj.lst)
                    {
                        count = 0;
                        foreach (ChiTietHoaDonDTO itemHD in lst)
                        {
                            if (itemCT.MADS == itemHD.MADS)
                            {
                                itemHD.SOLUONG += itemCT.SOLUONG;
                                itemHD.THANHTIEN = itemHD.SOLUONG * itemHD.DONGIA;
                                break;
                            }
                            count++;
                        }
                        if (count == lst.Count) {
                            lst.Add(itemCT);
                        }
                    }
                    lstDS.DataContext = lst;
                }
            }
            ICollectionView view = CollectionViewSource.GetDefaultView(lstDS.ItemsSource);
            view.Refresh();
        }

        private void btnXoa_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (ChiTietHoaDonDTO item in lstDS.SelectedItems)
            {
                tongtien -= item.THANHTIEN;
                lst.Remove(item);
            }
            lstDS.DataContext = lst;
            txtTongTien.Text = string.Format("{0:N0}", tongtien);
            ICollectionView view = CollectionViewSource.GetDefaultView(lstDS.ItemsSource);
            view.Refresh();
        }

        private void btnCapNhat_Click_1(object sender, RoutedEventArgs e)
        {
            tongtien = 0;
            lstDS.UpdateLayout();
            foreach (ChiTietHoaDonDTO item in lst)
            {
                item.THANHTIEN = item.SOLUONG * item.DONGIA;
                tongtien += item.THANHTIEN;
            }
            txtTongTien.Text = string.Format("{0:N0}", tongtien);
            ICollectionView view = CollectionViewSource.GetDefaultView(lstDS.ItemsSource);
            view.Refresh();
        }

        private void btnLapHoaDon_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtMaHD.Text == "" || txtSoTienNhan.Text == "" || cbMaKH.SelectedItem == null || NLHD.Text=="")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else if (lst.Count == 0)
            {
                MessageBox.Show("Chi tiết hoa đơn không có dữ liệu");
            }
            else
            {
                decimal tienno = decimal.Parse(txtTongTien.Text.ToString()) - decimal.Parse(txtSoTienNhan.Text.ToString());
                if (tienno < 0)
                    tienno = 0;
                foreach (ChiTietHoaDonDTO item in lst)
                {
                    item.MAHD = txtMaHD.Text;
                }
                KhachHangDTO kh = (KhachHangDTO)cbMaKH.SelectedItem;
                HoaDonDTO hd = new HoaDonDTO
                {
                    MAHD = txtMaHD.Text,
                    MANV = txtMaNV.Text,
                    MAKH = kh.MAKH,
                    NGAYLAP = DateTime.Parse(NLHD.Text.ToString()),
                    TONGTIEN = decimal.Parse(txtTongTien.Text.ToString()),
                    TIENTRA = decimal.Parse(txtSoTienNhan.Text.ToString()),
                    TIENNO = tienno,
                };
                if (HoaDonBUS.AddHoaDon(hd, lst))
                    MessageBox.Show("Lập hóa đơn thành công");
            }
        }
    }
}
