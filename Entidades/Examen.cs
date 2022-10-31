using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen : EntidadBase
    {
        public DateTime fecha { get; set; }

        public int materia { get; set; }
    }
    public class Notas
    {
        private int alumnoID;
        private int examenID;
        private decimal notaExamen;

        public int GetAlumnoID() { 
            return alumnoID;
        }
        public int GetExamenID()
        {
            return examenID;
        }
        public decimal GetNotaExamen()
        {
            return notaExamen;
        }
        public void SetAlumnoID(int alumnoID)
        {
            this.alumnoID = alumnoID;
        }
        public void SetExamenId(int examenID)
        {
            this.examenID = examenID;
        }
        public void SetNotaExamen(decimal nota)
        {
            this.notaExamen = nota;
        }
    }
}
