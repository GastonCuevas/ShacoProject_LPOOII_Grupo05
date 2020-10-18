using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPelicula
    {
        //Método que trae todas las películas de la base de datos
        public DataTable traerPeliculas() 
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM pelicula";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        //Método que busca un Cliente dependiendo de su DNI
        public static Pelicula traerPelicula(String codigo)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Pelicula where pel_codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Pelicula oPelicula = null;
            if (reader.Read())
            {
                oPelicula = new Pelicula();
                oPelicula.Pel_Codigo = (string)reader["pel_codigo"];
                oPelicula.Pel_Titulo = (string)reader["pel_titulo"];
                oPelicula.Pel_Genero = (string)reader["pel_genero"];
                oPelicula.Pel_Duracion = (string)reader["pel_duracion"];
                oPelicula.Pel_Clase = (string)reader["pel_clase"];
                oPelicula.Pel_Imagen = (string)reader["pel_imagen"];
            }
            conn.Close();
            return oPelicula;
        }

        //Método que valida si la Película ya está registrada
        public static Boolean validarPelicula(string cod)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" select PEL_Codigo " + "From Pelicula";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            Boolean bandera = false;

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["PEL_Codigo"].Equals(cod))
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

        //AGREGAR Película
        public static void AgregarPelicula(Pelicula oPelicula)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Pelicula(PEL_Codigo,PEL_Titulo,PEL_Duracion,PEL_Clase,PEL_Genero,PEL_Imagen)
                                values
                                (@codigo,@T,@D,@C,@G,@I)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@codigo", oPelicula.Pel_Codigo);
            cmd.Parameters.AddWithValue("@T", oPelicula.Pel_Titulo);
            cmd.Parameters.AddWithValue("@D", oPelicula.Pel_Duracion);
            cmd.Parameters.AddWithValue("@C", oPelicula.Pel_Clase);
            cmd.Parameters.AddWithValue("@G", oPelicula.Pel_Genero);
            cmd.Parameters.AddWithValue("@I", oPelicula.Pel_Imagen);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //MODIFICAR Película
        public static void ModificarPelicula(Pelicula oPelicula)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Pelicula
                                set
                                PEL_Codigo=@codigo,PEL_Titulo=@T,PEL_Duracion=@D,PEL_Clase=@C,PEL_Genero=@G,PEL_Imagen=@I
                                where
                                PEL_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", oPelicula.Pel_Codigo);
            cmd.Parameters.AddWithValue("@D", oPelicula.Pel_Duracion);
            cmd.Parameters.AddWithValue("@C", oPelicula.Pel_Clase);
            cmd.Parameters.AddWithValue("@G", oPelicula.Pel_Genero);
            cmd.Parameters.AddWithValue("@I", oPelicula.Pel_Imagen);
            cmd.Parameters.AddWithValue("@T", oPelicula.Pel_Titulo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //ELIMINAR Película
        public static void EliminarPelicula(string codigo)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Pelicula
                                where
                                PEL_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
