   M S B A M L   `   `   `  ���� C  ?Kursovay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KursovayKursovay      Kursovay.StaffDepartament   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Kursovay       � Title$7  1Пользователь: Отдел кадров��$	��560��$	��800��.��� .+��� .@��� $��Сотрудники��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ DataGridStaff��   AutoGenerateColumns$ False��   CanUserResizeColumns$ False��   CanUserReorderColumns$ False��   CanUserResizeRows$ False��$��	0,0,0,240q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 	   Header$#	 Табельный номер��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Id+  $
 True��$ * $	 Фамилия��
 �� *	Surname+  $
 True��$ * $	 Имя��
 �� *Name+  $
 True��$ * $	 Отчество��
 �� *
Patronymic+  $
 True��$ * $	 Должность��
 �� *Post+  $
 True��$ * $	 Зарплата��
 �� *Salary+�� $��
10,170,0,0q�.+���  �� Orientation$ 
Horizontal=�$��	5,115,0,0q�.+��� $��	0,0,111,0q�$��Фамилия:���� $��100,0,111,0q�$��Должность:���� $ 
Horizontal=�$��5,0,0,2q�.+��� -    ��Name$ Surname��$	��160������  �� ElementName$ DataGridStaff�� �� Path$ SelectedItem.Surname� �� Mode$ OneWay=��� -    ��Name$
 Post��$	��160��$��	102,0,0,0q�$��18�� �� Text �� $ DataGridStaff��$ SelectedItem.Post�$ OneWay=�.@��� $��Работник���� $��Инструктор���� $��Менеджер���� $��Ассистент���� $ 
Horizontal=�$��5,12,0,2q�.+��� $��
0,0,46.5,0q�$��Имя:���� $ 
Horizontal=�$��5,0,0,2q�.+��� -   $ 	StaffName��$	��160������ $ DataGridStaff��$ SelectedItem.Name�$ OneWay=��� $ 
Horizontal=�$��5,12,0,2q�.+��� $��	0,0,106,0q�$��Отчество:���� $ 
Horizontal=�$��5,0,0,2q�.+��� -   $ 
Patronymic��$	��160������ $ DataGridStaff��$ SelectedItem.Patronymic�$ OneWay=��� $ 
Horizontal=�$��5,25,0,0q�.+��� -   $��70��$��30��$��	250,0,0,0q�$��Добавить���� -   $��70��$��50,0,0,0q�$��Изменить���� -   $��70��$��50,0,0,0q�$��Удалить��