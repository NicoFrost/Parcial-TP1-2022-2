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

namespace SysAcademy2
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {

            foreach (var examen in Examenes.listaExamenes)
            {
                int alumnoID = Usuarios.BuscarActivo().GetID();
                foreach(var fecha in Materias.BuscarAsistencia(alumnoID)){

                    if (fecha == examen.fecha)
                    {
                        int idExamen = examen.GetID();
                        Notas? notaExamen;
                        int n = DG_ListaMaterias.Rows.Add();
                        DG_ListaMaterias.Rows[n].Cells[0].Value = examen.GetNombre();
                        if(Examenes.NotasExamenes.Count > 0)
                        {
                            notaExamen = Examenes.NotasExamenes.Find(objeto => objeto.GetExamenID() == idExamen && objeto.GetAlumnoID() == alumnoID);
                            if(notaExamen != null)
                            {
                                DG_ListaMaterias.Rows[n].Cells[1].Value = notaExamen.GetNotaExamen();
                            }
                        }
                        Materia materia = Materias.MateriafromList(examen.materia);
                        DG_ListaMaterias.Rows[n].Cells[2].Value = materia.GetNombre();
                        DG_ListaMaterias.Rows[n].Cells[3].Value = Usuarios.BuscarUsuario(materia.GetProfesorAsignado());
                    }
                }
            }

        }
    }
}
