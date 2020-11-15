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
//using System.Windows.Shapes;
using ClasesBase;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Reflection;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VisorProyecciones.xaml
    /// </summary>
    public partial class VisorProyecciones : Window
    {
        List<VisorPelicula> lista = new List<VisorPelicula>();
        int index = 0;
        ObservableCollection<VisorPelicula> peliculas = new ObservableCollection<VisorPelicula>();

        public VisorProyecciones()
        {
            InitializeComponent();
            peliculas = GetPeliculas();
            if (peliculas.Count > 0)
            {
                lista.Add(peliculas[0]);
                video.Source = new Uri(CreateAbsolutePathTo(peliculas[0].Trailer), UriKind.Absolute);
                ListViewProyecciones.ItemsSource = lista;
                index = 0;
            }
        }

        private ObservableCollection<VisorPelicula> GetPeliculas()
        {
            DataTable dt = TrabajarProyeccion.traerProyecciones();
            VisorPelicula oPelicula = new VisorPelicula();
            ObservableCollection<VisorPelicula> listadoPeliculas = new ObservableCollection<VisorPelicula>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                oPelicula = new VisorPelicula();
                string image = String.Empty;
                image = Convert.ToString(dt.Rows[i]["PeliculaImagen"]);
                oPelicula.Imagen = GetImageSource(CreateAbsolutePathTo(image));
                oPelicula.Titulo = (string)dt.Rows[i]["PeliculaTitulo"];
                oPelicula.Clase = (string)dt.Rows[i]["PeliculaClase"];
                oPelicula.Duracion = (string)dt.Rows[i]["PeliculaDuracion"];
                oPelicula.Genero = (string)dt.Rows[i]["PeliculaGenero"];
                oPelicula.Trailer = (string)dt.Rows[i]["PeliculaTrailer"];
                oPelicula.Sinopsis = (string)dt.Rows[i]["PeliculaSinopsis"];
                oPelicula.Pro_Codigo = (string)dt.Rows[i]["ProyeccionCodigo"];
                DateTime fecha = (DateTime)dt.Rows[i]["ProyeccionFecha"];
                oPelicula.Pro_Fecha = fecha.ToShortDateString();
                oPelicula.Pro_Hora = (string)dt.Rows[i]["ProyeccionHora"];
                oPelicula.Sala_NroSala = (int)dt.Rows[i]["ProyeccionNroSala"];
                oPelicula.Sala_Denominacion = (string)dt.Rows[i]["SalaDenominacion"];
                oPelicula.Sala_Precio = (decimal)dt.Rows[i]["SalaPrecio"];
                listadoPeliculas.Add(oPelicula);
                oPelicula = new VisorPelicula();
            }

            return listadoPeliculas;
        }

        private static string CreateAbsolutePathTo(string mediaFile)
        {
            return Path.Combine(new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName, mediaFile);
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

        //Conjunto de métodos de comportamiento de los botones para moverse por la lista
        private void btnFirts_Click(object sender, RoutedEventArgs e)
        {
            index = 0;
            lista = new List<VisorPelicula>();
            lista.Add(peliculas[index]);
            ListViewProyecciones.ItemsSource = lista;
            video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
        }

        private void btnPrevius_Click(object sender, RoutedEventArgs e)
        {
            if (index == 0)
            {
                index = (peliculas.Count - 1);
                lista = new List<VisorPelicula>();
                lista.Add(peliculas[index]);
                ListViewProyecciones.ItemsSource = lista;
                video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
            }
            else 
            {
                index = index - 1;
                lista = new List<VisorPelicula>();
                lista.Add(peliculas[index]);
                ListViewProyecciones.ItemsSource = lista;
                video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (index == (peliculas.Count - 1))
            {
                index = 0;
                lista = new List<VisorPelicula>();
                lista.Add(peliculas[index]);
                ListViewProyecciones.ItemsSource = lista;
                video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
            }
            else 
            {
                index = (index + 1);
                lista = new List<VisorPelicula>();
                lista.Add(peliculas[index]);
                ListViewProyecciones.ItemsSource = lista;
                video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
            }
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            index = (peliculas.Count - 1);
            lista = new List<VisorPelicula>();
            lista.Add(peliculas[index]);
            ListViewProyecciones.ItemsSource = lista;
            video.Source = new Uri(CreateAbsolutePathTo(peliculas[index].Trailer), UriKind.Absolute);
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            video.LoadedBehavior = MediaState.Manual;
            video.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            video.LoadedBehavior = MediaState.Manual;
            video.Pause();
        }
    }
}
