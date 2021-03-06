﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProyeccion
    {
        public static DataTable traerProyecciones()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM vistaProyeccion";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        public static DataTable traerProyeccionesSemana()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM vistaProyeccion where ProyeccionFecha between getdate() and (getdate()+7)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        public static DataTable traerProyeccionesEntreDosFechas(DateTime fecha1, DateTime fecha2)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM vistaProyeccion where ProyeccionFecha between @fecha1 and @fecha2";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@fecha1", fecha1);
            cmd.Parameters.AddWithValue("@fecha2", fecha2);

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        /// <summary>
        /// Método que trae las proyecciones de la tabla Proyección según nombre de película
        /// </summary>
        /// <param name="nombre"></param>
        public static DataTable buscarProyecciones(String nombre)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configuración de la consulta - Update con parametros
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerProyeccionesNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Configuración de los parametros
            cmd.Parameters.AddWithValue("@nombre", nombre);

            //Creación de la tabla

            DataTable dt = new DataTable();

            //Cración del adaptador

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            //Llenamos la tabla con los datos que necesitamos
            da.Fill(dt);

            //Retornamos la tabla cargada
            return dt;
        }

        public static DataTable traerProyeccionesCB()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select PRO_Codigo, PEL_Codigo + ' - ' + PRO_Hora + 'hs' as datos FROM proyeccion order by PRO_Hora asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        //AGREGAR Proyeccción
        public static void AgregarProyeccion(Proyeccion oProyeccion)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Proyeccion(PRO_Codigo,PEL_Codigo,Pro_Fecha,PRO_Hora,SALA_NroSala)
                                values
                                (@codigo,@pc,@f,@h,@n)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@codigo", oProyeccion.Pro_Codigo);
            cmd.Parameters.AddWithValue("@pc", oProyeccion.Pel_Codigo);
            cmd.Parameters.AddWithValue("@f", oProyeccion.Pro_Fecha);
            cmd.Parameters.AddWithValue("@h", oProyeccion.Pro_Hora);
            cmd.Parameters.AddWithValue("@n", oProyeccion.Sala_NroSala);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Método que busca una Proyección dependiendo de su código
        public static Proyeccion traerProyeccion(String codigo)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Proyeccion where pro_codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Proyeccion oProyeccion = null;
            if (reader.Read())
            {
                oProyeccion = new Proyeccion();
                oProyeccion.Pro_Codigo = (string)reader["pro_codigo"];
                oProyeccion.Pel_Codigo = (string)reader["pel_codigo"];
                oProyeccion.Pro_Fecha = (DateTime)reader["pro_fecha"];
                oProyeccion.Pro_Hora = (string)reader["pro_hora"];
                oProyeccion.Sala_NroSala = (int)reader["sala_nrosala"];
            }
            conn.Close();
            return oProyeccion;
        }

        //MODIFICAR Proyección
        public static void ModificarProyeccion(Proyeccion oProyeccion)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Proyeccion
                                set
                                PRO_Codigo=@codigo,PEL_Codigo=@C,PRO_Hora=@H,PRO_Fecha=@F,SALA_NroSala=@S
                                where
                                PRO_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", oProyeccion.Pro_Codigo);
            cmd.Parameters.AddWithValue("@C", oProyeccion.Pel_Codigo);
            cmd.Parameters.AddWithValue("@H", oProyeccion.Pro_Hora);
            cmd.Parameters.AddWithValue("@F", oProyeccion.Pro_Fecha);
            cmd.Parameters.AddWithValue("@S", oProyeccion.Sala_NroSala);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //ELIMINAR Proyección
        public static void EliminarProyeccion(string codigo)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Proyeccion
                                where
                                PRO_Codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //ELIMINAR Proyección según la sala
        public static void EliminarProyeccionSala(int nroSala)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Proyeccion
                                where
                                SALA_NroSala=@nroSala";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nroSala", nroSala);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
