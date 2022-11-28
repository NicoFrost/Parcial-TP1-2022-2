using datos;
using Entidades;

namespace SysAcademy
{
    public partial class CreacionUser : Form
    {
        public CreacionUser()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.SetID(Sql.GetLastID("Usuario") + 1);
            usuario.SetNombre(txtB_User.Text);
            usuario.SetPassword(txtB_Password.Text);
            if (rb_Admin.Checked)
            {
                usuario.SetPerfil("Admin");
            }
            else if (rb_Profesor.Checked)
            {
                usuario.SetPerfil("Profesor");
            }
            else if (rb_Alumno.Checked)
            {
                usuario.SetPerfil("Alumno");
            }
            SqlUsuario.InsertarUsuario(usuario);
            Usuario userVerif = SqlUsuario.ObtenerUsuario(txtB_User.Text);
            MessageBox.Show($"Has creado y metido el usuario: Nombre:{userVerif.GetNombre()} Pass: {userVerif.GetPassword()} y con acceso de {userVerif.GetPerfil()}", $"{usuario.GetID()}");
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
