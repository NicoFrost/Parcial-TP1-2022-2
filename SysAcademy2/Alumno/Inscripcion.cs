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
using M = datos.Materias;
using System.Security.Cryptography.X509Certificates;

namespace SysAcademy2
{
    public partial class InscripcionAdmin : Form
    {
        public InscripcionAdmin()
        {
            InitializeComponent();
        }

        private void btnc_InsBaja_Click(object sender, EventArgs e)
        {
            if(lb_TotMaterias.SelectedItems != null)
            {
                string materiaElegida = lb_TotMaterias.SelectedItem.ToString();
                Alumno alumno = new();
                var usuario = Usuarios.BuscarActivo();
                alumno = Usuario.ConvertirAlumno(usuario);

                int idMateriaElegida = Materias.BuscarMateria(materiaElegida);
                if (materiaElegida != null && idMateriaElegida != -1)
                {
                    if (!Usuarios.listaUsuarios.Contains(alumno) && Usuarios.BuscarAlumno(alumno.GetNombre()) == -1)
                    {
                        alumno.materiaA = idMateriaElegida;
                        Usuarios.listaAlumnos.Add(alumno);
                        btnc_InsBaja.Text = "Dejar de Cursar";
                    }
                    else
                    {
                        var alumnoExported = Usuarios.AlumnofromList(alumno.GetID());
                        if (alumnoExported != null && alumnoExported.materiaA != -1 && (alumnoExported.materiaA != idMateriaElegida && alumnoExported.materiaB != idMateriaElegida))
                        {
                            int id = Usuarios.BuscarAlumno(alumno.GetNombre());
                            var alumnoList = Usuarios.AlumnofromList(id);
                            alumnoList.materiaB = idMateriaElegida;
                            btnc_InsBaja.Text = "Dejar de Cursar";
                        }
                        else
                        {
                            string mensaje;
                            if(alumnoExported.materiaA != -1 && alumnoExported.materiaB != -1)
                            {
                                mensaje = "Ya esta inscripto en 2 materias al mismo tiempo";
                            }
                            else
                            {
                                mensaje = "Ya esta inscripto en esa materia";
                            }
                            MessageBox.Show(mensaje);
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lb_TotMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = Materias.BuscarMateria(lb_TotMaterias.SelectedItem.ToString());
            Alumno alumnoExported = Usuarios.AlumnofromList(Usuarios.BuscarActivo().GetID());
            if (Usuarios.VerifMaterias(alumnoExported,idMateria))
            {
                btnc_InsBaja.Text = "Dejar de cursar";
            }
            else
            {
                btnc_InsBaja.Text = "Inscribirse";
            }
                lb_Correlativas.Items.Clear(); 
                lb_TotMaterias_Click(sender, e);
        }
        private void lb_TotMaterias_Click(object sender, EventArgs e)
        {
            if (lb_TotMaterias.SelectedItem != null)
            {
                int idMateria = M.BuscarMateria(lb_TotMaterias.SelectedItem.ToString());

                Materia materia = M.MateriafromList(idMateria);
                for (int i = 0; i < materia.correlativas.Count; i++)
                {
                    lb_Correlativas.Items.Add(materia.correlativas[i].GetNombre());
                }
            }
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            foreach(var materia in M.listaMaterias)
            {
                lb_TotMaterias.Items.Add(materia.GetNombre());
            }
        }


    }
}
