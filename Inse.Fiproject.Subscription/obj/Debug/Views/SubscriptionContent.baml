   M S B A M L   `   `   `  ����M  IInse.Fiproject.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]Aclr-namespace:Inse.Fiproject.Wpf.Mvvm;assembly=Inse.Fiproject.WpfInse.Fiproject.Wpf.Mvvm  5       Inse.Fiproject.Subscription;   5Inse.Fiproject.Subscription.Views.SubscriptionContent   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      RmvvmAclr-namespace:Inse.Fiproject.Wpf.Mvvm;assembly=Inse.Fiproject.Wpf     5      ,   &Inse.Fiproject.Wpf.Mvvm.AttachedBinder    Loaded  5      �� *ViewLoadedHandler+.��5	      �� ._�5
   
   �  � RowDefinitions 5      �� 5      $��60 �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��320 �6#   .+�5      �� $��0��6   $��0��6"    �� Padding$ 10, 0, 0, 0q�62   ._�5      �� $
��Left=�5      $��Center=�5         
Foreground#���   5        HeadTextTwo#��[ 5      ��5      �� *$"SelectedSubscription.Snippet.Title+5      5      �� 5      $��1��6   $��0��6"   $ 10, 0, 10, 0q�62   ._�5      �� $��Hidden=�6   $��Hidden=�6F   ��.  .��5       ��  �� Orientation$ Vertical=�6!   .+�5#      �� $��
0, 0, 0, 5q�6!   ._�5$      �� $��채널 설명��6(   $
��Left=�5%   (   $��Center=�5&   (   #���   5'   (   #��[ 5(   (   5)      �� 5,      $��0, 0, 0, 10q�6!   ._�5-      �� $
��Left=�5.   (   $��Center=�5/   (   $��WrapWithOverflow=�50   (   #���   51   (   ��5-   (   �� **(SelectedSubscription.Snippet.Description+51   (   52      53      54      55      �� 59      $��0��6   $��1��6"     
Background#���  62   $��0, 0, 0, 10q�6\   $ 10q�6q   ._�5:      �� $��사용자 구독 목록��6   $
��Left=�5;      $��Center=�5<      #���   5=      #��[ 5>      5?      �� 5B      $��1��6   $��1��6"   ._�5C      �� ��6   �� *Subscriptions+ �� SelectedItem 6@   �� *SelectedSubscription+ �� Mode$ TwoWay=���5D      �� 5E       �� 
TargetType" ��6*   .R�5F      �� $��Hidden=�6+   $��Visible=�5G   +   ��.  .��5I   "   �� 5J      5K      ��5M      �� 5N      .R�5O      �� $ Vertical=�6)   5P      ��5R      �� 5S       �� 
TargetType" ��6    .�5T      �� 	 �� Property	 � ��
 �� Value
 .  6:   �� 5U      	 �@�FocusVisualStyle
 6A   Z� �� 5V      	 � ��$
 40��67   �� 5W      	 � ��$
 10, 0, 0, 0q�68   �� 5X      	 � ��$
 
0, 0, 5, 0q�67   �� 5Y      	 � ��   ToggleButtonBackgroundNormal#
 �  6;   �� 5Z      	 � ��   ToggleButtonForegroundNormal#
 �  6;   �� 5[      	 � ��$
 0q�6@   �� 5\      	 � ��$
 Stretch=�6D   �� 5]      	 � ��$
 Stretch=�6B   �� 5^      	 � ��$

 Left=�6K   �� 5_      	 � ��$
 Center=�6I   �� 5`      	 � ��
 5a   "   �� 5b   &   " ��66   .R�5c   *   �� #��z��61   #��z��5d   1   #��z��5e   1   #��z��5f   1   #��z��5g   1   #��z��5h   1   ._�5i   .   �� #��z��5j   8   #��z��5k   8   #��z��5l   8   #��z��5m   8   ��5i   8   �� *Snippet.Title+5m   8   5n   +   5o   '   5q       �� Triggers 5s      P� 5t   "    P� Property �@J�IsMouseOver P� Value . . �5u   &   �� 	 � ��  ToggleButtonBackgroundHover#
 �  6C   �� 5v   &   	 � ��  ToggleButtonForegroundHover#
 �  6C   5w   #   P� 5x   "    �@��
IsSelected . . �5y   &   �� 	 � �� ' #ToggleButtonBackgroundCheckedNormal#
 �  6C   �� 5z   &   	 � �� ' #ToggleButtonForegroundCheckedNormal#
 �  6C   5{   #   ]� 5|   "    ]� 
Conditions 5}   &   �� 5~   *    �� Property �@J�IsMouseOver �� Value . 6K   �� 5   *    �@��
IsSelected . 6J   /�5�   &   �� 5�   *   	 � �� &	 "ToggleButtonBackgroundCheckedHover#
 � 	 6G   �� 5�   *   	 � �� &
 "ToggleButtonForegroundCheckedHover#
 � 
 6G   5�   #   5�      5�      5�      5�      5�      5�      