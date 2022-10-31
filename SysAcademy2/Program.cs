using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using datos;
using DF = datos.Funciones;
using System.Security.Cryptography.X509Certificates;
using SysAcademy2;

namespace SysAcademy
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HardData.InicializarDatos();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Starter());
            Application.Run(new Inicio());
            
        }
    }
    
}
    /*
    public class Examen
    {
        private string date;
        private string name;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
*/