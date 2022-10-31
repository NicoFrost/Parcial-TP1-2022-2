using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Examenes
    {
        public static List<Examen> listaExamenes = new List<Examen>();
        //ID EXAMEN / NOTA EXAMEN
        public static List<Notas> NotasExamenes = new();

        public static List<Alumno> FiltroAlumnEnExamen(List<Alumno> listaAlumnos)
        {
            List<Alumno> listaARetornar = new List<Alumno>();
            foreach (var alumno in listaAlumnos)
            {
                foreach(var examen in listaExamenes)
                {
                    foreach (var fecha in Materias.BuscarAsistencia(alumno.GetID()))
                    {
                        if (fecha == examen.fecha && (examen.materia == alumno.materiaA || examen.materia == alumno.materiaB)){
                            listaARetornar.Add(alumno);
                        }

                    }

                }            
            }
            return listaARetornar;
            /*
            Alumno                     
                fecha de asistencia
                                    ==> examen asigna alumnoID
            examen                              
                fecha de realizacion   


            ID del examen diccionario
                                    ==> conexion del Examen con su nota
            examen ID
             */            
        }
        public static int IdIncremental(List<Examen> lista)
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

    }

}
