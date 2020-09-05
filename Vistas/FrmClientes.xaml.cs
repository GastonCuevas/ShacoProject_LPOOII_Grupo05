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
    /// Interaction logic for FrmClientes.xaml
    /// </summary>
    public partial class FrmClientes : Window
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_Apellido = txtApellido.Text;
            oCliente.Cli_DNI = Convert.ToInt32(txtDNI.Text);
            oCliente.Cli_Email = txtEmail.Text;
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Telefono = txtTelefono.Text;

            if (oCliente.Cli_Apellido != "" && oCliente.Cli_Nombre != "" && oCliente.Cli_Telefono != "" && oCliente.Cli_DNI != 0
               && oCliente.Cli_Email != "")
            {
                if (MessageBox.Show("Cliente: " + oCliente.Cli_Apellido +
                    ", " + oCliente.Cli_Nombre + "\nDNI: " + oCliente.Cli_DNI + "\nTeléfono: "
                    + oCliente.Cli_Telefono + "\nEmail: " + oCliente.Cli_Email, "¿Está seguro que desea agregar este cliente?", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Cliente Registrado");
                }
            }
            else 
            {
                MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
        }
    }
}
