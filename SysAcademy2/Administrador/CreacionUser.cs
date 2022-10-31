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
using D = datos.Usuarios;

namespace SysAcademy
{
    public partial class CreacionUser : Form
    {
        public CreacionUser()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.SetID(D.IdIncremental(D.listaUsuarios));
            usuario.SetNombre(txtB_User.Text);
            usuario.SetPassword(txtB_Password.Text);
            if (rb_Admin.Checked)
            {
                usuario.SetPerfil("Admin");
            } else if (rb_Profesor.Checked)
            {
                usuario.SetPerfil("Profe");
            } else if (rb_Alumno.Checked)
            { 
                usuario.SetPerfil("Alumno");
            }
            D.AgregarUsuario(usuario, D.listaUsuarios);
            MessageBox.Show($"Has creado y metido el usuario: Nombre:{usuario.GetNombre()} Pass: {usuario.GetPassword()} y con acceso de {usuario.GetPerfil()}",$"{usuario.GetID()}");
            Close(); 
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
