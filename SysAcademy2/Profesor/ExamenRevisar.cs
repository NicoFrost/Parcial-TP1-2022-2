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
using D = datos.Usuarios;

namespace SysAcademy2
{
    public partial class ExamenRevisar : Form
    {
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

        private void ExamenRevisar_Load(object sender, EventArgs e)
        {
            lbox_Alumnos.Items.Clear();
            var listaAlumnos = Examenes.FiltroAlumnEnExamen(D.listaAlumnos);
            foreach(var alumno in listaAlumnos)
            {
                int profesorID = D.BuscarActivo().GetID();
                if (Materias.MateriafromList(alumno.materiaA).GetProfesorAsignado() == profesorID || Materias.MateriafromList(alumno.materiaB).GetProfesorAsignado() == profesorID)
                {
                    lbox_Alumnos.Items.Add(alumno.GetNombre());
                }
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
            Usuario profesor = D.BuscarActivo();
            int idAlumno = D.BuscarUsuario(lbox_Alumnos.Text);
            Materia materiaSel = Materias.listaMaterias.Find(objeto => objeto.GetProfesorAsignado() == profesor.GetID());
            int idExamen = Examenes.listaExamenes.Find(objeto => objeto.materia == materiaSel.GetID()).GetID();
            decimal notaExamen = nSel_NotaExamen.Value;
            Notas nota = new();
            nota.SetAlumnoID(idAlumno);
            nota.SetExamenId(idExamen);
            nota.SetNotaExamen(notaExamen);
            Examenes.NotasExamenes.Add(nota);
        }
    }
}
