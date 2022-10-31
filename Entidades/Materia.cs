using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia : EntidadBase
    {
        internal int idStarter;
        private int profesorAsignadoID = -1;
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

        
    }
}
