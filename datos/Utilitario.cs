using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class Utilitario<T>
    {
        public void Recorrer(List<T> lista)
        {
            foreach(var objeto in lista)
            {
                Console.WriteLine("HOLA");
            }
        }
    }
}
