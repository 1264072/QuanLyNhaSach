   M S B A M L   `   `   `  ����   GUI    GUI.ChiTietHoaDon   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  ChiTietHoaDon��$��319.173��$��393.609��.��� $��Stretch=� � RowDefinitions �� $��25 ��� $��25 ��� $��25 ��� $
��Auto � � ColumnDefinitions �� $	��110 ��� �� $��20 ��� $	��130 ��� .+��� $��Mã hóa đơn:��$��0��$��0��$��Center=�$
��10,0q��� -   $
��MaHD��$��1��$��0��$��Center=�$
��10,0q�$
��Bold"��� $��Mã khách hàng:��$��0��$��1��$��Center=�$
��10,0q��� -   $
��MaKH��$��1��$��1��$��Center=�$
��10,0q�$
��Bold"��� $��Tổng tiền:��$��0��$��2��$��Center=�$
��10,0q��� -   $��TongTien��$��1��$��2��$��Center=�$
��10,0q�$
��Bold"��� $��Ngày lập:��$��3��$��0��$��Center=�$
��10,0q��� -   $��NgayLap��$��4��$��0��$��Center=�$
��10,0q�$
��Bold"��� $��Tên khách hàng:��$��3��$��1��$��Center=�$
��10,0q��� -   $��TenKH��$��4��$��1��$��Center=�$
��10,0q�$
��Bold"��� $��Nhân viên bán hàng:��$��3��$��2��$��Center=�$
��10,0q��� -   $��TenNV��$��4��$��2��$��Center=�$
��10,0q�$
��Bold"�&   System.Windows.Controls.DataGrid  -   $��
dgvChiTiet��$��3��$��5��   
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đầu sách��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *MADS+  $ 
Tên sách��$	 * 
 �� *
TENDAUSACH+  $ Thể loại��$	 * 
 �� *TENTL+  $ Số lượng��$	 * 
 �� *	SOLUONG+  $ 
Đơn giá��$	 * 
 �� *DONGIA+ �� StringFormat$ {0:N0}��  $ Thành tiền��$	 * 
 �� *	THANHTIEN+$ {0:N0}��