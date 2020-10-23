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
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
namespace Vistas
{
    /// <summary>
    /// Interaction logic for ListadoUsuario.xaml
    /// </summary>
    public partial class ListadoUsuario : Window
    {
        public ListadoUsuario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataTable dt = TrabajarUsuario.traerUsuarioSP(txtBuscar.Text);
            grdUsuarios.ItemsSource = dt.DefaultView;
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            frmVistaPrevia oFrmVistaPrevia = new frmVistaPrevia();
            oFrmVistaPrevia.Show();
        }
    }
}
