using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;


namespace ClasesBase
{
    public class TrabajarUsuario
    {

        public ObservableCollection<Usuario> TraerUsuarios() 
        {
            ObservableCollection<Usuario> listaUsuario = new ObservableCollection<Usuario>();

            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //da.Fill(listaUsuario);

            return listaUsuario;    
        }

    }
}
