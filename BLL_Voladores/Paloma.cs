using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Paloma : Ave
    {


        public Paloma( string nombre )
            : base( nombre )
        {
            Console.WriteLine("Soy un objeto paloma llamado "+this._nombre+ "!\n");
        }
    }
}
