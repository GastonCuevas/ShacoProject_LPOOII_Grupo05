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
    /// Interaction logic for FrmLogin.xaml
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que valida los datos cargados en el login, si son correctos, abre la ventana principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            Usuario userLogued = new Usuario();
            Boolean encontrado = false;
            //Traemos los valores de el controlUs.Login
            String nombreUs = controlLogin.Usuario;
            String contraseña = controlLogin.Contraseña;
            //Validación de login
            if (TrabajarUsuario.ValidarUsuario(nombreUs,contraseña)==true)
            {
                encontrado = true;
                userLogued = TrabajarUsuario.traerUsuario(nombreUs);
            }
            if (encontrado == false)
            {
                MessageBox.Show("Datos incorrectos");
                //Reiniciamos los valores del controlLogin
                controlLogin.txtNombreUsuario.Text = "";
                controlLogin.pbContraseña.Password = "";
            }
            else
            {
                music.Source = new Uri("C:/Users/Brunoich/Documents/GitHub/ShacoProject_LPOOII_Grupo05/Vistas/Resources/y2mate.com - Guerra Mundial Z BSO -- Isolated System -- Muse_320kbps.mp3");
                frmPantallaCarga oFrmCarga = new frmPantallaCarga(userLogued);
                FrmPrincipal oFrmPrincipal = new FrmPrincipal(userLogued);
                this.Hide();
                oFrmCarga.ShowDialog();
                oFrmPrincipal.Show();
                this.Close();
            }
            
        }
    }
}
