   M S B A M L   `   `   `  ����C  ?WPF13Lab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF13Lab.ViewWPF13Lab.View  5      -clr-namespace:WPF13Lab.ViewWPF13Lab.View  5      7 clr-namespace:WPF13Lab.ViewModelWPF13Lab.ViewModel  5          WPF13Lab.View.MenuView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WPF13Lab.View     5      ,viewclr-namespace:WPF13Lab.View     5      6	viewmodel clr-namespace:WPF13Lab.ViewModel     5        � 	Resources  5      &   WPF13Lab.ViewModel.GameViewModel   	viewModel  MenuButtonTemplate �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty W� From	 W� To	 g� Duration
 ��Name J� Opacity��%�  &	        &	        5   
   6"   �� 5   
   " ��65   .R�5      �� $
��Auto��6   $
��Auto��6&   $��Center=�64    5        5      . 5        
Normal��. 5      �� .��5   "   W� $ btnUnderline��62   $ Opacity�6W   $ 1X�5   %   $ 0X�6.   $	 0:0:0.2D�65   5      5        5      	MouseOver��. 5      �� .��5   "   W� $ btnUnderline��62   $ Opacity�6W   $ 0X�5   %   $ 1X�6.   $	 0:0:0.2D�65   5      5       5!      .+�5$      �� #��z��6   $
��Auto��6=   $��42(�6K   
�������$��Impact)�6q   �� 5%      $
 btnUnderline��6M   $
��Auto��6   $��4��6*   
�������$��0,2,0,0q�6c   $ 0Q�6t   5&      5'      5(      .��5+      � .+�5,   
   ��  � DataContext# [  6   $��1��5.      ��5-      ��  �� Path$ Sprites���5/      �� 50      .R�51      �� -   5        51      52      54      �� 56   
   .+�57      � $��Center=�6   $��Center=�60   $��	0,120,0,0q�6K    � RowDefinitions 58      �� 59      $
��Auto �6$   �� 5:      $��20 �6$   �� 5;      $
��Auto �6$   �� 5<      $��10 �6$   �� 5=      $
��Auto �6$   .+�5@      �� $��../Assets/logo.png��6   $��0��64   $	��550��6A   �� 5B      -   5         ��Name$ startBtn��5B      $��Center=�6B   $��2��6_   $��START��6l   #��[ 6|   �� 5C      -   5        $ exitBtn��5C      $��Center=�6@   $��4��6]   $��WYJDŹ��6j   #��[ 6z   5D      5E      5F      5G      