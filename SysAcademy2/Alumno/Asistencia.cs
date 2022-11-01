using datos;
using Entidades;
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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Usuario ActiveUser = Usuarios.AlumnofromList(Usuarios.BuscarActivo().GetID());
            AsistenciaAlumno asistencia = new();
            asistencia.fecha = FCal_diaAsistencia.SelectionRange.Start;
            asistencia.idAlumno = ActiveUser.GetID();
            Materias.listaAsistencia.Add(asistencia);
            Close();
        }
    }
}
