using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public abstract class Mamifero : Animal
    {

        public Mamifero ( string unNombre )
            : base( unNombre )
        {
            Console.WriteLine("Se está creando un mamífero");
        }
    }
}
