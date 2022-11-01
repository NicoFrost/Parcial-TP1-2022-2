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

    public partial class Docentes : Form
    {
//        List<Examen> listaExamen = new List<Examen>();
//       Examen examen = new Examen();
        public Docentes()
        {

            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        {/*
            if(txt_NombreExamen.Text.Length > 0)
            {
                
                Examen NuevoExamen = new Examen();
                NuevoExamen.Name = txt_NombreExamen.Text;
                string fecha = fcal_Eleccion.SelectionRange.Start.ToString();
                for(int i = 0;i < fecha.Length;i++)
                {
                    if (fecha[i].ToString() == " ")
                    {
                        NuevoExamen.Date = fecha.Substring(0, i);
                        break;
                    }
                }
                lb_Examenes.Items.Add(NuevoExamen.Name + " " + NuevoExamen.Date);
            } else
            {
                MessageBox.Show("Se necesita un nombre para registrar","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                */
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            /*
            List<Examen> listaExamen = new List<Examen>();
            Examen NuevoExamen = new Examen();
            lb_Examenes.Items.Clear();
            for(int i = 0; i < listaExamen.Count; i++)
            {
                NuevoExamen = listaExamen[i];
                lb_Examenes.Items.Add(NuevoExamen.Name + " " + NuevoExamen.Date);
            }
            */
        }
    }
}
