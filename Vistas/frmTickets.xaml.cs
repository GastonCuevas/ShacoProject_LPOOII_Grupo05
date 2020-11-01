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
using System.Data;
using System.Data.SqlClient;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for frmTickets.xaml
    /// </summary>
    public partial class frmTickets : Window
    {
        public int butacaSeleccionadaId = 0;
        private decimal precioSala; 

        public frmTickets()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();

        public frmTickets(Usuario vendedor)
        {
            InitializeComponent();
            usuario = vendedor;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtpFechaVenta.SelectedDate = DateTime.Today;
        }

        private void btnVenderTicket_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("¿Confirmar Venta?", "Venta de Tickets", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Ticket oTicket = new Ticket();
                oTicket.But_ID = butacaSeleccionadaId;
                oTicket.Cli_DNI = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                oTicket.Pro_Codigo = cbProyeccion.SelectedValue.ToString();
                oTicket.Tick_FechaVenta = (DateTime)dtpFechaVenta.SelectedDate;
                oTicket.Tick_Precio = Convert.ToDecimal(precioSala);
                TrabajarTicket.AgregarTicket(oTicket);
                MessageBox.Show("Venta realizada con éxito");

                DataTable dt = TrabajarTicket.traerTickets();
                grdTickets.ItemsSource = dt.DefaultView;

                frmVentaTicket oFrmVentaTicket = new frmVentaTicket(usuario,oTicket);
                oFrmVentaTicket.Show();

            }
        }

        private void btnSeleccionarButaca_Click(object sender, RoutedEventArgs e)
        {
            //Traemos la proyección seleccionada
            Proyeccion oProyeccion = TrabajarProyeccion.traerProyeccion(cbProyeccion.SelectedValue.ToString());

            //Traemos la aala dentro de la proyección seleccionada
            Sala oSala = TrabajarSala.traerSala(oProyeccion.Sala_NroSala);
            precioSala = oSala.Sala_Precio;

            FrmButacas butacas = new FrmButacas(oSala,oProyeccion,this);
            butacas.Show();
        }
    }
}
