using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;


namespace ClasesBase
{
    public class TrabajarUsuario
    {
        //Traer un usuario
        public static Usuario traerUsuario(string username)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Usuario where USU_NombreUsuario=@username";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@username", username);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Usuario oUsuario = null;
            if (reader.Read())
            {
                oUsuario = new Usuario();
                oUsuario.Usu_ApellidoNombre = (string)reader["USU_ApellidoNombre"];
                oUsuario.Usu_Contraseña = (string)reader["USU_Contraseña"];
                oUsuario.Usu_ID = (int)reader["USU_ID"];
                oUsuario.Usu_NombreUsuario = (string)reader["USU_NombreUsuario"];
                oUsuario.Rol_Codigo = (string)reader["ROL_Codigo"];
            }
            conn.Close();
            return oUsuario;
        }
        //Método que busca Clientes dependiendo de su username por stored procedure
        public static DataTable traerUsuarioSP(string username)
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerUsuariosPorNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Cración del adaptador
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //añadir un parametro de entrada
            SqlParameter param;
            param = new SqlParameter("@u ", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = username;
            da.SelectCommand.Parameters.Add(param);

            //Creación de la tabla

            DataTable dt = new DataTable();

            

            //Llenamos la tabla con los datos que necesitamos
            da.Fill(dt);

            //Retornamos la tabla cargada
            return dt;
        }
        //Detectar si usuario existe por username y contraseña
        public static bool ValidarUsuario(string u, string p)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            conn.Open();
            string ini = "SELECT USU_NombreUsuario FROM Usuario WHERE (USU_NombreUsuario=@usua AND USU_Contraseña=@contra) ";
            SqlCommand com = new SqlCommand(ini, conn);
            com.Parameters.AddWithValue("@usua", u);
            com.Parameters.AddWithValue("@contra", p);
            if (com.ExecuteScalar() != null)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }
        //pasar usuarios a observable
        public static ObservableCollection<Usuario> TraerUsuariosObservable() 
        {
            var listaUsuario = new ObservableCollection<Usuario>();
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                listaUsuario.Add(new Usuario(Convert.ToInt32(row["USU_ID"]),row["USU_NombreUsuario"].ToString(), row["USU_Contraseña"].ToString(), row["USU_ApellidoNombre"].ToString(), row["ROL_Codigo"].ToString()));
            }
            return listaUsuario;
        }

        //traer usuarios
        public static DataTable TraerUsuarios()
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable traerUsuariosSP()
        {
            //Conexión
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            //Configuración de la consulta
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "traerUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Creación de la tabla

            DataTable dt = new DataTable();

            //Cración del adaptador

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llenamos la tabla con los datos que necesitamos
            da.Fill(dt);

            //Retornamos la tabla cargada
            return dt;
        }

        //AGREGAR Usuario
        public static void AgregarUsuario(Usuario oUsuario)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Usuario(USU_ApellidoNombre,USU_Contraseña,USU_NombreUsuario,ROL_Codigo)
                                values
                                (@A,@C,@N,@Cod)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            cmd.Parameters.AddWithValue("@A", oUsuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@C", oUsuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@N", oUsuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@Cod", oUsuario.Rol_Codigo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //MODIFICAR Usuario
        public static void ModificarUsuario(Usuario oUsuario)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Usuario
                                set
                                USU_ApellidoNombre=@A,USU_Contraseña=@C,USU_NombreUsuario=@N,ROL_Codigo=@Cod
                                where
                                USU_ID=@ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", oUsuario.Usu_ID);
            cmd.Parameters.AddWithValue("@A", oUsuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@C", oUsuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@N", oUsuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@Cod", oUsuario.Rol_Codigo);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //ELIMINAR Usuario
        public static void EliminarUsuario(int ID)
        {
            SqlConnection conn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Usuario
                                where
                                USU_ID=@ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@ID", ID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
