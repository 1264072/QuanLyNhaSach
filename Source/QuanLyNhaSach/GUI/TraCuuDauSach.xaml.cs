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
        public int Option { get; set; }

        public event Listener ThemDauSach = null;
        public TraCuuDauSach()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<TheLoaiDTO> lst = TheLoaiBUS.LayDanhSach();
            TheLoaiDTO all = new TheLoaiDTO() { MATL = "ALL", TENTL = "Tất cả thể loại" };
            cbTheLoai.Items.Add(all);
            foreach (TheLoaiDTO tl in lst)
            {
                cbTheLoai.Items.Add(tl);
            }
            cbTheLoai.DisplayMemberPath = "TENTL";
            cbTheLoai.SelectedValuePath = "MATL";
            cbTheLoai.SelectedIndex = 0;

            cbSoLuong.SelectedIndex = 0;
            cbPrice.SelectedIndex = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string matl = cbTheLoai.SelectedValue.ToString();
            string soluong = ((ComboBoxItem)cbSoLuong.SelectedItem).Tag.ToString();
            string dongia = ((ComboBoxItem)cbPrice.SelectedItem).Tag.ToString();

            lstDS.DataContext = DauSachBUS.TimKiem(txtTenDauSach.Text, matl, soluong, dongia);
        }

        private void lstDS_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Option == 1)
            {
                if (sender != null)
                {
                    ListView lvw = sender as ListView;
                    if (lvw != null && lvw.SelectedItem != null)
                    {
                        DauSachDTO ds = (DauSachDTO)lvw.SelectedItem;

                        QuyDinhDTO qd = QuyDinhBUS.LayQuyDinh();
                        ds.SOLUONG = qd.NHAPTOITHIEU;
                        if (ThemDauSach != null)
                        {
                            ThemDauSach(lvw.SelectedItem, new MyDelegate(ds));
                        }
                    }
                }
            }
        }
    }
}
