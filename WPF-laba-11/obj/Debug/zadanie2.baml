   M S B A M L   `   `   `  ����F  BWPF-laba-11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_laba_11WPF_laba_11  5   	       WPF_laba_11.zadanie2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_laba_11     5   	     � Title$>  8Заказы CD/DVD дисков по каталогам��5   	   $	��450��63   $	��800��6@   .��5	      � .+�5
   
   �� ��5      �� 5      .��5      �  � Color$ 
LightGreen��6#    � Offset$
 0.05Q�66   6F   � 5      $ 	LightCyan��6#   $	 0.5Q�65   6D   5      5      �� 5   
   $��Игры��6   $	��100��6   $��30��6+   $
��Left=�67   $	��Top=�6R   $��	20,10,0,0q�6j   $��14(�6}   �� 5   
   $+��%Обучающие программы��6   $	��170��6.   $��30��6:   $��Right=�6F   $	��Top=�6b   $��	0,10,50,0q�6z   $��14(�6�   �� 5   
   -   5         ��Name$ gamesCB��5       �� 
IsEditable . $	��200��66   $��25��6B   $
��Left=�6N   $	��Top=�6i   $��	20,50,0,0q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5        $ programmsCB��5       . $	��200��6:   $��25��6F   $��Right=�6R   $	��Top=�6n   $��	0,50,20,0q�6�    5        5      5      �� 5    
   -   5         ��Name$ orderLB��5       $	��320��6#   $	��200��6/   $��Center=�6<   $��Center=�6Y   $��0,0,0,0q�6t   $��14(�6�   �� 5"   
   -   5        $$��Добавить в заказ��5"      $	��115��6,   $��30��68   $��14(�6D   $
��Left=�6R   $��Bottom=�6m   $��	50,0,0,30q�6�   
�������6�   �� 5#   
   -   5        $&�� Удалить из заказа��5#      $	��120��6-   $��30��69   $��14(�6E   $��Right=�6S   $��Bottom=�6o   $��	0,0,50,30q�6�   
�������6�   �� 5%   
   -   5         ��Name$ orderCountL��5%      $	��200��6%   $��30��61   $��Center=�6=   $��Center=�6a   $��Bottom=�6~   $��0,0,0,30q�6�   
���<��$��14(�6�   5&      5'      