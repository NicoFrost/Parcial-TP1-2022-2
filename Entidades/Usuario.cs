﻿

using System.Data.SqlClient;

namespace Entidades
{
    public class Usuario : EntidadBase
    {
        private string? password;
        private string? perfil;
        public bool activo { get; set; }

        public static int GetLastID(List<Usuario> usuarios)
        {
            int lastId = 0;
            
            foreach (var usuario in usuarios)
            {
                if (usuario.GetID() > lastId)
                {
                    lastId = usuario.GetID();
                }
            }

            return lastId;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
            
        public string GetPerfil()
        {
            return perfil;
        }
        public void SetPerfil(string perfil)
        {
            this.perfil = perfil;
        }

        public void AsignarID(List<Materia> lista)
        {
            if (lista.Count == 0)
            {
                SetID(0);
            }
            else
            {
                SetID(lista.Last().GetID() + 1);
            }
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
            SetID(-1);
            SetNombre("");
            SetPassword("");
            SetPassword("");
            SetPerfil("");
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
        public string Nombre
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

        public AlumnoJSON()
        {
        }
    }
}