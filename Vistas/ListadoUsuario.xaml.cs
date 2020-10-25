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
        private CollectionViewSource vistaColeccionFiltrada; 

        public ListadoUsuario()
        {
            InitializeComponent();
            vistaColeccionFiltrada = Resources["vista_usuarios"] as CollectionViewSource;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (vistaColeccionFiltrada != null)
            {
                vistaColeccionFiltrada.Filter += CollectionViewSource_Filter;
            }
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            frmVistaPrevia oFrmVistaPrevia = new frmVistaPrevia();
            oFrmVistaPrevia.Show();
        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            Usuario usuario = e.Item as Usuario;
            if (usuario.Usu_NombreUsuario.StartsWith(txtBuscar.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                //MessageBox.Show(usuario.Usu_NombreUsuario);
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }
    }
}
