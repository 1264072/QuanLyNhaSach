   M S B A M L   `   `   `  ����   GUI    GUI.NhapSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���   � RowDefinitions  �� $
��Auto ��� $��50 ��� $	��200 ��� $��50 �.+��� $��0��$��Thông tin phiếu nhập��$��10q�.���   �� $��30 ��� $��30 � � ColumnDefinitions �� $	��120 ��� $��* ��� $��50 ��� $	��100 ��� $��* �.+��� $��0��$��0��$��Center=�$
��10,0q�$��Mã phiếu nhập���� -   $
��MaPN��$��1��$��0��$��Center=�$
��10,0q��� $��0��$��1��$��Center=�$
��10,0q�$��Ngày lập phiếu��(  "System.Windows.Controls.DatePicker  -   $��NgayLap��$��1��$��1��$��Center=�$
��10,0q��� $��3��$��0��$��Center=�$
��10,0q�$��Nhà cung cấp���� -   $��cbNCC��$��4��$��0��$��Center=�$
��10,0q� �� DisplayMemberPath$ TENNCC�� �� SelectedValuePath$ MANCC������ �� $��3��$��1��$��Center=�$
��10,0q�$��Tổng tiền���� $��4��$��1��$��Center=�$
��10,0q�
���  ��$
��Bold"��� -   $��btnThem��$��1��$��Center=�$��Center=�$��2q�.��Thêm sản phẩm�� $��2��$��Chi tiết phiếu nhập��$��10q�.��&   System.Windows.Controls.DataGrid  -   $��
dgvChiTiet��   CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Tên sách��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *	TENSACH+  $ Thể loại��$ *  . 	 �� *TENTL+  $ 
Tác giả��$ *  . 	 �� *TACGIA+  $ Số lượng��$ * 	 �� *	SOLUONG+  $ 
Đơn giá��$ *  . 	 �� *DONGIA+
 �� StringFormat$
 {0:N0}��  $ Thành tiền��$ *  . 	 �� *	THANHTIEN+$
 {0:N0}��