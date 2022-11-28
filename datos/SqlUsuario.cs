using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{

    public class SqlUsuario
    {
        private static SqlConnection connection; // Puente.
        private static SqlCommand command;      // Quien lleva la consulta.


        static SqlUsuario()
        {
            connection = new SqlConnection(@"
                Data Source = DESKTOP-HD6ABJ7;
                Database = Universidad;
                Trusted_Connection = True;
            ");

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        //global | Usuario
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                command.CommandText = $"SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id WHERE u.id = {id}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuario = Usuario.PasoDeInformacion(reader);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            return usuario;
        }
        public static Usuario? ObtenerUsuario(string nombre)
        {
            Usuario? usuario = new Usuario();
            try
            {

                command.CommandText = $"SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id WHERE u.nombre = '{nombre}'";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuario = Usuario.PasoDeInformacion(reader);
                }
            }
            catch (SqlException)
            {
                usuario = null;
                
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            return usuario;
        }

        //Activo | Usuario
        public static Usuario? ObtenerUsuarioActivo()
        {
            Usuario? usuario = null;
            try
            {
                command.CommandText = $"SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id WHERE activo = 1";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuario = Usuario.PasoDeInformacion(reader);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            return usuario;
        }

        //Inicio - Main | Inicio Secion Usuario
        public static void ActualizarUsuario(Usuario usuario, string columna, int dato)
        {
            try
            {
                command.CommandText = $"UPDATE Usuario SET {columna} = {dato} WHERE id = {usuario.GetID()}";
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        //CreacionUsuario | A Usuario
        public static void InsertarUsuario(Usuario usuario)
        {
            try
            {
                //si llegas cambia esto!! permisos en vez de nombre pasalos a numeros 0 admin, 1 profe, 2 alumno
                int permiso = 2;
                switch (usuario.GetPerfil())
                {
                    case "Admin":
                        permiso = 0;
                        break;
                    case "Profesor":
                        permiso = 1;
                        break;
                    case "Alumno":
                        permiso = 2;
                        break;
                }
                command.CommandText = $"INSERT INTO Usuario VALUES ('{usuario.GetNombre()}','{usuario.GetPassword()}',{permiso},0)";
                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        //CreacionUsuario | M Usuario
        public static void ActualizarUsuario(Usuario usuario, string columna, string dato)
        {
            try
            {
                command.CommandText = $"UPDATE Usuario SET {columna} = '{dato}' WHERE = id = {usuario.GetID()}";
                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }
    }
}
