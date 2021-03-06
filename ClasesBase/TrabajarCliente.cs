﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        //Método que busca un Cliente dependiendo de su DNI
        public static Cliente traerCliente(int dni)
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
                oCliente.Cli_DNI = reader.GetInt32(reader.GetOrdinal("cli_dni"));
                oCliente.Cli_Nombre = reader.GetString(reader.GetOrdinal("cli_nombre"));
                oCliente.Cli_Apellido = reader.GetString(reader.GetOrdinal("cli_apellido"));
                oCliente.Cli_Telefono = reader.GetString(reader.GetOrdinal("cli_telefono"));
                oCliente.Cli_Email = reader.GetString(reader.GetOrdinal("cli_email"));
            }
            conn.Close();
            return oCliente;
        }

        //Método que valida si el Cliente ya está registrado
        public static Boolean validarCliente(int dni)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select cli_dni " + "From Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            Boolean bandera = false;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["cli_dni"].Equals(dni))
                    {
                        bandera = true;
                    }
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                string error = ex.Message;
                bandera = false;
            }
            finally
            {
                conn.Close();
            }

            return bandera;
        }

        //Método que trae todos los clientes de la base de datos 
        public static DataTable traerClientes()
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

        //Método que trae la lista de Clientes para el ComboBox
        public static DataTable traerClientesCB()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select CLI_DNI, CLI_Apellido + ', ' + CLI_Nombre as datos FROM Cliente order by CLI_Apellido asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

    }
}