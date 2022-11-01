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
using SysAcademy2.Administrador;

namespace SysAcademy
{
    public partial class Main : Form
    {   
        public Usuario usuarioActivo = new Usuario();
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
            usuarioActivo = D.listaUsuarios.Find(objecto => objecto.activo == true);
            string BienvenidoMsg = "Bienvenido, " + usuarioActivo.GetNombre();
            Mensaje.Text = BienvenidoMsg;

            //Busqueda de permisos
            { 
            //Admin
            if (U.BuscarPermisos(estadosAlumnosToolStripMenuItem.Text, usuarioActivo.GetID())) {
                estadosAlumnosToolStripMenuItem.Enabled = true;
            }
            if (U.BuscarPermisos(asignacionProfesToolStripMenuItem.Text, usuarioActivo.GetID()))
            {
                asignacionProfesToolStripMenuItem.Enabled = true;
            }
            if (U.BuscarPermisos(nuevaMateriaToolStripMenuItem.Text, usuarioActivo.GetID())) {
                nuevaMateriaToolStripMenuItem.Enabled = true;

            }
            if (estadosAlumnosToolStripMenuItem.Enabled || asignacionProfesToolStripMenuItem.Enabled || nuevaMateriaToolStripMenuItem.Enabled)
            {
                estadosMateriasToolStripMenuItem.Enabled = true;
            } else
            {
                estadosMateriasToolStripMenuItem.Enabled = false;
            }

            if (U.BuscarPermisos(nuevoUsuarioToolStripMenuItem.Text, usuarioActivo.GetID())) {
                nuevoUsuarioToolStripMenuItem.Enabled = true;
            }
            if(U.BuscarPermisos(estadisticasToolStripMenuItem.Text, usuarioActivo.GetID())){
                estadisticasToolStripMenuItem.Enabled = true;
            }
            if (nuevoUsuarioToolStripMenuItem.Enabled || estadosMateriasToolStripMenuItem.Enabled || estadisticasToolStripMenuItem.Enabled)
            {
                administradorToolStripMenuItem.Enabled = true;
            }
            

            //Profes
            if (U.BuscarPermisos(listaToolStripMenuItem1.Text, usuarioActivo.GetID()))
            {
                listaToolStripMenuItem1.Enabled = true;
            }
            if (U.BuscarPermisos(crearToolStripMenuItem.Text, usuarioActivo.GetID()))
            {
                crearToolStripMenuItem.Enabled = true;
            }
            if (listaToolStripMenuItem1.Enabled || crearToolStripMenuItem.Enabled)
            {
                examenesToolStripMenuItem.Enabled = true;
            }
            //Alumno
            string ArchivosDelPrograma = "C:\\Users\\alumno\\Documents\\Visual Studio 2022\\Templates\\ProjectTemplates\\C#\\Parcial-TP1-2022-2-master";
            if (U.BuscarPermisos("Inscribirse a materias", usuarioActivo.GetID()))
            {
                Image imagenInscripcion = Image.FromFile($"{ArchivosDelPrograma}\\img\\inscAct.png");
                pb_Inscripcion.Enabled = true;
                pb_Inscripcion.Image = imagenInscripcion;

                Image imagenClassroom = Image.FromFile($"{ArchivosDelPrograma}\\img\\classAct.jpg");
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
            if (U.BuscarPermisos("Dar Asistencia a materias", usuarioActivo.GetID()))
            {
                Image imagenAsistencia = Image.FromFile($"{ArchivosDelPrograma}\\img\\asisAct.jpg");
                pb_asistencias.Enabled = true;
                pb_asistencias.Image = imagenAsistencia;
            }
            if(U.BuscarPermisos("Inscripcion de Alumnos", usuarioActivo.GetID()))
                {
                    Image imagenInscripcion = Image.FromFile($"{ArchivosDelPrograma}\\img\\inscAct.png");
                    pb_Inscripcion.Enabled = true;
                    pb_Inscripcion.Image = imagenInscripcion;
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
                D.listaUsuarios[D.BuscarActivoIndex(D.listaUsuarios)].activo = false;   
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
            string perfilUserActive = D.BuscarActivo().GetPerfil();
            switch (perfilUserActive)
            {
                case "Alumno":
                    InscripcionAdmin FrmInscripcion = new();
                    FrmInscripcion.Show();
                    break;
                case "Admin":
                    InscripcionSuper FrmInscripcionSuper = new();
                    FrmInscripcionSuper.Show();
                    break;
            }

        }

        private void pb_asistencias_Click(object sender, EventArgs e)
        {
            if (cbox_materia.SelectedItem != null)
            {
                Asistencia FrmAsistencia = new();
                FrmAsistencia.Show();
            } 
            else 
            {
                MessageBox.Show("No se selecciono una materia", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Da la asistencia a la materia que esta seleccionada, en caso de no estar seleccionada salta un Warning
        }

        private void estadosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoAlumnos frmEAlumnos = new();
            frmEAlumnos.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            Usuario activeUser = D.BuscarActivo();
            Alumno alumno = D.AlumnofromList(activeUser.GetID());
            if (alumno != null)
            {
                int idMateria = alumno.materiaA;
                Materia materia = Materias.MateriafromList(idMateria);
                if (idMateria != -1 && !cbox_materia.Items.Contains(materia.GetNombre()))
                {
                    cbox_materia.Items.Add(materia.GetNombre());
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
            if(D.BuscarActivo().GetPerfil() == "Alumno")
            {
                MostrarDatos FrmMostrarDatos = new();
                FrmMostrarDatos.Show();
            }
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantInscriptos = D.listaAlumnos.Count,cantNotas = Examenes.NotasExamenes.Count;
            decimal notaTotal = 0;
            
            var listaUsersAl = D.listaAlumnos.FindAll(objeto => objeto.GetPerfil() == "Alumno");
            int cantUsuariosAlumnos = listaUsersAl.Count;
            foreach(var notas in Examenes.NotasExamenes)
            {
                notaTotal =+ notas.GetNotaExamen();
            }
            if(cantNotas > 0)
            {
                decimal promedioNotas = notaTotal / cantNotas;
                MessageBox.Show($"al momento las notas promedio son de {promedioNotas}");
            }
            if(cantInscriptos > 0)
            {
                decimal promedioinscripcion = cantUsuariosAlumnos / cantInscriptos;
                MessageBox.Show($"al momento el promedio de alumnos inscriptos es de {promedioinscripcion}");
            }
        }
    }
}
