   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   	   E AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase 5   	   
 Vistas   Vistas.ListadoUsuario   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase      5   	     � Title$  Listado De Usuarios��5   	   $	��301��6%   $	��580��62    � 	Resources 5       S� 
ObjectType   ClasesBase.TrabajarUsuario S� 
MethodName   lista_usuarios  lista_encontrados  vista_usuarios �� Source �� SortDescriptions+   %System.ComponentModel.SortDescription   PropertyName   	Direction��%)  &	        &	 D     &	 �     7  S� 5   
   "  5	      $ traerUsuariosSP��5
      5      S� 5   
   "  5      $ TraerUsuariosObservable��5      5      �� 5   
   -   5        8    5        5      $ Usu_NombreUsuario��61   $ 	Ascending=�6R   5      5      .��5      � $
��Auto��6   .+�5   
   �� -   5        $��	txtBuscar��5   L   $��23��6   $
��Left=�6   $��	98,19,0,0q�69   $	��Top=�6]   $	��206��6u   6�   �� 5   
   -   5        $��label1��5   \   $��Buscar:��6   $��28��6"   $
��Left=�6.   $��	37,19,0,0q�6I   $	��Top=�6j   $	��102��6�   �� 5   
   -   5        $��btnImprimir��5   _   $��Imprimir��6   $��23��6$   $
��Left=�60   $��
404,19,0,0q�6K   $	��Top=�6r   $��75��6�   6�   �� 5    
   -   5        $��
lstUsuario��5       $��12,65,12,12q�6e   ��6%   ��  �� Source# [ 	 �� View	 5!      �� 5"      .P�5#      �� $��Usuario��6a   
 �� Width$	
 150��6r    �� DisplayMemberBinding 6)   ��  �� Path$ Usu_NombreUsuario�6r   �� 5$      $��ID��6V   $
 40��6b    6)   �� $ Usu_ID�6b   �� 5%      $��Nombre��6b   $	
 140��6r    6)   �� $ Usu_ApellidoNombre�6r   �� 5&      $��Contraseña��6^   $
 90��6r    6)   �� $ Usu_Contraseña�6r   �� 5'      $��Codigo��6Z   $
 80��6j    6)   �� $ 
Rol_Codigo�6j   5(      5*      5+      5,      