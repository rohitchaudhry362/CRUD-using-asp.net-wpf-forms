   M S B A M L   `   `   `  ����D  @MultiForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MultiForm	MultiForm  5   	       MultiForm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MultiForm     5   	     � Title$  Employee Information��5   	   $	��350��6&   $	��600��63    � 
ResizeMode$ CanMinimize=�6?   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��8* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $
��Name��6$   $��DemiBold"�63   $��Center=�6I   �� 5      $��1��6   $��Position��6$   $��DemiBold"�67   $��Center=�6M   �� 5      $��2��6   $��Hourly Pay Rate��6$   $��DemiBold"�6>   $��Center=�6T   5      �� 5   
   $��1��6   $��10q�6   $��Stretch=�5      
������ ��5   +   �� *	Employees+ �� SelectedItem 6M   �� *SelectedEmployee+��5      �� 5       .R�5!      �  5"      �� 5#      $��* �6/   6;   �� 5$      $��* �6/   6;   �� 5%      $��* �6/   6;   .+�5'      �� $��0��6    $��DemiBold"�6I   $��0 0 0 1q�5(       
���   �$��Center=�6N   ��5'   0   �� *name+5(   N   �� 5)      $��1��6    $��DemiBold"�6M   $��0 0 0 1q�5*       
���   �$��Center=�6N   ��5)   0   �� *
position+5*   N   �� 5+      $��2��6    $��DemiBold"�6T   $��0 0 0 1q�5,       
���   �$��Center=�6N   ��5+   0   �� *hourly_pay_rate+5,   N   5-      5.      50      �� 53   
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�55      �� -   5        $��Insert��55   ?   $��Insert��6   $
��70 5q�6&   $��50��64   
���   �$��2q�56   )   $��DemiBold"�6=   �� 58      -   5        $��Update��58   ?   $��Update��6   $
��70 5q�6&   $��50��64   
���   �$��2q�59   )   $��DemiBold"�6=   �� 5;      -   5        $��Delete��5;   ?   $��Delete��6   $
��70 5q�6&   $��50��64   
���   �$��2q�5<   )   $��DemiBold"�6=   5=      5>      5?      