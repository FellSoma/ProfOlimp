   M S B A M L   `   `   `  ����  	ProfOlimp    ProfOlimp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��400��5   	   $	��350��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5
       �� 
TargetType   	Textboxes �� Property �� Value �� 
TargetType	 �Name
 J� SnapsToDevicePixels ��Name ��Name��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ 	0,10,0,30q�6'   �� 5       � ��$ 18(�6)   �� 5       � ��$ 0q�60   �� 5       � ��
 �����6+   �� 5       � ��$ Center=�62   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � $
	 root��6   #��z��5      #��z��5   %   
 . .+�5      �� $ 
background��6%   
�������#��z��5   %   #��z��5   %   �� 5       
���   �$��1��68   $��Bottom=�6C   �� 5"      $ PART_ContentHost��6+   $��1q�5#   +   
������ #��z��5%   +   ��.  $��0,9,0,6q�5'   +   $��18(�5(   +   #��z��5)   +   5*      5+      5-      5.      5/      .��50      �� $��2q�6   
�������._�53      � .+�54   
   ��  �� Orientation$ Vertical=�6   .+�56      �� $��Авторизация��57      $��Center=�58      $��0,20,0,0q�59      $��19(�5:      $��Medium"�5;      �� 5=      $��
Логин��5>      $��	20,20,0,0q�5?      $��19(�5@      $��Medium"�5A      �� 5B      -   5        $��LoginTb��5C      $	��300��5D      
���   �#��[  5F      �� 5G      $��Пароль��5H      $��	20,10,0,0q�5I      $��19(�5J      $��Medium"�5K      �� 5L      -   5        $��
PasswordTb��5M      $	��300��5N      
���   �#��[  5P      �� 5Q      $��30��5R      $	��200��5S      $��Вход��5T        
BlueBitton#��[ 5U      5V      �� 5W       J� IsHitTestVisible .  $��
Логин��5X      $��Center=�5Y      $��28,110,-8,266q�5Z      $��18(�5[      
���������5^      �� 5_      " ��6    .�5`      ��  � y�$ 	Collapsed=�6;    �� Triggers 5a      �� 5b       �� Binding 6*   �� *Text+ �� ElementName$ LoginTb�� �� Value  6X   .a�5c   &   ��  � y�$ Visible=�6C   5d   #   5f      5h      �� 5j       .  $��Пароль��5l      $��Center=�5m      $��28,225,-8,151q�5n      $��18(�5o      
���������5r      �� 5s      " ��6   .�5t      ��  � y�$ 	Collapsed=�67    5u      �� 5v       6*   �� *Text+$ 
PasswordTb��  6[   .a�5w   "   ��  � y�$ Visible=�6?   5x      5z      5|      5}      5      5�      