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
using System.Security.Cryptography.X509Certificates;

namespace SysAcademy2
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void btnc_InsBaja_Click(object sender, EventArgs e)
        {
            if(lb_TotMaterias.SelectedItems != null)
            {
                string materiaElegida = lb_TotMaterias.SelectedItem.ToString();
                Alumno alumno = new();
                var usuario = SqlUsuario.ObtenerUsuarioActivo();
                alumno = Usuario.ConvertirAlumno(usuario);
                Materia materia = SqlMateria.ObtenerMateria(materiaElegida);

                if (SqlAlumnos.CantMateriasAlumno(alumno.GetID()) != 2)
                { if(materia != null)
                    {
                        if (SqlAlumnos.VerifMateriasAlumno(alumno.GetID(), materia.GetID()))
                        {
                            alumno.materiaA = materia.GetID();
                            SqlAlumnos.InsertarAlumno(alumno);
                            //Usuarios.listaAlumnos.Add(alumno);
                            btnc_InsBaja.Text = "Dejar de Cursar";
                        }
                        else
                        {
                            MessageBox.Show("Aqui deberias poder desinscribirte");
                        }
                    } else
                    {
                        MessageBox.Show("ERRROR, Contacte un Administrador");
                    }

                } else
                {
                    MessageBox.Show("Ya esta inscripto en 2 materias al mismo tiempo");
                }

              /*if (materiaElegida != null && materia != null)
                {
                    if (!Usuarios.listaUsuarios.Contains(alumno) && Usuarios.BuscarAlumno(alumno.GetNombre()) == -1)
                    {
                        alumno.materiaA = materia.GetID();
                        SqlAlumnos.InsertarAlumno(alumno);
                        //Usuarios.listaAlumnos.Add(alumno);
                        btnc_InsBaja.Text = "Dejar de Cursar";
                    }
                    else
                    {
                        var alumnoExported = SqlAlumnos.ObtenerAlumno(alumno.GetID());
                        /*if (alumnoExported != null && alumnoExported.materiaA != -1 && (alumnoExported.materiaA != idMateriaElegida && alumnoExported.materiaB != idMateriaElegida))
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
                }*/
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lb_TotMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario? active = SqlUsuario.ObtenerUsuarioActivo();
            if (lb_TotMaterias.SelectedItem != null && active != null)
            {

                Materia? materia = SqlMateria.ObtenerMateria(lb_TotMaterias.SelectedItem.ToString());
                Alumno? alumnoExported = SqlAlumnos.ObtenerAlumno(active.GetID());
                if (materia != null && alumnoExported != null)
                {
                    if (SqlAlumnos.VerifMateriasAlumno(alumnoExported.GetID(), materia.GetID()))
                    //if (Usuarios.VerifMaterias(alumnoExported, materia.GetID()))
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
            }
        }
        private void lb_TotMaterias_Click(object sender, EventArgs e)
        {
            if (lb_TotMaterias.SelectedItem != null)
            {
                Materia? materia = SqlMateria.ObtenerMateria(lb_TotMaterias.SelectedItem.ToString());
                if(materia != null)
                {
                    List<Materia>? correlativas = SqlMateria.ObtenerTodasLasCorrelativas(materia.GetID());
                    if (correlativas != null)
                    {
                        foreach(var correlativa in correlativas)
                        {
                            lb_Correlativas.Items.Add(correlativa.GetNombre());
                        }
                    }
                }
            }
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            foreach(var materia in Sql.ObtenerTodasLasMaterias())
            {
                lb_TotMaterias.Items.Add(materia.GetNombre());
            }
        }


    }
}
