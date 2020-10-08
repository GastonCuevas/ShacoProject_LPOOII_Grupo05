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
using System.Windows.Forms;
using ClasesBase;
using System.Text.RegularExpressions;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmPeliculas.xaml
    /// </summary>
    public partial class FrmPeliculas : Window
    {
        public FrmPeliculas()
        {
            InitializeComponent();
        }

        public OpenFileDialog oOpenFileDialogImagen = new OpenFileDialog(); 

        /// <summary>
        /// Método que agrega una película
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Pelicula oPel = new Pelicula();
            oPel.Pel_Titulo = txtTitulo.Text;
            oPel.Pel_Duracion = txtDuracion.Text;
            oPel.Pel_Codigo = txtCodigo.Text;
            oPel.Pel_Genero = cbGenero.Text;
            oPel.Pel_Clase = cbClase.Text;
            oPel.Pel_Imagen = imgVistaPrevia.Source.ToString();

            if (oPel.Pel_Titulo != "" && oPel.Pel_Genero != "" && oPel.Pel_Clase != "" && oPel.Pel_Codigo != ""
               && oPel.Pel_Duracion != "")
            {
                if (System.Windows.MessageBox.Show("Titulo: " + oPel.Pel_Titulo +
                    ", " + "\nGenero: " + oPel.Pel_Genero + "\nClase: "
                    + oPel.Pel_Clase + "\nCodigo: " + oPel.Pel_Codigo +"\nDuracion: " + oPel.Pel_Duracion , "¿Está seguro que desea agregar esta Pelicula?", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    System.Windows.MessageBox.Show("Pelicula Incluida");
                    limpiarCampos();
                }
            }
            else 
            {
                System.Windows.MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        /// <summary>
        /// Método que llama al método de limpiar campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Método que valida que solo se pueden ingresar números al textbox de código.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtCodigo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        /// <summary>
        /// Método que valida que solo se pueden ingresar números al textbox de duración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtDuracion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        /// <summary>
        /// Método que modifica la película seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Método que elimina la película seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Método que limpia los campos del formulario.
        /// </summary>
        private void limpiarCampos() 
        {
            txtTitulo.Text = "";
            txtDuracion.Text = "";
            txtCodigo.Text = "";
            cbGenero.Text = null;
            cbClase.Text = null;
            imgVistaPrevia.Source = null;
            btnAgregar.IsEnabled = false;
        }

        /// <summary>
        /// Conjunto de métodos que verifican si se puede habilitar el botón de agregar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtDuracion.Text != "" && cbClase.SelectedValue != ""
              && cbGenero.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtDuracion.Text != "" && cbClase.SelectedValue != ""
              && cbGenero.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void txtDuracion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtDuracion.Text != "" && cbClase.SelectedValue != ""
              && cbGenero.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void cbClase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtDuracion.Text != "" && cbClase.SelectedValue != ""
              && cbGenero.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        private void cbGenero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtDuracion.Text != "" && cbClase.SelectedValue != ""
              && cbGenero.SelectedValue != "")
            {
                btnAgregar.IsEnabled = true;
            }
        }

        //Este método carga la imagen de la película
        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Agregamos algunas validaciones como el tipo de archivos que se puede seleccionar
                oOpenFileDialogImagen.Filter = "Image Files (*.bmp;*.png;*.jpg;)|*.bmp;*.png;*.jpg";
                oOpenFileDialogImagen.Multiselect = false;
                oOpenFileDialogImagen.RestoreDirectory = true;

                oOpenFileDialogImagen.ShowDialog();
                
                if (this.oOpenFileDialogImagen.FileName.Equals("") == false)
                {
                    imgVistaPrevia.Source = GetImageSource(oOpenFileDialogImagen.FileName);
                }
            }
            catch (Exception ex) 
            {
                System.Windows.MessageBox.Show("No se puede cargar esta imagen: " + ex.ToString());
            }
        }

        //Método que convierte en BitMap el directorio de la imagen seleccionada de dialog para poder usarlo como source en la imagen
        public ImageSource GetImageSource(string filename)
        {
            string _fileName = filename;

            BitmapImage glowIcon = new BitmapImage();

            glowIcon.BeginInit();
            glowIcon.UriSource = new Uri(_fileName);
            glowIcon.EndInit();

            return glowIcon;
        }

        private void grdPeliculas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
