   M S B A M L   `   `   `  ����C  ?iamst4rk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:iamst4rk.windowsiamst4rk.windows  5   	       iamst4rk.windows.main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:iamst4rk.windows     5   	     � Title$  Главное окно��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��69* �6   �� 5      $
��283* �6   �� 5      $	��82* �6   .+�5   
   �� $
��Left=�6   $	��200��60   .+�5      �� .��6   " Поиск по читателю6'   �� 5      -   5         ��Name$ 	TbReaders��5      $	��200��6M   6[   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6/   $��60��6L   .+�5      �� -   5         ��Name$	 CSV��5   =   $
��50px��6   $��/res/img_20646.png��6!   6J   5      �� 5   
   $
��Left=�6   $��1��60   $��50��6>   $��	0,283,0,0q�6I   $��2��6\   .+�5      �� -   5        $��/res/tlb-logout-1.png��5      $
��50px��63   $��0 15 0 0q�6@   6�   5      �� 5   
   $��Right=�6   $��2��61   .+�5      �� $��/res/logo_vis222.png��6   $��150px��62   6B   5      �� 5   
   -   5         ��Name$ 	LvReaders��5       $��1��6   ��5      �� 5      .R�5      �� .+�5       �� $	��100��6!   $	��100��6-    �� CornerRadius$	 200��6:   ��5!      �� 5"   "    �� ImageSource 6-   �� *Photo+6M   5$      �� 5%      $��20(�6$   	 �� TextAlignment$	 Center=�62   ��6I   �� *fio+�� 5&      $��20(�6$   $	 Center=�62   $�� ��6I   5'      5(      ��5*      �� 5+      .R�5,      � $	��650��6    6.   5-      5/      �� 50   
   -   5        $ ImgBilet_Copy��50   -   
 � ToolTip$)
 #Читательский билет��6   $��/res/img_570846.png��6|   $
��50px��6�   $
��50px��6�   $��
690,0,60,0q�6�   51      52      