   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   
 Vistas   Vistas.FrmClientes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   >DATOS,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   8TIPOS&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  FrmClientes��5   	   $	��361��6   $
��1199��6*    � 	Resources 5       S� 
ObjectType    ClasesBase.TrabajarCliente S� 
MethodName   lista_clientes  oCliente S� MethodParameters  TextBoxErrorTemplate � Color � Offset  EstiloError �� 
TargetType �� Property	 �� Value
 �� Triggers P� Property P� Value �� Path �� Self �� RelativeSource��%  &	        &	 B     &	 �     &	 �    7  S� 5   
   "  5	      $ traerClientes��5
      5      S� 5   
   "  6.   $ traerCliente��6Z    5      5      �� 5   
   .R�5      ]� .+�5      A� $��Right=�6   $	��2,0q�61   $��10��6>   $��10��6I   ��5      �� 5      .��5      � $ White��6+   $ 0Q�69   � 5      $ Orange��6+   $ 1Q�6:   5      5      �� 5      5      5      �� 5   
   " ��6$   .�5       ��  � ��$	 4,4,10,4q�6'   �� 5!       �@=�ErrorTemplate8	   69   
 5"      P� 5#       �@=�HasError . . �5$      ��  �@�ToolTip	 5%      �� 5&      $) #(Validation.Errors)[0].ErrorContent�6&   # Z 6Q   5(      5)      5+      5,      .��5-      � $
��1171��6    � ColumnDefinitions 5.   
   �� 5/      $
��987* �6   �� 50      $	��13* �6    � RowDefinitions 52   
   �� 53      $
��321* �6   �� 54      $��* �6   .+�56   
   �� -   5        $��txtDni��56   N   $��23��6   $��Right=�6   $��
0,13,847,0q�6:   $	��Top=�6\   $	��206��6t   #��[ 6�    �� 	MaxLength$ 10��6�   .��6   ��57      �� 58       �� Source# [ 6   $ MethodParameters[0]�59       �� BindsDirectlyToSource .  �� UpdateSourceTrigger$ PropertyChanged=�5;       �� ValidatesOnExceptions .  �� ValidatesOnDataErrors . 5>      .��5?      5@      �� 5A   
   -   5        $��lblDni��5A   V   $	��Dni��6   $��28��6   $
��Left=�6*   $��5,7,0,0q�6E   $	��Top=�6d   �� 5B   
   -   5        $��	txtNombre��5B   N   $��23��6   $
��Left=�6   $��103,0,0,233q�69   $��Bottom=�6_   $	��206��6z   #��[ 6  {�.  ��6�   �� # [ $ 
Cli_Nombre� .  . 6&  �� 5C   
   -   5        $��	lblNombre��5C   Z   $��Nombre��6   $��28��6!   $
��Left=�6-   $��5,60,0,0q�6H   $	��Top=�6k   �� 5D   
   -   5        $��lblApellido��5D   ]   $��Apellido��6   $��27��6#   $
��Left=�6/   $��	5,115,0,0q�6J   $	��Top=�6p   �� 5E   
   -   5        $��txtApellido��5E   N   $��23��6   $
��Left=�6   $��103,121,0,0q�69   $	��Top=�6a   $	��206��6y   #��[ 6  {�.  ��6�   �� # [ $ Cli_Apellido� .  . 6'  �� 5F   
   -   5        $��label1��5F   ]   $��Telefono��6   $��27��6#   $
��Left=�6/   $��	5,172,0,0q�6J   $	��Top=�6k   �� 5G   
   -	   5        $��txtTelefono��5G   N   $��23��6   $
��Left=�6   $��103,178,0,0q�69   #��[ 6a   $	��Top=�6  $	��206��6  {�.  ��6�   �� # [ $ Cli_Telefono� .  . 69  �� 5H   
   -
   5        $��label2��5H   Z   $��Email��6   $��27��6    $
��Left=�6,   $��	5,218,0,0q�6G   $	��Top=�6h   �� 5I   
   -   5        $��txtEmail��5I   N   $��23��6   $
��Left=�6   $��103,224,0,0q�69   #��[ 6^   $	��Top=�6�   $	��206��6  {�.  ��6�   �� # [ $ 	Cli_Email� .  . 6!  �� 5J   
   -   5        $��btn_modificar��5J   a   $��	Modificar��6   $��26��6%   $
��Left=�61   $��168,276,0,0q�6L   $	��Top=�6v   $	��102��6�   {�.  6�   �� 5K   
   -   5        $��btn_eliminar��5K   a   $��Eliminar��6   $��26��6$   $��Right=�60   $��0,276,750,0q�6L   $	��Top=�6u   $	��102��6�   {�.  6�   �� 5L   
   -   5        $��btn_Confirmar��5L   `   $��	Confirmar��6   $��82��6%   $
��Left=�61   $��
344,33,0,0q�6L   $	��Top=�6u   $	��102��6�   6�   �� 5M   
   -   5        $��btn_Cancelar��5M   `   $��Cancelar��6   $��82��6$   $
��Left=�60   $��344,153,0,0q�6K   $	��Top=�6t   $	��102��6�   6�   �� 5N   
   -   5        $��btn_Agregar��5N   ^   $��Agregar��6   $��26��6#   $
��Left=�6/   $��
20,276,0,0q�6J   $	��Top=�6q   $	��113��6�   6�   �� 5O   
   -   5        $��btn_Confirmar_Modificar��5O   `   $��	Confirmar��6   $��82��6%   $
��Left=�61   $��
344,33,0,0q�6L   $	��Top=�6   $	��102��6�   6�   �� 5P   
   -   5        $��btn_Confirmar_Eliminar��5P   `   $��	Confirmar��6   $��82��6%   $
��Left=�61   $��
344,34,0,0q�6L   $	��Top=�6~   $	��102��6�   6�   �� 5Q   
   -   5        $��grdClientes��5Q   O   $	��282��6   $
��Left=�6    $��
505,14,0,0q�6;   $	��Top=�6b   $	��647��6z   ��6�   �� # [   �� View 5R      �� 5S      .P�5T      ��  �� Width$	 100��6%   $	��DNI��61    �� DisplayMemberBinding 6>   �� $ CLI_DNI��� 5U      $	 100��6%   $��Nombre��61    6A   �� $ 
CLI_Nombre��� 5V      $	 100��6%   $��Apellido��61    6C   �� $ CLI_Apellido��� 5W      $	 100��6%   $��	Teléfono��61    6C   �� $ CLI_Telefono��� 5X      $	 250��6%   $��Email��61    6@   �� $ 	CLI_Email�5Y      5[      5\      5]      