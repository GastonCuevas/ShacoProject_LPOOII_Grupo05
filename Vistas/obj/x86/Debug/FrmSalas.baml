   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.FrmSalas   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   6svc,clr-namespace:ClasesBase;assembly=ClasesBase  5   	     � Title$  Gestión de Salas��5   	   $	��372��6"   $	��933��6/    � 	Resources 5       S� 
ObjectType   ClasesBase.TrabajarSala S� 
MethodName   lista_salas��%I   &	        S� 5   
   "  5	      $ 
traerSalas��5
      5      5      .��5      � $	��910��6    5   
     clave_denominaciones � Source � XPath��%S   &	       � 5      $ DenominacionSala.xml?�6;   $ /denominaciones��6Y   5      .+�5   
   �� -   5        $��grdSalas��5      $��560,12,29,151q�6#   ��5      ��  �� Source# [   �� View 5      �� 5      .P�5      ��  �� Width$ 60��6%   $��Número��60   	 �� DisplayMemberBinding	 6@   �� 
 �� Path$
 SALA_NroSala��� 5      $	 100��6%   $��Cant. Butacas��61   	 6H   �� $
 SALA_CantButacas��� 5      $	 100��6%   $��Denominación��61   	 6G   �� $
 SALA_Denominacion��� 5      $ 50��6%   $��Precio��60   	 6@   �� $
 SALA_Precio�5      5      �� 5    
   -   5        $��lblDenominacion��5    c   $��Denominación: ��6   $��31��6)   $
��Left=�65   $��	25,59,0,0q�6P   $	��Top=�6z   $	��153��6�   �� 5!   
   -   5        $��lblFilas��5!   ]   $��Filas: ��6   $��31��6"   $
��Left=�6.   $��
25,114,0,0q�6I   $	��Top=�6m   $	��153��6�   $y�Hidden=�6�   �� 5"   
   -   5        $��lblColumnas��5"   _   $��
Columnas: ��6   $��31��6%   $
��Left=�61   $��	25,86,0,0q�6L   $	��Top=�6r   $	��153��6�   $y�Hidden=�6�   �� 5#   
   -   5        $��lblCantidadButacas��5#   R   $��Cantidad de Butacas: ��6   $��31��60   $��25,149,520,0q�6<   $	��Top=�6l   �� 5$   
   -   5        $��cbDenominacion��5$   �    �� SelectedIndex$ 0��6   $��23��6}   $��197,59,549,0q�6�   $	��Top=�6�   {�.  ��6%   �� # [  �� XPath$ clave/@name��6�   �� 5%   
   -   5        $��txtColumnas��5%   M   $��23��6   $
��Left=�6   $��
197,86,0,0q�69   $	��Top=�6`   $	��164��6x   {�.  $y�Hidden=�6�   �� 5&   
   -   5        $��txtFilas��5&   N   $��23��6   $
��Left=�6   $��197,112,0,0q�69   $	��Top=�6^   $	��164��6v   {�.  $y�Hidden=�6�   �� 5'   
   -	   5        $��
btnAgregar��5'   ^   $��Agregar��6   $��23��6#   $
��Left=�6/   $��
61,194,0,0q�6J   $	��Top=�6p   $��75��6�    � Cursor$
 Hand��6�   �� 5(   
   -
   5        $��btnModificar��5(   a   $��	Modificar��6   $��23��6%   $
��Left=�61   $��142,194,0,0q�6L   $	��Top=�6u   $��75��6�   {�.  $
 Hand��6�   �� 5)   
   -   5        $��btnEliminar��5)   `   $��Eliminar��6   $��23��6$   $
��Left=�60   $��223,194,0,0q�6K   $	��Top=�6s   $��75��6�   {�.  $
 Hand��6�   �� 5*   
   -   5        $��
lblNroSala��5*   b   $��Sala Número: ��6   $��31��6(   $
��Left=�64   $��	25,30,0,0q�6O   $	��Top=�6t   $	��153��6�   �� 5+   
   -   5        $��
txtNroSala��5+   M   $��23��6   $
��Left=�6   $��
197,30,0,0q�69   $	��Top=�6_   $	��164��6w   6�   �� 5,   
   -   5        $��btnConfirmar��5,   W   $�� ��6   $��70��6   $
��Left=�6(   $��
420,20,0,0q�6C   $	��Top=�6k   $��70��6�   $
 Hand��6�   $y�Hidden=�6�   ��5-      �� 5.       �� 
TargetType" ��6"   .R�5/      � .+�50      A� 
�������6"   �� 51      $��Center=�6+   $��Center=�6H   "  FontAwesome.WPF.ImageAwesome  52         Icon$ CheckCircleOutline=�6*   $��70��6D   $��70��6O      
Foreground
 �/���$��Stretch=�6t   6�   53      54      56      �� 57   
   -   5        $��btnCancelar��57   X   $�� ��6   $��70��6   $
��Left=�6(   $��420,114,0,0q�6C   $	��Top=�6k   $��70��6�   $
 Hand��6�   $y�Hidden=�6�   ��58      �� 59      " ��6"   .R�5:      � .+�5;      A� 
�������6"   �� 5<      $��Center=�6+   $��Center=�6H     5=      $ TimesCircleOutline=�6*   $��70��6D   $��70��6O   
 �  ��$��Stretch=�6l   6�   5>      5?      5A      5B      5C      