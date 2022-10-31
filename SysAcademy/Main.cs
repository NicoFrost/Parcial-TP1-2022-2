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
    public partial class Main : Form
    {   

        public string BienvenidoMsg;
        public Main()
        {

            InitializeComponent();
            BienvenidoMsg = Mensaje.Text;
            BienvenidoMsg = BienvenidoMsg + "USUARIO";
            Mensaje.Text = BienvenidoMsg;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accesoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (true) // Validar permiso
            {
                CreacionUser usuarioNuevo = new CreacionUser();
                usuarioNuevo.Show();
            }
        }

        private void accesoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (true) // Validar permiso
            {
                Docentes docentes = new Docentes();
                docentes.Show();
            }
        }
    }
}
