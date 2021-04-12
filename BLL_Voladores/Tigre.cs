using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Tigre : Mamifero
    {

        public Tigre(string unNombre) : base(unNombre)
        {
            Console.WriteLine("Soy un objeto tipo Tigre llamado " + this._nombre + "!\n");
        }

        public void Rugir()
        {
            Console.WriteLine( "GRRRRRR!!!");
        }
    }
}
