using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using Entidades;

namespace SysAcademy2
{
    public partial class ExamenRevisar : Form
    {
        private Usuario? usuarioActivo = SqlUsuario.ObtenerUsuarioActivo();
        public ExamenRevisar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZoomInOut(true);
        }

        private void ZoomInOut(bool zoom)
        {
            //Zoom ratio by which the images will be zoomed by default
            int zoomRatio = 10;
            //Set the zoomed width and height
            int widthZoom = pictureBox1.Width * zoomRatio / 100;
            int heightZoom = pictureBox1.Height * zoomRatio / 100;
            //zoom = true --> zoom in
            //zoom = false --> zoom out
            if (!zoom)
            {
                widthZoom *= -1;
                heightZoom *= -1;
            }
            //Add the width and height to the picture box dimensions
            pictureBox1.Width += widthZoom;
            pictureBox1.Height += heightZoom;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZoomInOut(false);
        }

        private void hScrollBar1_DragEnter(object sender, DragEventArgs e)
        {
        }

        public Examen examen = new();
        private void ExamenRevisar_Load(object sender, EventArgs e)
        {
            lbox_Alumnos.Items.Clear();
            //examenes particulares
            List<int> lista = Sql.ObtenerExamenesID(examen.GetID());
            List<Materia>? materias = SqlMateria.ObtenerMaterias("idUserP_Asignado",usuarioActivo.GetID());
            foreach (var alumnoID in lista)
            {
                foreach(var materia in materias)
                {
                    string nombre = SqlAlumnos.ObtenerAlumno(alumnoID).GetNombre();
                    Alumno? alumno = SqlAlumnos.ObtenerAlumno(nombre, materia.GetID());
                
                    if(alumno != null && usuarioActivo != null && materia != null && alumno.materiaA == materia.GetID())
                    {
                        lbox_Alumnos.Items.Add(alumno.GetNombre());
                    }
                }
                //Materia materia = SqlMateria.ObtenerMateria(alumno.materiaA);
                //int profesorID = SqlUsuario.ObtenerUsuarioActivo().GetID();
                //if(SqlMateria.ObtenerMateria(alumno.materiaA).GetProfesorAsignado() == profesorID)
                //if (Materias.MateriafromList(alumno.materiaA).GetProfesorAsignado() == profesorID || Materias.MateriafromList(alumno.materiaB).GetProfesorAsignado() == profesorID)
            }            
                //foreach (var examenSel in Examenes.listaExamenes)
                //{
                //    foreach(KeyValuePair<int,decimal> idExamen in Examenes.NotasExamenes)
                //    {
                //        Examen examenFinded = Examenes.listaExamenes.Find(objeto => objeto.GetID() == idExamen.Key);                        
                //        if(examenFinded != null && (alumno.materiaA == examenSel.materia || alumno.materiaB == examenSel.materia))
                //        {
                //            Alumno? alumnoExported = Materias.ConfirmarAsistencia(alumno,examenSel.fecha);
                //            if (alumnoExported != null)
                //            {
                //                lbox_Alumnos.Items.Add(alumnoExported.GetNombre());
                //            }
                //        }
                //    }
                //}
            
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            decimal nota = nSel_NotaExamen.Value;
            Materia? materia = SqlMateria.ObtenerMateria("id",examen.materia);
            if(lbox_Alumnos.SelectedItem != null && materia != null)
            {
                Alumno? alumno = SqlAlumnos.ObtenerAlumno(lbox_Alumnos.SelectedItem.ToString(),materia.GetID());
                if(alumno != null)
                {
                    Sql.ActualizarExamenesAlumnos(alumno.GetID(),examen.GetID(),nota);
                }

                if(Sql.ObtenerNota(alumno.GetID(),examen.GetID()).GetNotaExamen() == nota)
                {
                    MessageBox.Show("Nota guardada " + nota);
                }

            }

            /*
            Usuario profesor = SqlUsuario.ObtenerUsuarioActivo();
            Alumno alumno = SqlAlumnos.ObtenerAlumno(lbox_Alumnos.Text, materiaSel.GetID());
            Materia materiaSel = SqlMateria.ObtenerMateria(alumno.materiaA);
            //Materia materiaSel = Materias.listaMaterias.Find(objeto => objeto.GetProfesorAsignado() == profesor.GetID());
            Examen examen = Sql.ObtenerExamenIDAlumno(alumno.GetID());
            //int idExamen = Examenes.listaExamenes.Find(objeto => objeto.materia == materiaSel.GetID()).GetID();

            decimal notaExamen = nSel_NotaExamen.Value;
            Notas nota = new();
            nota.SetAlumnoID(alumno.GetID());
            nota.SetExamenId(examen.GetID());
            nota.SetNotaExamen(notaExamen);
            Sql.ActualizarExamenesAlumnos(alumno.GetID(),nota);
            //Examenes.NotasExamenes.Add(nota);
            */
        }
    }
}
