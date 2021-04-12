using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public abstract class Ave : Animal , IObjVolador
    {

        public Ave( string nombre )
            : base( nombre )
        {
            Console.WriteLine("Instanciando un ave llamada: "+ this._nombre );
        }

        public virtual void Volar()
        {
            Console.WriteLine(this._nombre + ": Soy ave y me desplazo volando");
        }

        public override void Desplazarse()
        {
            base.Desplazarse();
            this.Volar();
        }
    }
}
