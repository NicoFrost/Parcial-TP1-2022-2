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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario administradorRoot = new Usuario();
            administradorRoot.id = 0;
            administradorRoot.nombre = "Administrador";
            administradorRoot.password = "admin";
            administradorRoot.permisos = "Admin";
            Program.listaUsuarios.Add(administradorRoot);
            Entidades.Funcion.id;
            Usuario usuario = new Usuario();

            if(Program.listaUsuarios.Count > 0)
            {
                usuario = Entidades.listaUsuarios.Find(x => x.Name.Contains(txt_name.Text));
                if (usuario.Password == txt_password.Text)
                {
                    Inicio inicioSesion = new Inicio();
                    Main ventanaPrincipal = new Main();
                    ventanaPrincipal.Show();
                    inicioSesion.Close();
                } else
                {
                    MessageBox.Show("Usuario o Contraseña erroneos","WARNING 1",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("NO hay usuarios cargados", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
