   M S B A M L   `   `   `  ����@  <WPF10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF10.View
WPF10.View  5      'clr-namespace:WPF10.View
WPF10.View  5      1clr-namespace:WPF10.ViewModelWPF10.ViewModel  5          WPF10.View.BasicStopwatch   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPF10.View     5      )viewclr-namespace:WPF10.View     5      3	viewmodelclr-namespace:WPF10.ViewModel     5        � 	Resources  5      (  "WPF10.ViewModel.StopwatchViewModel   	viewModel/  )WPF10.ViewModel.TimeNumberFormatConverter  timeNumberFormatConverter)  #WPF10.ViewModel.BooleanNotConverter  notConverter0  *WPF10.ViewModel.BooleanVisibilityConverter  visibilityConverter  StandardBtnTemplate �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty	 W� To g� Duration	 W� From
 g� AutoReverse g� RepeatBehavior ��Name �� CornerRadius��%)  &	        &	      &	 &     &	 9     &	 L       5   
   6:     5   
   6Q     5   
   6>     5   
   6L   �� 5   
   " ��66   .R�5      �  5        5      CommonStates��. 5        
Normal��. 5      �� .��5   "   W� $ BackgroundBorder��5   %   $ Opacity�5   %   $ 1X�5   %   $ 0:0:0.5D�5   %   5      5        5      Disabled��. 5       �� .��5!   "   W� $ BackgroundBorder��5"   %   $ Opacity�5#   %   $	 0.5X�5$   %   $ 0:0:0.5D�5%   %   5&      5'        5(      Focused��. 5)      �� .��5*   "   W� $ BackgroundBorder��5+   %   $ Opacity�5,   %   $	 0X�5-   %   $ 1X�5.   %   $ 0:0:0.5D�5/   %   
 . $ Forever��51   %   52      53      54      .+�57      �� $ BackgroundBorder��6   $��65��63   $��65��6>   
������ 
���   �$��10q�5:      $��2q�5;      $	 100��5<      �� 5=      #��z��6   $��13(�6=   $
��Bold"�6K   
���   �$��Center=�6p   $��Center=�5>      5?      5@      5D      .��5G      �  � DataContext# [  6   .+�5I   
   �� .+�5J      �� �� 5K      .�6   Zmierzony czas:6(    �� 5L      �6   �� *Hours+ �� 	Converter# [  �� 5M      .�6   :6    �� 5N      �6   �� *	Minutes+# [  �� 5O      .�6   :6    �� 5P      �6   �� *	Seconds+# [ 5Q      �� 5S      �� 5T      .�6   Czas okrążenia:6(    �� 5U      �6   �� *
LapHours+# [  �� 5V      .�6   :6    �� 5W      �6   �� *
LapMinutes+# [  �� 5X      .�6   :6    �� 5Y      �6   �� *	Seconds+# [ 5Z      �� 5\       �� Orientation$ 
Horizontal=�6   .+�5]      �� -   5         ��Name$
 btn1��5]      #��[ 6'   $��Start��6�   {�6W   �� *	Running+# [ 6�   �� 5`      -   5        #��[ 5`   7   {�6   �� *	Running+.��6�   Stop6�   �� 5a      -   5        #��[ 5a      .��6c   Zeruj6j   �� 5b      -   5        #��[ 5b      {�6I   �� *	Running+.��6   Okrążenie6�   5c      �� 5d      $��Stoper działa��6   y�6-   �� *	Running+# [ 5e      5g      5h      