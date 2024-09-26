using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class Pedido
    {
        private ArregloFloral _arregloFlorals;
        private double _total;
        private bool _descuentoAplicado;
        public Pedido(ArregloFloral arregloFlorals, double total, bool descuentoAplicado)
        {
            _arregloFlorals = arregloFlorals;
            _total = total;
            _descuentoAplicado = descuentoAplicado;
        }
        public ArregloFloral ArregloFlorals
        {
            get { return _arregloFlorals; }
            set { _arregloFlorals = value; }
        }
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public bool DescuentoAplicado
        {
            get { return _descuentoAplicado; }
            set { _descuentoAplicado = value; }
        }
    }
}
