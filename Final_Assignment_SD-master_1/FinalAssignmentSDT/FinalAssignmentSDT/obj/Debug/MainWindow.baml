   M S B A M L   `   `   `  ����M  IFinalAssignmentSDT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalAssignmentSDTFinalAssignmentSDT  5   	   #    FinalAssignmentSDT.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalAssignmentSDT     5   	   Jlocal19http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	     � Title$  
MainWindow��5	   	   $��729.5��6   $
��1300��6+    � WindowStartupLocation$ Manual=�68    � 
ResizeMode$ CanMinimize=�6W    � 	Resources 5
      $   FinalAssignmentSDT.MyConverter   MyConverter��%   &	          5   
   6   5      ��5      
� 5   
   .��5      �  � Color$ 	#FFA5E6BC��6   � 5      $ 	#FFF5F2F2��6    � Offset$ 1Q�6-   5      .��5      � $��	33,0,0,-3q�6   ���	#FFF5F2F2 � RowDefinitions 5   
   �� 5      $	��12* �6   �� 5      $	��17* �6   �� 5      $
��675* �6    � ColumnDefinitions 5   
   �� 5      $
��408* �6   �� 5      $
��158* �6   �� 5      $
��695* �6   .+�5   
   �� -   5         ��Name$ lbTitle��5      $��Appointment Details��6!   $
��Left=�6?   $��	183,0,0,0q�6Z   $	��Top=�6m   $��18(�6�   $
��Bold"�6�   $��34��6�   $	��192��6�   $��3��6�   �� 5   
   -   5        $ lblConsultancyType��5      $��Customer Type��6,   $
��Left=�6D   $��
10,162,0,0q�6_   $	��Top=�6s   	 J� RenderTransformOrigin$	 0.518,3.126&�6�   $��25��6�   $	��120��6�   $��2��6�   �� 5    
   -   5        $ lblDepartment��5       $��
Department��6'   $
��Left=�6<   $��
10,363,0,0q�6W   $	��Top=�6k   $	 0.518,3.126&�6�   $��25��6�   $	��120��6�   $��2��6�   �� 5!   
   -   5        $ lblTime��5!      $��	Time Slot��6!   $
��Left=�65   $��
10,107,0,0q�6P   $	��Top=�6d   $��26��6|   $��36��6�   $��2��6�   �� 5"   
   -   5        $ lblDay��5"      $	��Day��6    $
��Left=�6.   $��	10,54,0,0q�6I   $	��Top=�6\   $��26��6t   $��36��6�   $��2��6�   �� 5#   
   -   5        $ lblPhone��5#      $��Phone Number��6"   $
��Left=�69   $��
10,505,0,0q�6T   $	��Top=�6h   $��26��6�   $	��100��6�   $��2��6�   �� 5$   
   -   5        $ lblCustomerName��5$      $��Customer Name��6)   $
��Left=�6A   $��
10,456,0,0q�6\   $	��Top=�6p   $��26��6�   $	��100��6�   $��2��6�   �� 5%   
   -   5        $ lblCustomerType��5%      $��Consultancy Type��6)   $
��Left=�6D   $��
10,243,0,0q�6_   $	��Top=�6s   $	 0.5,3.41&�6�   $��26��6�   $	��120��6�   $��2��6�   �� 5&   
   -	   5        
 ��Name$
 btnSave��5&      $	��Add��6"   $
��Left=�60   $��
57,577,0,0q�6K   $	��Top=�6_   $	��100��6w   $��25��6�   $��2��6�   6�   �� 5'   
   -
   5         ��Name$ cbTime��5'      $
��Left=�6G   $��151,103,0,0q�6b   $	��Top=�6w   $	��165��6�   $��22��6�   $��2��6�   ��6#   ��  �� Path$ Slots� �� SelectedItem 5(      �� 5)      $ TempAppointment.Time�6    �� UpdateSourceTrigger$ PropertyChanged=�66    �� ValidationRules 5*      /  )FinalAssignmentSDT.ComboBoxValidationRule  5+      5-      5/      �� 50   
   -   5        $ cbTypeOfClient��50      $
��Left=�6W   $��151,162,0,0q�6r   $	��Top=�6�   $	��165��6�   $��21��6�   $��2��6�   ��6+   �� $ TypesOfClient� 51      �� 52      $$ TempAppointment.TypeOfCustomer�6   $ PropertyChanged=�6@    53        54      56      58      �� 59   
   -   5         ��Name$ MyList��59      $
��Left=�6"   $	��100��6=   $��158,214,0,0q�6J   $	��Top=�5:      $	��158��6*   $��2��6�   ��67   �� $ Services� 5;      �� 5<      $ TempAppointment.Service�6   $ PropertyChanged=�69    5=        5>      5@      5B      �� 5C   
   -   5         ��Name$ tbfield1��5C      $
��Left=�6$   $��23��6?   $��
70,317,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��165��6�   $��2��6�   $��2��6�   $��1��6�   �� 5D   
   -   5        $ tbPhoneNumber��5D      $
��Left=�6)   $��23��6D   $��149,508,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��165��6�   $��2��6�   .��6�   ��5E      �� 5F      $$ TempAppointment.Customer.Phone�6   $ 	LostFocus=�6@    5G      .  (FinalAssignmentSDT.TextBoxValidationRule  5H         Regex$ ^[0-9]{10}$��66      ErrorMessage$) #Please enter 10 digit mobile number��6L      	MinLength$ 9��6   5J      .��5K      5L      �� 5N   
   -   5        $ tbName��5N      $
��Left=�6"   $��23��6=   $��149,456,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��165��6�   $��2��6�   .��6�   ��5O      �� 5P      $( "TempAppointment.Customer.FirstName�6   $ 	LostFocus=�6D    5Q        5R      $ ^[a-zA-Z\s]+$��66   $- 'Please use only  alphabetical chracters��6N   $ 5��6�   5T      .��5U      5V      �� 5W   
   -   5        $ MyListDepartment��5W      $
��Left=�6,   $	��100��6G   $��156,325,0,0q�6T   $	��Top=�5X      $	��158��6*   $��2��6`   ��67   �� $ Departments� 5Y      �� 5Z      $  TempAppointment.Department�6   $ PropertyChanged=�6<    5[        5\      5^      5`      �� 5a   
   -   5        $ 
lbSchedule��5a      $��List of Appointments��6$   $
��Left=�6C   $��	245,0,0,0q�6^   $	��Top=�6q   $��18(�6�   $
��Bold"�6�   $	��257��6�   $��2��6�   $��3��6�   � 5b   
   $��	47,31,0,0q�6   $��2��6"   $��2��66   $��1��6C   .+�5c      �� ���	#FFF5F2F2$��	10,30,0,0q�60   .+�5d      ��  �� Orientation$ 
Horizontal=�6   $��40��66   .+�5e      �� $��Filter��6   $
��Left=�6-   $��	210,9,0,0q�6H   $��82��6[   $	 -1.434,0.621&�6f   �� 5f      -   5        $ cbFilter��5f      $
��Left=�61   $��22��6L   $��20,9,0,9q�6X   $	��132��6j   6�   �� 5g      $��by��6   $��20,9,0,0q�6)   �� 5h      -   5        $ cbFilterValue��5h      $	��133��66   $��40,9,0,9q�6B   $��22��6T   6`   5j      &   System.Windows.Controls.DataGrid  5k      -   5          Name$ datagrid��5k   �      AlternatingRowBackground
 �����$��207,5,256,10q�6n      AutoGenerateColumns .  $
��Auto��6�   $
��Auto��6�   ��6   �� *AppointmentsList+   Columns 5l      0  *System.Windows.Controls.DataGridTextColumn  5m      ,  &System.Windows.Controls.DataGridColumn   Header$
 Time��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5n   %   �� *Time+ �� Mode$ OneWay=�  5o      $
 Date��6-    5p   %   �� *Date+ �� StringFormat$ d��$ OneWay=�   	CellStyle 5q      �� 5r   "     �� 
TargetType*  $System.Windows.Controls.DataGridCell"   6(   .�5s   &   �� ! �� Property! � ��" �� Value" 5t      �� *Date+# �� 	Converter## [  5u   #   5w        5x      $ 
Department��6-    5y   %   �� *
Department+$ OneWay=�  5z      $ TypeOfCustomer��6-    5{   %   �� *TypeOfCustomer+$ OneWay=�  5|      $ Service��6-    5}   %   �� *	Service+$ OneTime=�  5~      $
 Name��6-    5   %   �� *Customer.FirstName+$ OneWay=�5�      �� 5�      $ 
Horizontal=�6   5�      5�      (	  "System.Windows.Controls.DatePicker	  5�   
   -   5        $ 	 Name$$ dpDate��5�      $
��Left=�6&   $��
149,54,0,0q�6A   $��2��6U   $	��Top=�6b   $	��167��6z   % 	  SelectedDate% 5�      �� 5�      $ TempAppointment.Date�6   $ PropertyChanged=�66    5�      '
  !FinalAssignmentSDT.DateValidation
  5�      5�      5�      �� 5�   
   -   5        $
 
btnDisplay��5�      $��Display��6%   $
��Left=�67   $��186,577,0,0q�6R   $	��Top=�6g   $	��100��6   $��25��6�   $��2��6�   6�   �� 5�   
   -   5        $ 
lblHeading��5�      $��Urban Clap Ltd.��6$   $
��Left=�6>   $��	70,-9,0,0q�6Y   $	��Top=�6l   $��25(�6�   $
��Bold"�6�   $	��257��6�   $��1��6�   $��3��6�   $��2��6�   $��39��6�   5�      5�      