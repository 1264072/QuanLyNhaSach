   M S B A M L   `   `   `  ����   GUI    GUI.LapHoaDon   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   .���   � RowDefinitions  �� $��80 ��� $��10 ��� $
��auto ��� $��40 ��� $��40 ��� $��60 �.+��� $��2��$��Thông tin hóa đơn��.���  � ColumnDefinitions �� $	��100 ��� $��* ��� $	��100 ��� $��* ��� $	��100 ��� $��* �  �� $��30 ��� $��30 �.+��� $��Center=�$��Center=�$��Mã hóa đơn��$��0��$��0���� -   $��txtMaHD��$��Center=�$
��Left=�$��1��$��0��$	��200���� $��Center=�$��Center=�$��Tên khách hàng��$��2��$��0���� -   $��cbMaKH��$��Center=�$
��Left=�$��3��$��0��$	��200�� �� DisplayMemberPath$ HOTEN�� �� SelectedValuePath$
 MAKH������ �� $��Center=�$��Center=�$��Mã nhân viên��$��4��$��0���� -   $��txtMaNV��$��Center=�$
��Left=�$��5��$��0��$	��200�� �� 
IsReadOnly . �� $��Center=�$��Center=�$��Ngày lập hóa đơn��$��0��$��1��(  "System.Windows.Controls.DatePicker  -   $
��NLHD��$��Center=�$
��Left=�$��1��$��1��$	��200���� $��2��$��Danh sách sản phẩm��.���� -   $��lstDS��$	��150������  �� View �� .P��� $�� �� �� Width$ 30�� �� CellTemplate �� .R��� .+��� $	��chk�� d� 	IsChecked �� 	 �� Path$	 
IsSelected�
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" ���� $��Tên đầu sách�� �� DisplayMemberBinding �� *
TENDAUSACH+ ��  �� ElementName$ helperField��$	 ActualWidth��� $��Tên thể loại�� �� *TENTL+ �� $ helperField��$	 ActualWidth��� $��Giá đầu sách�� �� *DONGIA+ �� $ helperField��$	 ActualWidth��� $��Số lượng�� �� $ helperField��$	 ActualWidth� �� .R��� .+��� $��txtQuantity��$��50������ $	 SOLUONG��� $��Thành tiền�� �� *	THANHTIEN+ �� $ helperField��$	 ActualWidth�� $y�Hidden=� �� $��52 ��� ���� $	 col��$	 ActualWidth��� $��* ��� $��* ��� $��* ��� $��* �.+�� -    �Name$ helperField��$��1��]� $��3����.  .+��� -   $	��120��$��30��$
��Left=�$��0,0,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $!��.\Icons\addressbook-add.png��$��24��$��24��$��Center=�$
��Left=��� $��Thêm sản phẩm��$��Center=��� -	   $��btnXoa��$��80��$��30��$
��Left=�$��0,0,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $$��.\Icons\addressbook-delete.png��$��24��$��24��$��Center=�$
��Left=��� $
��Xóa��$��Center=��� -
   $��
btnCapNhat��$	��100��$��30��$
��Left=�$��0,0,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $"��.\Icons\addressbook-edit.png��$��24��$��24��$��Center=�$
��Left=��� $��Cập nhật��$��Center=��� -   $��txtTongTien��$��Center=�$��Right=�$��0��$��Right=�$��0,0,60,0q�$��16(�$
��Bold"�
���  ���� $��Center=�$��Right=�$��Tổng tiền : ��$��Right=�$��16(�$
��Bold"�
���  ��]� $��4����.  .+��� -   $��txtSoTienNhan��$��Center=�$��Center=�$	��150��$��Right=�$��0,0,25,0q��� $��Center=�$��Center=�$��Right=�$��Số tiền nhận��$��14(�$��0,0,5,0q��� -   $��btnLapHoaDon��$��5��$	��150��$��60��$��Right=�$��0,0,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $��.\Icons\add1.png��$��48��$��48��$��Center=�$
��Left=��� $��Lập hóa đơn��$��Center=�