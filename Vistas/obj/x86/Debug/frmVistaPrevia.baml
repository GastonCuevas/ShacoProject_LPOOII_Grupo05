   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas   Vistas.frmVistaPrevia   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =data,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	     � Title$"  Imprimir Listado de Usuarios��5   	   $	��497��6.   $	��689��6;    � 	Resources 5         listado_usuarios S� 
ObjectType    ClasesBase.TrabajarUsuario S� 
MethodName��%L   &	        S� 5	   
   "  5      $ TraerUsuarios��5      5      5      .��5      � $	��482��6   $	��700��6   .+�5   
   �� $��	60,0,83,0q�6   .+�5      -�  �� Left$ 12��6!   
 �� Top$ 28��62   $	��539��6B   $	��342��6N   .��5      /� -   5         �Name$ DocMain��5      .T�5      J� .*�6    Listado de Usuarios65   �� 5      .r�5      �� -   5        $��grdUsuarios��5   #   ��66   ��  �� Source# [   �� View 5      �� 5   "   P�5   &   �� 5   *   $��ID��69   	 �� Width$	 40��6r   
 �� DisplayMemberBinding
 6E   ��  �� Path$ Usu_ID�6   �� 5   *   $��Usuario��69   $		 100��6�   
 6J   �� $ Usu_NombreUsuario�6�   �� 5   *   $��Contraseña��69   $		 100��6�   
 6M   �� $ Usu_Contraseña�6�   �� 5   *   $��Nombre y Apellido��69   $		 200��6�   
 6T   �� $ Usu_ApellidoNombre�6�   �� 5   *   $��Código��69   $	 60��6z   
 6I   �� $ 
Rol_Codigo�6�   5    #   5"      5#      5$      5%      �� 5&      -   5        $��btnImprimir��5&      $��Imprimir��6(   $��79��6U   $��30q�6`   5'      5(      5)      