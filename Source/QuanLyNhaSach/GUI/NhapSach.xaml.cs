using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<DauSachDTO> lstDTO = new List<DauSachDTO>();
        QuyDinhDTO qd = QuyDinhBUS.LayQuyDinh();
        private NhanVienDTO nhanVienDTO;

        decimal tong = 0;
        public NhapSach()
        {
            InitializeComponent();
        }

        public NhapSach(NhanVienDTO nhanVienDTO)
        {
            // TODO: Complete member initialization
            this.nhanVienDTO = nhanVienDTO;
            InitializeComponent();
        }

        private void dgvChiTiet_Loaded(object sender, RoutedEventArgs e)
        {
            dgvChiTiet.ItemsSource = null;
            dgvChiTiet.ItemsSource = lstDTO;

            if (dgvChiTiet.Items.Count == 0)
            {
                SoLuong.Text = "0";
            }
            else
            {
                foreach (DauSachDTO item in lstDTO)
                {
                    tong += item.THANHTIEN;
                }
            }

            TongTien.Text = tong.ToString("N0") + " VND";
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            TraCuuDauSach timkiem = new TraCuuDauSach() { Option = 1 };
            timkiem.ThemDauSach += timkiem_ThemDauSach;
            Window window = new Window()
            {
                Title = "Thêm sản phẩm",
                Content = timkiem
            };
            Nullable<bool> result = window.ShowDialog();
        }

        void timkiem_ThemDauSach(object sender, MyDelegate e)
        {
            DauSachDTO ds = (DauSachDTO)e.Data;
            bool kq = lstDTO.Any(i => i.MADS == ds.MADS);
            if (!kq)
            {
                lstDTO.Add(ds);
            }
            dgvChiTiet_Loaded(null, null);
        }

        private void dgvChiTiet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                DataGrid lvw = sender as DataGrid;
                if (lvw != null && lvw.SelectedItem != null)
                {
                    DauSachDTO ds = (DauSachDTO)lvw.SelectedItem;
                    SoLuong.Text = ds.SOLUONG.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgvChiTiet.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắn chắn muốn xóa dữ liệu sản phẩm này ?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DauSachDTO ds = (DauSachDTO)dgvChiTiet.SelectedItem;
                    lstDTO.Remove(ds);
                    dgvChiTiet_Loaded(null, null);
                    MessageBox.Show("Đã xóa sản phẩm ra khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa khỏi danh sách !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            if (dgvChiTiet.SelectedItem != null)
            {
                DauSachDTO ds = (DauSachDTO)dgvChiTiet.SelectedItem;
                if (SoLuong.Value.Value < qd.NHAPTOITHIEU)
                {
                    MessageBox.Show("Số lượng nhập tối thiểu là " + qd.NHAPTOITHIEU, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    lstDTO.Where(s => s.MADS == ds.MADS).FirstOrDefault().SOLUONG = SoLuong.Value.Value;
                    dgvChiTiet_Loaded(null, null);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn sản phẩm cần cập nhật số lượng !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<NhaCungCapDTO> lst = NhaCungCapBUS.LayDanhSach();
            cbNCC.DataContext = lst;
            cbNCC.DisplayMemberPath = "TENNCC";
            cbNCC.SelectedValuePath = "MANCC";
            cbNCC.SelectedIndex = 0;
        }

        private void btnLapPhieu_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTra())
            {
                PhieuNhapDTO pn = new PhieuNhapDTO()
                {
                    MAPN = MaPN.Text,
                    MANV = nhanVienDTO.MANV,
                    MANCC = cbNCC.SelectedValue.ToString(),
                    NGAYLAP = (DateTime)NgayLap.SelectedDate,
                    TONGTIEN = tong,
                    CONNO = tong
                };
                int i = PhieuNhapBUS.ThemPhieuNhap(pn);
                if (i > 0)
                {
                    int n = ChiTietPhieuNhapBUS.ThemChiTiet(lstDTO, pn.MAPN);
                    if (n > 0)
                    {
                        MessageBox.Show("Lập phiếu nhập thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        MaPN.Text = "";
                        NgayLap.SelectedDate = null;
                        TongTien.Text = "0 VND";
                        dgvChiTiet.ItemsSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi ! Mã phiếu nhập đã tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    MaPN.Focus();
                }
            }
        }

        private bool KiemTra()
        {
            if (string.IsNullOrWhiteSpace(MaPN.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                MaPN.Focus();
                return false;
            }
            if (NgayLap.SelectedDate == null)
            {
                MessageBox.Show("Chưa chọn ngày hóa đơn !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                NgayLap.Focus();
                return false;
            }
            if (dgvChiTiet.Items.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm trong giỏ hàng !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                btnThem.Focus();
                return false;
            }
            return true;
        }
    }
}
