   M S B A M L   `   `   `  ����C  ?WpfApp34, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp34WpfApp34  5   	       WpfApp34.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp34     5   	     � Title$  Пример 1��5   	   $	��360��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�5	      $��Comic Sans MS)�5
       � WindowStyle$ 
ToolWindow=�5       � 
ResizeMode$ NoResize=�5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $	��150 �6   �� 5      �� 5      $��30 �6   .+�5   
   �� $��Пример 1��6   $��0��5      $��Center=�5      $��Center=�5      $��18��6   $��
119,7,94,5q�6(   $��81��6<   $��2��6G   �� 5   
   $!��Входные данные��6   $��2��5      $��0��5      $
��Left=�5       $	��Top=�5!      $��5,10,0,0q�5"      $��17��6   $��98��6   �� 5#   
   $��Ответ:��6   $��2��6"   $��5,10,169,52q�66   $��3��6K   �� 5$   
   -   5         ��Name$ TextBlockAnswer��5$      $��3��5%      $��0��5'      $��2��5(      $��Stretch=�5)      $��Stretch=�5*      $��119,10,10,52q�5+      �� 5,   
   -   5        $ ListBoxData��5,      $��2��5-      $��Visible=�5.      $
��10 0q�5/      $��1q�50      $��
108,0,0,87q�6   $��2��6)   $��2��6:   �� 51   
   $��4��6   $��0��52      $��2��53       �� Orientation$ 
Horizontal=�54      $��Center=�55      $
��61,0q�6   $	��172��6,   .+�56      �� -   5         ��Name$ BtnOK��56      $��OK��6$   $��80��57      $��24��6   $��3q�6   ���	#FF3985B0
�������	 �� 	IsDefault	 . 5:      �� 5;      -   5        $ 	BtnCancel��5;      $��Cancel��6(   $��80��5<      $��24��6   $��3q�6   ���	#FF3985B0
�������
 �� IsCancel
 . 5?      5@      5A      5B      