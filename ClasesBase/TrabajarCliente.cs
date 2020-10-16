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
                oCliente.Cli_Telefono = (string)reader["cli_Telefono"];
                oCliente.Cli_Email = (string)reader["cli_Email"];
            }
            conn.Close();
            return oCliente;
        }
        public DataTable traerClientes()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //AGREGAR Cliente
        public static void AgregarCliente(Cliente oCliente)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Cliente(CLI_DNI,CLI_Nombre,CLI_Apellido,CLI_Telefono,CLI_Email)
                                values
                                (@DNI,@N,@A,@T,@E)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@N", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@A", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@T", oCliente.Cli_Telefono);
            cmd.Parameters.AddWithValue("@E", oCliente.Cli_Email);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //MODIFICAR Cliente
        public static void ModificarCliente(Cliente oCliente)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Cliente
                                set
                                CLI_DNI=@DNI,CLI_Nombre=@N,CLI_Apellido=@A,CLI_Email=@E,CLI_Telefono=@T
                                where
                                CLI_DNI=@DNI";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@DNI", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@N", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@A", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@E", oCliente.Cli_Email);
            cmd.Parameters.AddWithValue("@T", oCliente.Cli_Telefono);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //ELIMINAR Cliente
        public static void EliminarCliente(int ID)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Cliente
                                where
                                CLI_DNI=@DNI";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@DNI", ID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}