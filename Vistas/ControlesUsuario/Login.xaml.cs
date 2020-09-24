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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas.ControlesUsuario
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        //Obtiene el Texto del TextBox
        public String Usuario
        {
            get { return txtNombreUsuario.Text; }
        }

        //Obtiene la contraseña del PasswordBox
        public String Contraseña
        {
            get { return pbContraseña.Password; }
        }
    }
}
