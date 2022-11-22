using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DF = datos.Funciones;
using DU = datos.Usuarios;

namespace datos
{
    public class HardData
    {

        public static void InicializarDatos()
        {
            {
            DU.listaUsuarios = Sql.ObtenerTodosLosUsuarios();
            //Usuario administradorRoot = new Usuario(0,"Administrador", "admin", "Admin");
            //Usuario Alumno1 = new Usuario(1, "Adrian","river el fachero","Alumno");
            //Usuario Profe2 = new Usuario(4, "Lucas","Boquita", "Profesor");
            //Usuario Alumno2 = new Usuario(2, "Dario", "BocaEl+Grande","Alumno");
            //Usuario Profe1 = new Usuario(3, "Martin", "luciano2002", "Profesor");
            //DU.listaUsuarios.Add(administradorRoot);
            //DU.listaUsuarios.Add(Alumno1);
            //DU.listaUsuarios.Add(Alumno2);
            //DU.listaUsuarios.Add(Profe1);
            //DU.listaUsuarios.Add(Profe2);
            }
            // permisos prestablecidos
            //Administradores
            DF.listaFunciones = Sql.ObtenerTodasLasFunciones();
            {
            //    Funcion AltaUsuarios = new Funcion();
            //    Funcion EstadoMateria = new Funcion();
            //    Funcion CrearMaterias = new Funcion();
            //    Funcion AsignarProfeMateria = new Funcion();

            //    AltaUsuarios.SetID(0);
            //    AltaUsuarios.SetNombre("Nuevo Usuario");
            //    AltaUsuarios.SetPermiso("Admin");

            //    EstadoMateria.SetID(1);
            //    EstadoMateria.SetNombre("Estado materia para alumnos"); //(regular/libre)
            //    EstadoMateria.SetPermiso("Admin");

            //    CrearMaterias.SetID(2);
            //    CrearMaterias.SetNombre("Nueva Materia");
            //    CrearMaterias.SetPermiso("Admin");

            //    AsignarProfeMateria.SetID(3);
            //    AsignarProfeMateria.SetNombre("Asignacion Profes");
            //    AsignarProfeMateria.SetPermiso("Admin");

            //    DF.listaFunciones.Add(AltaUsuarios);
            //    DF.listaFunciones.Add(EstadoMateria);
            //    DF.listaFunciones.Add(CrearMaterias);
            //    DF.listaFunciones.Add(AsignarProfeMateria);

            //}
            ////Profesores
            //{
            //    Funcion CrearExamenes = new Funcion();
            //    Funcion PonerNotas = new Funcion();

            //    CrearExamenes.SetID(4);
            //    CrearExamenes.SetNombre("Crear"); // nombre y fecha
            //    CrearExamenes.SetPermiso("Profesor");

            //    PonerNotas.SetID(5);
            //    PonerNotas.SetNombre("Lista");
            //    PonerNotas.SetPermiso("Profesor");

            //    DF.listaFunciones.Add(CrearExamenes);
            //    DF.listaFunciones.Add(PonerNotas);
            //}
            ////Alumnos
            //{
            //    Funcion Inscribirse = new Funcion();
            //    Funcion Asistencia = new Funcion();

            //    Inscribirse.SetID(6);
            //    Inscribirse.SetNombre("Inscribirse a materias");
            //    Inscribirse.SetPermiso("Alumno");

            //    Asistencia.SetID(7);
            //    Asistencia.SetNombre("Dar Asistencia a materias");
            //    Asistencia.SetPermiso("Alumno");
            //    DF.listaFunciones.Add(Inscribirse);
            //    DF.listaFunciones.Add(Asistencia);
            }

            // 
            {
                Materias.listaMaterias = Sql.ObtenerTodasLasMaterias();
                //Materia materia = new();
                //materia.SetID(0);
                //materia.SetNombre("matematica");
                //Materias.listaMaterias.Add(materia);
                //Materia materia2 = new();
                //materia2.SetID(1);
                //materia2.SetNombre("lengua");
                //Materias.listaMaterias.Add(materia2);
                //Materia materia3 = new();
                //materia3.SetID(2);
                //materia3.SetNombre("Ingenieria");
                //Materias.listaMaterias.Add(materia3);
                //Materia materia4 = new();
                //materia4.SetID(3);
                //materia4.SetNombre("Matermatica II");
                //Materia materiaTemp = Materias.listaMaterias.Find(objeto => objeto.GetID() == 0);
                //if(materiaTemp != null)
                //{
                //    materia4.correlativas.Add(materiaTemp);
                //}
                //materiaTemp = Materias.listaMaterias.Find(objeto => objeto.GetID() == 2);
                //if(materiaTemp != null)
                //{
                //    materia4.correlativas.Add(materiaTemp);
                //}
                //Materias.listaMaterias.Add(materia4);
            }

            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
        }
    }
}
