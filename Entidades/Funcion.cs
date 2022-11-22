using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcion : EntidadBase
    {
        private string permisoReq;

        public string GetPermiso()
        {
            return permisoReq;
        }
        public void SetPermiso(string permiso)
        {
            if (permiso != null)
            {
                permisoReq = permiso;

            }
            else
            {
                Console.WriteLine("ERROR AL SETEAR PERMISO");
            }
        }
        public Funcion(int id, string nombre, string permisoReq)
        {
            SetID(id);
            SetNombre(nombre);
            this.permisoReq = permisoReq;
        }

        public static Funcion PasoDeInformacion(SqlDataReader v)
        {
            //El paso de informacion de lo leido de la base de datos
            Funcion funcion = new Funcion(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["permisoReq"].ToString() ?? ""
                );

            return funcion;
        }
    }
}
