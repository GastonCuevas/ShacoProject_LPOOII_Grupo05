   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.frmTickets   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5          � Title$  Venta de Tickets��5   	   $	��487��6"   $	��817��6/    � 	Resources 5       S� 
ObjectType#   ClasesBase.TrabajarProyeccion S� 
MethodName   lista_proyecciones   ClasesBase.TrabajarButaca  lista_butacas    ClasesBase.TrabajarCliente  lista_clientes   ClasesBase.TrabajarTicket  lista_tickets��%8  &	        &	 H     &	 �     &	 �     S� 5   
   "  5	      $ traerProyeccionesCB��5
      5      S� 5   
   "  5      $ traerButacasCB��5      5      S� 5   
   "  5      $ traerClientesCB��5      5      S� 5   
   "  5      $ traerTickets��5      5      5      .��5      � .+�5   
   �� -   5        $��
grdTickets��5      $��342,12,21,166q�6%   ��5       ��  �� Source# [  �� View 5!      �� 5"      .P�5#      ��  �� Width$	 105��6%   $��Número Ticket��61    �� DisplayMemberBinding 6H   ��  �� Path$ TICK_Nro��� 5$      $ 90��6%   $��Fecha��60    6?   �� $ TICK_FechaVenta��� 5%      $	 130��6%   $��Código Proyección��61    6L   �� $ 
PRO_Codigo��� 5&      $ 80��6%   $��Cliente��60    6A   �� $ CLI_DNI�5'      5)      �� 5*   
   -   5        $��
lblCliente��5*   ^   $��	Cliente: ��6   $��28��6$   $
��Left=�60   $��	12,28,0,0q�6K   $	��Top=�6p   �� 5+   
   -   5        $��btnSeleccionarButaca��5+   Q   $��Seleccionar Butaca��6   $��28��6.   $��12,96,499,324q�6:   	 � Cursor$
	 Hand��6�   �� 5,   
   -   5        $��	lblNumBut��5,   l   $��Butaca Seleccionada:  ��6   $��28��61   $
��Left=�6=   $��
10,130,0,0q�6X   $	��Top=�6}   �� 5-   
   -   5        $��lblProyeccion��5-   _   $��Proyección��6   $��28��6%   $
��Left=�61   $��	12,62,0,0q�6L   $	��Top=�6t   �� 5.   
   -   5        $��lblFechaVenta��5.   f   $��Fecha de Venta: ��6   $��28��6+   $
��Left=�67   $��
12,164,0,0q�6R   $	��Top=�6{   �� 5/   
   -   5        $��	cbCliente��5/   �   
 �� SelectedIndex$
 0��6    �� DisplayMemberPath$ datos��6d    �� SelectedValuePath$ CLI_DNI��6~   $��23��6�   $
��Left=�6�   $��
152,33,0,0q�6�   $	��Top=�6�   $	��144��6�   ��6%   �� # [ 6�   �� 50   
   -	   5        $��cbProyeccion��50   �   $
 0��6   $ datos��6h   $ 
PRO_Codigo��6�   $��23��6�   $
��Left=�6�   $��
152,67,0,0q�6�   $	��Top=�6�   $	��144��6  ��6%   �� # [  6  (  "System.Windows.Controls.DatePicker  51   
   -
   5        $��dtpFechaVenta��51   Q   $��25��6   $
��Left=�6!   $��152,167,0,0q�6<   $	��Top=�6f   $	��144��6~   $
	 Hand��6�   �� 52   
   -   5        $��btnVenderTicket��52   e   $��Realizar Venta��6   $��25��6*   $
��Left=�66   $��
82,257,0,0q�6Q   $	��Top=�6|   $	��139��6�   $
	 Hand��6�   �� 53   
   -   5        $��
btnCliente��53   W   $�� ��6   $��30��6   $
��Left=�6(   $��
302,31,0,0q�6C   $	��Top=�6i   $��30��6�   $
	 Hand��6�   ��54      �� 55       �� 
TargetType" ��6"   .R�56      � .+�57      A� 
�������6"   �� 58      $��Center=�6+   $��Center=�6H   "  FontAwesome.WPF.ImageAwesome  59         Icon$
 Plus=�6*   $��20��66   $��20��6A      
Foreground
 �P��$��Stretch=�6`   6~   5:      5;      5=      5>      5?      