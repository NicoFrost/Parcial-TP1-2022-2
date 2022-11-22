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
    public class SqlMateria
    {
        private static SqlConnection connection; // Puente.
        private static SqlCommand command;      // Quien lleva la consulta.

        static SqlMateria()
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

        //CreacionUsuario | A Materia
        public static void InsertarMateria(Materia materia)
        {
            try
            {

                command.CommandText = $"INSERT INTO Materia VALUES ('{materia.GetNombre()}',{materia.GetProfesorAsignado()})";
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

        //CrearMateria | A Correlativa
        public static void InsertarCorrelativa(Materia materia, Materia correlativa)
        {
            try
            {

                command.CommandText = $"INSERT INTO Correlativa VALUES ({materia.GetID()},{correlativa.GetID()})";
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

        //Actualizar Materia | M Materia
        public static void ActualizarMateria(Materia materia, string columna, int dato)
        {
            try
            {
                if (dato == -1)
                {
                    command.CommandText = $"UPDATE Materia SET {columna} = NULL WHERE id = {materia.GetID()}";
                }
                else
                {
                    command.CommandText = $"UPDATE Materia SET {columna} = {dato} WHERE id = {materia.GetID()}";
                }
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
        public static void ActualizarMateria(Materia materia, string columna, string dato)
        {
            try
            {
                command.CommandText = $"UPDATE Materia SET {columna} = {dato} WHERE nombre = {materia.GetID()}";
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

        //Busqueda | Materia
        public static Materia? ObtenerMateria(string columna,int dato)
        {
            Materia? materia = new Materia();
            try
            {

                command.CommandText = $"SELECT * FROM Materia WHERE {columna} = {dato}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    materia = Materia.PasoDeInformacion(reader);
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
            return materia;
        }
        public static List<Materia>? ObtenerMaterias(string columna, int dato)
        {
            List<Materia>? materias = new ();
            try
            {

                command.CommandText = $"SELECT * FROM Materia WHERE {columna} = {dato}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = new Materia();
                    materia = Materia.PasoDeInformacion(reader);

                    materias.Add(materia);
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
            return materias;
        }
        public static Materia? ObtenerMateria(string nombreMateria)
        {
            Materia materia = new Materia();
            try
            {

                command.CommandText = $"SELECT * FROM Materia WHERE nombre = '{nombreMateria}'";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    materia = Materia.PasoDeInformacion(reader);
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
            return materia;
        }

        public static Materia? ObtenerCorrelativa(int idMateria,int idCorrelativa)
        {
            //SELECT c.*,m.nombre,m.idUserP_Asignado FROM Correlativa AS c INNER JOIN Materia AS m ON c.idCorrelativaMat = m.id 	WHERE c.idMateria = 3 
            Materia? correlativa = new Materia();
            try
            {

                command.CommandText = $"SELECT c.*,m.nombre,m.idUserP_Asignado FROM Correlativa AS c INNER JOIN Materia AS m ON c.idCorrelativaMat = m.id WHERE c.idMateria = {idMateria} AND c.idCorrelativaMat = {idCorrelativa}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    correlativa = Materia.PasoDeInformacion(reader);
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
            return correlativa;
        }

        public static List<Materia>? ObtenerTodasLasCorrelativas(int idMateria)
        { 
            List<Materia>? correlativas = new List<Materia>();
            Materia? materia = new Materia();
            try
            {

                command.CommandText = $"SELECT c.idMateria id,c.idCorrelativaMat,m.nombre,m.idUserP_Asignado FROM Correlativa AS c INNER JOIN Materia AS m ON c.idCorrelativaMat = m.id WHERE c.idMateria = {idMateria}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    materia = Materia.PasoDeInformacion(reader);
                    if(materia != null)
                    {
                        correlativas.Add(materia);
                    }
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
            return correlativas;
        }
    }
}
