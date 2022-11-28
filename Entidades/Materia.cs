using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia : EntidadBase
    {
        private int profesorAsignadoID;
        public List<Materia> correlativas = new();

        public int IdIncremental(List<Materia> lista)
        {
            if(lista.Count == 0)
            {
                return 0;
            }
            else
            {
                return lista.Last().GetID() + 1;
            }
        }
        public int GetProfesorAsignado()
        {
            return profesorAsignadoID;
        }
        public void SetProfesorAsignado(int ProfesorID)
        {
            profesorAsignadoID = ProfesorID;
        }

        public Materia()
        {
            SetID(-1);
            SetNombre("");
            SetProfesorAsignado(-1);
        }
        public Materia(int id, string nombre,int idProfesor)
        {
            SetID(id);
            SetNombre(nombre);
            SetProfesorAsignado(idProfesor);
        }
        public static Materia? PasoDeInformacion(SqlDataReader v)
        {
            //El paso de informacion de lo leido de la base de datos
            int profesor;
            try
            {
                profesor = Convert.ToInt32(v["idUserP_Asignado"]);
            }
            catch(Exception)
            {
                profesor = -1;
            }
            Materia materia = new();
            if (true) { 
                materia = new Materia(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                profesor
                );
            }            
            
            return materia;
        }
    }
}
