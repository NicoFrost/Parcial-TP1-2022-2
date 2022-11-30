using Entidades;
using datos;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Tests
{
    [TestClass]
    public class SqlUsuarioTest
    {

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void TestConexionDeMetodosASql()
        {
            //ARRAGE
            Usuario? usuario = null;
            int idUsuarioTest = 1;
            SqlConnection connectionFalse; // Puente falso

            SqlCommand command;      // Quien lleva la consulta.

            command = new SqlCommand();
            connectionFalse = new SqlConnection(@"
                Data Source = DESKTOP-HD6ABJ;
                Database = Universidad;
                Trusted_Connection = True;
            ");


            //Act
            command.Connection = connectionFalse;
            command.CommandType = CommandType.Text;

            command.CommandText = $"SELECT u.id,u.nombre,password,p.nombre perfil,activo FROM Usuario AS U INNER JOIN Permiso AS p ON u.id_permiso=p.id WHERE u.id = {idUsuarioTest}";
            connectionFalse.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                usuario = Usuario.PasoDeInformacion(reader);
            }

            if (connectionFalse.State == ConnectionState.Open)
            {
                connectionFalse.Close();
            }
        }

        [TestMethod]
        public void TestUsuarioNulo()
        {
            Usuario? userTest = null; 

            userTest = SqlUsuario.ObtenerUsuario("lulu");

            Assert.AreEqual(null, userTest);
        }

        [TestMethod]
        public void TestUsuarioCorrecto()
        {
            Usuario? userTest;
            
            userTest = SqlUsuario.ObtenerUsuario(0);
            
            Assert.AreEqual(userTest.GetID(),0);
        }
    }
}