using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarSala
    {
        public static DataTable traerSalas()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM sala";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        public static int traerUltima()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TOP 1 * FROM Sala ORDER BY SALA_NroSala DESC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();

            DataRow fila = dt.Rows[0];
            int numero = Convert.ToInt32(fila["SALA_NroSala"].ToString());

            return numero;
        }

        //Método que busca una Sala dependiendo de su ID
        public static Sala traerSala(int id)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Sala where SALA_NroSala=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Sala oSala = null;
            if (reader.Read())
            {
                oSala = new Sala();
                oSala.Sala_NroSala = reader.GetInt32(reader.GetOrdinal("SALA_NroSala"));
                oSala.Sala_Denominacion = reader.GetString(reader.GetOrdinal("SALA_Denominacion"));
                oSala.Sala_CantButacas = reader.GetInt32(reader.GetOrdinal("SALA_CantButacas"));
                oSala.Sala_Columnas = reader.GetInt32(reader.GetOrdinal("SALA_Columnas"));
                oSala.Sala_Filas = reader.GetInt32(reader.GetOrdinal("SALA_Filas"));
                oSala.Sala_Precio = reader.GetDecimal(reader.GetOrdinal("SALA_Precio"));
            }
            conn.Close();
            return oSala;
        }

        //AGREGAR Sala
        public static void AgregarSala(Sala oSala)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Sala(SALA_CantButacas,SALA_Denominacion,SALA_Columnas,SALA_Filas,SALA_Precio)
                                values
                                (@b,@d,@c,@f,@p)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@b", oSala.Sala_CantButacas);
            cmd.Parameters.AddWithValue("@d", oSala.Sala_Denominacion);
            cmd.Parameters.AddWithValue("@c", oSala.Sala_Columnas);
            cmd.Parameters.AddWithValue("@f", oSala.Sala_Filas);
            cmd.Parameters.AddWithValue("@p", oSala.Sala_Precio);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //MODIFICAR Sala
        public static void ModificarSala(Sala oSala)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Sala
                                set
                                SALA_CantButacas=@b,SALA_Denominacion=@d,SALA_Columnas=@c,SALA_Filas=@f,SALA_Precio=@p
                                where
                                SALA_NroSala=@nro";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nro", oSala.Sala_NroSala);
            cmd.Parameters.AddWithValue("@b", oSala.Sala_CantButacas);
            cmd.Parameters.AddWithValue("@d", oSala.Sala_Denominacion);
            cmd.Parameters.AddWithValue("@c", oSala.Sala_Columnas);
            cmd.Parameters.AddWithValue("@f", oSala.Sala_Filas);
            cmd.Parameters.AddWithValue("@p", oSala.Sala_Precio);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //ELIMINAR Sala
        public static void EliminarSala(int nro)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Sala
                                where
                                SALA_NroSala=@nro";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nro", nro);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
