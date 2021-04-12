using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Mariposa : Insecto , IObjVolador
    {

        public Mariposa( string nombre ) : base( nombre )
        {

        }

        public void Volar()
        {
            Console.WriteLine(this._nombre + ": Soy una mariposa y me desplazo volando");
        }

        public override void Desplazarse()
        {
            this.Volar();
        }
    }
}
