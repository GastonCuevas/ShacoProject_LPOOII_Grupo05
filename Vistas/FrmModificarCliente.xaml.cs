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
            if (cli != null)
            {
                if (cli.Cli_Apellido != null)
                {
                    txtApellido.Text = cli.Cli_Apellido;
                    txtNombre.Text = cli.Cli_Nombre;
                }
            }
            
            
            
        }

        private void txtDni_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

    }
}
