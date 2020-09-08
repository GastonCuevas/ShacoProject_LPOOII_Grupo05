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
    /// Interaction logic for FrmPeliculas.xaml
    /// </summary>
    public partial class FrmPeliculas : Window
    {
        public FrmPeliculas()
        {
            InitializeComponent();
        }

        private void cbgender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            Pelicula oPel = new Pelicula();
            oPel.Pel_Titulo = txttitulo.Text;
            oPel.Pel_Duracion = Convert.ToInt32(txtduracion.Text);
            oPel.Pel_Codigo = Convert.ToInt32(txtcodigo.Text);
            oPel.Pel_Genero = cbgender.SelectedItem.ToString();
            oPel.Pel_Clase = cbgender.SelectedItem.ToString();

            if (oPel.Pel_Titulo != "" && oPel.Pel_Genero != "" && oPel.Pel_Clase != "" && oPel.Pel_Codigo != 0
               && oPel.Pel_Duracion != 0)
            {
                if (MessageBox.Show("Titulo: " + oPel.Pel_Titulo +
                    ", " + "\nGenero: " + oPel.Pel_Genero + "\nClase: "
                    + oPel.Pel_Clase + "\nCodigo: " + oPel.Pel_Codigo +"\nDuracion: " + oPel.Pel_Duracion , "¿Está seguro que desea agregar esta Pelicula?", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Pelicula Incluida");
                }
            }
            else 
            {
                MessageBox.Show("¡Hay campos vacíos, complételos!");
            }
        }

        private void btnclean_Click(object sender, RoutedEventArgs e)
        {
            txttitulo.Text = "";
            txtduracion.Text = "";
            txtcodigo.Text = "";
        }

        void txtcodigo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        void txtduracion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btnmod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
