using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AsistenciaAlumno
    {
        public int idAlumno { get; set; }
        public DateTime fecha { get; set; }

        public AsistenciaAlumno()
        {
            idAlumno = new();
            fecha = new();
        }
        public AsistenciaAlumno(int id,DateTime fecha)
        {
            idAlumno = id;
            this.fecha = fecha;
        }
        public static AsistenciaAlumno PasarInformacion(SqlDataReader v)
        {
            AsistenciaAlumno asistencia = new(
                Convert.ToInt32(v["idAlumno"]),
                Convert.ToDateTime(v["fechaAsistencia"])
                );
            return asistencia;
        }
    }
}
