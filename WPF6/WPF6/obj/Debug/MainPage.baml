   M S B A M L   `   `   `  ����?  ;WPF6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPF6WPF6  5          WPF6.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:WPF6     5        N� Title$  MainPage��5	       N� 
Background �	#FFFAFAFA � 	Resources 5        WPF6.ComicQueryManager   comicQueryManager 	 Title �� 
TargetType �� Property �� Value  SubheaderTextStyle  ListViewStyle  ListTitleStyle  ListSubtitleStyle��%w  &	        &	      &	 �     &	 �     &	 ^    &	 �      5   
   6<   �� 5   
   " ��6   .�5      ��  � ��$ 32(�6)   �� 5       � ��$ Arial)�6+   5      �� 5   
   " ��6+   .�5      ��  � ��$ 20(�6)   �� 5       � ��$ Arial)�6+   5      �� 5   
   " ��6&   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 0q�60   5      �� 5!   
   " ��6'   .�5"      ��  � ��$
 Bold"�6+   �� 5#       � ��$ 15(�6)   5$      �� 5&   
   " ��6*   .�5'      ��  � ��$ Light"�6+   �� 5(       � ��$ 13(�6)   5)      5*      .��5,      � $
��0,50q�6    � DataContext# [  6    � RowDefinitions 5-   
   �� 5.      $
��Auto �6   �� 5/      $��75 �6   �� 50      $
��Auto �6   �� 51       � ColumnDefinitions 53   
   �� 54      $��80 �6   �� 55      �� 56      $��60 �6   .+�59   
   �� $��1��6   $��0��6$   #��[ 61   $��Komiksy Janka��6P   �� 5<   
   $��1��6   $��2��6$   #��[ 61   $$��Wybierz zapytanie do wykonania��6]   $��	10,0,0,20q�6�   �� 5>   
   -   5        $
��list��5>   �   $��3��6   $��1��6    $��	0,-10,0,0q�60   #��[ 6l   ��6C   �� *AvailableQueries+��5?      �� 5@      .R�5A      �� 	 �� Orientation$	 
Horizontal=�6!   $��0,0,0,15q�6:   .+�5B      �� $	��110��6!   $	��110��6-   ._�5C      �� $��UniformToFill=�6=   ��6$   �� *Image+4  .System.Windows.Automation.AutomationProperties
   Name
 6U   �� *Title+5D      �� 5E      $��1��6%   $	��Top=�65   $��10,0,0,0q�6M   .+�5F      �� $��NoWrap=�6?   #��[ 6U   ��6(   �� *Title+6U   �� 5G      $��NoWrap=�6B   #��[ 6X   ��6(   �� *
Subtitle+6X   �� 5H      $��60��6E   ��6(   �� *Description+6E   5I      5J      5K      5M      5O      5P      