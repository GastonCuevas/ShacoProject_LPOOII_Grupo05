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

        /// <summary>
        /// Método que valida el rol del usuario logueado para mostrar el menú.
        /// </summary>
        /// <param name="userLogued"></param>
        public void cargaMenu(Usuario userLogued){

            if (userLogued.Rol_Codigo.Equals("ADM"))
            {
                menuVendedor.Visibility = System.Windows.Visibility.Collapsed;
            }
            else 
            {
                menuAdmin.Visibility = System.Windows.Visibility.Collapsed;
            }

            lblUsuarioLogueado.Content = "Bienvenido: " + userLogued.Usu_ApellidoNombre;
        }

        //Método que muestra el formulario de gestión de clientes.
        private void miClientes_Click(object sender, RoutedEventArgs e)
        {
            FrmClientes oFrmClientes = new FrmClientes();
            oFrmClientes.Show();
        }

        //Método que muestra el formulario de gestión de tickets.
        private void miTickets_Click(object sender, RoutedEventArgs e)
        {

        }

        //Método que muestra el formulario de gestión de usuarios.
        private void miUsuarios_Click(object sender, RoutedEventArgs e)
        {
            FrmClientes oFrmClientes = new FrmClientes();
            oFrmClientes.Show();
        }

        //Método que muestra el formulario de gestión de películas.
        private void miPeliculas_Click(object sender, RoutedEventArgs e)
        {
            FrmPeliculas oFrmPeliculas = new FrmPeliculas();
            oFrmPeliculas.Show();
        }

        //Método que muestra el formulario de gestión de butacas.
        private void miButacas_Click(object sender, RoutedEventArgs e)
        {
            FrmButacas oFrmButacas = new FrmButacas();
            oFrmButacas.Show();
        }

        //Método que muestra el formulario de gestión de proyecciones.
        private void miProyeccciones_Click(object sender, RoutedEventArgs e)
        {
            frmProyecciones oFrmProyecciones = new frmProyecciones();
            oFrmProyecciones.Show();
        }

        //Método que muestra el formulario de gestión de Salas.
        //private void miUsuarios_Click(object sender, RoutedEventArgs e)
        //{
            //oFrmSalas.Show();
        //}

        //Método que cierra el formulario principal y abre el formulario de login
        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            FrmLogin oFrmLogin = new FrmLogin();
            this.Close();
            oFrmLogin.Show();
        }
        //Método que cierra el formulario principal y abre el formulario de loginXD
        private void miModificar_Click(object sender, RoutedEventArgs e)
        {
            FrmModificarCliente oFrmModificarCliente = new FrmModificarCliente();
            oFrmModificarCliente.Show();
        }

    }
}
