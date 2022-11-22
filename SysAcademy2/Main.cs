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
using datos;
using D = datos.Usuarios;
using System.Drawing.Text;
using U = datos.UsuarioPermisos;
using SysAcademy2;

namespace SysAcademy
{
    public partial class Main : Form
    {   
        public Usuario? usuarioActivo = SqlUsuario.ObtenerUsuarioActivo();
        public Main()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void accesoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void accesoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {
//            usuarioActivo = Sql.ObtenerUsuarioActivo();
//          usuarioActivo = D.listaUsuarios.Find(objecto => objecto.activo == true);
            string BienvenidoMsg = "Bienvenido, " + usuarioActivo.GetNombre();
            Mensaje.Text = BienvenidoMsg;

            //Busqueda de permisos
            { 
            //Admin
            if (Sql.VerificarPermisos(estadosAlumnosToolStripMenuItem.Text)) {
                estadosAlumnosToolStripMenuItem.Enabled = true;
            }
            if (Sql.VerificarPermisos(asignacionProfesToolStripMenuItem.Text))
            {
                asignacionProfesToolStripMenuItem.Enabled = true;
            }
            if (Sql.VerificarPermisos(nuevaMateriaToolStripMenuItem.Text)) {
                nuevaMateriaToolStripMenuItem.Enabled = true;

            }
            if (estadosAlumnosToolStripMenuItem.Enabled || asignacionProfesToolStripMenuItem.Enabled || nuevaMateriaToolStripMenuItem.Enabled)
            {
                estadosMateriasToolStripMenuItem.Enabled = true;
            } else
            {
                estadosMateriasToolStripMenuItem.Enabled = false;
            }

            if (Sql.VerificarPermisos(nuevoUsuarioToolStripMenuItem.Text)) {
                nuevoUsuarioToolStripMenuItem.Enabled = true;
            }
            if (nuevoUsuarioToolStripMenuItem.Enabled || estadosMateriasToolStripMenuItem.Enabled)
            {
                administradorToolStripMenuItem.Enabled = true;
            }

            //Profes
            if (Sql.VerificarPermisos(listaToolStripMenuItem1.Text))
            {
                listaToolStripMenuItem1.Enabled = true;
            }
            if (Sql.VerificarPermisos(crearToolStripMenuItem.Text))
            {
                crearToolStripMenuItem.Enabled = true;
            }
            if (listaToolStripMenuItem1.Enabled || crearToolStripMenuItem.Enabled)
            {
                examenesToolStripMenuItem.Enabled = true;
            }
            //Alumno
            if (Sql.VerificarPermisos("Inscribirse a materias"))
            {
                Image imagenInscripcion = Image.FromFile("E:\\2022 2do cuatri\\TP1\\Sol1\\img\\inscAct.png");
                pb_Inscripcion.Enabled = true;
                pb_Inscripcion.Image = imagenInscripcion;

                Image imagenClassroom = Image.FromFile("E:\\2022 2do cuatri\\TP1\\Sol1\\img\\classAct.jpg");
                class1.Enabled = true;
                class1.Image = imagenClassroom;
                class2.Enabled = true;
                class2.Image = imagenClassroom;
                class3.Enabled = true;
                class3.Image = imagenClassroom;
                class4.Enabled = true;
                class4.Image = imagenClassroom;

                cbox_materia.Enabled = true;
                
            }
            if (Sql.VerificarPermisos("Dar Asistencia a materias"))
            {
                Image imagenAsistencia = Image.FromFile("E:\\2022 2do cuatri\\TP1\\Sol1\\img\\asisAct.jpg");
                pb_asistencias.Enabled = true;
                pb_asistencias.Image = imagenAsistencia;
            }
            }
            //Cargar solo los que tengan una afiliacion con el alumno activo
        }


        private void materiasToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
        }

        private void estadosMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro quiere cerrar sesion?","info",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                SqlUsuario.ActualizarUsuario(usuarioActivo, "activo", 0);
                //D.listaUsuarios[D.BuscarActivoIndex(D.listaUsuarios)].activo = false;   
                Close();
            }           
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (usuarioActivo.perfil == "Admin") // Validar permiso
            CreacionUser usuarioNuevo = new CreacionUser();
            usuarioNuevo.Show();            
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Docentes docentes = new Docentes();
                docentes.Show();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DocenteLista FlistaExamen = new DocenteLista();
            FlistaExamen.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearMaterias crearMaterias = new();
            crearMaterias.Show();
        }

        private void asignacionProfesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionMateria asignacionMateria = new();
            asignacionMateria.Show();
        }

        private void pb_Inscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion FrmInscripcion = new();
            FrmInscripcion.Show();
        }

        private void pb_asistencias_Click(object sender, EventArgs e)
        {
            //if (cbox_materia.SelectedItem != null)
            //{
                Asistencia FrmAsistencia = new();
                FrmAsistencia.Show();
            //} 
            //else 
            //{
            //    MessageBox.Show("No se selecciono una materia", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //Da la asistencia a la materia que esta seleccionada, en caso de no estar seleccionada salta un Warning
        }

        private void estadosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoAlumnos frmEAlumnos = new();
            frmEAlumnos.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (usuarioActivo != null) { 
    //          Usuario activeUser = D.BuscarActivo();
                Alumno? alumno = SqlAlumnos.ObtenerAlumno(usuarioActivo.GetID());
                if (alumno != null)
                {
                    int idMateria = alumno.materiaA;
                    Materia? materia = SqlMateria.ObtenerMateria("id",idMateria);
                  //Materia materia = Materias.MateriafromList(idMateria);
                    if (idMateria != -1 && !cbox_materia.Items.Contains(materia.GetNombre()))
                    {
                        cbox_materia.Items.Add(materia.GetNombre());
                    }
                }

                //buscar Conexion entre Examen y Alumno Activo
                if (usuarioActivo.GetPerfil() == "Alumno")
                {
                    List<Examen> Lista = Sql.ObtenerTodosLosExamenes();
                    List<AsistenciaAlumno> ListaAsistencia = SqlAlumnos.ObtenerAsistencias("idAlumno", usuarioActivo.GetID());
                    foreach (var examen in Lista)
                    {
                        foreach (var asistencia in ListaAsistencia)
                        {
                            if (examen.fecha == asistencia.fecha)
                            {
                                Sql.CrearExamenesAlumnos(asistencia.idAlumno,examen.GetID());
                            }
                        }
                    }
                }
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Escape == e.KeyCode)
            {
                if (MessageBox.Show("Seguro quiere cerrar sesion?", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    D.listaUsuarios[D.BuscarActivoIndex(D.listaUsuarios)].activo = false;
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usuarioActivo != null && usuarioActivo.GetPerfil() == "Alumno")
            {
                MostrarDatos FrmMostrarDatos = new();
                FrmMostrarDatos.Show();
            }
        }
    }
}
