   M S B A M L   `   `   `  ����C  ?WPF13Lab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF13Lab.ViewWPF13Lab.View  5      -clr-namespace:WPF13Lab.ViewWPF13Lab.View  5      7 clr-namespace:WPF13Lab.ViewModelWPF13Lab.ViewModel  5          WPF13Lab.View.GameView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WPF13Lab.View     5      ,viewclr-namespace:WPF13Lab.View     5      6	viewmodel clr-namespace:WPF13Lab.ViewModel     5      -   5          N� Title$  GameView��5       N� 
Background �#1e1f21 � 	Resources 5      '  !WPF13Lab.ViewModel.AGameViewModel   	viewModel �� 
TargetType  TitleFB �� Property �� Value  PointsTB  MenuButtonTemplate �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� 
TargetName �� TargetProperty W� From	 W� To g� Duration ��Name J� Opacity��%�  &	        &	      &	 �     &	       5   
   66   �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 36(�6)   �� 5       � ��$ 25,0,0,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��65   .R�5      �� $
��Auto��6   $
��Auto��6&   $��Center=�64    5         5!      . 5"        
Normal��.	 5#      �� .��5$   "   W� $
 btnUnderline��62   $ Opacity�6W   $ 1X�5%      $ 0X�6&   $ 0:0:0.2D�6-   5&      5'        5)      	MouseOver��.	 5*      �� .��5+   "   W� $
 btnUnderline��62   $ Opacity�6W   $ 0X�5,      $ 1X�6&   $ 0:0:0.2D�6-   5-      5.      5/      .+�52      �� #��z��6   $
��Auto��6=   $��42(�6K   
�������$��Impact)�6q   �� 53      $ btnUnderline��6M   $
��Auto��6   $��4��6*   
�������$��0,2,0,0q�6c   $ 0Q�6t   54      55      56      .��5:      �  � ColumnDefinitions 5;   
   �� 5<      $��50 �6   �� 5=      $
��Auto �6   �� 5>      $��4* �6   �� 5?      $
��Auto �6   �� 5@      $��50 �6    � RowDefinitions 5C   
   �� 5D      $��15 �6   �� 5E      $
��Auto �6   �� 5F      $��15 �6   �� 5G      $��3* �6   �� 5H      $��15 �6   .+�5M   
   �� $��1��6   $��1��6!   $��Invaders��61   #��[ 6A   �� 5O   
   $��1��6   $��3��6"   $
��Auto��62   $
��Auto��6?   $��Right=�6M    �� Orientation$ Vertical=�6i   $��0,0,25,0q�6�   .+�5P      �� $
��2350��6   #��[ 6$   �� 5R      $
��Auto��6   $
��Auto��6&   $��Right=�64   $ 
Horizontal=�6P   5T      5U      �� 5W   
    �� CornerRadius$ 20��6   
���   �$��3q�66   ���#353638$��3��5X      $��1��6   $��3��6*   ._�5Y      ��  � DataContext# [  6   $��1��5[      ��5Z      ��  �� Path$ Sprites���5\      �� 5]      .R�5^      �� -   5        5^   !   5_      5a      5c      � 5h   
   -   5         �Name$
 menu��5h   h   ���	#CC3E3E3E$��0��6&   $��0��66   $��5��6C   $��5��6W   $y�Hidden=�6v    5i      �� 5j      $	��120 �6    �� 5k      $
��Auto �6    �� 5l      $��20 �6    �� 5m      $
��Auto �6    �� 5n      $��10 �6    �� 5o      $
��Auto �6    �� 5p      $��10 �6    �� 5q      $
��Auto �6    .+�5t      �� $��../Assets/logo.png��6   $��1��60   $	��550��6=   �� 5v      -   5         ��Name$ startBtn��5v      $��Center=�6>   $��3��6[   $��	KONTYNUUJ��6h   #��[ 6|   �� 5w      -   5        $ exitToMenuBtn��5w      $��Center=�6H   $��5��6e   $��WYJDŹ DO MENU��6r   #��[ 6�   �� 5x      -   5        $ exitBtn��5x      $��Center=�6<   $��7��6Y   $��WYJDŹ��6f   #��[ 6v   5y      5z      5{      