   M S B A M L   `   `   `  ����E  ACafeWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CafeWpfApp
CafeWpfApp  5   	       CafeWpfApp.WaiterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CafeWpfApp     5   	     � Title$  Официант��5   	   $	��450��6   $	��847��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5        $��	LogOutBtn��5      $��
Выйти��5      $	��100��5      $��10q�5      $
��Left=�5      �� 5   
   -   5        $��BackBtn��5      $��
Назад��5      $	��100��5      $��115,10,0,10q�5      $
��Left=�5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      .+�5       &   System.Windows.Controls.DataGrid  -   5        $��OrdersDGrid��5$      $��1��5       $��10q�5!         AutoGenerateColumns$ False��5"         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5#         CanUserAddRows$ False��5%         
IsReadOnly$
 True��5&         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Создал��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *User.LastName+  5*      $!	 Время создания��6)   
 6A   �� *
DateCreate+ �� StringFormat$ {0:HH:mm:ss dd MMMM yyyy}��  5+      $	 Статус заказа��6)   
 6@   �� *StatusOrder.Title+  5,      $	 Столик��6)   
 69   �� *Table.Number+  5-      $	 Кол-во персон��6)   
 6@   �� *
CountGuest+  5.      $	 Оплата��6)   
 69   �� *PaymentMethod.Title+50      �� 52      .+�53      �� -   5        $��AddOrderBtn��56      $!��Добавить заказ��53      $��10q�54      $��30��55      57      �� 58      -   5        $��EditOrderBtn��5;      $!��Изменить заказ��58      $��10q�59      $��30��5:      5<      5=      5>      5?      5@      