   M S B A M L   `   `   `  ����L  HRegistration form, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Registration_formRegistration_form  5   	   "    Registration_form.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Registration_form     5   	     � Title$  
MainWindow��5   	   $	��370��6   $	��525��6)   .��5	      � .+�5
   
   � $��	12,0,12,0q�6    � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    �� 5      $	��10* �6    .+�5      �� -   5         ��Name$ formName��5      $��0��6*   $��Center=�67   $	��Top=�6U   $��Registration Form��6m   $��25(�6�   � 5      $��
12,0,12,12q�6   $��2��6'    5      �� 5      $	��14* �6$   �� 5      $��2* �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��2* �6'   .+�5      �� $��0��6   $��0��6)   $��Right=�69   $	��Top=�6V   $��
First name��6n   $��
12,5,12,12q�6�   $��15(�6�   �� 5      -   5        $ lastName��5      $��0��6.   $��0��6;   $��Right=�6K   $	��Top=�6h   $��	Last name��6�   $��12,27,12,12q�6�   $��15(�6�   �� 5      -   5        $ 	birthDate��5      $��0��6/   $��0��6<   $��Right=�6L   $	��Top=�6i   $��
Birth date��6�   $��12,49,12,12q�6�   $��15(�6�   �� 5      -   5        $ Gender��5      $��0��6,   $��0��69   $��Right=�6I   $	��Top=�6f   $��Gender��6~   $��12,71,12,12q�6�   $��15(�6�   �� 5      -   5        $ Email��5      $��0��6+   $��0��68   $��Right=�6H   $	��Top=�6e   $��Email��6}   $��12,93,12,12q�6�   $��15(�6�   �� 5      -   5        $ phoneNumber��5      $��0��61   $��0��6>   $��Right=�6N   $	��Top=�6k   $��Phone number��6�   $��12,115,12,12q�6�   $��15(�6�   �� 5       -   5        $
 info��5       $��0��6*   $��0��67   $��Right=�6G   $	��Top=�6d   $��Additional info��6|   $��12,137,12,12q�6�   $��15(�6�   �� 5!      -   5         ��Name$ firstNameText��5!      $��0��61   $��1��6>   $
��Left=�6N   $	��Top=�6i   $	��220��6�   $��
12,5,12,12q�6�   $��15(�6�   �� 5"      -	   5        $ lastNameText��5"      $��0��60   $��1��6=   $
��Left=�6M   $	��Top=�6h   $	��220��6�   $��12,27,12,12q�6�   $��15(�6�   �� 5#      -
   5        $	 Day��5#      $��0��6)   $��1��66   $
��Left=�6F   $	��Top=�6b   $	��Day��6z   $��12,49,12,12q�6�   $��15(�6�   �� 5$      -   5        $ dayText��5$      $��0��6+   $��1��68   $
��Left=�6H   $	��Top=�6c   $��25��6{   $��40,49,12,12q�6�   $��15(�6�   �� 5%      -   5        $ Month��5%      $��0��6+   $��1��68   $
��Left=�6H   $	��Top=�6d   $��Month��6|   $��80,49,12,12q�6�   $��15(�6�   �� 5&      -   5        $ 	monthText��5&      $��0��6-   $��1��6:   $
��Left=�6J   $	��Top=�6e   $��25��6}   $��125,49,12,12q�6�   $��15(�6�   �� 5'      -   5        $
 Year��5'      $��0��6*   $��1��67   $
��Left=�6G   $	��Top=�6c   $
��Year��6{   $��170,49,12,12q�6�   $��15(�6�   �� 5(      -   5        $ yearText��5(      $��0��6,   $��1��69   $
��Left=�6I   $	��Top=�6d   $��75��6|   $��200,49,12,12q�6�   $��15(�6�   	� 5)      -   5         	�Name$ genderm��5)       	� 	GroupName$ 	genderbox��6/   $��0��6E   $��1��6R   $
��Left=�6b   $	��Top=�6}   $��75��6�   $��12,71,12,12q�6�   $
��Male��6�    d� 	IsChecked$
 TrueY�6�   $��15(�6�   	� 5*      -   5        $ genderf��5*      $ 	genderbox��6/   $��0��6E   $��1��6R   $
��Left=�6b   $	��Top=�6}   $��75��6�   $��125,71,12,12q�6�   $��Female��6�   $��15(�6�   �� 5+      -   5        $ 	emailText��5+      $��0��6-   $��1��6:   $
��Left=�6J   $	��Top=�6e   $	��220��6}   $��12,93,12,12q�6�   $��15(�6�   �� 5,      -   5        $ phoneNumberText��5,      $��0��63   $��1��6@   $
��Left=�6P   $	��Top=�6k   $	��220��6�   $��12,115,12,12q�6�   $��15(�6�   �� 5-      -   5        $ infoText��5-      $��0��6,   $��1��69   $
��Left=�6I   $	��Top=�6d   $��66��6|   $	��220��6�   $��12,137,12,12q�6�   $��15(�6�   �� 5.      -   5         ��Name$ registration��5.      $��1��6/   $��1��6<   $
��Left=�6L   $��Center=�6g   $��Sign up��6�   $��18(�6�   $	��100��6�   5/      50      51      52      