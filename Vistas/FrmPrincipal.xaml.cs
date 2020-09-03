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
    /// Interaction logic for FrmPrincipal.xaml
    /// </summary>
    public partial class FrmPrincipal : Window
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Usuario userLogued)
        {
            InitializeComponent();
            cargaMenu(userLogued);
        }

        public void cargaMenu(Usuario userLogued){

            if (userLogued.Rol_Codigo.Equals("ADM"))
            {
                menuVendedor.Visibility = System.Windows.Visibility.Collapsed;
            }
            else 
            {
                menuAdmin.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void miClientes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miTickets_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miUsuarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miPeliculas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miButacas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miProyeccciones_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
