   M S B A M L   `   `   `  ����D  @GaugesApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GaugesApp	GaugesApp  5      C&clr-namespace:GaugesApp.CustomControlsGaugesApp.CustomControls  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089*    $GaugesApp.CustomControls.AnalogClock  �� 
TargetType �� Property �� Value �� 
TargetType � 	Resources   Key J� RenderTransformOrigin �� Angle'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� 
TargetName �� TargetProperty	 �� To A�Name �� Color ��Name	 �� X1	 �� X2   BooleanToVisibilityConverter �� 	Converter�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      !localclr-namespace:GaugesApp  5      1custom&clr-namespace:GaugesApp.CustomControls  5      %�  '         7  �� 5      "    6   .�5	   
   ��  � �� 5
      �� 5      "   6"    5      ���� 5       BooleanToVisibilityConverter  67   5      .R�5      � $ 0.5 0.5&�6   z�5      �� 5      $ 90Q�6.    5        5      
TimeStates��. 5   "     Day��.	 5   &   �� .��5   *   �� $
 	ClockFill��69   $ Color�5   9    SkyBlue5   9   �� 5   *   $
 
HourStroke��69   $ Color�5   9    Gold5   9   �� 5   *   $
 MinuteStroke��69   $ Color�5   9    Gold5    9   5!   '   5"   #     5#   "   	Night��.	 5$   &   �� .��5%   *   �� $
 	ClockFill��69   $ Color�5&   9   	 Black5'   9   �� 5(   *   $
 
HourStroke��69   $ Color�5)   9   	 White5*   9   �� 5+   *   $
 MinuteStroke��69   $ Color�5,   9   	 White5-   9   5.   '   5/   #     50   "   	Christmas��.	 51   &   �� .��52   *   �� $
 	ClockFill��69   $ Color�53   9   	 Green54   9   �� 55   *   $
 
HourStroke��69   $ Color�56   9    Red57   9   �� 58   *   $
 MinuteStroke��69   $ Color�59   9    Red5:   9   5;   '   5<   #   5=      .+�5@      A� $ PART_Border��6"   
���   �$��1��6F   $	��210��6Z   $	��210��6f   ��5A      �� 5B   "   	ClockFill��$ White��6E   5D      �� 5F      $ Part_HourHand��6   $��1��66   $ 0��6J   $	 -75��6Q   $��Center=�5G      $��Center=�6:   ��5H      �� 5I   "   
HourStroke��$ Black��6F   5K      �� 5L      $ Part_MinuteHand��6   $��1��68   $ 0��6M   $
 -100��6T   $��Center=�5M      $��Center=�6:   ��5N      �� 5O   "   MinuteStroke��$ Black��6H   5Q      �� 5R      $ Part_SecondHand��6   
���  ��$��1��6E   $��Center=�5S      $��Center=�6:   $ 0��6W   $
 -100��6^   y�5T      �� *ShowSeconds+8   5U      5V      5X      5Y      5Z      