using Entidades;
using datos;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Tests
{
    [TestClass]
    public class SqlUsuarioTest
    {
        [TestMethod]
        public void TestUsuarioNulo()
        {
            Usuario userTest;

            userTest = SqlUsuario.ObtenerUsuario("lulu");

            Assert.AreEqual(null, userTest);
        }

        [TestMethod]
        public void TestUsuarioCorrecto()
        {
            Usuario userTest;
            
            userTest = SqlUsuario.ObtenerUsuario(0);

            Assert.AreEqual(userTest.GetID(),0);
        }
    }
}