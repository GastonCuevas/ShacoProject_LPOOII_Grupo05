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
            Proyeccion oProyeccion = new Proyeccion();
            oProyeccion.Pro_Codigo = txtCodigo.Text;
            oProyeccion.Pel_Codigo = cbPelicula.Text;
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
                    MessageBox.Show("Proyección Incluida");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        /// <summary>
        /// Método que modifica la proyección seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Método que elimina la proyección seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

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
            if (txtCodigo.Text != "" && txtHora.Text != "" && cbSala.SelectedValue != "" && dtpFecha.SelectedDate != null
              && cbPelicula.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtHora.Text != "" && cbSala.SelectedValue != "" && dtpFecha.SelectedDate != null
              && cbPelicula.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void dtpFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtHora.Text != "" && cbSala.SelectedValue != "" && dtpFecha.SelectedDate != null
              && cbPelicula.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtHora_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtHora.Text != "" && cbSala.SelectedValue != "" && dtpFecha.SelectedDate != null
              && cbPelicula.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void cbSala_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtHora.Text != "" && cbSala.SelectedValue != "" && dtpFecha.SelectedDate != null
              && cbPelicula.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
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
    }
}
