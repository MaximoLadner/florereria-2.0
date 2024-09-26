using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class ArregloFloral
    {
        private List<Flor> _flor;
        public ArregloFloral(List<Flor> flor)
        {
            this._flor = flor; 
        }
        public List<Flor> ListaFlores
        {
            get { return _flor; }
            set { _flor = value; }
        }
        public double ObtenerCostoArreglo(List<Flor> flor)
        {
            double TotalArreglo = 0;
            foreach(var item in _flor)
            {
                TotalArreglo += item.Costo;
                
            }
            return TotalArreglo;
        }
    }
}
