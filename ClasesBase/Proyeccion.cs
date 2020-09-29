using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private string pro_Codigo;

        public string Pro_Codigo
        {
            get { return pro_Codigo; }
            set { pro_Codigo = value; }
        }
        private DateTime pro_Fecha;

        public DateTime Pro_Fecha
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
        private int sala_NroSala;

        public int Sala_NroSala
        {
            get { return sala_NroSala; }
            set { sala_NroSala = value; }
        }
        private string pel_Codigo;

        public string Pel_Codigo
        {
            get { return pel_Codigo; }
            set { pel_Codigo = value; }
        }
    }
}
