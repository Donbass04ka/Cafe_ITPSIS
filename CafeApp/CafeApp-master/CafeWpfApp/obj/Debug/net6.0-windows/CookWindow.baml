   M S B A M L   `   `   `  ����E  ACafeWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CafeWpfApp
CafeWpfApp  5   	       CafeWpfApp.CookWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CafeWpfApp     5   	     � Title$  
Повар��5   	   $	��450��6   $	��600��6$    � WindowStartupLocation$ CenterScreen=�60   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5        $��	LogOutBtn��5      $��
Выйти��5      $	��100��5      $
��Left=�5      $��10q�5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��OrdersDGrid��5         AutoGenerateColumns$ False��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         CanUserAddRows$ False��5      $��1��5      $��10q�5         
IsReadOnly$
 True��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Создал��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *
User.Login+  5      $! Время создания��6%   	 6=   �� *
DateCreate+  5       $ Статус заказа��6%   	 6<   �� *StatusOrder.Title+5"      5#      5$      