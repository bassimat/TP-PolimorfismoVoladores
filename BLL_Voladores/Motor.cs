using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Motor
    {
        private int _potencia;
        private string _marca;

        public int Potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }


        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

    }
}
