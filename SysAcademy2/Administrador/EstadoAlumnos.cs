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
            foreach (var materia in Materias.listaMaterias)
            {
                lb_materias.Items.Add(materia.GetNombre());
            }
        }

        private void lb_materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Alumnos.Items.Clear();
            Materia materia = Materias.listaMaterias.Find(objecto => objecto.GetNombre() == lb_materias.SelectedItem.ToString());
            if (materia != null)
            {
                List<Alumno> alumnos = Usuarios.listaAlumnos.FindAll(objeto => objeto.materiaA == materia.GetID() || objeto.materiaB == materia.GetID());
                foreach(var alumno in alumnos)
                {
                    if (!lb_Alumnos.Items.Contains(alumno.GetNombre())){
                        lb_Alumnos.Items.Add(alumno.GetNombre());
                    }
                }
                
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Materia materia = Materias.listaMaterias.Find(objeto => objeto.GetNombre() == lb_materias.SelectedItem.ToString());
            Alumno alumno = Usuarios.listaAlumnos.Find(objeto => objeto.GetNombre() == lb_Alumnos.SelectedItem.ToString());
            if (rbtn_Libre.Checked)
            {
                Alumno.SetEstadoMateria(materia, alumno, false);
            }
            if (rbtn_Regular.Checked)
            {
                Alumno.SetEstadoMateria(materia, alumno, true);
            }
        }
    }
}
