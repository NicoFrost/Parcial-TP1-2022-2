using datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Drawing.Drawing2D;

namespace SysAcademy2
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();

        }
        public Usuario? usuarioActivo = SqlUsuario.ObtenerUsuarioActivo();
        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            if(usuarioActivo != null)
            {
                Materia? materia = new();
                List<Examen> lista = Sql.ObtenerTodosLosExamenes();
                foreach (var examen in lista)
                {
                    Examen examenSql = Sql.ObtenerExamen(examen.GetID(), usuarioActivo.GetID());
                    if (examen != null && examenSql.GetID() == examen.GetID())
                    {
                        materia = SqlMateria.ObtenerMateria("id",examen.materia);
                        if(materia != null && materia.GetID() != -1)
                        {
                            int n = DG_ListaMaterias.Rows.Add();
                            DG_ListaMaterias.Rows[n].Cells[0].Value = examen.GetNombre();
                            if(Sql.ObtenerNota(usuarioActivo.GetID(), examen.GetID()) != null)
                            {
                                DG_ListaMaterias.Rows[n].Cells[1].Value = Sql.ObtenerNota(usuarioActivo.GetID(), examen.GetID()).GetNotaExamen();
                            }
                            DG_ListaMaterias.Rows[n].Cells[2].Value = materia.GetNombre();
                            DG_ListaMaterias.Rows[n].Cells[3].Value = SqlUsuario.ObtenerUsuario(materia.GetProfesorAsignado()).GetNombre();
                            List<Materia>? correlativas = SqlMateria.ObtenerTodasLasCorrelativas(materia.GetID());
                            string correlativaComa = "";
                            foreach(var materiaC in correlativas)
                            {
                                correlativaComa += $"{materiaC.GetNombre()},";
                            }
                            DG_ListaMaterias.Rows[n].Cells[4].Value = correlativaComa;
                        }
                    }
                }


                //int alumnoID = Usuarios.BuscarActivo().GetID();
                //foreach(var fecha in Materias.BuscarAsistencia(alumnoID)){

                //    if (fecha == examen.fecha)
                //    {
                //        int idExamen = examen.GetID();
                //        Notas? notaExamen;
                //        int n = DG_ListaMaterias.Rows.Add();
                //        DG_ListaMaterias.Rows[n].Cells[0].Value = examen.GetNombre();
                //        if(Examenes.NotasExamenes.Count > 0)
                //        {
                //            notaExamen = Examenes.NotasExamenes.Find(objeto => objeto.GetExamenID() == idExamen && objeto.GetAlumnoID() == alumnoID);
                //            if(notaExamen != null)
                //            {
                //                DG_ListaMaterias.Rows[n].Cells[1].Value = notaExamen.GetNotaExamen();
                //            }
                //        }
                //        Materia materia = Materias.MateriafromList(examen.materia);
                //        DG_ListaMaterias.Rows[n].Cells[2].Value = materia.GetNombre();
                //        DG_ListaMaterias.Rows[n].Cells[3].Value = Usuarios.BuscarUsuario(materia.GetProfesorAsignado());
                //    }
            }
        }
    }
}
