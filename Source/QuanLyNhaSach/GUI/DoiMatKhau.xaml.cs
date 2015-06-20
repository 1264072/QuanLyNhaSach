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
    /// Interaction logic for DoiMatKhau.xaml
    /// </summary>
    public partial class DoiMatKhau : UserControl
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            if (KiemTraDauVao())
            {

            }
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
            return true;
        }

        private void btnHuyBo_Click(object sender, RoutedEventArgs e)
        {
            ((this.Parent as TabItem).Parent as TabControl).Items.Remove(this.Parent);
        }
    }
}
