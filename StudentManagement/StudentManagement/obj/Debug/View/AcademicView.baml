   M S B A M L   `   `   `  ����L  HStudentManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:StudentManagement.ViewStudentManagement.View  5      I)clr-namespace:StudentManagement.ViewModelStudentManagement.ViewModel  5      )    #StudentManagement.View.AcademicView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:StudentManagement.View     5      ?	ViewModel)clr-namespace:StudentManagement.ViewModel     5      U QMahApps.Metro, Version=1.4.0.42, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f8Metro,http://metro.mahapps.com/winfx/xaml/controls  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	        � 	Resources  5      3   -StudentManagement.ViewModel.AcademicViewModel   key1��%!   &	          5   
   5      5      .��5      � .+�5   
   � ��5      �� 5       �� ImageSource$/ )/Resources/Backgrounds/MainBackground.png��5      5      5      �� 5   
   $
��Auto=�6   $
��Auto=�6I   .��5      �  � RowDefinitions 5      �� 5       $
��Auto �6$   64   �� 5!      $��* �6$   61   �� 5"      $��* �6$   61    � ColumnDefinitions 5&      �� 5'      $
��0.5* �6'   66   �� 5(      $
��Auto �6'   66   �� 5)      $��0.15* �6'   67   �� 5*      $
��Auto �6'   66   �� 5+      $
��0.5* �6'   66   .+�5.      ��  �� Orientation$ 
Horizontal=�6   $��0��66   $��1��6C   .+�5/      �� $��	0,30,0,30q�6   
��� � �$��2q�51      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Choose Module��52      .@�53      �� $��Module 1��6'   55      �� 56      $��Module 2��6'   58      �� 59      $��Summer Module��6'   5;      5<      �� 5>      $��20,30,30,30q�5?      
��� � �$��2q�5A      $ Choose Year��5B      .@�5C      �� $��Year 1��6'   5E      �� 5F      $��Year 2��6'   5H      �� 5I      $��Year 3��6'   5K      �� 5M      $��Year 4��6'   5O      5P      5S      �� 5T      -   5        $��grbAcademic��5T   &   $��0q�6   $
��Mark��69   $��1��6G   $��1��6T    � DataContext# [  6d   .��5U      &   System.Windows.Controls.DataGrid  -   5        $��dtgAcademic��5U   1      
IsReadOnly .   AzureDataGrid#���  5V         AutoGenerateColumns .  $	��765��5W   V   ��6   �� *AcademicList+	   Columns	 5X      0  *System.Windows.Controls.DataGridTextColumn  5Y      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly
 .    Header$ Subject ��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *DisciplineID+5[        5]      
 . $ Process Mark ��6C   $	 150 6Z    6f   �� *ProcessMark+5_        5a      
 . $ Midterm Mark ��6C   $	 150 6Z    6f   �� *MidtermMark+5c        5e      
 . $ Finalterm Mark ��6C   $	 150 6\    6h   �� *FinaltermMark+5g        5i      
 . $ Average ��6C   $	 150 6U    6a   �� *AvarageMark+5k      .  (System.Windows.Interactivity.Interaction   Triggers 5n      /	  )System.Windows.Interactivity.EventTrigger	  5o       	  	EventName$ SelectionChanged��6-   .
  (System.Windows.Interactivity.TriggerBase 
  Actions. 5p   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *DetailCommand+   CommandParameter 6Z   ��  �� ElementName$ dtgAcademic��5q      5s      5t      �� 5v      $��0q�6   # [  6&   $��Subject Detail��6J   $��3��6c   $��1��6s   .��5x      �� -   5        $��	lstDetail��5x   D   $	��275��6U   ��6   �� *SubjectDetail+��5y      �� 5z      .R�5{   "   �� $ Vertical=�6-   .+�5|   &   �� $ 
Horizontal=�61   .+�5}   *   �� $
��Bold"�64   $��5q�6F   $��Teacher:��6Q   $	��120��6a   6o   �� 5~   *   $��5q�64   $	��120��6?   ��6K   �� *TeacherName+6k   5   '   �� 5�   &   $ 
Horizontal=�61   .+�5�   *   �� $
��Bold"�64   $��5q�6F   $��Department:��6Q   $	��120��6d   6r   �� 5�   *   $��5q�64   $	��120��6?   ��6K   �� *DepartmentName+6m   5�   '   �� 5�   &   $ 
Horizontal=�61   .+�5�   *   �� $
��Bold"�64   $��5q�6F   $��School:��6Q   $	��120��6`   6n   �� 5�   *   $��5q�64   $	��120��6[   ��6?   �� *
SchoolName+6i   5�   '   5�   #   5�      5�      5�      �� 5�      $��2��6   $��1��6*   $ 
Horizontal=�6:   $��Right=�6S   .+�5�      �� $
��Bold"�6    $��	Average: ��62   6E   �� 5�      -   5        $��lblSum��5�       $��This Sum��6.   6@   5�      5�      5�      5�      5�      