
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Usuario : EntidadBase
    {
        private string? password;
        private string? perfil;
        public bool activo { get; set; }

        public string? GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
            
        public string? GetPerfil()
        {
            return perfil;
        }
        public void SetPerfil(string perfil)
        {
            this.perfil = perfil;
        }

        public static Alumno ConvertirAlumno(Usuario usuario)
        {
            Alumno alumno = new();

            alumno.SetID(usuario.GetID());
            alumno.SetNombre(usuario.GetNombre());
            alumno.password = usuario.password;
            alumno.perfil = usuario.perfil;
            alumno.activo = usuario.activo;

            return alumno;
        }
        public Usuario() {
        }
        public Usuario(int id, string nombre, string password, string perfil, bool activo)
        {
            SetID(id);
            SetNombre(nombre);
            SetPassword(password);
            SetPerfil(perfil);
            this.activo = activo;
        }

        public static Usuario PasoDeInformacion(SqlDataReader v)
        {

                //El paso de informacion de lo leido de la base de datos
                Usuario usuario = new Usuario(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["password"].ToString() ?? "",
                v["perfil"].ToString() ?? "",
                Convert.ToBoolean(v["activo"]) 
                );

            return usuario;
        }
    }

    public class UsuariosG<T>
    {

        public delegate T? delegadoSql(SqlDataReader v);

        public static T? PasoDeInformacionU(SqlDataReader v)
        {

            //El paso de informacion de lo leido de la base de datos
            Usuario usuario = new Usuario(
            Convert.ToInt32(v["id"]),
            v["nombre"].ToString() ?? "",
            v["password"].ToString() ?? "",
            v["perfil"].ToString() ?? "",
            Convert.ToBoolean(v["activo"])
            );

            try
            {
                return (T)Convert.ChangeType(usuario, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }

        public static T? PasoDeInformacionF(SqlDataReader v)
        {
            //El paso de informacion de lo leido de la base de datos
            Funcion funcion = new Funcion(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["permisoReq"].ToString() ?? ""
                );

            try
            {
                return (T)Convert.ChangeType(funcion, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }

        public static T? PasoDeInformacionM(SqlDataReader v)
        {
            //El paso de informacion de lo leido de la base de datos
            int profesor;
            try
            {
                profesor = Convert.ToInt32(v["idUserP_Asignado"]);
            }
            catch (Exception)
            {
                profesor = -1;
            }
            Materia materia = new();
            if (true)
            {
                materia = new Materia(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                profesor
                );
            }

            try
            {
                return (T)Convert.ChangeType(materia, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }

        public static T? PasoDeInformacionE(SqlDataReader v)
        {

            //El paso de informacion de lo leido de la base de datos
            Examen examen = new Examen(
            Convert.ToInt32(v["id"]),
            v["nombre"].ToString() ?? "",
            Convert.ToDateTime(v["fecha"]),
            Convert.ToInt32(v["idMateria"])
            );

            try
            {
                return (T)Convert.ChangeType(examen, typeof(T));
            }
            catch (InvalidCastException)
            {
                return default(T);
            }
        }
    }

    public class Permisos
    {
        public int idUsuario { get; set; }
        public int idFuncion { get; set; }
    }
    public class Alumno : Usuario
    {
        //materiaID
        public int materiaA = -1;
        //estadoMateria Regular true / Libre false
        public bool estadoMA;

        //public int materiaB = -1;
        //public bool estadoMB;

        public static Alumno PasoDeInformacionAlumno(SqlDataReader v,Usuario usuario)
        {
            //El paso de informacion de lo leido de la base de datos
            Alumno alumno = ConvertirAlumno(usuario);
            alumno.materiaA = Convert.ToInt32(v["materia"]);
            alumno.estadoMA = Convert.ToBoolean(v["estado"]);
            //alumno.materiaB = Convert.ToInt32(v["materiaB"]);
            //alumno.estadoMB = Convert.ToBoolean(v["estadoMB"]);

            return alumno;
        }

        public static void SetEstadoMateria(Materia materia,Alumno alumno,bool value)
        {
            if (materia.GetID() == alumno.materiaA)
            {
                alumno.estadoMA = value;
            }
            //else
            //{
            //    alumno.estadoMB = value;
            //}
        }
    }
    public class AlumnoJSON
    {
        private int id;
        private string? nombre;
        private string? password;
        private string? perfil;
        private int materiaA;
        private bool estadoMA;
        private bool activo;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string? Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string? Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string? Perfil 
        {
            get
            {
                return perfil;
            }
            set
            {
                perfil = value;
            }
        }
        public int MateriaA
        {
            get { return materiaA; }
            set
            {
                materiaA = value;
            }
        }
        public bool EstadoMA
        {
            get => estadoMA;
            set
            {
                estadoMA = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        public AlumnoJSON(int id,string? nombre,string? password,string? perfil,int materiaA,bool estadoMA,bool activo) : this()
        {
            this.id = id;
            this.nombre = nombre;
            this.password = password;
            this.perfil = perfil;
            this.materiaA = materiaA;
            this.estadoMA = estadoMA;
            this.activo = activo;
        }

        public static Alumno ConvertirJsonAAlumno(AlumnoJSON alumno)
        {
            Alumno alumnoNew = new();
            if(alumno.nombre != null && alumno.password != null && alumno.perfil != null)
            {
                alumnoNew.SetNombre(alumno.nombre);
                alumnoNew.SetPassword(alumno.password);
                alumnoNew.SetPerfil(alumno.perfil);
                alumnoNew.materiaA = alumno.materiaA;

            }
            return alumnoNew;
        }
        public AlumnoJSON()
        {
        }
    }
}