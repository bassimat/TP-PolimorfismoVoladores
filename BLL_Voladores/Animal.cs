using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public abstract class Animal
    {
        protected string _nombre;

        public Animal( string nombre)
        {
            this._nombre = nombre;
            Console.WriteLine("Se esta creando un animal");
        }


        public virtual void Desplazarse()
        {
            Console.WriteLine(this._nombre + ": Soy un animal y me desplazo");
        }
    }
}
