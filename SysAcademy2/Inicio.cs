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
using System.DirectoryServices.ActiveDirectory;

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
            Usuario usuario = new Usuario();

            if(D.listaUsuarios.Count > 0)
            {
//                usuario = D.listaUsuarios.Find(x => x.nombre.Contains(txt_name.Text));
                usuario = D.listaUsuarios.Find(objeto => objeto.GetNombre().Contains(txt_name.Text));
                int i = D.listaUsuarios.FindIndex(x => x.GetNombre().Contains(txt_name.Text));
                if (usuario != null && usuario.GetPassword() == txt_password.Text)
                {
                    Inicio inicioSesion = new Inicio();
                    D.listaUsuarios[i].activo = true;
                    Main ventanaPrincipal = new Main();
                    txt_name.Text = "";
                    txt_password.Text = "";
                    ventanaPrincipal.ShowDialog();
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

        private void Inicio_Activated(object sender, EventArgs e)
        {
            int index = D.BuscarActivoIndex(D.listaUsuarios);
            if (index != -1 && D.listaUsuarios[index].activo == true)
            {
                D.listaUsuarios[index].activo = false;   
            }
            else 
            {

            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            txt_name.Text = "Administrador";
            txt_password.Text = "admin";
        }

        private void btn_Alum_Click(object sender, EventArgs e)
        {
            txt_name.Text = "Dario";
            txt_password.Text = "BocaEl+Grande";
        }

        private void btn_Profe_Click(object sender, EventArgs e)
        {
            txt_name.Text = "Martin";
            txt_password.Text = "luciano2002";
        }
    }
}
