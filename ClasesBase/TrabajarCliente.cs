using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public Cliente traerCliente(int dni)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Cliente where cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@dni", dni);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Cliente oCliente = null;
            if (reader.Read())
            {
                oCliente = new Cliente();
                oCliente.Cli_DNI = (int)reader["cli_dni"];
                oCliente.Cli_Nombre = (string)reader["cli_nombre"];
                oCliente.Cli_Apellido = (string)reader["cli_apellido"];
            }
            conn.Close();
            return oCliente;
        }
    }
}