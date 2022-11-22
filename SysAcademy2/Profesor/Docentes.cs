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
using System.Drawing.Drawing2D;

namespace SysAcademy
{

    public partial class Docentes : Form
    {
//        List<Examen> listaExamen = new List<Examen>();
//       Examen examen = new Examen();
        public Docentes()
        {

            InitializeComponent();
            
        }

        private void lb_Examenes_Click(object sender, EventArgs e)
        {
 /*
            for(int i = 0;i < listaExamen.Capacity;i++)  
            {
                examen = listaExamen[i];
                listaExamen.Add(examen);
                MessageBox.Show(examen.Name);
            }
*/
        }
        private void btn_CExamen_Click(object sender, EventArgs e)
        {
            if(txt_NombreExamen.Text.Length > 0)
            {
                 
                Examen NuevoExamen = new Examen();
                NuevoExamen.SetNombre(txt_NombreExamen.Text);
                NuevoExamen.fecha = fcal_Eleccion.SelectionRange.Start;
                if(cb_Materia.SelectedItem != null)
                {
                    NuevoExamen.materia = Materias.BuscarMateria(cb_Materia.SelectedItem.ToString());
                    DateTime fecha = NuevoExamen.fecha.Date;

                    Sql.InsertarExamen(NuevoExamen);
                    lb_Examenes.Items.Add($"{NuevoExamen.GetNombre()} {fecha.ToString("d")} ({Materias.BuscarMateria(NuevoExamen.materia)})");
                }
                //Sql.InsertarExamen(NuevoExamen);
                
                //Barrido de viejos datos
                txt_NombreExamen.Text = "";
                cb_Materia.SelectedItem = null;
                lb_Examenes.SelectedItem = null;
            } else
            {
                MessageBox.Show("Se necesita un nombre para registrar","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            lb_Examenes.Items.Clear();
            cb_Materia.Items.Clear();

            Usuario? ActiveUser = SqlUsuario.ObtenerUsuarioActivo();
            if(ActiveUser != null)
            {
                foreach (var materias in Sql.ObtenerTodasLasMaterias())
                {
                    if(materias.GetProfesorAsignado() == ActiveUser.GetID())
                    {
                        cb_Materia.Items.Add(materias.GetNombre());
                    }
                }
                Materia materiaTemp = new();
                foreach(var materia in Sql.ObtenerTodasLasMaterias())
                {
                    if(materia.GetProfesorAsignado() == ActiveUser.GetID())
                    {
                        materiaTemp = materia;
                        break;
                    }
                }
                foreach (var examen in Sql.ObtenerTodosLosExamenes())
                {
                    if (ActiveUser.GetID() == materiaTemp.GetProfesorAsignado() && materiaTemp.GetID() == examen.materia)
                    {
                        lb_Examenes.Items.Add($"{examen.GetNombre()} {examen.fecha.ToShortDateString()} ({SqlMateria.ObtenerMateria("id",examen.materia).GetNombre()})");
                    }
                }
            }
        }

        private void Docentes_Shown(object sender, EventArgs e)
        {
            ActiveControl = txt_NombreExamen;
        }
    }
}
