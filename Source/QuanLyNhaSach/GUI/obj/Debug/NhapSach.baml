   M S B A M L   `   `   `  ����  GUI    GUI.NhapSach   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47wpftool)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5        .��5      �   � RowDefinitions  5	   
   �� 5
      $
��Auto �6   �� 5      $��50 �6   �� 5      $	��200 �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��Thông tin phiếu nhập��6    $��10q�6>   .��5      �   5      �� 5      $��30 �6$   �� 5      $��30 �6$    � ColumnDefinitions 5      �� 5      $	��120 �6'   �� 5      $��* �6'   �� 5      $��50 �6'   �� 5      $	��100 �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��0��6,   $��Center=�69   $
��10,0q�6T   $��Mã phiếu nhập��6b   �� 5      -   5        $
��MaPN��5   `   $��1��6   $��0��6*   $��Center=�67   $
��10,0q�6R   6`   �� 5       $��0��6   $��1��6,   $��Center=�69   $
��10,0q�6T   $��Ngày lập phiếu��6b   (  "System.Windows.Controls.DatePicker  5!      -   5        $��NgayLap��5!      $��1��6,   $��1��6<   $��Center=�6I   $
��10,0q�6d   6t   �� 5#      $��3��6   $��0��6,   $��Center=�69   $
��10,0q�6T   $��Nhà cung cấp��6b   �� 5$      -   5        $��cbNCC��5$   a   $��4��6   $��0��6+   $��Center=�68   $
��10,0q�6S    �� DisplayMemberPath$ TENNCC��6�    �� SelectedValuePath$ MANCC��6�   ��6n   �� 6�   �� 5%      $��3��6   $��1��6,   $��Center=�69   $
��10,0q�6T   $��Tổng tiền��6b   �� 5&      -   5        $��TongTien��5&      $��4��6,   $��1��6<   $��Center=�6I   $
��10,0q�6d   
���  ��$
��Bold"�6�   5'      5(      �� 5*   
   $��1��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5+      �� $
��10,0q�6   $��Center=�6&   Số lượng6K   %  Xceed.Wpf.Toolkit.IntegerUpDown  5,      -   5        $��SoLuong��5,   p   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	Increment$ 1X�6$   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$ 0��62   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�6;   $
��10,0q�6G   $��Center=�6U   $��50��6   6�   �� 5-      -   5        $��
btnCapNhat��5-   J   $��2q�6   $
��10,0q�6!   $��Center=�6/   .��6u   Cập nhật số lượng6�   �� 5.      -   5        $��btnXoa��5.   J   $��2q�6   $
��10,0q�6!   $��Center=�6/   .��6m   Xóa chi tiết6{   �� 5/      -	   5        $��btnThem��5/   #   $
��10,0q�6   $��Center=�6H   $��Center=�6e   $��2q�6�   .��6�   Thêm sản phẩm6�   50      �� 52   
   $��2��6   $��Chi tiết phiếu nhập��6    $��10q�6=   .��53      &   System.Windows.Controls.DataGrid  -
   5        $��
dgvChiTiet��53   K      AutoGenerateColumns .  	   CanUserAddRows	 .  
   
IsReadOnly
 . ��6   ��    Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Tên sách��6)      Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	 6W   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6;   �� *	TENSACH+6W     56      $ Thể loại��6)   $ *	 6U    6;   �� *TENTL+6U     57      $ 
Tác giả��6)   $ *	 6U    6:   �� *TACGIA+6U     58      $ Số lượng��6)   $ *	 6W    6;   �� *	SOLUONG+6W     59      $ 
Đơn giá��6)   $ *	 6l    6:   �� *DONGIA+ �� StringFormat$ {0:N0}��6l     5:      $ Thành tiền��6)   $ *	 6r    6=   �� *	THANHTIEN+$ {0:N0}��6r   5<      5=      �� 5?   
   -   5        $��btnLapPhieu��5?      $��3��6   $��Center=�6K   $��Center=�6f   $��5q�6�   .��6�   Lập phiếu6�   5@      5A      