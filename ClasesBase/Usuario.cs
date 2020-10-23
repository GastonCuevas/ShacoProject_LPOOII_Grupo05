using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClasesBase
{
    public class Usuario : INotifyPropertyChanged
    {
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; Notificador(Usu_NombreUsuario); }
        }
        private string usu_Contraseña;

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; Notificador(Usu_Contraseña); }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private string rol_Codigo;

        public string Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario(){}

        public Usuario(int ID, string nombreUsuario, string contraseña, string apellidoNombre, string codigo) 
        {
            Usu_ID = ID;
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contraseña = contraseña;
            Usu_ApellidoNombre = apellidoNombre;
            Rol_Codigo = codigo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Notificador(string prop) 
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
