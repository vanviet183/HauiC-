   M S B A M L   `   `   `  ����D  @DeOnTap01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DeOnTap01	DeOnTap01  5   	       DeOnTap01.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DeOnTap01     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $
��mabn��5
      $��Mã bệnh nhân��6   $
��Left=�63   $��	72,47,0,0q�6N   $	��Top=�6a   $	��120��6y   $��30��6�   �� 5   
   -   5        $��hoTen��5      $��	Họ tên��6   $
��Left=�6.   $��	72,82,0,0q�6I   $	��Top=�6\   $	��120��6t   $��30��6�   �� 5   
   -   5        $��diaChi��5      $��Địa chỉ��6   $
��Left=�60   $��
72,117,0,0q�6K   $	��Top=�6_   $	��120��6w   $��30��6�   �� 5   
   -   5        $��soNgay��5      $��Số ngày nằm viện��6   $
��Left=�69   $��
72,152,0,0q�6T   $	��Top=�6h   $	��120��6�   $��30��6�   �� 5   
   -   5        $
��khoa��5      $��
Khoa khám��6   $
��Left=�60   $��
72,187,0,0q�6K   $	��Top=�6_   $	��120��6w   $��30��6�   �� 5   
   $
��Left=�6   $��
276,47,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   $	��200��6m   $��30��6y   �� 5   
   $
��Left=�6   $��
276,82,0,0q�6-   $
 Wrap=�6A   $	��Top=�6U   $	��200��6m   $��30��6y   �� 5   
   $
��Left=�6   $��276,117,0,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��200��6n   $��30��6z   �� 5   
   $
��Left=�6   $��276,152,0,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��200��6n   $��30��6z   �� 5   
   -   5        $��khoaCb��5      $
��Left=�6!   $��276,187,0,0q�6<   $	��Top=�6Q   $	��200��6i   $��30��6u   &   System.Windows.Controls.DataGrid  5   
   -   5        $
��data��5      $��40,234,40,60q�6      AutoGenerateColumns$ False��65      AlternatingRowBackground
 �����   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã bệnh nhân��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaBn+  5      $ 	Họ tên��6%    65   �� *HoTen+  5      $ Địa chỉ��6%    66   �� *DiaChi+  5      $ Số ngày nằm viện��6%    6?   �� *SoNgayNamVien+  5      $ 
Khoa khám��6%    68   �� *MaKhoa+  5      $ Viện phí��6%    67   �� *	VienPhi+5      �� 5   
   -	   5        $	��add��5      $��Thêm��6   $
��Left=�6+   $��278,394,0,0q�6F   $	��Top=�6[   $��25��6s   $��56��6   6�   �� 5   
   -
   5        $
��find��5      $
��Tìm��6   $
��Left=�6+   $��400,394,0,0q�6F   $	��Top=�6[   $��25��6s   $��56��6   6�   5!      5"      