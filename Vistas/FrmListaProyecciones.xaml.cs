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
using System.Data.SqlClient;
using System.Data;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmListaProyecciones.xaml
    /// </summary>
    public partial class FrmListaProyecciones : Window
    {
        public FrmListaProyecciones()
        {
            InitializeComponent();
        }

        private void btnBuscarFecha_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = TrabajarProyeccion.traerProyeccionesEntreDosFechas((DateTime)dPFecha1.SelectedDate, (DateTime)dPFecha2.SelectedDate);
            grdProyecciones.ItemsSource = dt.DefaultView;
        }

        private void btnRefrescar_Click(object sender, RoutedEventArgs e)
        {
            txtBuscarNombre.Text = "";
            dPFecha1.SelectedDate = null;
            dPFecha2.SelectedDate = null;
            DataTable dt = TrabajarProyeccion.traerProyeccionesSemana();
            grdProyecciones.ItemsSource = dt.DefaultView;
        }

        private void txtBuscarNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dt = TrabajarProyeccion.buscarProyecciones(txtBuscarNombre.Text);
            grdProyecciones.ItemsSource = dt.DefaultView;
        }

        private void btnTodas_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = TrabajarProyeccion.traerProyecciones();
            grdProyecciones.ItemsSource = dt.DefaultView;
        }
    }
}
