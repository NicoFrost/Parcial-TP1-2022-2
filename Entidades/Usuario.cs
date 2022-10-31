

namespace Entidades
{
    public class Usuario : EntidadBase
    {
        private string? password;
        private string? perfil;
        public bool activo { get; set; }

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

        public int materiaB = -1;
        public bool estadoMB;

        public static void SetEstadoMateria(Materia materia,Alumno alumno,bool value)
        {
            if (materia.GetID() == alumno.materiaA)
            {
                alumno.estadoMA = value;
            }
            else
            {
                alumno.estadoMB = value;
            }
        }
    }

}