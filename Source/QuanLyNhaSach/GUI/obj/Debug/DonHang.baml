   M S B A M L   `   `   `  ����  GUI    GUI.DonHang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        .��5      � $��Stretch=�6     � RowDefinitions  5   
   �� 5	      $
��Auto �6   6,   �� 5
      $��30 �6   6*   �� 5      $
��Auto �6   6,   .+�5   
   �� $'��!Tìm kiếm thông tin hóa đơn��6   $��0��67   $��5q�6D   .��5      �   5      �� 5      $��25 �6$   62   �� 5      $��25 �6$   62    � ColumnDefinitions 5      �� 5      $	��110 �6'   65   �� 5      6)   �� 5      $��20 �6'   64   �� 5      $	��100 �6'   65   �� 5      6)   .+�5      �� $��Mã hóa đơn:��6   $��0��6/   $��0��6?   $��Center=�6L   $
��10,0q�6g   �� 5      -   5        $
��MaHD��5      $��1��6&   $��0��66   $��Center=�6C   $
��10,0q�6^   $
��Bold"�6l   �� 5      $��Mã khách hàng:��6   $��0��62   $��1��6B   $��Center=�6O   $
��10,0q�6k   �� 5      -   5        $
��MaKH��5      $��1��6&   $��1��66   $��Center=�6C   $
��10,0q�6^   $
��Bold"�6l   �� 5!      $��Ngày lập:��6   $��3��6-   $��0��6=   $��Center=�6J   $
��10,0q�6f   (  "System.Windows.Controls.DatePicker  5"      -   5        $��NgayLap��5"      $��4��6,   $��0��6<   $��Center=�6I   $
��10,0q�6d   $
��Bold"�6r   �� 5#      $��Tên nhân viên:��6   $��3��62   $��1��6B   $��Center=�6O   $
��10,0q�6k   �� 5$      -   5        $��TenNV��5$      $��4��6'   $��1��67   $��Center=�6D   $
��10,0q�6_   $
��Bold"�6m   5%      5&      �� 5(   
   -   5        $��
btnTimKiem��5(      $��1��6#   $��Center=�60   $��Center=�6M   $��2q�6h   .��6t   Tìm kiếm6~   �� 5*   
   $��2��6   $��5q�6    $��Danh sách hóa đơn��6+   .��5+      &   System.Windows.Controls.DataGrid  -   5        $��
dgvDonHang��5+   v      
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  ��6�   ��    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã hóa đơn��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *MAHD+6V     5.      $ Mã khách hàng��6)   $ * 6Y   	 6@   �� *MAKH+6Y     5/      $ Tên khách hàng��6)   $ * 6[   	 6A   �� *TENKH+6[     50      $ Ngày lập��6)   $ * 6v   	 6;   �� *	NGAYLAP+
 �� StringFormat$
 {0:dd/MM/yyyy}��6v     51      $ Nhân viên bán��6)   $ * 6Z   	 6@   �� *TENNV+6Z     52      $ Tổng tiền��6)   $ * 6p   	 6<   �� *
TONGTIEN+$
 {0:N0}��6p     53      $ 
Đã trả��6)   $ * 6l   	 69   �� *	TIENTRA+$
 {0:N0}��6l     54      $ 	Còn nợ��6)   $ * 6k   	 69   �� *TIENNO+$
 {0:N0}��6k   56      57      59      5:      