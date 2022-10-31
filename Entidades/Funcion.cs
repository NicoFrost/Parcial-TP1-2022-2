using System;
using System.Collections.Generic;
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
            if(permiso != null)
            {
                permisoReq = permiso;

            }
            else
            {
                Console.WriteLine("ERROR AL SETEAR PERMISO");
            }
        }

    }
}
