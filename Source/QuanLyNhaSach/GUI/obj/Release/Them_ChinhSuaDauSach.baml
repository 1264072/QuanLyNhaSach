   M S B A M L   `   `   `  ����   GUI    GUI.Them_ChinhSuaDauSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47wpfTool)http://schemas.xceed.com/wpf/xaml/toolkit  -     � Title$  Them_ChinhSuaDauSach��$	��400��$	��600�� � 
ResizeMode$ NoResize=�.��� .+��� $��Thông tin đầu sách��$��10q�.����  �� Orientation$ 
Horizontal=�.+�� $��20q�$
��Left=� � RowDefinitions �� �� �� �� �� �� $��30 � � ColumnDefinitions �� $	��100 ��� .+��� $��Center=�$��SemiBold"�$��0��$��0��$��16��$	��0,6q�
Tên sách�� $��Center=�$��SemiBold"�$��0��$��1��$��16��$	��0,6q�Thể loại�� $��Center=�$��SemiBold"�$��0��$��2��$��16��$	��0,6q�
Tác giả�� $��Center=�$��SemiBold"�$��0��$��3��$��16��$	��0,6q�Số lượng�� $��Center=�$��SemiBold"�$��0��$��4��$��16��$	��0,6q�
Đơn giá�� -   $��TenSach��$��Center=�$��1��$��0��$��18��$	��0,5q��� -   $��TheLoai�� �� DisplayMemberPath$ TENTL�� �� SelectedValuePath$
 MATL�� �� SelectedValue$
 MATL��$��Center=�$��1��$��1��$��23������ �� -   $��TacGia��$��Center=�$��1��$��2��$��18��$	��0,5q�%  Xceed.Wpf.Toolkit.IntegerUpDown  -   $��SoLuong��$��Center=�$��1��$��3��$��18��$	��0,5q�,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$ 0���  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]	   Minimum$	 0X��  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
   	Increment$
 1X�%  Xceed.Wpf.Toolkit.DecimalUpDown  -   $��DonGia��$��Center=�$��1��$��4��$��18��$	��0,5q��  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$ 0��$
 1000���  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�   	Increment$
 1000X��� $��1��$��5��$ 
Horizontal=�$��Center=�.+��� -   $��
btnXacNhan��$��5q�$	��100��.��Xác nhận�� -   $��btnHuyBo��$��5q�$��50��.��
Hủy bỏ�� -	   $��ThongBao��$��Italic$�
���  ��$
��0,30q�