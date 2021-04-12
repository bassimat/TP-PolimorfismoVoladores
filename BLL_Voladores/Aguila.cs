using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Aguila : Ave
    {
        public Aguila( string nombre ) : base(nombre)
        {
            Console.WriteLine("Soy un objeto Aguila llamado " + this._nombre + "!\n");
        }


        public override void Volar()
        {
            Console.WriteLine(this._nombre + ":Soy un aguila y me desplazo alta en el cielo");
        }
    }
}
