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
        public DataTable traerProyecciones()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM proyeccion";
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