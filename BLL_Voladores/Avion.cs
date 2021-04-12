using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Avion : IObjVolador
    {
        public List<Motor> _motores = new List<Motor>();

        public void Volar()
        {
            Console.WriteLine("Encendiendo motores para despegar!");
        }



    }
}
