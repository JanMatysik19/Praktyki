   M S B A M L   `   `   `  ����@  <WPF10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF10WPF10  5   	   'clr-namespace:WPF10.View
WPF10.View  5   	   1clr-namespace:WPF10.ViewModelWPF10.ViewModel  5   	       WPF10.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPF10     5   	   )viewclr-namespace:WPF10.View     5   	   3	viewmodelclr-namespace:WPF10.ViewModel     5   	     � Title$  
MainWindow��5
   	   $	��593��6   $	��800��6)    � 	Resources 5       �� 
TargetType   TitleTB �� Property �� Value��%R   &	        �� 5   
   " ��6   .�5      ��  � ��$ 36(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      �� 5      $	��120 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $��15 �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $��50 �6   .+�5$   
   �� $��Stoper��6   $��1��6"   $��1��62   #��[  6?      WPF10.View.BasicStopwatch  5&   
   $��1��6   $��3��6.   $��Center=�6;       WPF10.View.AnalogStopWatch  5(   
   $��1��6   $��4��6/   $��Center=�6<   5)      5*      