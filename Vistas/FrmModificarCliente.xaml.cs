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
    /// Lógica de interacción para FrmModificarCliente.xaml
    /// </summary>
    public partial class FrmModificarCliente : Window
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDni.Text != "")
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Apellido = "aquí va el apellido";
                oCliente.Cli_Nombre = "aquí va el nombre";
                TrabajarCliente oTrabajarCliente = new TrabajarCliente();
                oCliente = oTrabajarCliente.traerCliente(Convert.ToInt32(txtDni.Text));
                cargarCliente(oCliente);
            }
            
        }
        public void cargarCliente(Cliente cli) {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            if (cli != null)
            {
                if (cli.Cli_Apellido != null)
                {
                    txtApellido.Text = cli.Cli_Apellido;
                    txtNombre.Text = cli.Cli_Nombre;
                    txtTelefono.Text = cli.Cli_Telefono;
                    txtEmail.Text = cli.Cli_Email;
                }
            }
            
            
            
        }

        private void txtDni_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn_Confirmar.Visibility = Visibility.Hidden;
            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Confirmar_Modificar.Visibility = Visibility.Hidden;
            btn_Confirmar_Eliminar.Visibility = Visibility.Hidden;
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Desea modificar el Cliente?", "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                btn_Confirmar_Eliminar.Visibility = Visibility.Visible;
            }
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Desea modificar el Cliente?", "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                btn_Confirmar_Modificar.Visibility = Visibility.Visible;
            }
        }

        private void btn_Agregar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Desea agregar un nuevo Cliente?", "Agregar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                limpiarCampos();
                btn_Confirmar.Visibility = Visibility.Visible;
            }
        }

        private void btn_Confirmar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_DNI = Convert.ToInt32(txtDni.Text);
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Apellido = txtApellido.Text;
            oCliente.Cli_Telefono = txtTelefono.Text;
            oCliente.Cli_Email = txtEmail.Text;
            TrabajarCliente.AgregarCliente(oCliente);
            ocultarCampos();
        }
        private void btn_Confirmar_Modificar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_DNI = Convert.ToInt32(txtDni.Text);
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Apellido = txtApellido.Text;
            oCliente.Cli_Telefono = txtTelefono.Text;
            oCliente.Cli_Email = txtEmail.Text;
            TrabajarCliente.ModificarCliente(oCliente);
            ocultarCampos();
        }

        private void btn_Confirmar_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(txtDni.Text);
            TrabajarCliente.EliminarCliente(ID);
        }

        private void mostrarCampos()
        {
            btn_Cancelar.Visibility = Visibility.Visible;
            btn_Agregar.Visibility = Visibility.Hidden;
            btn_eliminar.Visibility = Visibility.Hidden;
            btn_modificar.Visibility = Visibility.Hidden;
        }
        private void ocultarCampos()
        {
            btn_Confirmar.Visibility = Visibility.Hidden;
            btn_Confirmar_Modificar.Visibility = Visibility.Hidden;
            btn_Confirmar_Eliminar.Visibility = Visibility.Hidden;
            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Agregar.Visibility = Visibility.Visible;
            btn_eliminar.Visibility = Visibility.Visible;
            btn_modificar.Visibility = Visibility.Visible;
        }
        private void habilitarTXT()
        {
            txtApellido.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            txtEmail.IsEnabled = true;
        }
        private void desHabilitarTXT()
        {
            txtApellido.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtTelefono.IsEnabled = false;
            txtEmail.IsEnabled = false;
        }
        private void limpiarCampos() 
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            ocultarCampos();
            desHabilitarTXT();
            limpiarCampos();
        }

        

        

        

    }
}
