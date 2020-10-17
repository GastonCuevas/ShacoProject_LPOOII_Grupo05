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

        //Método que busca el cliente mediante el DNI 
        private void txtDni_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDni.Text != "")
            {
                Cliente oCliente = new Cliente();
                oCliente = TrabajarCliente.traerCliente(Convert.ToInt32(txtDni.Text));
                cargarCliente(oCliente);
            }
            
        }

        //Método que carga los textBox cuando se encuentra el cliente buscado
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
                    btn_modificar.IsEnabled = true;
                    btn_eliminar.IsEnabled = true;
                }
            }
            else 
            {
                btn_modificar.IsEnabled = false;
                btn_eliminar.IsEnabled = false;
            }
            
            
            
        }

        private void txtDni_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        //Método que oculta los botones cuando se carga el formulario
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn_Confirmar.Visibility = Visibility.Hidden;
            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Confirmar_Modificar.Visibility = Visibility.Hidden;
            btn_Confirmar_Eliminar.Visibility = Visibility.Hidden;
        }

        //Método que elimina un cliente dependiendo del DNI
        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere eliminar el cliente?:\n" + txtDni.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                txtDni.IsEnabled = false;
                desHabilitarTXT();
                mostrarCampos();
                btn_Confirmar_Eliminar.Visibility = Visibility.Visible;
            }
        }

        //Método que modifica un cliente dependiendo de un DNI
        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el Cliente?:\n" + txtDni.Text, "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                btn_Confirmar_Modificar.Visibility = Visibility.Visible;
                txtDni.IsEnabled = false;
            }
        }

        //Método que agrega un cliente
        private void btn_Agregar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar un nuevo Cliente?", "Agregar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                limpiarCampos();
                btn_Confirmar.Visibility = Visibility.Visible;
            }
        }

        //Botones de confirmación de las operaciones (Agregar, modificar, eliminar)
        private void btn_Confirmar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDni.Text.Length >= 8 && txtNombre.Text != "" && txtApellido.Text != "" && txtEmail.Text != "" && txtTelefono.Text.Length != 0)
            {
                Boolean bandera = TrabajarCliente.validarCliente(Convert.ToInt32(txtDni.Text));

                if (bandera == false)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_DNI = Convert.ToInt32(txtDni.Text);
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Telefono = txtTelefono.Text;
                    oCliente.Cli_Email = txtEmail.Text;
                    TrabajarCliente.AgregarCliente(oCliente);
                    MessageBox.Show("¡Cliente agregado con éxito!");
                    limpiarCampos();
                    ocultarCampos();
                }
                else
                {
                    MessageBox.Show("El Cliente con DNI: " + txtDni.Text + ", ya está registrado\nIntente con otro DNI.");
                }
            }
            else 
            {
                MessageBox.Show("¡No olvide completar todos los campos!");
            }
            
            
        }

        private void btn_Confirmar_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDni.Text.Length >= 8 && txtNombre.Text != "" && txtApellido.Text != "" && txtEmail.Text != "" && txtTelefono.Text.Length != 0)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_DNI = Convert.ToInt32(txtDni.Text);
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Telefono = txtTelefono.Text;
                oCliente.Cli_Email = txtEmail.Text;
                TrabajarCliente.ModificarCliente(oCliente);
                MessageBox.Show("¡Cliente modificado con éxito!");
                ocultarCampos();
                desHabilitarTXT();
                txtDni.IsEnabled = true;
            }
            else 
            {
                MessageBox.Show("¡No olvide completar todos los campos!");
            }
            
        }

        private void btn_Confirmar_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(txtDni.Text);
            TrabajarCliente.EliminarCliente(ID);
            MessageBox.Show("¡Cliente eliminado con éxito!");
            limpiarCampos();
            ocultarCampos();
            txtDni.IsEnabled = true;
            btn_modificar.IsEnabled = false;
            btn_eliminar.IsEnabled = false;
        }

        //Conjunto de métodos que cambian el diseño del formulario
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

        //Botón que cancela cualquiera de las operaciones (Agregar, modificar, eliminar)
        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            txtDni.IsEnabled = true;
            ocultarCampos();
            desHabilitarTXT();
        }
    }
}
