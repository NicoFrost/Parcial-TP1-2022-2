using datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcademy2
{
    public partial class Asistencia : Form
    {
        Usuario? ActiveUser = SqlUsuario.ObtenerUsuarioActivo();
        public Asistencia()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (cbox_materia.SelectedItem != null)
            {
                if (ActiveUser != null)
                {

                    AsistenciaAlumno asistenciaNueva = new();
                    asistenciaNueva.fecha = FCal_diaAsistencia.SelectionRange.Start;
                    asistenciaNueva.idAlumno = ActiveUser.GetID();
                    Materia materia = SqlMateria.ObtenerMateria(cbox_materia.SelectedItem.ToString());
                    if(materia != null)
                    {
                        SqlAlumnos.InsertarAsistencia(asistenciaNueva.idAlumno, materia.GetID(), asistenciaNueva.fecha);
                        List<AsistenciaAlumno> verifAsistencia = SqlAlumnos.ObtenerAsistencias("idAlumno", asistenciaNueva.idAlumno);
                        foreach(var asistencia in verifAsistencia)
                        {
                            if(asistencia.fecha == asistenciaNueva.fecha)
                            {
                                MessageBox.Show("Asistencia guardada\nAsistencia " + asistencia.fecha.ToShortDateString());
                                Close();
                                break;
                            } else
                            {
                                MessageBox.Show("ERROR en guardado, Contactese con un Administrador");
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se selecciono una materia", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            if(ActiveUser != null)
            {
                Alumno? alumno = SqlAlumnos.ObtenerAlumno(ActiveUser.GetID());
                if (alumno != null)
                {
                    int idMateria = alumno.materiaA;
                    List<Materia> materias = SqlAlumnos.ObtenerMateria(idMateria);
                    foreach(var materia in materias)
                    {
                        if (idMateria != -1 && !cbox_materia.Items.Contains(materia.GetNombre()))
                        {
                            cbox_materia.Items.Add(materia.GetNombre());
                        }
                    }
                }
            }
        }
    }
}
