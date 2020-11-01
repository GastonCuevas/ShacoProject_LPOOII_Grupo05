using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarTicket
    {

        //Método que trae todos los tickets de la base de datos 
        public static DataTable traerTickets()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Ticket";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        //AGREGAR Ticket
        public static void AgregarTicket(Ticket oTicket)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Ticket(TICK_FechaVenta,PRO_Codigo,CLI_DNI,BUT_ID,TICK_Precio)
                                values
                                (@F,@C,@DNI,@butID,@p)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@F", oTicket.Tick_FechaVenta);
            cmd.Parameters.AddWithValue("@C", oTicket.Pro_Codigo);
            cmd.Parameters.AddWithValue("@DNI", oTicket.Cli_DNI);
            cmd.Parameters.AddWithValue("@p", oTicket.Tick_Precio);
            cmd.Parameters.AddWithValue("@butID", oTicket.But_ID);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Método que trae los tickets segun proyeccion
        public static DataTable traerTicketsProyeccion(string codigo)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Ticket where PRO_Codigo = @cod";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
