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
using System.Drawing.Drawing2D;

namespace SysAcademy2
{
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();

        }
        public Usuario? usuarioActivo = SqlUsuario.ObtenerUsuarioActivo();
        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            if(usuarioActivo != null)
            {
                Materia? materia = new();
                List<Examen> lista = Sql.ObtenerTodosLosExamenes(usuarioActivo.GetID());

                //Utilitario<Examen> utilitario = new Utilitario<Examen>();
                //utilitario.Recorrer(lista);

                foreach (var examen in lista)
                {
                    Examen examenSql = Sql.ObtenerExamen(examen.GetID(), usuarioActivo.GetID());
                    if (examen != null && examenSql.GetID() == examen.GetID())
                    {
                        materia = SqlMateria.ObtenerMateria("id", examen.materia);
                        if (materia != null && materia.GetID() != -1)
                        {
                            int n = DG_ListaMaterias.Rows.Add();
                            DG_ListaMaterias.Rows[n].Cells[0].Value = examen.GetNombre();
                            if (Sql.ObtenerNota(usuarioActivo.GetID(), examen.GetID()) != null)
                            {
                                DG_ListaMaterias.Rows[n].Cells[1].Value = Sql.ObtenerNota(usuarioActivo.GetID(), examen.GetID()).GetNotaExamen();
                            }
                            DG_ListaMaterias.Rows[n].Cells[2].Value = materia.GetNombre();
                            DG_ListaMaterias.Rows[n].Cells[3].Value = SqlUsuario.ObtenerUsuario(materia.GetProfesorAsignado()).GetNombre();
                            List<Materia>? correlativas = SqlMateria.ObtenerTodasLasCorrelativas(materia.GetID());
                            string correlativaComa = "";
                            foreach (var materiaC in correlativas)
                            {
                                correlativaComa += $"{materiaC.GetNombre()},";
                            }
                            DG_ListaMaterias.Rows[n].Cells[4].Value = correlativaComa;
                        }
                    }
                }
            }
        }
    }
}
