﻿using System;
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
        private string pro_Codigo;

        public string Pro_Codigo
        {
            get { return pro_Codigo; }
            set { pro_Codigo = value; }
        }
        private int but_ID;

        public int But_ID
        {
            get { return but_ID; }
            set { but_ID = value; }
        }

        private decimal tick_Precio;

        public decimal Tick_Precio
        {
            get { return tick_Precio; }
            set { tick_Precio = value; }
        }

        /*public Ticket(int numero, DateTime fecha, int dni, string pro_codigo, int butId, decimal precio) 
        {
            Tick_Nro = numero;
            Tick_FechaVenta = fecha;
            Cli_DNI = dni;
            Pro_Codigo = pro_codigo;
            butId = But_ID;
            Tick_Precio = precio;
        }*/
    }
}
