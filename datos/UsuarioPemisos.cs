using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace datos
{
   public class UsuarioPermisos
    {
        public static List<Permisos> listaPermisos = new List<Permisos>();
        //Guardar permisos de gente harcodeada
        public static void GuardarPermiso(List<Usuario> listaUsuarios, List<Funcion> listaFunciones)
        {
            foreach (Usuario oUsuario in listaUsuarios)
            {
                switch (oUsuario.GetPerfil())
                {
                    case "Admin":
                        foreach (Funcion oFuncion in listaFunciones)
                        {
                            if (oUsuario.GetPerfil() == oFuncion.GetPermiso())
                            {
                                Permisos oUsuarioPermiso = new Permisos();
                                oUsuarioPermiso.idUsuario = oUsuario.GetID();
                                oUsuarioPermiso.idFuncion = oFuncion.GetID();
                                listaPermisos.Add(oUsuarioPermiso);
                            }
                        }
                        break;
                    case "Profesor":
                        foreach (Funcion oFuncion in listaFunciones)
                        {
                            if (oUsuario.GetPerfil() == oFuncion.GetPermiso())
                            {
                                Permisos oUsuarioPermiso = new Permisos();
                                oUsuarioPermiso.idUsuario = oUsuario.GetID();
                                oUsuarioPermiso.idFuncion = oFuncion.GetID();
                                listaPermisos.Add(oUsuarioPermiso);
                            }
                        }
                        break;
                    case "Alumno":
                        foreach (Funcion oFuncion in listaFunciones)
                        {
                            if (oUsuario.GetPerfil() == oFuncion.GetPermiso())
                            {
                                Permisos oUsuarioPermiso = new Permisos();
                                oUsuarioPermiso.idUsuario = oUsuario.GetID();
                                oUsuarioPermiso.idFuncion = oFuncion.GetID();
                                listaPermisos.Add(oUsuarioPermiso);
                            }
                        }
                    break;               
                }
            }
        }

        //Para saber si los botones estan Enabled o no
        public static bool BuscarPermisos(string nombreFuncion,int idUsuario)
        {
            Permisos oPermiso = new Permisos();
            oPermiso.idFuncion = -1;
            oPermiso.idUsuario = idUsuario;
            foreach(Funcion funcion in Funciones.listaFunciones)
            {
                if (nombreFuncion == funcion.GetNombre())
                {
                    oPermiso.idFuncion = funcion.GetID();
                    break;
                }
            }

            foreach (Permisos oPermisoExp in UsuarioPermisos.listaPermisos)
            {
                if ((oPermiso.idUsuario == oPermisoExp.idUsuario) && oPermiso.idFuncion == oPermisoExp.idFuncion)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
