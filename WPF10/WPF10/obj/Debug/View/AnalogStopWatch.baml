   M S B A M L   `   `   `  ����@  <WPF10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF10.View
WPF10.View  5      1clr-namespace:WPF10.ViewModelWPF10.ViewModel  5           WPF10.View.AnalogStopWatch   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPF10.View     5      3	viewmodelclr-namespace:WPF10.ViewModel     5        � 	Resources  5      (  "WPF10.ViewModel.StopwatchViewModel   	viewModel)  #WPF10.ViewModel.BooleanNotConverter  notConverter$  WPF10.ViewModel.AngleConverter  angleConverter  StandardBtnTemplate �� 
TargetType'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty	 W� To g� Duration	 W� From
 g� AutoReverse g� RepeatBehavior ��Name �� CornerRadius��%  &	        &	      &	 &     &	 9       5   
   6'     5   
   6(     5   
   6#   �� 5   
   " ��66   .R�5      �  5        5      CommonStates��. 5        
Normal��. 5      �� .��5   "   W� $ BackgroundBorder��5   %   $ Opacity�5   %   $ 1X�5   %   $ 0:0:0.5D�5   %   5      5        5      Disabled��. 5       �� .��5!   "   W� $ BackgroundBorder��5"   %   $ Opacity�5#   %   $	 0.5X�5$   %   $ 0:0:0.5D�5%   %   5&      5'        5(      Focused��. 5)      �� .��5*   "   W� $ BackgroundBorder��5+   %   $ Opacity�5,   %   $	 0X�5-   %   $ 1X�5.   %   $ 0:0:0.5D�5/   %   
 . $ Forever��51   %   52      53      54      .+�57      �� $ BackgroundBorder��6   $��65��63   $��65��6>   
������ 
���   �$��10q�5:      $��2q�5;      $	 100��5<      �� 5=      #��z��6   $��13(�6=   $
��Bold"�6K   
���   �$��Center=�6p   $��Center=�5>      5?      5@      5A      .��5D      � -   5         �Name$ baseGrid��5D       � DataContext# [  6    � ColumnDefinitions 5E   
   �� 5F      $	��400 �6   .+�5I   
   A� $	��300��6   $	��300��6   
���   �$��2��6:   ��5J      �� 5K       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 5L      �� 5M       �� CenterX$	 0.5Q�6*    �� CenterY$	 0.5Q�68    �� Angle$ 45Q�6F   .��5P      �  � Color$ 	#FFB03F3F��6#   � 5Q      $ 	#FFE4CECE��6#    � Offset$ 1Q�65   5R      5T      �� 5W   
    J� RenderTransformOrigin$ 0.5,0.5&�6   $��2��64   $	��150��6>   
���   �z�5X      V� 5Y      .~�5Z      T�  T� Y$	 -60Q�6)   �� 5[       6&   �� *	Seconds+ �� 	Converter# [  �� ConverterParameter$ Seconds��5\      5^      �� 5a   
   $ 0.5,0.5&�6   $��4��64   $	��100��6>   
���   �z�5b      V� 5c      .~�5d      T� $	 -50Q�6)   �� 5e       6&   �� *	Minutes+# [ $ Minutes��5f      5h      �� 5j   
   $ 0.5,0.5&�6   $��1��64   $	��150��6>   
��� ���z�5k      V� 5l      .~�5m      T� $	 -60Q�6)   �� 5n       6&   �� *
LapSeconds+# [ $ Seconds��5o      5q      �� 5s   
   $ 0.5,0.5&�6   $��2��64   $	��100��6>   
��� ���z�5t      V� 5u      .~�5v      T� $	 -50Q�6)   �� 5w       6&   �� *
LapMinutes+# [ $ Minutes��5x      5z      A� 5|   
   $��10��6   $��10��6   
���   �6)   �� 5~   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   .+�5      �� -   5         ��Name$
 btn1��5      #��[ 6#   $��Start��6�   {�6S   �� *	Running+# [ 6�   �� 5�      -   5        #��[ 5�   3   {�6   �� *	Running+.��6|   Stop6�   �� 5�      -   5        #��[ 5�      .��6_   Zeruj6f   �� 5�      -   5        #��[ 5�      {�6E   �� *	Running+.��6{   Okrążenie6�   5�      5�      5�      