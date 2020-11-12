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
using System.Text.RegularExpressions;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmSalas.xaml
    /// </summary>
    public partial class FrmSalas : Window
    {
        public FrmSalas()
        {
            InitializeComponent();
        }

        int opcion = 0;
        int cantidadBut = 0;
        int columnas = 0;
        int filas = 0;

        /// <summary>
        /// Validación de textbox para que solo se escriban números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtColumnas_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtFilas_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void txtNroSala_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        /// <summary>
        /// Variante de la cantidad de butacas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFilas_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtFilas.Text != "" && txtColumnas.Text != "")
            {
                int cantidad = Convert.ToInt32(txtColumnas.Text) * Convert.ToInt32(txtFilas.Text);

                lblCantidadButacas.Content = "Cantidad de Butacas:          " + cantidad;
            }
            else 
            {
                
                lblCantidadButacas.Content = "Cantidad de Butacas:          0" ;
            }
            
        }

        private void txtColumnas_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtFilas.Text != "" && txtColumnas.Text != "")
            {
                int cantidad = Convert.ToInt32(txtColumnas.Text) * Convert.ToInt32(txtFilas.Text);

                lblCantidadButacas.Content = "Cantidad de Butacas:          " + cantidad;
            }
            else
            {

                lblCantidadButacas.Content = "Cantidad de Butacas:          0";
            }
        }

        private void txtNroSala_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNroSala.Text != "")
            {
                int numero = Convert.ToInt32(txtNroSala.Text);
                Sala oSala = new Sala();
                oSala = TrabajarSala.traerSala(numero);
                cargarSala(oSala);
            }
            else 
            {
                cbDenominacion.Text = "";
                lblCantidadButacas.Content = "Cantidad de Butacas:          ";
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
            }
        }

        private void cargarSala(Sala oSala) 
        {
            if (oSala != null)
            {
                cbDenominacion.Text = oSala.Sala_Denominacion;
                lblCantidadButacas.Content = "Cantidad de Butacas:          " + oSala.Sala_CantButacas;
                cantidadBut = oSala.Sala_CantButacas;
                columnas = oSala.Sala_Columnas;
                filas = oSala.Sala_Filas;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
            }
            else 
            {
                cbDenominacion.Text = "";
                lblCantidadButacas.Content = "Cantidad de Butacas:          " ;
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
            }
            
        }

        private void actualizarGrilla() 
        {
            DataTable dt = TrabajarSala.traerSalas();
            grdSalas.ItemsSource = dt.DefaultView;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar la Sala?:\n" + txtNroSala.Text, "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                cbDenominacion.IsEnabled = true;
                opcion = 2;
                txtNroSala.IsEnabled = false;
                deshabilidarBotones();
            }
            
        }

        private void deshabilidarBotones() 
        {
            btnAgregar.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnConfirmar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
        }

        private void habilidarBotones()
        {
            btnAgregar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnConfirmar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            txtNroSala.IsEnabled = true;
        }

        private void habilidarBotones2()
        {
            btnAgregar.IsEnabled = true;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnConfirmar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            txtNroSala.IsEnabled = true;
        }

        private void mostrarFilasyColumnas() 
        {
            lblFilas.Visibility = Visibility.Visible;
            lblColumnas.Visibility = Visibility.Visible;
            txtColumnas.Visibility = Visibility.Visible;
            txtFilas.Visibility = Visibility.Visible;
        }

        private void noMostrarFilasyColumnas()
        {
            lblFilas.Visibility = Visibility.Hidden;
            lblColumnas.Visibility = Visibility.Hidden;
            txtColumnas.Visibility = Visibility.Hidden;
            txtFilas.Visibility = Visibility.Hidden;
            txtNroSala.IsEnabled = true;
            lblNroSala.IsEnabled = true;
            lblNroSala.Visibility = Visibility.Visible;
            txtNroSala.Visibility = Visibility.Visible;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la Sala?:\n" + txtNroSala.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                opcion = 3;
                txtNroSala.IsEnabled = false;
                deshabilidarBotones();
            }
            
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if(opcion != 0)
            {
                if (opcion == 1)
                {
                    if (txtColumnas.Text != "" && txtColumnas.Text != "0" && txtFilas.Text != "" && txtFilas.Text != "0") 
                    {
                        cantidadBut = Convert.ToInt32(txtColumnas.Text) * Convert.ToInt32(txtFilas.Text);
                        columnas = Convert.ToInt32(txtColumnas.Text);
                        filas =Convert.ToInt32(txtFilas.Text);
                        Sala oSala = new Sala();
                        oSala.Sala_Denominacion = cbDenominacion.SelectedValue.ToString();
                        if (cbDenominacion.SelectedValue.ToString().Equals("Sala 2D")) 
                        {
                            oSala.Sala_Precio = Convert.ToDecimal(200);
                        }
                        else if (cbDenominacion.SelectedValue.ToString().Equals("Sala 3D"))
                        {
                            oSala.Sala_Precio = Convert.ToDecimal(250);
                        }
                        else 
                        {
                            oSala.Sala_Precio = Convert.ToDecimal(300);
                        }
                        oSala.Sala_CantButacas = cantidadBut;
                        oSala.Sala_Columnas = columnas;
                        oSala.Sala_Filas = filas;
                        TrabajarSala.AgregarSala(oSala);
                        actualizarGrilla();
                        noMostrarFilasyColumnas();
                        lblCantidadButacas.Content = "Cantidad de Butacas:          ";
                        btnModificar.IsEnabled = false;
                        btnEliminar.IsEnabled = false;
                        btnAgregar.IsEnabled = true;
                        int numero = TrabajarSala.traerUltima();
                        crearButacas(Convert.ToInt32(txtColumnas.Text), Convert.ToInt32(txtFilas.Text),numero);
                        txtColumnas.Text = "";
                        txtFilas.Text = "";
                        MessageBox.Show("¡Sala creada con éxito!");
                        cbDenominacion.IsEnabled = false;
                        btnConfirmar.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    
                }
                else if (opcion == 2)
                {
                    Sala oSala = new Sala();
                    oSala.Sala_NroSala = Convert.ToInt32(txtNroSala.Text);
                    oSala.Sala_Denominacion = cbDenominacion.SelectedValue.ToString();
                    if (cbDenominacion.SelectedValue.ToString().Equals("Sala 2D"))
                    {
                        oSala.Sala_Precio = Convert.ToDecimal(200);
                    }
                    else if (cbDenominacion.SelectedValue.ToString().Equals("Sala 3D"))
                    {
                        oSala.Sala_Precio = Convert.ToDecimal(250);
                    }
                    else
                    {
                        oSala.Sala_Precio = Convert.ToDecimal(300);
                    }
                    oSala.Sala_CantButacas = cantidadBut;
                    oSala.Sala_Columnas = columnas;
                    oSala.Sala_Filas = filas;
                    TrabajarSala.ModificarSala(oSala);
                    actualizarGrilla();
                    MessageBox.Show("¡Sala modificada con éxito!");
                    cbDenominacion.IsEnabled = false;
                    habilidarBotones();
                }
                else 
                {
                    TrabajarSala.EliminarSala(Convert.ToInt32(txtNroSala.Text));
                    actualizarGrilla();
                    TrabajarButaca.EliminarButaca(Convert.ToInt32(txtNroSala.Text));
                    TrabajarProyeccion.EliminarProyeccionSala(Convert.ToInt32(txtNroSala.Text));
                    txtNroSala.Text = "";
                    MessageBox.Show("¡Sala eliminada con éxito!");
                    cbDenominacion.IsEnabled = false;
                    habilidarBotones2();
                } 
            }
        }

        private void crearButacas(int col, int fila, int nroSala) 
        {
            for (int i = 1; i <= fila; i++) 
            {
                for (int j = 1; j <= col; j++ )
                {
                    Butaca oButaca = new Butaca();
                    oButaca.But_Estado = "Libre";
                    oButaca.But_Nro = j;
                    oButaca.But_Fila = i;
                    oButaca.Sala_NroSala = nroSala;

                    TrabajarButaca.AgregarButaca(oButaca);
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            habilidarBotones();
            noMostrarFilasyColumnas();
            txtNroSala.Visibility = Visibility.Visible;
            lblNroSala.Visibility = Visibility.Visible;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea agregar una Sala?\n", "Agregar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                mostrarFilasyColumnas();
                opcion = 1;
                txtNroSala.Visibility = Visibility.Hidden;
                lblNroSala.Visibility = Visibility.Hidden;
                cbDenominacion.IsEnabled = true;
                txtColumnas.IsEnabled = true;
                txtFilas.IsEnabled = true;
                deshabilidarBotones();
            }
        }
    }
}
