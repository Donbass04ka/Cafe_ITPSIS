   M S B A M L   `   `   `  ����E  ACafeWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CafeWpfApp
CafeWpfApp  5   	       CafeWpfApp.AdminWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CafeWpfApp     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5        $��	LogOutBtn��5      $��
Выйти��5      $	��100��5      $��10q�5      $
��Left=�5      �� 5   
   -   5        $��CreateOrderBtn��5      $!��Открыть заказы��5      $	��125��5      $��115,10,0,10q�5      $
��Left=�5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   �� 5      .+�5       &   System.Windows.Controls.DataGrid  -   5        $��
UsersDGrid��5$      $��1��5       $��10q�5!         AutoGenerateColumns$ False��5"         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5#         CanUserAddRows$ False��5%         
IsReadOnly$
 True��5&      ��5'   B   �� *Users+   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� *	FirstName+  5*      $ Отчество��6)   	 6;   �� *
SecondName+  5+      $ Фамилия��6)   	 6:   �� *
LastName+  5,      $ 
Логин��6)   	 68   �� *Login+  5-      $ Должность��6)   	 6<   �� *
Role.Title+  5.      $ Статус��6)   -   5        
Status��	 5.   9   �� *
Post.Title+6X   50      �� 52      .+�53      �� -   5        $��
AddUserBtn��56      $/��)Добавить пользователя��53      $��10q�54      $��30��55      57      �� 58      -   5        $��EditUserBtn��5;      $/��)Изменить пользователя��58      $��10q�59      $��30��5:      5<      �� 5=      -   5        $��DeletUserBtn��5@      $-��'Удалить пользователя��5=      $��10q�5>      $��30��5?      5A      5B      5C      5D      5E      