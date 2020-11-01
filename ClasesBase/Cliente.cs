using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Cliente:IDataErrorInfo
    {
        private int cli_DNI;

        public int Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private string cli_Telefono;

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }
        private string cli_Email;

        public string Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                string mensaje = string.Empty;
                //VALIDACION//
                if (columnName == "Cli_DNI")
                {
                    if (Cli_DNI.ToString().Length >= 7 && Cli_DNI.ToString().Length <=10)
                    {
                        mensaje = "Largo del DNI incorrecto";
                    }
                }

                if (columnName == "Cli_Nombre")
                {
                    if (string.IsNullOrEmpty(Cli_Nombre))
                    {
                        mensaje = "Nombre es un campo obligatorio";
                    }
                }
                if (columnName == "Cli_Apellido")
                {
                    if (string.IsNullOrEmpty(Cli_Apellido))
                    {
                        mensaje = "Apellido es un campo obligatorio";
                    }
                }
                if (columnName == "Cli_Telefono")
                {
                    if (string.IsNullOrEmpty(Cli_Telefono))
                    {
                        mensaje = "Telefono es un campo obligatorio";
                    }
                }
                if (columnName == "Cli_Email")
                {
                    if (string.IsNullOrEmpty(Cli_Email))
                    {
                        mensaje = "Email es un campo obligatorio";
                    }
                }
                return mensaje;
            }
        }
    }
}
