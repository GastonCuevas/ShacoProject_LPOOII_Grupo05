using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private string pel_Codigo;

        public string Pel_Codigo
        {
            get { return pel_Codigo; }
            set { pel_Codigo = value; }
        }
        private string pel_Titulo;

        public string Pel_Titulo
        {
            get { return pel_Titulo; }
            set { pel_Titulo = value; }
        }
        private string pel_Duracion;

        public string Pel_Duracion
        {
            get { return pel_Duracion; }
            set { pel_Duracion = value; }
        }
        private string pel_Genero;

        public string Pel_Genero
        {
            get { return pel_Genero; }
            set { pel_Genero = value; }
        }
        private string pel_Clase;

        public string Pel_Clase
        {
            get { return pel_Clase; }
            set { pel_Clase = value; }
        }

        private string pel_Imagen;

        public string Pel_Imagen
        {
            get { return pel_Imagen; }
            set { pel_Imagen = value; }
        }

        private string pel_trailer;

        public string Pel_trailer
        {
            get { return pel_trailer; }
            set { pel_trailer = value; }
        }

        private string pel_Sinopsis;

        public string Pel_Sinopsis
        {
            get { return pel_Sinopsis; }
            set { pel_Sinopsis = value; }
        }
    }
}
