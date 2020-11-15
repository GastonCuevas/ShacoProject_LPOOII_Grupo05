using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vistas
{
    class VisorPelicula
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
            }
        }

        private System.Windows.Media.ImageSource imagen;
        public System.Windows.Media.ImageSource Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
            }
        }

        private string clase;
        public string Clase
        {
            get { return clase; }
            set
            {
                clase = value;
            }
        }

        private string duracion;
        public string Duracion
        {
            get { return duracion; }
            set
            {
                duracion = value;
            }
        }

        private string genero;
        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
            }
        }

        private string trailer;
        public string Trailer
        {
            get { return trailer; }
            set
            {
                trailer = value;
            }
        }

        private string sinopsis;
        public string Sinopsis
        {
            get { return sinopsis; }
            set
            {
                sinopsis = value;
            }
        }

        private string pro_Codigo;
        public string Pro_Codigo
        {
            get { return pro_Codigo; }
            set
            {
                pro_Codigo = value;
            }
        }

        private string pro_Fecha;
        public string Pro_Fecha
        {
            get { return pro_Fecha; }
            set
            {
                pro_Fecha = value;
            }
        }

        private string pro_Hora;
        public string Pro_Hora
        {
            get { return pro_Hora; }
            set
            {
                pro_Hora = value;
            }
        }

        private int sala_NroSala;
        public int Sala_NroSala
        {
            get { return sala_NroSala; }
            set
            {
                sala_NroSala = value;
            }
        }

        private string sala_Denominacion;
        public string Sala_Denominacion
        {
            get { return sala_Denominacion; }
            set
            {
                sala_Denominacion = value;
            }
        }

        private decimal sala_Precio;
        public decimal Sala_Precio
        {
            get { return sala_Precio; }
            set
            {
                sala_Precio = value;
            }
        }
    }
}
