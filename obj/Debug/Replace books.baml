   M S B A M L   `   `   `  ����B  >testing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:testingtesting  5   	       testing.Replace_books   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:testing     5   	     � Title$  Replace_books��5   	   $	��450��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68   .��5	      � 
�������.+�5
   
   � $��50q�6   
������� � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6#   �� 5       � RowDefinitions 5      �� 5      $��50 �6    �� 5      �� 5      $��50 �6    .+�5      �� -   5         ��Name$ List1��5      $��1��6&   $��0��63   $��
30,10,30,0q�6C   $��Center=�6W   $	��199��6t   {�.  $	��Top=�6�   $	��236��6�    �� SelectedIndex$ 1��6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   
���   � �� View 5      �� 5      .P�5      �� 5      5      �� 5      -   5        $ List2��5      $��1��6&   $��2��63   $��
30,10,30,0q�6C   $��Center=�6W   $	��199��6t   {�.  $	��Top=�6�   $	��236��6�   
���   � 5      �� 5      .P�5      �� 5       5"      �� 5#      -   5         ��Name$ btStart��5#   2   $��2��6   $��0��6"   $��Start��6C   $��30��6S   $	��200��6_   $
��10,0q�6k   $��16(�6�   
���   �6�   �� 5$      -   5        $ btFinish��5$   2   $��2��6   $��2��6"   $��Finish��6D   $��30��6U   $	��200��6a   $
��10,0q�6m   $��16(�6�   {�.  
���   �6�   �� 5%      	 �� Orientation$	 Vertical=�6   $��1��60   $��1��6=   $��Center=�6M   .+�5&      �� -   5        $ btPlace��5&      $��Place��6+   $��30��6;   $��80��6G   $��16(�6h   {�.  
���   �$��0,0,0,40q�6�   �� 5'      -   5        $ btRemove��5'      $��Remove��6,   $��30��6=   $��80��6I   $��16(�6k   {�.  
���   �6�   5(      �� 5)      -   5        $��
theWelcome��5)   5   $��0��6   $��3��6!   $��Welcome��6G   $��30��6Y   $��Center=�6e   5+      5-      5.      