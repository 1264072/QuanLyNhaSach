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
    /// Interaction logic for DoiMatKhau.xaml
    /// </summary>
    public partial class DoiMatKhau : UserControl
    {
        private NhoMatKhauDTO nhoMatKhauDTO;

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public DoiMatKhau(NhoMatKhauDTO nhoMatKhauDTO)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.nhoMatKhauDTO = nhoMatKhauDTO;
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {
                if (!TaiKhoanBUS.KiemTraMatKhau(nhoMatKhauDTO.USERNAME, txtMatKhauCu.Password))
                {
                    ThongBao1.Text = "* Mật khẩu cũ không đúng";
                }
                else
                {
                    int i = TaiKhoanBUS.DoiMatKhau(nhoMatKhauDTO.USERNAME, txtMatKhauMoi.Password);
                    if (i > 0)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetAll();
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ! Thay đổi mật khẩu thất bại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetAll();
                    }
                }                
            }
        }

        private void ResetAll()
        {
            txtMatKhauCu.Password = "";
            txtMatKhauMoi.Password = "";
            txtNhapLai.Password = "";
        }

        private bool KiemTraDauVao()
        {
            if (String.IsNullOrEmpty(txtMatKhauCu.Password))
            {
                ThongBao1.Text = "* Chưa nhập mật khẩu cũ";
                txtMatKhauCu.Focus();
                return false;
            }
            ThongBao1.Text = "";
            if (String.IsNullOrEmpty(txtMatKhauMoi.Password))
            {
                ThongBao2.Text = "* Chưa nhập mật khẩu mới";
                txtMatKhauMoi.Focus();
                return false;
            }
            ThongBao2.Text = "";
            if (String.IsNullOrEmpty(txtNhapLai.Password))
            {
                ThongBao3.Text = "* Chưa nhập lại mật khẩu mới";
                txtNhapLai.Focus();
                return false;
            }
            ThongBao3.Text = "";
            if (txtMatKhauMoi.Password != txtNhapLai.Password)
            {
                ThongBao3.Text = "* Mật khẩu nhập lại không đúng";
                txtNhapLai.Focus();
                return false;
            }
            ThongBao3.Text = "";
            return true;
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            ((this.Parent as TabItem).Parent as TabControl).Items.Remove(this.Parent);
        }
    }
}
