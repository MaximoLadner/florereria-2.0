using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class Flor
    {
        private string _tipo;
        private double _costo;
        public Flor(string tipo,double costo) 
        {
            _tipo = tipo;
            _costo = costo;
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
    }
}
