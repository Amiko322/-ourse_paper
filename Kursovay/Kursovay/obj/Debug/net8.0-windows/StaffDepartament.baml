   M S B A M L   `   `   `  ����C  ?Kursovay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KursovayKursovay  5   	       Kursovay.StaffDepartament   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Kursovay     5   	     � Title$7  1Пользователь: Отдел кадров��5   	   $	��560��6,   $	��800��69   .��5	      � .+�5
   
   �� .@�5      �� $��Сотрудники��6   .��5      � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridStaff��5         AutoGenerateColumns$ False��5         CanUserResizeColumns$ False��5         CanUserReorderColumns$ False��5         CanUserResizeRows$ False��5      $��	0,0,0,240q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True��5   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   	   Header$#	 Табельный номер��6B   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   1   �� *Id+5   B     5      $
 True��5   %   $ * 67   $	 Фамилия��6A   
 5   1   �� *	Surname+5   A     5      $
 True��5   %   $ * 67   $	 Имя��6A   
 5   1   �� *Name+5   A     5      $
 True��5   %   $ * 67   $	 Отчество��6A   
 5   1   �� *
Patronymic+5   A     5      $
 True��5   %   $ * 67   $	 Должность��6A   
 5   1   �� *Post+5   A     5      $
 True��5    %   $ * 68   $	 Зарплата��6B   
 5   1   �� *Salary+5    B   5#      �� 5$      $��
10,170,0,0q�6!   .+�5&      ��  �� Orientation$ 
Horizontal=�6%   $��	5,115,0,0q�6>   .+�5'      �� $��	0,0,111,0q�6(   $��Фамилия:��6;   �� 5(      $��100,0,111,0q�6(   $��Должность:��6=   5)      �� 5+      $ 
Horizontal=�6%   $��5,0,0,2q�6>   .+�5,      �� -   5         ��Name$ Surname��5-      $	��160��6+   ��5,   &   ��  �� ElementName$ DataGridStaff�� �� Path$ SelectedItem.Surname� �� Mode$ OneWay=�5-   7   �� 5.      -   5         ��Name$
 Post��5/      $	��160��5.   '   $��	102,0,0,0q�5/   (   $��18��6;    �� Text 5.   3   �� $ DataGridStaff��$ SelectedItem.Post�$ OneWay=�.@�50   "   �� $��Работник��6/   �� 51   "   $��Инструктор��6/   �� 52   "   $��Менеджер��6/   �� 53   "   $��Ассистент��6/   54      55      �� 57      $ 
Horizontal=�6%   $��5,12,0,2q�6>   .+�58      �� $��
0,0,46.5,0q�6(   $��Имя:��6<   59      �� 5;      $ 
Horizontal=�6%   $��5,0,0,2q�6>   .+�5<      �� -   5        $ 	StaffName��5=      $	��160��6-   ��5<   &   �� $ DataGridStaff��$ SelectedItem.Name�$ OneWay=�5=   9   5>      �� 5@      $ 
Horizontal=�6%   $��5,12,0,2q�6>   .+�5A      �� $��	0,0,106,0q�6(   $��Отчество:��6;   5B      �� 5D      $ 
Horizontal=�6%   $��5,0,0,2q�6>   .+�5E      �� -   5        $ 
Patronymic��5F      $	��160��6.   ��5E   &   �� $ DataGridStaff��$ SelectedItem.Patronymic�$ OneWay=�5F   :   5G      �� 5H      $ 
Horizontal=�6%   $��5,25,0,0q�6>   .+�5I      �� -   5        $��70��5I   %   $��30��60   $��	250,0,0,0q�6<   $��Добавить��6O   6b   �� 5J      -   5        $��70��5J   %   $��50,0,0,0q�60   $��Изменить��6C   6V   �� 5K      -   5        $��70��5K   %   $��50,0,0,0q�60   $��Удалить��6C   6U   5L      5M      5N      5O      5P      5Q      5R      