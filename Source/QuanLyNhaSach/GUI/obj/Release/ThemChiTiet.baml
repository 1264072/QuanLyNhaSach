   M S B A M L   `   `   `  ����   GUI    GUI.ThemChiTiet   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Chi tiết hóa đơn��$	��580��.���  � RowDefinitions �� $
��Auto ��� $��60 ��� $
��auto ��� $��60 ��� $
��auto ��� $��60 �.+��� $��0��$ ��Thông tin cần tra cứu��.���  �� $��30 ��� $��30 � � ColumnDefinitions �� $	��120 ��� $��* ��� $��50 ��� $	��100 ��� $��* �.+��� $��0��$��0��$��Center=�$
��10,0q�$��Tên đầu sách���� -   $��txtTenDauSach��$��1��$��0��$��Center=�$
��10,0q��� $��0��$��1��$��Center=�$
��10,0q�$��Số lượng tồn���� -   $��	cbSoLuong��$��1��$��1��$��Center=�$
��10,0q� �� SelectedValue$	 Tag��.@��� 
 � Tag$ 1��.���� $+��%Từ ít nhất đến nhiều nhất���� $ 0��.���� $+��%Từ nhiều nhất đến ít nhất���� $��3��$��0��$��Center=�$
��10,0q�$��Thể loại���� -   $��	cbTheLoai��$��4��$��0��$��Center=�$
��10,0q� �� DisplayMemberPath$ TENTL�� �� SelectedValuePath$
 MATL��$
 MATL������ �� $��3��$��1��$��Center=�$
��10,0q�$��Lọc theo giá���� -   $��cbPrice��$��4��$��1��$��Center=�$
��10,0q�$	 Tag��.@��� $ 1��.���� $*��$Từ thấp nhất đến cao nhất���� $ 0��.���� $*��$Từ cao nhất đến thấp nhất���� -   $��1��$	��100��$��50��$��Right=�$��0,5,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $"��.\Icons\Magnifying-glass.png��$��48��$��48��$��Center=�$
��Left=��� $��	Tra cứu��$��Center=��� $��2��$"��Danh sách các đầu sách��.���� -   $��lstDS��$	��100������  �� View �� .P��� $��Tên đầu sách�� �� DisplayMemberBinding �� *	TENSACH+	 �� Width	 �� 
 �� ElementName$
 helperField�� �� Path$ ActualWidth��� $��Tên thể loại�� �� *TENTL+	 �� $
 helperField��$ ActualWidth��� $��Giá đầu sách�� �� *DONGIA+	 �� $
 helperField��$ ActualWidth��� $��Số lượng�� �� *	SOLUONG+	 �� $
 helperField��$ ActualWidth�� $y�Hidden=� �� $��45 ��� ���� $	
 col��$ ActualWidth��� $��* ��� $��* ��� $��* �.+�� -    �Name$ helperField��$��1���� -	   $��	btnThemHD��$��3��$	��200��$��50��$��Right=�$��0,5,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $!��.\Icons\addressbook-add.png��$��48��$��48��$��Center=�$
��Left=��� $&�� Thêm vào chi tiết hóa đơn��$��Center=��� $��4��$��Chi tiết hóa đơn��.���� -
   $��lstDSCT��$	��150������  �� .P��� $��Tên đầu sách�� �� *
TENDAUSACH+	 �� $
 helperField2��$ ActualWidth��� $��Tên thể loại�� �� *TENTL+	 �� $
 helperField2��$ ActualWidth��� $��Giá đầu sách�� �� *DONGIA+	 �� $
 helperField2��$ ActualWidth��� $��Số lượng�� �� *	SOLUONG+	 �� $
 helperField��$ ActualWidth�� $y�Hidden=� �� $��45 ��� ���� $	
 col��$ ActualWidth��� $��* ��� $��* ��� $��* �.+�� -   $ helperField2��$��1���� -   $��btnThemHoaDon��$��5��$	��170��$��50��$��Right=�$��0,5,10,0q���Z� ��Z� .��]� $
��Left=���.  .+��� $��.\Icons\Order-history.png��$��48��$��48��$��Center=�$
��Left=��� $��Thêm vào hóa đơn��$��Center=�