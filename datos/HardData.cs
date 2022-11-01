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
            Usuario administradorRoot = new Usuario();
            administradorRoot.SetID(0);
            administradorRoot.SetNombre("Administrador");
            administradorRoot.SetPassword("admin");
            administradorRoot.SetPerfil("Admin");
            DU.listaUsuarios.Add(administradorRoot);
            Usuario Alumno1 = new Usuario();
            Alumno1.SetID(1);
            Alumno1.SetNombre("Adrian");
            Alumno1.SetPassword("river el fachero");
            Alumno1.SetPerfil("Alumno");
            DU.listaUsuarios.Add(Alumno1);
            Usuario Alumno2 = new Usuario();
            Alumno2.SetID(2);
            Alumno2.SetNombre("Dario");
            Alumno2.SetPassword("BocaEl+Grande");
            Alumno2.SetPerfil("Alumno");
            DU.listaUsuarios.Add(Alumno2);
            Usuario Profe1 = new Usuario();
            Profe1.SetID(3);
            Profe1.SetNombre("Martin");
            Profe1.SetPassword("luciano2002");
            Profe1.SetPerfil("Profesor");
            DU.listaUsuarios.Add(Profe1);
            Usuario Profe2 = new Usuario();
            Profe2.SetID(4);
            Profe2.SetNombre("Lucas");
            Profe2.SetPassword("Boquita");
            Profe2.SetPerfil("Profesor");
            DU.listaUsuarios.Add(Profe2);
            }
            // permisos prestablecidos
            //Administradores
            {
                Funcion AltaUsuarios = new Funcion();
                Funcion EstadoMateria = new Funcion();
                Funcion CrearMaterias = new Funcion();
                Funcion AsignarProfeMateria = new Funcion();
                Funcion InscripcionAlumnos = new();
                
                AltaUsuarios.SetID(0);
                AltaUsuarios.SetNombre("Nuevo Usuario");
                AltaUsuarios.SetPermiso("Admin");

                EstadoMateria.SetID(1);
                EstadoMateria.SetNombre("Estado materia para alumnos"); //(regular/libre)
                EstadoMateria.SetPermiso("Admin");

                CrearMaterias.SetID(2);
                CrearMaterias.SetNombre("Nueva Materia");
                CrearMaterias.SetPermiso("Admin");

                AsignarProfeMateria.SetID(3);
                AsignarProfeMateria.SetNombre("Asignacion Profes");
                AsignarProfeMateria.SetPermiso("Admin");

                InscripcionAlumnos.SetID(4);
                InscripcionAlumnos.SetNombre("Inscripcion de Alumnos");
                InscripcionAlumnos.SetPermiso("Admin");
                
                DF.listaFunciones.Add(AltaUsuarios);
                DF.listaFunciones.Add(EstadoMateria);
                DF.listaFunciones.Add(CrearMaterias);
                DF.listaFunciones.Add(AsignarProfeMateria);
                DF.listaFunciones.Add(InscripcionAlumnos);
            }
            //Profesores
            {
                Funcion CrearExamenes = new Funcion();
                Funcion PonerNotas = new Funcion();

                CrearExamenes.SetID(5);
                CrearExamenes.SetNombre("Crear"); // nombre y fecha
                CrearExamenes.SetPermiso("Profesor");

                PonerNotas.SetID(6);
                PonerNotas.SetNombre("Lista");
                PonerNotas.SetPermiso("Profesor");

                DF.listaFunciones.Add(CrearExamenes);
                DF.listaFunciones.Add(PonerNotas);
            }
            //Alumnos
            {
                Funcion Inscribirse = new Funcion();
                Funcion Asistencia = new Funcion();
                Funcion Estadistica = new();

                Inscribirse.SetID(7);
                Inscribirse.SetNombre("Inscribirse a materias");
                Inscribirse.SetPermiso("Alumno");


                Asistencia.SetID(8);
                Asistencia.SetNombre("Dar Asistencia a materias");
                Asistencia.SetPermiso("Alumno");

                Estadistica.SetID(9);
                Estadistica.SetNombre("Estadisticas");
                Estadistica.SetPermiso("Admin");

                DF.listaFunciones.Add(Inscribirse);
                DF.listaFunciones.Add(Asistencia);
                DF.listaFunciones.Add(Estadistica);
            }

            //
            {
                Materia materia = new();
                materia.SetID(0);
                materia.SetNombre("matematica");
                Materias.listaMaterias.Add(materia);
                Materia materia2 = new();
                materia2.SetID(1);
                materia2.SetNombre("lengua");
                Materias.listaMaterias.Add(materia2);
                Materia materia3 = new();
                materia3.SetID(2);
                materia3.SetNombre("Ingenieria");
                Materias.listaMaterias.Add(materia3);
                Materia materia4 = new();
                materia4.SetID(3);
                materia4.SetNombre("Matermatica II");
                Materia materiaTemp = Materias.listaMaterias.Find(objeto => objeto.GetID() == 0);
                if(materiaTemp != null)
                {
                    materia4.correlativas.Add(materiaTemp);
                }
                materiaTemp = Materias.listaMaterias.Find(objeto => objeto.GetID() == 2);
                if(materiaTemp != null)
                {
                    materia4.correlativas.Add(materiaTemp);
                }
                Materias.listaMaterias.Add(materia4);
            }

            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
            UsuarioPermisos.GuardarPermiso(DU.listaUsuarios, DF.listaFunciones);
        }
    }
}
