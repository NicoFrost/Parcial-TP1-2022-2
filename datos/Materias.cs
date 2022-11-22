using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Materias
    {
        public static List<Materia> listaMaterias = new();
        public static List<AsistenciaAlumno> listaAsistencia = new();

        public static List<DateTime?> BuscarAsistencia(int idAlumno)
        {
            List<DateTime?> listaFecha = new();
            foreach (var asistencia in listaAsistencia.FindAll(objeto => objeto.idAlumno == idAlumno))
            {
                listaFecha.Add(asistencia.fecha);
            }
                if(listaFecha.Count > 0)
                {
                    return listaFecha;
                } else
                {
                    return null;
                }
        }
        public static int BuscarMateria(string nombreMateria)
        {
            if(nombreMateria != null)
            {
                foreach(var materia in listaMaterias)
                {
                    if(materia.GetNombre().Equals(nombreMateria))
                    {
                        return materia.GetID();
                    }
                }
            }
            return -1;
        }
        public static string BuscarMateria(int id)
        {
            if(id >= 0)
            {
                foreach(var materia in listaMaterias)
                {
                    if(materia.GetID() == id)
                    {
                        return materia.GetNombre();
                    }
                }
            }
            return "";
        }
        public static Materia? MateriafromList(int id)
        {
            if (id >= 0)
            {
                foreach (var materia in listaMaterias)
                {
                    if (materia.GetID() == id)
                    {
                        return materia;
                    }
                }
            }
            return null;

        }
    }
}
