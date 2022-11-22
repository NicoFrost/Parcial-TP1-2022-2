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
using System.Text.Json;
using Entidades;

namespace SysAcademy2
{
    public partial class AsignacionMateria : Form
    {
        public AsignacionMateria()
        {
            InitializeComponent();
        }

        private void AsignacionMateria_Load(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = Sql.ObtenerTodosLosUsuarios();
            Cbx_Profesores.Items.Clear();
            foreach (var Usuarios in listaUsuarios)
            {
                if (Usuarios.GetPerfil() == "Profesor")
                    Cbx_Profesores.Items.Add(Usuarios.GetNombre());
            }
            Cbx_Profesores.Items.Add("Ninguno");
            listBox1.Items.Clear();
            List<Materia> listaMat = Sql.ObtenerTodasLasMaterias();
            foreach(var materia in listaMat)
            {
                listBox1.Items.Add(materia.GetNombre());
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0 && listBox1.SelectedItem != null)
            {
                string buscar = listBox1.SelectedItem.ToString();
                var materia = SqlMateria.ObtenerMateria(buscar);
                //var materia = M.listaMaterias.Find(objeto => objeto.GetNombre() == buscar);
                if(materia != null)
                {
                    txt_Nombre.Text = materia.GetNombre();
                    int ProfesorID = materia.GetProfesorAsignado();
                    var UserProfesor = SqlUsuario.ObtenerUsuario(ProfesorID);
                    if (!(UserProfesor == null || ProfesorID == -1))
                    {
                        Cbx_Profesores.Text = UserProfesor.GetNombre();
                    } else
                    {
                        if(ProfesorID == -1)
                        {
                            Cbx_Profesores.Text = "Ninguno";
                        } else
                        {
                            Cbx_Profesores.Text = null;
                        }
                    };
                }

                btn_Exportar.Enabled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            foreach(var materia in Sql.ObtenerTodasLasMaterias())
            {
                if(listBox1.SelectedItem.ToString() == materia.GetNombre())
                {
                    if(Cbx_Profesores.Text != "Ninguno"){
                        SqlMateria.ActualizarMateria(materia, "idUserP_Asignado",SqlUsuario.ObtenerUsuario(Cbx_Profesores.Text).GetID());
                    } else
                    {
                        SqlMateria.ActualizarMateria(materia, "idUserP_Asignado", -1);
                    }
                    MessageBox.Show("el profesor asignado ahora es " + Cbx_Profesores.Text);
                    //materia.profesorAsignado = Cbx_Profesores.Text;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            string path = "E:\\2022 2do cuatri\\TP1\\Sol1\\";
            if (listBox1.SelectedItem != null)
            {
                Materia materia = SqlMateria.ObtenerMateria(listBox1.SelectedItem.ToString());
                if(materia != null)
                {
                    List<Alumno>? alumnos = SqlAlumnos.AlumnosAnotados(materia);
                    if (alumnos != null)
                    {
                        string stringJson = "";
                        string stringCSV = "id,nombre,password,perfil,materiaA,estadoMA,activo\n";
                        DialogResult result = new();
                        result = MessageBox.Show("JSON(Y) o CSV(N)?", "", MessageBoxButtons.YesNo);
                        foreach (var alumno in alumnos)
                        {
                            AlumnoJSON alumnoJSON = new(alumno.GetID(), alumno.GetNombre(), alumno.GetPassword(), alumno.GetPerfil(), alumno.materiaA, alumno.estadoMA, alumno.activo);
                            if (result == DialogResult.Yes)
                            {
                                stringJson = JsonSerializer.Serialize(alumnoJSON);
                            } else
                            {
                                stringCSV += $"{alumnoJSON.Id},{alumnoJSON.Nombre},{alumnoJSON.Password},{alumnoJSON.Perfil},{alumnoJSON.MateriaA},{alumnoJSON.EstadoMA},{alumnoJSON.Activo}\n";
                            }
                        }
                        if (result == DialogResult.No)
                        {
                            if (File.Exists(path + "Alumnos Exportados.json"))
                            {
                                var respuesta = MessageBox.Show("Advertencia el archivo ya fue exportado quiere sobrescribir?", "Archivo JSON", MessageBoxButtons.YesNo);
                                if (DialogResult.Yes == respuesta)
                                {
                                    try
                                    {
                                        File.WriteAllText(path + "Alumnos Exportados.csv", stringCSV);

                                    }
                                    catch (IOException)
                                    {
                                        MessageBox.Show("se esta usando el archivo desde otro lado, cierre la app y vuelva a intentar");
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    File.WriteAllText(path + "Alumnos Exportados.csv", stringCSV);
                                }
                                catch (IOException)
                                {
                                    MessageBox.Show("se esta usando el archivo desde otro lado, cierre la app y vuelva a intentar");
                                }
                            }
                        } else
                        {
                            if (File.Exists(path + "Alumnos Exportados.json"))
                            {
                                var respuesta = MessageBox.Show("Advertencia el archivo ya fue exportado quiere sobrescribir?", "Archivo JSON", MessageBoxButtons.YesNo);
                                if (DialogResult.Yes == respuesta)
                                {
                                    try
                                    {
                                        File.WriteAllText(path + "Alumnos Exportados.json", stringJson);
                                    }
                                    catch (IOException)
                                    {
                                        MessageBox.Show("se esta usando el archivo desde otro lado, cierre la app y vuelva a intentar");

                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    File.WriteAllText(path + "Alumnos Exportados.json", stringJson);
                                } catch (IOException)
                                {
                                    MessageBox.Show("se esta usando el archivo desde otro lado, cierre la app y vuelva a intentar");
                                }

                            }
                        }
                    }

                }
            }
        }
    }
}
