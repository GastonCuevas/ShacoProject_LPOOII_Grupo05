using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Ticket
    {
        private int tick_Nro;

        public int Tick_Nro
        {
            get { return tick_Nro; }
            set { tick_Nro = value; }
        }
        private DateTime tick_FechaVenta;

        public DateTime Tick_FechaVenta
        {
            get { return tick_FechaVenta; }
            set { tick_FechaVenta = value; }
        }
        private int cli_DNI;

        public int Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }
        private int pro_Codigo;

        public int Pro_Codigo
        {
            get { return pro_Codigo; }
            set { pro_Codigo = value; }
        }
        private string but_Fila;

        public string But_Fila
        {
            get { return but_Fila; }
            set { but_Fila = value; }
        }
        private string but_Nro;

        public string But_Nro
        {
            get { return but_Nro; }
            set { but_Nro = value; }
        }
    }
}
