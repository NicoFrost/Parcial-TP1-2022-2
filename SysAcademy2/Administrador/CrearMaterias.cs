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
    public partial class CrearMaterias : Form
    {
        public CrearMaterias()
        {
            InitializeComponent();
        }

        private void CrearMaterias_Load(object sender, EventArgs e)
        {
            Cbx_Profesores.Items.Clear();
            cb_correlativas.Items.Clear();
            lb_correlativasAdded.Items.Clear();
            foreach(var Usuarios in /*Sql.ObtenerTodosLosUsuarios()*/SqlG<Usuario>.ObtenerTodosdelDatoT())
            {
                if(Usuarios.GetPerfil() == "Profesor")
                {
                    Cbx_Profesores.Items.Add(Usuarios.GetNombre());
                }
            }
            Cbx_Profesores.Items.Add("Ninguno");
            foreach (var materia in SqlG<Materia>.ObtenerTodosdelDatoT())
            {
                cb_correlativas.Items.Add(materia.GetNombre());
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Materia materia = new();
            if(!(txt_Nombre.Text == string.Empty || txt_Nombre.Text == null || txt_Nombre.Text.Trim() == null || txt_Nombre.Text.Trim() == string.Empty))
            {
                materia.SetNombre(txt_Nombre.Text);
                if(Cbx_Profesores.SelectedItem != null)
                {
                    if(Cbx_Profesores.SelectedItem.ToString() == "Ninguno")
                    {
                        materia.SetProfesorAsignado(-1);
                    } else
                    {
                        var usuario = SqlUsuario.ObtenerUsuario(Cbx_Profesores.SelectedItem.ToString());
                        materia.SetProfesorAsignado(usuario.GetID());
                        materia.SetProfesorAsignado(SqlUsuario.ObtenerUsuario(Cbx_Profesores.SelectedItem.ToString()).GetID());
                    }
                }
                else
                {
                    materia.SetProfesorAsignado(-1);
                }

                for(int i = 0;i < lb_correlativasAdded.Items.Count; i++)
                {
                    var item = lb_correlativasAdded.Items[i].ToString();
                    foreach(var materiaIN in SqlG<Materia>.ObtenerTodosdelDatoT())
                    {
                        if(item == materiaIN.GetNombre())
                        {
                            if(materiaIN != null)
                            {
                                materia.correlativas.Add(materiaIN);
                            }
                        }
                    }
                }
                //materia.SetID(materia.IdIncremental(M.listaMaterias));
                materia.SetID(Sql.GetLastID("Materia") + 1);
                //M.listaMaterias.Add(materia);
                SqlMateria.InsertarMateria(materia);
                foreach(var correlativa in materia.correlativas)
                {
                    SqlMateria.InsertarCorrelativa(materia,correlativa);
                }
                MessageBox.Show($"Materia {materia.GetNombre()} creada");
                Close();
            } else
            {
                MessageBox.Show("No se aceptan materias sin nombre","info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_correlativas_Click(object sender, EventArgs e)
        {

        }

        private void cb_correlativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_correlativas.SelectedItem != null)
            {
                btn_AddCorrelativas.Enabled = true;
            }
            else
            {
                btn_AddCorrelativas.Enabled = false;
            }
        }

        private void btn_AddCorrelativas_Click(object sender, EventArgs e)
        {
            if(cb_correlativas.SelectedItem != null)
            {
                var item = cb_correlativas.SelectedItem;
                lb_correlativasAdded.Items.Add(item);
                cb_correlativas.Items.Remove(item);
                cb_correlativas.Text = "";
                btn_AddCorrelativas.Enabled = false;
            }
        }

        private void btn_RemoveCorrelativa_Click(object sender, EventArgs e)
        {
            var item = lb_correlativasAdded.SelectedItem;
            cb_correlativas.Items.Add(item);
            lb_correlativasAdded.Items.Remove(item);
            btn_RemoveCorrelativa.Enabled = false;
        }

        private void lb_correlativasAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_correlativasAdded.SelectedItem != null)
            {
                btn_RemoveCorrelativa.Enabled = true;
            }
            else
            {
                btn_RemoveCorrelativa.Enabled = false;
            }
        }
    }
}
