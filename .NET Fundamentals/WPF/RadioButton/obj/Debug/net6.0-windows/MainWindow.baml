   M S B A M L   `   `   `  ����F  BRadioButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RadioButtonRadioButton  5   	       RadioButton.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RadioButton     5   	     � Title$  
MainWindow��5   	   $	��380��6   $	��600��6)   
������ � WindowStartupLocation$ CenterScreen=�5	   !   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��Center=�5      $	��200��5      $	��200��5      
�������.+�5      ��  �� Orientation$ 
Horizontal=�6   $��0,10,0,0q�62   $	��150��6D   .+�5      �� $
��Wrap=�6   $��Valor 1��60   �� 5      -   5         ��Name$ txtValor1Calc��5       �� TextWrapping$
 Wrap=�61   $�� ��6E   $��10,0,0,0q�6M   $��95��6_   5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�62   $	��150��6D   .+�5      �� $
��Wrap=�6   $��Valor 2��60   �� 5      -   5        $ txtValor2Calc��5      $
 Wrap=�61   $�� ��6E   $��10,0,0,0q�6M   $��95��6_   5      �� 5      $��50��6   .+�5       	� -   5        $��rdSum��5       $
��Suma��6+    d� 	IsChecked$
 TrueY�6:   $��53��6K    J� RenderTransformOrigin$ 0.5,0.5&�6V   $
��Left=�6v   $	��Top=�6�    �� Left$ 31��6�   
	 �� Top$	 10��6�   5!      	� 5"      -   5        $��rdSubstract��5"      $��Resta��62   $��49��6B   $ 31��6M   $	 25��6^   $
��Left=�6n   $��Center=�6�   	� 5#      -   5        $��rdMulti��5#      $��Multiplicacion��6-   $��99��6F   $	 101��6Q   $	 10��6c   $
��Left=�6s   $	��Top=�6�   	� 5$      -   5        $��rdDiv��5$      $��Division��6+   $��64��6>   $	 101��6I   $	 25��6[   $
��Left=�6k   $��Center=�6�   5%      �� 5*      -   5        $��bttCalcularCalc��5*      $��Calcular��5+      $	��100��5,      5-      �� 5.      $��	Resultado��5/      $��Center=�50      $��0,10,0,0q�51      6,   �� 52      -   5        
 ��Name$
 txbResultCalc��52      
�������$��40��54      $��	20,0,20,0q�55      $��Result here...��56      60   58      �� 5:   
   $��1��6   $��Center=�5;      $	��200��5<      $	��200��5=      
�������.+�5?      �� $ 
Horizontal=�6   $��0,10,0,0q�62   $	��150��6D   .+�5@      �� $
��Wrap=�6   $��Valor 1��60   �� 5A      -	   5        $ txtValor1Convert��5A      $
 Wrap=�64   $�� ��6H   $��10,0,0,0q�6P   $��95��6b   5C      �� 5D      $ 
Horizontal=�6   $��0,10,0,0q�62   $	��150��6D   �� 5F      $ 
Horizontal=�6   $	��200��62   $��0,5,0,0q�6>   .+�5G      	� -
   5        $��rdCmToP��5G      $��10,0,0,0q�6-   $��8(�6?   $��De cm a pulgadas��6L   6i   	� 5H      -   5        $��rdPToCm��5H      $��10,0,0,0q�6-   $��8(�6?   $��Pulgadas a Cm��6L   6f   5I      �� 5K      -   5         ��Name$ 
bttConvert��5K      $��	Convertir��5L      $��80��5M      $��0,10,0,0q�5N      5O      �� 5Q      -   5        $
 txbResultConvert��5Q      
�������$��40��5S      $��	20,5,20,0q�5T      $
��Wrap=�5U      $��Result here...��5V      5W      5Y      5Z      