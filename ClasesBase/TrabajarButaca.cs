using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarButaca
    {
        //Método que trae la lista de Butacas para el ComboBox
        public static DataTable traerButacasCB()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select BUT_Nro, BUT_Fila + ' - ' + BUT_Nro as butacas FROM Butaca order by BUT_Nro asc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return (dt);
        }

        //AGREGAR Butaca
        public static void AgregarButaca(Butaca oButaca)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Butaca(BUT_Fila,BUT_Nro,SALA_NroSala,BUT_Estado)
                                values
                                (@F,@BN,@SN,@E)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@F", oButaca.But_Fila);
            cmd.Parameters.AddWithValue("@BN", oButaca.But_Nro);
            cmd.Parameters.AddWithValue("@SN", oButaca.Sala_NroSala);
            cmd.Parameters.AddWithValue("@E", oButaca.But_Estado);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /*MODIFICAR Butaca
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
        }*/

        //ELIMINAR Butaca
        public static void EliminarButaca(int nroSala)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Butaca
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
