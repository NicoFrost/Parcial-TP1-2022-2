using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen : EntidadBase
    {
        public DateTime fecha { get; set; }

        public int materia { get; set; }

        public Examen()
        {
            SetID(-1);
            SetNombre("");
            materia = -1;
        }
        public Examen(int id, string nombre,DateTime fecha, int idMateria)
        {
            SetID(id);
            SetNombre(nombre);
            this.fecha = fecha;
            this.materia = idMateria;
        }

        public static Examen PasoDeInformacion(SqlDataReader v)
        {

            //El paso de informacion de lo leido de la base de datos
            Examen usuario = new Examen(
            Convert.ToInt32(v["id"]),
            v["nombre"].ToString() ?? "",
            Convert.ToDateTime(v["fecha"]),
            Convert.ToInt32(v["idMateria"])
            );

            return usuario;
        }
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

        public Notas()
        {
            alumnoID = -1;
            examenID = -1;
            notaExamen = -1;
        }

        public Notas(int alumnoID,int examenID, decimal nota)
        {
            this.alumnoID = alumnoID;
            this.examenID = examenID;
            notaExamen = nota;
        }

        public static Notas PasoDeInformacion(SqlDataReader v)
        {  
            Notas nota = new Notas(
                Convert.ToInt32(v["alumnoID"]),
                Convert.ToInt32(v["ExamenID"]),
                Convert.ToDecimal(v["notaExamen"])
            );
            return nota;
        }
    }
}
