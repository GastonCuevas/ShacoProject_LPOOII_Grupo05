using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private int pro_Codigo;

        public int Pro_Codigo
        {
            get { return pro_Codigo; }
            set { pro_Codigo = value; }
        }
        private string pro_Fecha;

        public string Pro_Fecha
        {
            get { return pro_Fecha; }
            set { pro_Fecha = value; }
        }
        private string pro_Hora;

        public string Pro_Hora
        {
            get { return pro_Hora; }
            set { pro_Hora = value; }
        }
        private string pro_NroSala;

        public string Pro_NroSala
        {
            get { return pro_NroSala; }
            set { pro_NroSala = value; }
        }
        private string pel_Codigo;

        public string Pel_Codigo
        {
            get { return pel_Codigo; }
            set { pel_Codigo = value; }
        }
    }
}
