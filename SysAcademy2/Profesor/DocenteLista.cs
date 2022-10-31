using datos;
using Entidades;
using SysAcademy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcademy2
{
    public partial class DocenteLista : Form
    {
        public DocenteLista()
        {
            InitializeComponent();
        }

        private void DocenteLista_Load(object sender, EventArgs e)
        {
            lbl_Fecha.Text = "";
            lbl_Nombre.Text = "";
            lbl_Profesor.Text = "";
            lbl_Materia.Text = "";
            lb_Examenes.Items.Clear();
            foreach (var examen in Examenes.listaExamenes)
            {
                lb_Examenes.Items.Add(examen.GetNombre());
            }
        }

        private void lb_Examenes_Click(object sender, EventArgs e)
        {
            if(lb_Examenes.SelectedItem != null)
            {
                string examenSel = lb_Examenes.SelectedItem.ToString();
                foreach (var examen in Examenes.listaExamenes)
                {
                    if (examen.GetNombre() == examenSel)
                    {
                        Materia materia = Materias.MateriafromList(examen.materia);
                        Usuario profesor = Usuarios.UsuariofromList(materia.GetProfesorAsignado());
                        lbl_Nombre.Text = examen.GetNombre();
                        lbl_Fecha.Text = examen.fecha.Date.ToString();
                        lbl_Profesor.Text = profesor.GetNombre();
                        lbl_Materia.Text = materia.GetNombre();
                    }
                }
                
            }
            
        }

        private void btn_Revisar_Click(object sender, EventArgs e)
        {
            ExamenRevisar FrmRevisar = new();
            FrmRevisar.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Usuario ActiveUser = Usuarios.BuscarActivo();
            if (Usuarios.VerifProfesor(lbl_Profesor.Text))
            {
                Docentes FrmModificarMateria = new();
                FrmModificarMateria.Show();
                FrmModificarMateria.btn_CExamen.Text = "Modificar Examen";
            }
        }
    }
}
