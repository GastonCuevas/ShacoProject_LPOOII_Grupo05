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
using System.Data.SqlClient;
using System.Data;

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
            if (System.Windows.MessageBox.Show("¿Desea agregar una nueva Película?", "Agregar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                limpiarCampos();
                btnConfirmarAgregar.Visibility = Visibility.Visible;
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
            if (System.Windows.MessageBox.Show("¿Desea modificar la Película?:\n" + txtTitulo.Text, "Modificar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                habilitarTXT();
                mostrarCampos();
                btnConfirmarModificar.Visibility = Visibility.Visible;
                txtCodigo.IsEnabled = false;
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
            txtTitulo.IsEnabled = true;
            cbGenero.IsEnabled = true;
            cbClase.IsEnabled = true;
            txtDuracion.IsEnabled = true;
            btnCargar.IsEnabled = true;
        }

        private void desHabilitarTXT()
        {
            txtTitulo.IsEnabled = false;
            txtDuracion.IsEnabled = false;
            cbClase.IsEnabled = false;
            cbGenero.IsEnabled = false;
            btnCargar.IsEnabled = true;
        }

        /// <summary>
        /// Método que elimina la película seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("¿Está seguro que quiere eliminar la Película?:\n" + txtTitulo.Text, "Eliminar", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
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
        private void limpiarCampos() 
        {
            txtTitulo.Text = "";
            txtDuracion.Text = "";
            txtCodigo.Text = "";
            cbGenero.Text = null;
            cbClase.Text = null;
            imgVistaPrevia.Source = null;
        }

        /// <summary>
        /// Método que busca la película por el código
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula = TrabajarPelicula.traerPelicula(txtCodigo.Text);
                cargarPelicula(oPelicula);
            }
        }

        //Método que carga los campos cuando se encuentra la película buscada
        public void cargarPelicula(Pelicula peli)
        {
            txtTitulo.Text = "";
            cbGenero.SelectedIndex = 0;
            txtDuracion.Text = "0";
            cbClase.SelectedIndex = 0;
            imgVistaPrevia.Source = null;
            if (peli != null)
            {
                if (peli.Pel_Titulo != null)
                {
                    txtTitulo.Text = peli.Pel_Titulo;
                    cbGenero.SelectedValue = peli.Pel_Genero;
                    txtDuracion.Text = peli.Pel_Duracion;
                    cbClase.SelectedValue = peli.Pel_Clase;
                    imgVistaPrevia.Source = GetImageSource(peli.Pel_Imagen);
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

        //Botones de Confirmación de operaciones
        private void btnConfirmarModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtDuracion.Text != "0" && txtTitulo.Text != "" && cbGenero.Text != "" && cbClase.Text != "" && imgVistaPrevia.Source != null)
            {
                Pelicula oPelicula = new Pelicula();
                oPelicula.Pel_Codigo = txtCodigo.Text;
                oPelicula.Pel_Titulo = txtTitulo.Text;
                oPelicula.Pel_Duracion = txtDuracion.Text;
                oPelicula.Pel_Genero = cbGenero.Text;
                oPelicula.Pel_Clase = cbClase.Text;
                oPelicula.Pel_Imagen = Convert.ToString(imgVistaPrevia.Source);
                TrabajarPelicula.ModificarPelicula(oPelicula);
                DataTable dt = TrabajarPelicula.traerPeliculas();
                grdPeliculas.ItemsSource = dt.DefaultView;
                System.Windows.MessageBox.Show("¡Pelicula modificada con éxito!");
                ocultarCampos();
                limpiarCampos();
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                desHabilitarTXT();
                txtCodigo.IsEnabled = true;
            }
            else
            {
                System.Windows.MessageBox.Show("¡No olvide completar todos los campos!");
            }
        }

        private void btnConfirmarEliminar_Click(object sender, RoutedEventArgs e)
        {
            string cod = txtCodigo.Text;
            TrabajarPelicula.EliminarPelicula(cod);
            DataTable dt = TrabajarPelicula.traerPeliculas();
            grdPeliculas.ItemsSource = dt.DefaultView;
            System.Windows.MessageBox.Show("¡Película eliminada con éxito!");
            limpiarCampos();
            ocultarCampos();
            txtCodigo.IsEnabled = true;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtCodigo.IsEnabled = true;
            btnCargar.IsEnabled = false;
            btnAgregar.IsEnabled = true;
            ocultarCampos();
            desHabilitarTXT();
        }

        private void btnConfirmarAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtTitulo.Text != "" && cbGenero.Text != "" && cbClase.Text != "" && txtCodigo.Text != ""
               && txtDuracion.Text != "")
            {
                Pelicula oPel = new Pelicula();
                oPel.Pel_Titulo = txtTitulo.Text;
                oPel.Pel_Duracion = txtDuracion.Text;
                oPel.Pel_Codigo = txtCodigo.Text;
                oPel.Pel_Genero = cbGenero.Text;
                oPel.Pel_Clase = cbClase.Text;
                oPel.Pel_Imagen = imgVistaPrevia.Source.ToString();

                Boolean bandera = TrabajarPelicula.validarPelicula(txtCodigo.Text);

                if (bandera == false)
                {
                    if (System.Windows.MessageBox.Show("Titulo: " + oPel.Pel_Titulo +
                    ", " + "\nGenero: " + oPel.Pel_Genero + "\nClase: "
                    + oPel.Pel_Clase + "\nCodigo: " + oPel.Pel_Codigo + "\nDuracion: " + oPel.Pel_Duracion, "¿Está seguro que desea agregar esta Pelicula?",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        TrabajarPelicula.AgregarPelicula(oPel);

                        DataTable dt = TrabajarPelicula.traerPeliculas();
                        grdPeliculas.ItemsSource = dt.DefaultView;

                        System.Windows.MessageBox.Show("Pelicula Incluida");
                        limpiarCampos();
                        ocultarCampos();
                        desHabilitarTXT();
                        btnModificar.IsEnabled = false;
                        btnEliminar.IsEnabled = false;
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }
    }
}
