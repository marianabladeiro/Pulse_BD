   M S B A M L   `   `   `  ����@  <Pulse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PulsePulse  5          Pulse.Calendario   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Pulse     5      -   5          N� Title$  
Calendario��5
      .��5      � 
�������.+�5   
   � $��0,-26,0.4,0q�6   $	��280��6$   $	��Top=�61   .+�5      �� ���	#FFB9DCEB$��0��6)    �� RadiusX$
 27.5��6=    �� RadiusY$
 27.5��6L   �� 5      -   5        $��Marlett)�5      $��30(�6)   $��3��67   $
��Left=�6C   $	��Top=�6^   $��	10,40,0,0q�6v   6�   �� 5      $��18(�6   $��Center=�6"   $	��Top=�6?   $��0,40,0,0q�6W   .��6j   Calendário6v   � 5      $	��Top=�6   $��Center=�6+   $��0,85,0,0q�6H   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ CalendarioConsultas��5         CalendarDayButtonStyle 5      �� 5       �� 
TargetType:  4System.Windows.Controls.Primitives.CalendarDayButton"  6    .�5      ��  �� Property � �� �� Value$ 20��67   �� 5       � ��$ 30��66   �� 5       � �� 6;   �� *color+5      5      5      5       � 5!   
   $��Bottom=�6   $	��280��6+   $��0,0,0,60q�68   .+�5#      �� -   5        $��	ListView1��5#   -   $��0,10,0,0q�6   $
��Left=�6>   $	��Top=�6Y   $	��370��6q   $	��345��6}   $	��Top=�5$      $��Visible=�6,   .��5&      �� -   5         ��Name$ ListViewConsultas��5&      ��6:   �� *ListViewConsultas+��5'      �� 5(      .R�5)      �� .+�5+   "   � $��60��6'   
�������$��
20,0,20,10q�6J   .+�5-   &   �� 
���   �$��1q�6A   ._�5.   *   � $��80��6/   $
��Left=�6:   .+�5/   .   �� $
��Left=�6N   $��Center=�6i   $��	10,20,0,0q�6�   ��64   �� *Hora+6�   �� 50   .   ���#F17A7A$��10��6G   $��Right=�6R   51   +   52   '   �� 54   &   $	��Top=�6,   $��Right=�6D   $
��10,5q�6`   ��6n   �� *Data+6�   �� 55   &   $	��Top=�6,   $
��Left=�6D   $��85,5,0,0q�6_   $��Nr consultório:��6q   6�   �� 56   &   $	��Top=�6,   $
��Left=�6D   $��	170,5,0,0q�6_   ��6r   �� *Consultorio+6�   �� 58   &   $��Bottom=�6,   $
��Left=�6G   $��85,0,0,8q�6b   $��Médico:��6t   6�   �� 59   &   $��Bottom=�60   $
��Left=�6K   $��135,0,15,13q�6f   $��NoWrap=�6�   ��6{   �� *Nome+6�   5<   #   5>      5?      5A      5D      5E      � 5G   
   -   5        	 �Name$	 marcacao��5G   I   $��Bottom=�6   $	��280��6*   $��0,0,0,60q�67   $y�Hidden=�6[   
�������.+�5H      �� $
��Left=�6   $	��Top=�6/   $��45,10q�6G   $��14(�6V   .��6d   	Médico/a6n   �� 5I      $��50,40q�6   $	��Top=�6(   $��30��6@   .+�5J      �� -   5        $��	medicList��5J      ��5K      �� 5L      .R�5M      �� ��6(   �� *Nome+5N      5P      5Q      �� 5S      -   5        
 ��Name$
 
HorasLabel��5S      $
��Left=�6(   $	��Top=�6C   $��	45,75,0,0q�6[   $��14(�6n   .��6|   Horas6�   �� 5T      -	   5         ��Name$ Horas��5T      $��50,-40,50,0q�6(   $��Center=�6=   $��30��6X   .+�5U      �� -
   5        $��	hoursList��5U      ��5V      �� 5W      .R�5X      �� ��6(   �� *.+5Y      5[      5\      �� 5^      -   5         ��Name$ MarcarButton��5^      $��35��6+   $	��150��67   ���	#FFB9DCEB$��0,60,0,0q�6Z   .��6�   Marcar � 	Resources 5`      ��%_   '��       �� 5a      " ��6   .�5b      ��  �@��CornerRadius$ 10��69   5c      5d      5e      5g      � 5h   
   -   5        $
	 Book��5h   6   $��Bottom=�6   $��70��6*   .+�5i      �� -   5        $��35��5i      $	��200��6!   ���	#FFB9DCEB.��6Y   Marcar Consulta 5k      ��%_   '��       �� 5l      " ��6   .�5m      ��  �@��CornerRadius$ 10��69   5n      5o      5p      5q      5s      5u      