using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Butaca
    {
        private int but_Fila;

        public int But_Fila
        {
            get { return but_Fila; }
            set { but_Fila = value; }
        }
        private int but_Nro;

        public int But_Nro
        {
            get { return but_Nro; }
            set { but_Nro = value; }
        }
        private int sala_NroSala;

        public int Sala_NroSala
        {
            get { return sala_NroSala; }
            set { sala_NroSala = value; }
        }

        private string but_Estado;

        public string But_Estado
        {
            get { return but_Estado; }
            set { but_Estado = value; }
        }

        private int but_ID;

        public int But_ID
        {
            get { return but_ID; }
            set { but_ID = value; }
        }
    }
}
