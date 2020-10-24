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
using System.Data.SqlClient;
using System.Data;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for frmProyecciones.xaml
    /// </summary>
    public partial class frmProyecciones : Window
    {
        public frmProyecciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que agrega una proyección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            if (System.Windows.MessageBox.Show("¿Desea agregar una nueva Proyección?", "Agregar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                limpiarCampos();
                btnConfirmarAgregar.Visibility = Visibility.Visible;
            }
        }

        //Conjunto de métodos que cambian el diseño del formulario
        private void mostrarCampos()
        {
            btnCancelar.Visibility = Visibility.Visible;
            btnAgregar.Visibility = Visibility.Hidden;
            btnEliminar.Visibility = Visibility.Hidden;
            btnModificar.Visibility = Visibility.Hidden;
        }

        private void ocultarCampos()
        {
            btnConfirmarAgregar.Visibility = Visibility.Hidden;
            btnConfirmarModificar.Visibility = Visibility.Hidden;
            btnConfirmarEliminar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnAgregar.Visibility = Visibility.Visible;
            btnEliminar.Visibility = Visibility.Visible;
            btnModificar.Visibility = Visibility.Visible;
        }

        private void habilitarTXT()
        {
            txtHora.IsEnabled = true;
            cbSala.IsEnabled = true;
            cbPelicula.IsEnabled = true;
            dtpFecha.IsEnabled = true;
        }

        private void desHabilitarTXT()
        {
            txtHora.IsEnabled = false;
            cbSala.IsEnabled = false;
            cbPelicula.IsEnabled = false;
            dtpFecha.IsEnabled = false;
        }

        /// <summary>
        /// Método que modifica la proyección seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("¿Desea modificar la Proyección?:\n" + txtCodigo.Text, "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                btnConfirmarModificar.Visibility = Visibility.Visible;
                txtCodigo.IsEnabled = false;
            }
        }

        /// <summary>
        /// Método que elimina la proyección seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("¿Está seguro que quiere eliminar la Proyección?:\n" + txtCodigo.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                txtCodigo.IsEnabled = false;
                desHabilitarTXT();
                mostrarCampos();
                btnConfirmarEliminar.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Método que limpia los campos del formulario.
        /// </summary>
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Conjunto de métodos que verifican si se puede habilitar el botón de agregar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPelicula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            validar();
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Proyeccion oProyeccion = new Proyeccion();
                oProyeccion = TrabajarProyeccion.traerProyeccion(txtCodigo.Text);
                cargarProyeccion(oProyeccion);
            }
        }

        //Método que carga los campos cuando se encuentra la película buscada
        public void cargarProyeccion(Proyeccion pro)
        {
            cbPelicula.Text = "";
            cbSala.Text = "";
            txtHora.Text = "-:-";
            dtpFecha.SelectedDate = null;

            if (pro != null)
            {
                if (pro.Pro_Fecha != null)
                {
                    DataTable dt = TrabajarPelicula.traerPeliculas();
                    for(int i=0; i<dt.Rows.Count; i++)
                    {
                        if(dt.Rows[i]["PEL_Codigo"].ToString().Equals(pro.Pel_Codigo))
                        {
                            cbPelicula.Text = dt.Rows[i]["PEL_Titulo"].ToString();
                        }
                    }
                    cbSala.Text = Convert.ToString(pro.Sala_NroSala);
                    txtHora.Text = pro.Pro_Hora;
                    dtpFecha.Text = Convert.ToString(pro.Pro_Fecha);
                    btnModificar.IsEnabled = true;
                    btnEliminar.IsEnabled = true;
                }
            }
            else
            {
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
            }
        }

        /// <summary>
        /// Método que limpia los campos del formulario.
        /// </summary>
        private void limpiarCampos()
        {
            txtHora.Text = "";
            txtCodigo.Text = "";
            dtpFecha.SelectedDate = null;
            cbSala.Text = null;
            cbPelicula.Text = null;

            btnAgregar.IsEnabled = false;
        }

        //Método de validación de campos
        private void validar() 
        {
            string sala = Convert.ToString(cbSala.SelectedValue);
            string pelicula = Convert.ToString(cbPelicula.SelectedValue);
            if (txtCodigo.Text != "" && txtHora.Text != "" && sala != "" && dtpFecha.SelectedDate != null
              && pelicula != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtCodigo.IsEnabled = true;
            btnAgregar.IsEnabled = true;
            ocultarCampos();
            desHabilitarTXT();
        }

        private void btnConfirmarAgregar_Click(object sender, RoutedEventArgs e)
        {
            Proyeccion oProyeccion = new Proyeccion();
            oProyeccion.Pro_Codigo = txtCodigo.Text;
            oProyeccion.Pel_Codigo = cbPelicula.SelectedValue.ToString();
            oProyeccion.Pro_Fecha = (DateTime)dtpFecha.SelectedDate;
            oProyeccion.Pro_Hora = txtHora.Text;
            oProyeccion.Sala_NroSala = Convert.ToInt32(cbSala.Text);

            if (oProyeccion.Pro_Codigo != "" && oProyeccion.Pel_Codigo != "" && oProyeccion.Pro_Fecha != null &&
                oProyeccion.Pro_Hora != "" && oProyeccion.Sala_NroSala != 0)
            {
                if (MessageBox.Show("Código Película: " + oProyeccion.Pel_Codigo +
                    "\nCódigo Proyeccion: " + oProyeccion.Pro_Codigo + "\nFecha: "
                    + oProyeccion.Pro_Fecha + "\nHora: " + oProyeccion.Pro_Hora + "\nN° Sala: " + oProyeccion.Sala_NroSala, "¿Está seguro que desea agregar esta Proyección?",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    TrabajarProyeccion.AgregarProyeccion(oProyeccion);
                    DataTable dt = TrabajarProyeccion.traerProyecciones();
                    grdProyecciones.ItemsSource = dt.DefaultView;
                    MessageBox.Show("Proyección Incluida");
                    limpiarCampos();
                    ocultarCampos();
                }
            }
            else
            {
                MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        private void btnConfirmarModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtHora.Text != "0" && dtpFecha.Text != "" && cbPelicula.Text != "" && cbSala.Text != "")
            {
                Proyeccion oProyeccion = new Proyeccion();
                oProyeccion.Pro_Codigo = txtCodigo.Text;
                oProyeccion.Pel_Codigo = cbPelicula.SelectedValue.ToString();
                oProyeccion.Pro_Fecha = Convert.ToDateTime(dtpFecha.SelectedDate);
                oProyeccion.Pro_Hora = txtHora.Text;
                oProyeccion.Sala_NroSala = Convert.ToInt32(cbSala.Text);
                TrabajarProyeccion.ModificarProyeccion(oProyeccion);
                DataTable dt = TrabajarProyeccion.traerProyecciones();
                grdProyecciones.ItemsSource = dt.DefaultView;
                System.Windows.MessageBox.Show("¡Proyección modificada con éxito!");
                ocultarCampos();
                limpiarCampos();
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                desHabilitarTXT();
                txtCodigo.IsEnabled = true;
                btnAgregar.IsEnabled = true;
            }
            else
            {
                System.Windows.MessageBox.Show("¡No olvide completar todos los campos!");
            }
        }

        private void btnConfirmarEliminar_Click(object sender, RoutedEventArgs e)
        {
            string cod = txtCodigo.Text;
            TrabajarProyeccion.EliminarProyeccion(cod);
            DataTable dt = TrabajarProyeccion.traerProyecciones();
            grdProyecciones.ItemsSource = dt.DefaultView;
            System.Windows.MessageBox.Show("¡Proyección eliminada con éxito!");
            limpiarCampos();
            ocultarCampos();
            txtCodigo.IsEnabled = true;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnAgregar.IsEnabled = true;
        }
    }
}
