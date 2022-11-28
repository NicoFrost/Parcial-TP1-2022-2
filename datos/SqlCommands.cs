using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Net;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace datos
{
    public class Sql
    {
        private static SqlConnection connection; // Puente.
        private static SqlCommand command;      // Quien lleva la consulta.


        static Sql()
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

        public static int GetLastID(string tabla)
        {
            int LastId = 0;
            try
            {
                command.CommandText = $"SELECT id FROM {tabla}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idSQL = Convert.ToInt32(reader["id"]);
                    if (idSQL >= LastId)
                    {
                        LastId = idSQL;
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
            return LastId;
        }

        //Docente | A Examen
        public static void InsertarExamen(Examen examen)
        {
            try
            {
                DateTime fecha = examen.fecha;
                string fechaInv = $"{fecha.Year}/{fecha.Month}/{fecha.Day}";
                command.CommandText = $"INSERT INTO Examen VALUES ('{examen.GetNombre()}','{fechaInv}',{examen.materia})";
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

        private static bool VerificarConexion(int idAlumno, int idExamen)
        {
            try
            {

                command.CommandText = $"SELECT * FROM ExamenAlumno WHERE alumnoID = {idAlumno} AND ExamenID = {idExamen}";
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        return false;
                    } else
                    {
                        return true;
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
            return false;
        }

        //CrearExamenAlumno | Conexion Alumno -> Examen
        public static void CrearExamenesAlumnos(int idAlumno,int idExamen)
        {
            if (!VerificarConexion(idAlumno,idExamen))
            {
                try
                {

                    command.CommandText = $"INSERT INTO ExamenAlumno VALUES ({idAlumno},{idExamen},NULL)";
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

        //examenRevisar update notas
        public static void ActualizarExamenesAlumnos(int idAlumno,int idExamen,decimal nota)
        {
            try
            {
                string notaS = nota.ToString().Replace(',', '.');
                command.CommandText = $"UPDATE ExamenAlumno SET notaExamen = {notaS} WHERE AlumnoID = {idAlumno} AND ExamenID = {idExamen}";
                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error de conexión a la base de datos, " + e.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        //Busqueda Conexion | ExamenAlumno
        //devuelve lista de id de alumnos que asistieron ese dia y hicieron el examen
        public static List<int> ObtenerExamenesID(int idExamen)
        {
            List<int> alumnosID = new List<int>();
            if (idExamen > -1)
            {
                try
                {

                    command.CommandText = $"SELECT * FROM ExamenAlumno WHERE ExamenID = {idExamen}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["alumnoID"]);

                        alumnosID.Add(id);
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
            }

            return alumnosID;
        }

        //Busqueda | Examen
        public static Examen ObtenerExamen(string nombre)
        {
            Examen examen = new Examen();
            if (nombre != "")
            {
                try
                {

                    command.CommandText = $"SELECT * FROM Examen WHERE nombre = '{nombre}'";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        examen = Examen.PasoDeInformacion(reader);
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
            }

            return examen;
        }
        public static Examen ObtenerExamen(int idExamen,int idAlumno)
        {
            Examen examen = new Examen();
            if(idExamen > -1)
            {
                try
                {

                    command.CommandText = $"SELECT e.* FROM ExamenAlumno AS ea INNER JOIN Examen AS e ON e.id = ea.ExamenID WHERE alumnoID = {idAlumno} AND ExamenID = {idExamen}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        examen = Examen.PasoDeInformacion(reader);
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
            }

            return examen;
        }
        public static Examen ObtenerExamenIDAlumno(int idAlumno)
        {
            Examen examen = new Examen();
            if (idAlumno > -1)
            {
                try
                {

                    command.CommandText = $"SELECT * FROM Examen WHERE id = {idAlumno}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        examen = Examen.PasoDeInformacion(reader);
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
            }

            return examen;
        }


        public static Notas? ObtenerNota(int idAlumno,int idExamen)
        {
            Notas? notas = new Notas();
            if (idExamen > -1)
            {
                try
                {

                    command.CommandText = $"SELECT * FROM ExamenAlumno WHERE ExamenID = {idExamen} AND AlumnoID = {idAlumno}";
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        notas = Notas.PasoDeInformacion(reader);
                    }
                }
                catch (Exception)
                {
                    notas = null;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }
            }
                return notas;

        }
        
        //Candidatos a GENERICS con DELEGADOS
        /*
         usar genericos para usar solo una funcion para obtener todos mientras que los delegados van a decidir que Parseo usar para devolver un objeto T 
         */
        //Busqueda y Obtencion Total
      /*public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                command.CommandText = "SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = Usuario.PasoDeInformacion(reader);

                    listaUsuarios.Add(usuario);
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
            return listaUsuarios;
        }
        public static List<Funcion> ObtenerTodasLasFunciones()
        {
            List<Funcion> listaFunciones = new List<Funcion>();

            try
            {
                command.CommandText = "SELECT f.id,f.nombre,p.nombre permisoReq FROM Funcion AS f INNER JOIN Permiso AS p ON f.id_permiso = p.id";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Funcion funcion = Funcion.PasoDeInformacion(reader);

                    listaFunciones.Add(funcion);
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
            return listaFunciones;
        }
        public static List<Materia> ObtenerTodasLasMaterias()
        {
            List<Materia> listaMaterias = new List<Materia>();

            try
            {
                command.CommandText = "SELECT id,nombre,idUserP_Asignado FROM Materia";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Materia? materia = Materia.PasoDeInformacion(reader);

                    listaMaterias.Add(materia);
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
            return listaMaterias;
        }        
        public static List<Examen> ObtenerTodosLosExamenes()
        {
            List<Examen> examenes = new List<Examen>();

            try
            {
                command.CommandText = "SELECT * FROM Examen";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Examen examen = Examen.PasoDeInformacion(reader);

                    examenes.Add(examen);
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

            return examenes;
        }
        */
        public static List<Examen> ObtenerTodosLosExamenes(int id)
        {
            List<Examen> examenes = new List<Examen>();

            try
            {
                command.CommandText = $"SELECT e.* FROM Examen AS e INNER JOIN ExamenAlumno AS a ON a.ExamenID = e.id WHERE a.alumnoID = {id}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Examen examen = Examen.PasoDeInformacion(reader);

                    examenes.Add(examen);
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

            return examenes;
        }

        public static List<Alumno> ObtenerTodosLosAlumnos()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            try
            {
                command.CommandText = "SELECT * FROM Usuario WHERE id_permiso = 2";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = Usuario.PasoDeInformacion(reader);
                    Alumno alumno = Alumno.PasoDeInformacionAlumno(reader, usuario);
                    listaAlumno.Add(alumno);
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
            return listaAlumno;

        }

        public static List<Alumno> AlumnEnExamen(List<Alumno> listaAlumnos)
        {
            List<Alumno> listaARetornar = new List<Alumno>();
            try
            {
                command.CommandText = $"";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

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
            return listaARetornar;
            /*
            Alumno                     
                fecha de asistencia
                                    ==> examen asigna alumnoID
            examen                              
                fecha de realizacion   


            ID del examen diccionario
                                    ==> conexion del Examen con su nota
            examen ID
             */
        }
        public static bool VerificarPermisos(string nombreFuncion)
        {
            Usuario? active = SqlUsuario.ObtenerUsuarioActivo();

            try
            {
                int idPermiso = 2;
                if (active != null)
                {
                    switch (active.GetPerfil())
                    {
                        case "Admin":
                            idPermiso = 0;
                            break;
                        case "Profesor":
                            idPermiso = 1;
                            break;
                        case "Alumno":
                            idPermiso = 2;
                            break;
                    }
                }
                command.CommandText = $"SELECT id,id_permiso FROM Funcion WHERE nombre = '{nombreFuncion}' AND id_permiso = {idPermiso}";
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
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

    public class SqlG<T>
    {
        private static SqlConnection connection; // Puente.
        private static SqlCommand command;      // Quien lleva la consulta.


        static SqlG()
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


        public static List<T> ObtenerTodosdelDatoT() // ObtenerTodosdelDatoT
        {
            List<T> listaDato = new List<T>();
            try
            {
                if(typeof(T) == typeof(Usuario))
                {
                    command.CommandText = "SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id";
                }
                else if (typeof(T) == typeof(Materia))
                {
                    command.CommandText = "SELECT id,nombre,idUserP_Asignado FROM Materia";
                } else if (typeof(T) == typeof(Funcion))
                {
                    command.CommandText = "SELECT f.id,f.nombre,p.nombre permisoReq FROM Funcion AS f INNER JOIN Permiso AS p ON f.id_permiso = p.id";
                } else if(typeof(T) == typeof(Examen))
                {
                    command.CommandText = "SELECT * FROM Examen";
                } else if(typeof(T) == typeof(Alumno))
                {
                    command.CommandText = "SELECT * FROM Usuario WHERE id_permiso = 2";
                }
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                UsuariosG<T>.delegadoSql? delegado = null;
                if (typeof(T) == typeof(Usuario))
                {
                    delegado = new UsuariosG<T>.delegadoSql(UsuariosG<T>.PasoDeInformacionU);
                } else if(typeof(T) == typeof(Materia))
                {
                    delegado = new UsuariosG<T>.delegadoSql(UsuariosG<T>.PasoDeInformacionM);
                } else if (typeof(T) == typeof(Funcion))
                {
                    delegado = new UsuariosG<T>.delegadoSql(UsuariosG<T>.PasoDeInformacionF);
                } else if(typeof(T) == typeof(Examen))
                {
                    delegado = new UsuariosG<T>.delegadoSql(UsuariosG<T>.PasoDeInformacionE);
                }
                while (reader.Read())
                {
                    if(delegado != null)
                    {
                        T? usuario = delegado(reader);
                        if(usuario != null)
                        {
                            listaDato.Add(usuario);
                        }
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
            return listaDato;
        }
    }
}
