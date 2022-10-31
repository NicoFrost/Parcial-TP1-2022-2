using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            usuario.Id++;
            usuario.Name = txtB_User.Text;
            usuario.Password = txtB_Password.Text;
            if (rb_Admin.Checked)
            {
                usuario.Permisos = "Admin";
            } else if (rb_Profesor.Checked)
            {
                usuario.Permisos = "Profe";
            } else if (rb_Alumno.Checked)
            {
                usuario.Permisos = "Alumno";
            }
            
            
            Entidades.listaUsuarios.Add(usuario);

            MessageBox.Show($"Has creado y metido el usuario: Nombre:{usuario.Name} Pass: {usuario.Password} y con acceso de {usuario.Permisos}");
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
