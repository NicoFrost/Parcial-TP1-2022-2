using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public interface IGettersSettersID
    {
        public void SetID(int id);
        public int GetID();
    }
    public abstract class EntidadBase : IGettersSettersID
    {
        private int id;
        private string nombre;


        public virtual int GetID()
        {
            return id;
        }
        public virtual void SetIDIncrementa()
        {
            id++;
            SetID(id);
        }

        public virtual void SetID(int id)
        {
            this.id = id;
        }

        public virtual string GetNombre() 
        {
            return nombre; 
        }
        public virtual void SetNombre(string str)
        {
            if(str != null)
            {
                nombre = str; 
            } else
            {
                Console.WriteLine("ERROR AL SETEAR NOMBRE");
            }
        }
    }
}
