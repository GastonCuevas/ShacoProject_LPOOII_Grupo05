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
            /*
            usuario.Usu_ApellidoNombre = "Choquekun, Brunoich";
            oTicket.But_ID = 795;
            oTicket.Cli_DNI = 42583210;
            oTicket.Pro_Codigo = "555";
            oTicket.Tick_FechaVenta = Convert.ToDateTime("31 / 10 / 2020");
            oTicket.Tick_Nro = 1;
            oTicket.Tick_Precio = 200;*/

            //Obtención de objetos para información del Ticket
            Butaca oButaca = TrabajarButaca.traerButaca(oTicket.But_ID);
            Proyeccion oProyeccion = TrabajarProyeccion.traerProyeccion(oTicket.Pro_Codigo);
            Pelicula oPelicula = TrabajarPelicula.traerPelicula(oProyeccion.Pel_Codigo);
            Cliente oCliente = TrabajarCliente.traerCliente(oTicket.Cli_DNI);

            MessageBox.Show(usuario.Usu_ApellidoNombre);
            txtVendedor.Text = "Vendedor: " + usuario.Usu_ApellidoNombre;
            txtProyeccion.Text = "Código Proyección: " + oProyeccion.Pro_Codigo;
            txtFecha.Text = "Fecha de Venta: " + oTicket.Tick_FechaVenta.ToShortDateString();
            txtFechaProyeccion.Text = "Fecha y Hora: " + oProyeccion.Pro_Fecha.ToShortDateString() + " - " + oProyeccion.Pro_Hora + "Hs";
            txtCliente.Text = "Cliente: " + oCliente.Cli_Apellido + ", " + oCliente.Cli_Nombre;
            txtButaca.Text = "Número de Sala: " + oProyeccion.Sala_NroSala + " - Butaca: Fila: " + oButaca.But_Fila + " - Número: " + oButaca.But_Nro;
            txtPrecio.Text = "Precio: $" + oTicket.Tick_Precio;
            txtPelicula1.Text = "Película: " + oPelicula.Pel_Titulo + " - Género: " + oPelicula.Pel_Genero;
            txtPelicula2.Text = "Clase: " + oPelicula.Pel_Clase + " - Duración: " + oPelicula.Pel_Duracion + "'";
        }
    }
}
