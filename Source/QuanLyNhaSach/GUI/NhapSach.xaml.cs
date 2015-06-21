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
    /// Interaction logic for NhapSach.xaml
    /// </summary>
    public partial class NhapSach : UserControl
    {
        public List<DauSachDTO> lstDTO { get; set; }
        public NhapSach()
        {
            InitializeComponent();
        }

        private void dgvChiTiet_Loaded(object sender, RoutedEventArgs e)
        {
            dgvChiTiet.DataContext = lstDTO;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window()
            {
                Title = "Thêm sản phẩm",
                Content = new TraCuuDauSach() { Option = 1 }
            };
            window.ShowDialog();
        }

        public void ThemDauSach(DauSachDTO ds)
        {
            lstDTO.Add(ds);
            dgvChiTiet_Loaded(null, null);
        }
    }
}
