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
            cmd.CommandText = @"insert into Ticket(TICK_FechaVenta,PRO_Codigo,CLI_DNI,BUT_nro,BUT_Fila)
                                values
                                (@F,@C,@DNI,@Nro,@Fila)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@F", oTicket.Tick_FechaVenta);
            cmd.Parameters.AddWithValue("@C", oTicket.Pro_Codigo);
            cmd.Parameters.AddWithValue("@DNI", oTicket.Cli_DNI);
            //cmd.Parameters.AddWithValue("@Nro", oTicket.But_Nro);
            cmd.Parameters.AddWithValue("@Fila", oTicket.But_ID);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
