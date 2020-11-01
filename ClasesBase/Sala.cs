using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Sala
    {
        private int sala_NroSala;

        public int Sala_NroSala
        {
            get { return sala_NroSala; }
            set { sala_NroSala = value; }
        }
        private int sala_CantButacas;

        public int Sala_CantButacas
        {
            get { return sala_CantButacas; }
            set { sala_CantButacas = value; }
        }

        private string sala_Denominacion;

        public string Sala_Denominacion
        {
            get { return sala_Denominacion; }
            set { sala_Denominacion = value; }
        }
        private int sala_Columnas;

        public int Sala_Columnas
        {
            get { return sala_Columnas; }
            set { sala_Columnas = value; }
        }
        private int sala_Filas;

        public int Sala_Filas
        {
            get { return sala_Filas; }
            set { sala_Filas = value; }
        }

        private decimal sala_Precio;

        public decimal Sala_Precio
        {
            get { return sala_Precio; }
            set { sala_Precio = value; }
        }
    }
}
