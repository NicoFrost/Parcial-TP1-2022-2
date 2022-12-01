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
using System.IO;
using SysAcademy2.Administrador;
using System.Reflection;

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
            //List<Usuario> listaUsuarios = Sql.ObtenerTodosLosUsuarios();
            List<Usuario> listaUsuarios = SqlG<Usuario>.ObtenerTodosdelDatoT(); //Obtener todos los datos T
            Cbx_Profesores.Items.Clear();
            foreach (var Usuarios in listaUsuarios)
            {
                if (Usuarios.GetPerfil() == "Profesor")
                    Cbx_Profesores.Items.Add(Usuarios.GetNombre());
            }
            Cbx_Profesores.Items.Add("Ninguno");
            listBox1.Items.Clear();
            List<Materia> listaMat = SqlG<Materia>.ObtenerTodosdelDatoT();
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
            foreach(var materia in SqlG<Materia>.ObtenerTodosdelDatoT())
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
            if (listBox1.SelectedItem != null)
            {
                Materia? materia = SqlMateria.ObtenerMateria(listBox1.SelectedItem.ToString());
                if(materia != null)
                {
                    List<Alumno>? alumnos = SqlAlumnos.AlumnosAnotados(materia);
                    if (alumnos != null)
                    {
                       
                        DialogResult result = new();

                        result = MessageBox.Show("JSON(Y) o CSV(N)?", "", MessageBoxButtons.YesNo);

                        DialogResult resultado = new();
                        
                        if (result == DialogResult.Yes)
                        {
                            if (File.Exists("Alumnos Exportados.json"))
                            {
                                resultado = MessageBox.Show("Sobrescribir Archivos?", "", MessageBoxButtons.YesNo);
                            } else
                            {
                                resultado = DialogResult.Yes;
                            }

                            if (resultado == DialogResult.Yes)
                            {
                                try
                                {
                                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                                    opciones.WriteIndented = true;
                                    List<AlumnoJSON> alumnosJSON = new List<AlumnoJSON>();
                                    foreach (var alumno in alumnos)
                                    {
                                        AlumnoJSON alumnoJSON = new(alumno.GetID(), alumno.GetNombre(), alumno.GetPassword(), alumno.GetPerfil(), alumno.materiaA, alumno.estadoMA, alumno.activo);

                                        alumnosJSON.Add(alumnoJSON);
                                    }
                                    string jsonString = JsonSerializer.Serialize(alumnosJSON, opciones);
                                    File.WriteAllText("Alumnos Exportados.json", jsonString);
                                } catch (Exception excepcion)
                                {
                                    MessageBox.Show("Una Aplicacion esta usando el .Json, cierrelo y vuelva a intentar\n" + excepcion.Message);
                                }
                            }
                        } else 
                        {
                            if (File.Exists("Alumnos Exportados.csv"))
                            {
                                resultado = MessageBox.Show("Sobrescribir Archivos?", "", MessageBoxButtons.YesNo);
                            } else
                            {
                                resultado = DialogResult.Yes;
                            }
                            if (resultado == DialogResult.Yes)
                            {
                                string stringCSV = "id,nombre,password,perfil,materiaA,estadoMA,activo\n";
                                StreamWriter escritor = new StreamWriter("Alumnos Exportados.csv");
                                try
                                {
                                    foreach (var alumno in alumnos)
                                    {
                                        AlumnoJSON alumnoJSON = new(alumno.GetID(), alumno.GetNombre(), alumno.GetPassword(), alumno.GetPerfil(), alumno.materiaA, alumno.estadoMA, alumno.activo);

                                        stringCSV += $"{alumnoJSON.Id},{alumnoJSON.Nombre},{alumnoJSON.Password},{alumnoJSON.Perfil},{alumnoJSON.MateriaA},{alumnoJSON.EstadoMA},{alumnoJSON.Activo}\n";
                                    }
                                    escritor.WriteLine(stringCSV);

                                }
                                catch (Exception excepcion)
                                {
                                    MessageBox.Show("Una Aplicacion esta usando el .csv, cierrelo y vuelva a intentar\n" + excepcion.Message);
                                }
                                finally
                                {
                                    escritor.Close();
                                    escritor.Dispose();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            //Lectura Archivo

            pathImportar pathForm = new();
            pathForm.ShowDialog();
            string path = pathForm.path;
            string jsonString;
            try
            {
                jsonString = File.ReadAllText(path);


                // DeSerializacion
                List<AlumnoJSON>? alumnosJSON = JsonSerializer.Deserialize<List<AlumnoJSON>>(jsonString);
                Alumno? alumnoNull = new();
                if(alumnosJSON != null && alumnosJSON != null)
                {
                    foreach(var alumnoJ in alumnosJSON)
                    {
                       Alumno alumno = AlumnoJSON.ConvertirJsonAAlumno(alumnoJ);
                        //modificar aqui si el usuario a meter puede ser viejo de && a ||
                        Usuario userAlumnoNew = new(0,alumno.GetNombre(),alumno.GetPassword(),alumno.GetPerfil(),alumno.activo);
                        SqlUsuario.InsertarUsuario(userAlumnoNew);
                        alumno.SetID(SqlUsuario.ObtenerUsuario(userAlumnoNew.GetNombre()).GetID());
                        SqlAlumnos.InsertarAlumno(alumno);
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Error de lectura introduszca una direccion valida\nConsejos: no incluya el .json al final del nombre\n* No ponga el nombre del archivo al final de la direccion");
            }
        }
    }
}
