using Entidades;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace datos
{
    public class SqlAlumnos
    {
        private static SqlConnection connection; // Puente.
        private static SqlCommand command;      // Quien lleva la consulta.


        static SqlAlumnos()
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

        //global | Alumno
        public static Alumno? ObtenerAlumno(int id)
        {
            Alumno? alumno = new Alumno();
            Usuario usuario = SqlUsuario.ObtenerUsuario(id);
            try
            {
                command.CommandText = $"SELECT * FROM UsuarioAlumno WHERE id = '{id}'";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    alumno = Alumno.PasoDeInformacionAlumno(reader, usuario);
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
            return alumno;
        }
        public static Alumno? ObtenerAlumno(string nombre, int IDmateria)
        {
            Alumno? alumno = new Alumno();
            Usuario? usuario = SqlUsuario.ObtenerUsuario(nombre);
            try
            {
                command.CommandText = $"SELECT * FROM UsuarioAlumno WHERE id = {usuario.GetID()} AND materia = {IDmateria}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    alumno = Alumno.PasoDeInformacionAlumno(reader, usuario);
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
            return alumno;
        }

        public static void InsertarAlumno(Alumno alumno)
        {
            try
            {
                //si llegas cambia esto!! permisos en vez de nombre pasalos a numeros 0 admin, 1 profe, 2 alumno
                command.CommandText = $"INSERT INTO UsuarioAlumno VALUES ({alumno.GetID()},{alumno.materiaA},{alumno.estadoMA})";
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
        //Verificaciones Materias | Alumnos
        public static int CantMateriasAlumno(int IDalumno)
        {
            int retorno = -1;
            if (IDalumno > -1)
            {
                List<Alumno> listaAlumno = new List<Alumno>();
                try
                {
                    command.CommandText = $"SELECT COUNT(*) FROM UsuarioAlumno WHERE id = {IDalumno}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        retorno = Convert.ToInt32(reader[0]);
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

            }
            return retorno;
        }
        public static bool VerifMateriasAlumno(int IDalumno, int IDmateria)
        {
            bool retorno = false;
            if (IDmateria > -1 && IDalumno > -1)
            {
                try
                {
                    command.CommandText = $"SELECT * FROM UsuarioAlumno WHERE id = {IDalumno}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (IDmateria == Convert.ToInt32(reader["materia"]))
                        {
                            retorno = true;
                        }
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

            }
            return retorno;

        }

        public static void ActualizarAlumno(int IDalumno, int IDmateria, int dato)
        {
            try
            {
                command.CommandText = $"UPDATE UsuarioAlumno SET estado = {dato} WHERE id = {IDalumno} AND materia = {IDmateria}";
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

        public static List<Alumno>? AlumnosAnotados(Materia materia)
        {
            List<Alumno>? alumnos = new();
            try
            {
                command.CommandText = $"SELECT u.id,u.nombre,u.password,p.nombre perfil,u.activo,a.materia,a.estado from UsuarioAlumno AS a INNER JOIN Usuario AS U ON a.id = u.id INNER JOIN Permiso AS p ON p.id = u.id_permiso WHERE a.materia = {materia.GetID()} ";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = Usuario.PasoDeInformacion(reader);
                    Alumno alumno = Alumno.PasoDeInformacionAlumno(reader, usuario);

                    alumnos.Add(alumno);
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
            return alumnos;
        }

        //TOMAR ASISTENCIA
        public static void InsertarAsistencia(int idAlumno, int idMateria, DateTime fecha)
        {

            try
            {
                string fechaInv = $"{fecha.Year}/{fecha.Month}/{fecha.Day}";
                command.CommandText = $"INSERT INTO asistencia VALUES ({idAlumno},{idMateria},'{fechaInv}')";
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

        public static List<Materia> ObtenerMateria(int idAlumno)
        {
            List<Materia> materiaList = new List<Materia>();

            try
            {
                Materia? materia = new Materia();
                command.CommandText = $"SELECT m.* FROM UsuarioAlumno AS a INNER JOIN Materia AS m ON m.id = a.materia WHERE a.id = 2";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    materia = Materia.PasoDeInformacion(reader);
                    if(materia != null)
                    {
                        materiaList.Add(materia);
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

            return materiaList;
        }
        public static List<AsistenciaAlumno> ObtenerAsistencias(string busqueda, int id)
        {
            List<AsistenciaAlumno> asistencias = new();

            try
            {
                command.CommandText = $"SELECT * FROM asistencia WHERE {busqueda} = {id} GROUP BY idAlumno,idMateria,fechaAsistencia";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AsistenciaAlumno asistencia = AsistenciaAlumno.PasarInformacion(reader);

                    asistencias.Add(asistencia);
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

            return asistencias;
        }
        public static AsistenciaAlumno ObtenerAsistencia(string busqueda, DateTime fecha)
        {
            AsistenciaAlumno asistencia = new();

            try
            {
                string fechaInv = $"{fecha.Year}/{fecha.Month}/{fecha.Day}";
                command.CommandText = $"SELECT * FROM asistencia WHERE {busqueda} = {fechaInv} GROUP BY idAlumno,idMateria,fechaAsistencia";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    asistencia = AsistenciaAlumno.PasarInformacion(reader);
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

            return asistencia;
        }
    }
}
