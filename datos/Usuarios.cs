using Entidades;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace datos
{
    public class Usuarios
    {
        public static List<Usuario> listaUsuarios = new();
        public static List<Alumno> listaAlumnos = new();

        public static int IdIncremental(List<Usuario> lista)
        {
            if (lista.Count == 0)
            {
                return 0;
            }
            else
            {
                return lista.Last().GetID() + 1;
            }
        }

        //Diccionario<IdExamen,NotaExamen>
        public static void AgregarUsuario(Usuario oUsuario, List<Usuario> listaUsuarios)
        {

            listaUsuarios.Add(oUsuario);

        }

        public static bool VerifProfesor(Usuario profesor)
        {
            if (BuscarActivo().GetID() == profesor.GetID())
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool VerifProfesor(int profesorID)
        {
            if (BuscarActivo().GetID() == profesorID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifProfesor(string profesorNombre)
        {
            if(profesorNombre != null)
            {
                Usuario? profesor = listaUsuarios.Find(objeto => objeto.GetNombre() == profesorNombre);
                if (profesor != null && BuscarActivo().GetID() == profesor.GetID())
                {
                    return true;
                }
            }
            return false;
        }
        public static Usuario? UsuariofromList(int id)
        {
            if (id >= 0)
            {
                foreach (var alumno in listaUsuarios)
                {
                    if (alumno.GetID() == id)
                    {
                        return alumno;
                    }
                }
            }
            return null;

        }

        public static int BuscarUsuario(string nombre)
        {
            foreach(var user in listaUsuarios)
            {
                if(user.GetNombre() == nombre)
                {
                    return user.GetID();
                }
            }
            return -1;
        }

        public static string BuscarUsuario(int id) 
        {
            foreach (var user in listaUsuarios)
            {
                if(user.GetID() == id)
                {
                    return user.GetNombre();
                }
            }
            return "";
        }

        public static int BuscarAlumno(string nombre)
        {
            foreach (var user in listaAlumnos)
            {
                if (user.GetNombre() == nombre)
                {
                    return user.GetID();
                }
            }
            return -1;
        }

        public static string BuscarAlumno(int id)
        {
            foreach (var user in listaAlumnos)
            {
                if (user.GetID() == id)
                {
                    return user.GetNombre();
                }
            }
            return "";
        }

        public static Alumno? AlumnofromList(int id)
        {
            if (id >= 0)
            {
                foreach (var alumno in listaAlumnos)
                {
                    if (alumno.GetID() == id)
                    {
                        return alumno;
                    }
                }
            }
            return null;

        }

            public static bool VerifMaterias(Alumno alumno,int idMateria)
        {
            foreach(var user in listaAlumnos)
            {
                if(alumno != null && user.GetID() == alumno.GetID() && (alumno.materiaA == idMateria || alumno.materiaB == idMateria))
                {
                    return true;
                }
            }
            return false;
        }

        public static Usuario BuscarActivo()
        {
            return listaUsuarios.Find(objecto => objecto.activo == true);
        }

        public static int BuscarActivoIndex(List<Usuario> listaUsuario)
        {

            return listaUsuario.FindIndex(objecto => objecto.activo == true);
        }
    }
}  