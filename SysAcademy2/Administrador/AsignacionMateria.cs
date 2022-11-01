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
using M = datos.Materias;

namespace SysAcademy2
{
    public partial class AsignacionMateria : Form
    {
        public AsignacionMateria()
        {
            InitializeComponent();
        }

        private void AsignacionMateria_Load(object sender, EventArgs e)
        {
            Cbx_Profesores.Items.Clear();
            foreach (var Usuarios in Usuarios.listaUsuarios)
            {
                if (Usuarios.GetPerfil() == "Profesor")
                    Cbx_Profesores.Items.Add(Usuarios.GetNombre());
            }
            listBox1.Items.Clear();
            foreach(var materia in Materias.listaMaterias)
            {
                listBox1.Items.Add(materia.GetNombre());
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                string buscar = listBox1.SelectedItem.ToString();
                var materia = M.listaMaterias.Find(objeto => objeto.GetNombre() == buscar);
                txt_Nombre.Text = materia.GetNombre();
                int ProfesorID = materia.GetProfesorAsignado();
                var UserProfesor = Usuarios.UsuariofromList(ProfesorID);
                if (!(UserProfesor == null || ProfesorID == -1))
                {
                    Cbx_Profesores.Text = UserProfesor.GetNombre();
                } else
                {
                    Cbx_Profesores.Text = null;
                };
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            foreach(var materia in M.listaMaterias)
            {
                if(listBox1.SelectedItem.ToString() == materia.GetNombre())
                {
                    materia.SetProfesorAsignado(Usuarios.BuscarUsuario(Cbx_Profesores.Text));
                    //materia.profesorAsignado = Cbx_Profesores.Text;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
