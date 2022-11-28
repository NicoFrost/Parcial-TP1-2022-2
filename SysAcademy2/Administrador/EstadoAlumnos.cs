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
using datos;


namespace SysAcademy2
{
    public partial class EstadoAlumnos : Form
    {
        public EstadoAlumnos()
        {
            InitializeComponent();
        }

        private void EstadoAlumnos_Load(object sender, EventArgs e)
        {
            lb_Alumnos.Items.Clear();
            lb_materias.Items.Clear();
            foreach (var materia in /*Sql.ObtenerTodasLasMaterias()*/SqlG<Materia>.ObtenerTodosdelDatoT())
            {
                lb_materias.Items.Add(materia.GetNombre());
            }
        }

        private void lb_materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Alumnos.Items.Clear();
            if(lb_materias.SelectedIndex != null)
            {
                Materia materia = SqlMateria.ObtenerMateria(lb_materias.SelectedItem.ToString());
              //Materia materia = Materias.listaMaterias.Find(objecto => objecto.GetNombre() == lb_materias.SelectedItem.ToString());
                if (materia != null)
                {
                    List<Alumno>? alumnos = SqlAlumnos.AlumnosAnotados(materia);
                    //List<Alumno> alumnos = Usuarios.listaAlumnos.FindAll(objeto => objeto.materiaA == materia.GetID() || objeto.materiaB == materia.GetID());
                    if(alumnos != null)
                    {
                        foreach (var alumno in alumnos)
                        {
                            if (!lb_Alumnos.Items.Contains(alumno.GetNombre())){
                                lb_Alumnos.Items.Add(alumno.GetNombre());
                            }
                        }
                    }
                
                }
                rbtn_Regular.Checked = false;
                rbtn_Libre.Checked = false;
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Materia? materia = SqlMateria.ObtenerMateria(lb_materias.SelectedItem.ToString());
            Alumno? alumno = SqlAlumnos.ObtenerAlumno(lb_Alumnos.SelectedItem.ToString(),materia.GetID());
            if (materia != null && alumno != null && (rbtn_Libre.Checked || rbtn_Regular.Checked))
            {
                if (rbtn_Libre.Checked)
                {
                    SqlAlumnos.ActualizarAlumno(alumno.GetID(), materia.GetID(), 0);
                    //Alumno.SetEstadoMateria(materia, alumno, false);
                }
                if (rbtn_Regular.Checked)
                {
                    SqlAlumnos.ActualizarAlumno(alumno.GetID(), materia.GetID(), 1);
                    //Alumno.SetEstadoMateria(materia, alumno, true);
                }
            } else
            {
                MessageBox.Show("No se selecciono estado del alumno");
            }
        }

        private void lb_Alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Alumnos.SelectedItem != null)
            {
                Materia? materia = SqlMateria.ObtenerMateria(lb_materias.SelectedItem.ToString());
                Alumno? alumno = SqlAlumnos.ObtenerAlumno(lb_Alumnos.SelectedItem.ToString(), materia.GetID());
                if (alumno != null)
                {
                    if(alumno.estadoMA)
                    {
                        rbtn_Regular.Checked = true;
                    } else
                    {
                        rbtn_Libre.Checked = true;
                    }
                }
            }
        }
    }
}
