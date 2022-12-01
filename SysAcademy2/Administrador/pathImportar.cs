using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcademy2.Administrador
{
    public partial class pathImportar : Form
    {
        public string path = "";
        private string defaultpath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        public pathImportar()
        {
            InitializeComponent();
            txt_path.Text = defaultpath;
            txt_nombre.Text = "Alumnos Exportados.json";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path = txt_path.Text + "\\" + txt_nombre.Text;
            Close();
        }

        private void cbx_direccion_CheckedChanged(object sender, EventArgs e)
        {
            txt_path.Enabled = cbx_direccion.Checked;
            if (cbx_direccion.Checked)
            {
                txt_path.Text = "";
                txt_nombre.Text = "";
            } else
            {
                txt_path.Text = defaultpath;
                txt_nombre.Text = "Alumnos Exportados.json";
            }
        }
    }
}
