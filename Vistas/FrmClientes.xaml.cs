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
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Método que agrega un Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    limpiarCampos();
                }
            }
            else 
            {
                MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        //Método que llama al método de limpiar campos
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Conjunto de Métodos que verifican si se puede habilitar el botón de agregar en el FrmClientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtDNI.Text != ""
              && txtEmail.Text != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtDNI.Text != ""
              && txtEmail.Text != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtDNI.Text != ""
              && txtEmail.Text != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtDNI.Text != ""
              && txtEmail.Text != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtDNI_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            if (txtApellido.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtDNI.Text != ""
              && txtEmail.Text != "")
            {
                btnAgregar.IsEnabled = true;
            }
             * */
        }

        /// <summary>
        /// Conjunto de Métodos que validan los textBox de DNI y Teléfono para que solo se puedan ingresar números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtDNI_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        /// <summary>
        /// Método que limpia los campos del formulario
        /// </summary>
        private void limpiarCampos() 
        {
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
            btnAgregar.IsEnabled = false;
        }
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            FrmModificarCliente oFrmModificarCliente = new FrmModificarCliente();
            oFrmModificarCliente.Show();
        }

        
    }
}
