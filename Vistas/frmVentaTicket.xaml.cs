using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for frmVentaTicket.xaml
    /// </summary>
    public partial class frmVentaTicket : Window
    {
        public frmVentaTicket()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();
        Ticket oTicket = new Ticket();

        public frmVentaTicket(Usuario vendedor, Ticket tic)
        {
            InitializeComponent();
            usuario = vendedor;
            oTicket = tic;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Butaca oButaca = TrabajarButaca.traerButaca(oTicket.But_ID);

            txtVendedor.Text = "Vendedor: " + usuario.Usu_ApellidoNombre;
            txtProyeccion.Text = "Proyección: " + oTicket.Pro_Codigo;
            txtFecha.Text = "Fecha: " + oTicket.Tick_FechaVenta.ToString();
            txtCliente.Text = "Cliente: " + oTicket.Cli_DNI;
            txtButaca.Text = "Butaca: Fila: " + oButaca.But_Fila + " - Número: " + oButaca.But_Nro;
            txtPrecio.Text = "Precio: $" + oTicket.Tick_Precio;
        }
    }
}
