   M S B A M L   `   `   `  ����B  >Clicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ClickerClicker  5   	       Clicker.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Clicker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5	   	   $	��800��6.   $	��450��6=   .��5
      � -   5         �Name$ grid1��5
      .+�5   
   �� -   5         ��Name$ 
labelNariz��5      $��0��6$   $��Center=�60   $��0,41,0,0q�6M   $	��Top=�6_   $��36(�6w   �� 5   
   -   5         ��Name$ 
botaoNariz��5      $��Center=�6$   $	��100��6A   $��Center=�6N   $	��100��6i   $��/Imagens/Nariz.png��6u   6  �� 5   
   -   5        $ labelNpC��5      $��Nariz por Clique: 1��6"   $
��Left=�6@   $��	10,0,0,40q�6[   $��Bottom=�6n   $��16(�6�   �� 5   
   -   5        $ labelNpS��5      $��Nariz por Segundo: 0��6"   $
��Left=�6A   $��	10,0,0,10q�6\   $��Bottom=�6o   $��16(�6�   � 5   
   
�������$	��230��6"   $	��230��61   $��Right=�6=   .+�5      �� ���#EEEEEE J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         	Direction$	 270Q�6'      ShadowDepth$ 2Q�67      
BlurRadius$ 7Q�6G   5      �� 5      .��5      �� .+�5      � 	 � ColumnDefinitions	 5      �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��* �6/   .+�5      �� -   5        
 ��Name$
 botaox1��5   !   $��x1��62   $��0��6?   $	��Top=�6O   $��25��6g   $��14(�6s   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,1,1q�6�   6�   �� 5      -   5        $
 botaox10��5   !   $	��x10��63   $��1��6A   $	��Top=�6Q   $��25��6i   $��14(�6u   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,1,1q�6�   6�   �� 5      -   5        $
 	botaox100��5   !   $
��x100��64   $��2��6C   $	��Top=�6S   $��25��6k   $��14(�6w   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,0,1q�6�   6�   5       �� 5!      
���   �$��0,0,0,1q�61   ._�5"      � -	   5        $ botaoUpgrade1��5"      ���	#FFEEEEEE	 5#      �� 5$      $��7* �6/   �� 5%      $��3* �6/   .+�5'      � $��0��6    � RowDefinitions 5(      �� 5)   "   $��* �60   �� 5*   "   $��* �60   .+�5,      �� -
   5         ��Name$ labelUpgrade1Name��5,   (   $��0��6C   $��Toque macio��6P   $��Stretch=�6c   $��Center=�6�   $��10,5,0,5q�6�   $��15(�6�   $��Cascadia Mono)�6�   �� 5-      -   5        $ labelUpgrade1Price��5-   (   $��1��6D   $��10��6Q   $
��Left=�6[   $��Center=�6v   $��10,0,0,5q�6�   $��12(�6�   5.      �� 5/      -   5        $ labelUpgrade1Lv��5/   $   $��1��6=   $��0��6M   $��Right=�6V   $��Center=�6r   $��0,0,5,0q�6�   $��20(�6�   50      51      �� 52      -   5        $
 botaoUpgrade2��52      $��Cotonete (20)��64   $��Stretch=�6L   $	��Top=�6j   $��50��6�   $��14(�6�   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,0,1q�6�   �� 53      -   5        $
 botaoUpgrade3��53      $��Cafungada (200)��64   $��Stretch=�6N   $	��Top=�6l   $��50��6�   $��14(�6�   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,0,1q�6�   �� 54      -   5        $
 botaoUpgrade4��54      $��Pelos (500)��64   $��Stretch=�6J   $	��Top=�6h   $��50��6�   $��14(�6�   ���	#FFEEEEEE$��Cascadia Mono)�6�   $��0,0,0,1q�6�   55      56      57      58      59      