   M S B A M L   `   `   `  ����   GUI    GUI.DonHang   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   .��� $��Stretch=�  � RowDefinitions  �� $
��Auto ��� $��30 ��� $
��Auto �.+��� $'��!Tìm kiếm thông tin hóa đơn��$��0��$��5q�.���   �� $��25 ��� $��25 � � ColumnDefinitions �� $	��110 ��� �� $��20 ��� $	��100 ��� .+��� $��Mã hóa đơn:��$��0��$��0��$��Center=�$
��10,0q��� -   $
��MaHD��$��1��$��0��$��Center=�$
��10,0q�$
��Bold"��� $��Mã khách hàng:��$��0��$��1��$��Center=�$
��10,0q��� -   $
��MaKH��$��1��$��1��$��Center=�$
��10,0q�$
��Bold"��� $��Ngày lập:��$��3��$��0��$��Center=�$
��10,0q�(  "System.Windows.Controls.DatePicker  -   $��NgayLap��$��4��$��0��$��Center=�$
��10,0q�$
��Bold"��� $��Tên nhân viên:��$��3��$��1��$��Center=�$
��10,0q��� -   $��TenNV��$��4��$��1��$��Center=�$
��10,0q�$
��Bold"��� -   $��
btnTimKiem��$��1��$��Center=�$��Center=�$��2q�.��Tìm kiếm�� $��2��$��5q�$��Danh sách hóa đơn��.��&   System.Windows.Controls.DataGrid  -   $��
dgvDonHang��   
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã hóa đơn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *MAHD+  $ Mã khách hàng��$ * 	 �� *MAKH+  $ Tên khách hàng��$ * 	 �� *TENKH+  $ Ngày lập��$ * 	 �� *	NGAYLAP+
 �� StringFormat$
 {0:dd/MM/yyyy}��  $ Nhân viên bán��$ * 	 �� *TENNV+  $ Tổng tiền��$ * 	 �� *
TONGTIEN+$
 {0:N0}��  $ 
Đã trả��$ * 	 �� *	TIENTRA+$
 {0:N0}��  $ 	Còn nợ��$ * 	 �� *TIENNO+$
 {0:N0}��