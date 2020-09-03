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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Usuario vendedor = new Usuario();
            vendedor.Rol_Codigo = "VND";
            vendedor.Usu_ApellidoNombre = "Angello Miguél";
            vendedor.Usu_Contraseña = "vendedor";
            vendedor.Usu_ID = 2;
            vendedor.Usu_NombreUsuario = "icansellursoul";

            Usuario admin = new Usuario();
            admin.Rol_Codigo = "ADM";
            admin.Usu_ApellidoNombre = "Moreno Gisell";
            admin.Usu_Contraseña = "admin";
            admin.Usu_ID = 1;
            admin.Usu_NombreUsuario = "adminisfornoobs";

            Usuario userLogued = new Usuario();
            Boolean encontrado = false;
            //MessageBox.Show("Comparé: " + vendedor.Usu_Contraseña + " con " + txtContraseña.Text);
            if (txtNombreUsuario.Text == vendedor.Usu_NombreUsuario && pbContraseña.Password == vendedor.Usu_Contraseña)
            {
                userLogued = vendedor;
                encontrado = true;
            }
            if (txtNombreUsuario.Text == admin.Usu_NombreUsuario && pbContraseña.Password == admin.Usu_Contraseña)
            {
                userLogued = admin;
                encontrado = true;
            }

            if (encontrado == false)
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {
                MessageBox.Show("Bienvenido: " + userLogued.Usu_ApellidoNombre + ", Rol: " + userLogued.Rol_Codigo);
                FrmPrincipal oFrmPrincipal = new FrmPrincipal(userLogued);
                oFrmPrincipal.Show();
                this.Close();
            }
            
        }
    }
}
