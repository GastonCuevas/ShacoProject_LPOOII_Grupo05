   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Vistas.ControlesUsuarioVistas.ControlesUsuario  5   	       Vistas.FrmLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9control%clr-namespace:Vistas.ControlesUsuario     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$   ��5   	   $	��526��6   $	��340��6    � WindowStyle$
 None=�6+    � WindowStartupLocation$ CenterScreen=�6>    � 
ResizeMode$ NoResize=�6c   $��Stretch=�6y   $��Stretch=�6�   $��Stretch=�6�   $��Stretch=�6�   
���   � J� Opacity$
 0.97Q�6   � AllowsTransparency . .��5      � $
��Auto��6   $��LeftToRight=�6   ��64   Z�  � RowDefinitions 5   
   �� 5	      $	��72* �6   �� 5
      $
��415* �6   .+�5   
   #   Vistas.ControlesUsuario.Login  -   5          Name$ controlLogin��5      $��Right=�6.   $��Center=�6J   $��0q�6e   $	��137��6y   $��0,119,21,159q�6�   $	��229��6�   $��1��6�   6�   "  FontAwesome.WPF.ImageAwesome  5   
      Icon$ 
UserCircle=�6   $��40��6,   $��40��67   	   
Foreground
	 �����$��28,139,250,236q�6V   $��Stretch=�6n   $��1��6�   6�     5   
   $
 Lock=�6   $��40��6&   $��40��61   
	 �����$��28,195,250,180q�6P   $��1��6h   6w   �� 5   
   -   5        $��btnIngresar��5   �      BotónAccion#��[  6   $��Ingresar��66   $��30��6I   $��Center=�6U   $��
61,0,61,50q�6r   $��Bottom=�6�   $	��200��6�   $��1��6�   6�   �� 5   
   -   5        $��	checkBox1��5   R   $��
Recordarme��6   $��16��6(   $��Stretch=�64   $��Stretch=�6c   
����������	#FF640000���	#FF190000$��102,251,122,148q�6�    	 Check#��[ 6�   $��0q�6�   $��1��6  �� 5   
   -   5        $��image1��5   N   $	��139��6   $��Center=�6   $��
82,56,82,0q�6:   $
��Fill=�6\   $	��Top=�6k   $	��155��6�   $'��!/Vistas;component/Images/logo.jpg��6�   $��2��6�   �� 5   
   -   5        $��
rectangle1��5   �   
 J� 	AllowDrop
 .  ���	#FF640000$��34��6O   $��Center=�6[   $��-11,0q�6x    �� Stretch$
 Fill=�6�   ���	#FF640000$	��Top=�6�   $	��340��6�    � DataContext 6&   �� 6�   �� 5   
   -   5        $��
rectangle2��5   \   ���	#FF640000$��6��6%   $��Center=�60   $��-11,0q�6M   ���	#FF640000$��Bottom=�6�   $	��340��6�   $��1��6�   A� 5   
   -   5        $��ellipse1��5   M   $	��700��6   $��Center=�6   $��0,0,0,0q�6<   ���	#FF640000$��40��6p   $��Center=�6�   $	��465��6�   $��2��6�   r� 5   
   -   5        $��music��5   h    r� LoadedBehavior$
 Play=�6   $��24��6-   $
��Left=�69   $��
28,282,0,0q�6T   $	��Top=�6u   $��40��6�   $��1��6�   5      5      