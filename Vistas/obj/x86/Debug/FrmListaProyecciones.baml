   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas!   Vistas.FrmListaProyecciones   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  Listado de Proyecciones��5   	   $	��518��6)   $	��645��66    � 	Resources 5       S� 
ObjectType#   ClasesBase.TrabajarProyeccion S� 
MethodName   lista_proyecciones��%V   &	        S� 5	   
   "  5
      $ traerProyeccionesSemana��5      5      5      .��5      � .+�5   
   �� -   5        $��grdProyecciones��5      $��71,132,75,46q�6*   ��5      ��  �� Source# [   �� View 5      �� 5      .P�5      ��  �� Width$ 80��6%   $��Código��60    �� DisplayMemberBinding 6@   ��  �� Path$ ProyeccionCodigo��� 5      $	 150��6%   $��	Película��61    6C   �� $ PeliculaTitulo��� 5      $ 90��6%   $��Fecha��60    6?   �� $ ProyeccionFecha��� 5      $ 80��6%   $
��Hora��60    6>   �� $ ProyeccionHora��� 5      $ 70��6%   $
��Sala��60    6>   �� $ ProyeccionNroSala�5      5      �� 5   
   -   5        $��txtBuscarNombre��5   L   $��23��6   $
��Left=�6   $��	71,39,0,0q�69   $	��Top=�6c   $	��243��6{   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dPFecha1��5   P   $��25��6   $
��Left=�6!   $��
337,12,0,0q�6<   $	��Top=�6`   $	��211��6x   �� 5   
   -   5        $��btnBuscarFecha��5   W   $�� ��6   $��52��6   $
��Left=�6(   $��
554,12,0,0q�6C   $	��Top=�6m   $��52��6�   	 � Cursor$
	 Hand��6�   ��5       �� 5!      
 �� 
TargetType"
 ��6"   .R�5"      � .+�5#      �� 
�������6$   �� 5$      $��Center=�6+   $��Center=�6H   "  FontAwesome.WPF.ImageAwesome  5%         Icon$ Calendar=�6*   $��35��6:   $��35��6E      
Foreground
 �P��$��Stretch=�6d   6�   5&      5'      5)        5*   
   -   5        $��dPFecha2��5*   P   $��25��6   $
��Left=�6!   $��
337,39,0,0q�6<   $	��Top=�6`   $	��211��6x   �� 5+   
   -   5        $��lblNombrePelicula��5+   s   $&�� Buscar por nombre de película: ��6   $��28��6:   $
��Left=�6F   $��71,9,0,0q�6a   $	��Top=�6�   $	��243��6�   �� 5,   
   -   5        $��btnRefrescar��5,   W   $�� ��6   $��30��6   $
��Left=�6(   $��
518,96,0,0q�6C   $	��Top=�6k   $��30��6�   $
	 Hand��6�   ��5-      �� 5.      "
 ��6"   .R�5/      � .+�50      A� 
�������6"   �� 51      $��Center=�6+   $��Center=�6H     52      $ Refresh=�6*   $��20��69   $��20��6D   
 �P��$��Stretch=�6c   6�   53      54      56      �� 57   
   -   5        $��btnTodas��57   `   $��	Ver Todas��6   $��23��6%   $
��Left=�61   $��
71,103,0,0q�6L   $	��Top=�6p   $��75��6�   6�   58      59      