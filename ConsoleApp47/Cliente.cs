using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    public class Cliente
    {
        private string _nombre;
        private Pedido _pedido;
        public Cliente(string nombre, Pedido pedido) 
        {
            this._nombre = nombre;
            this._pedido = pedido;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Pedido Pediditos
        {
            get { return _pedido; }
            set { _pedido = value; }
        }
        public void MostrarResumenPedido(string TiposFlor, double CostoFlor, double CantidadFlores)
        {
            Console.WriteLine($"Nombre del cliente: {Nombre}\nTipo de flor: {TiposFlor}\nCosto de la flor: {CostoFlor}\nCantidad de flores: {CantidadFlores}\n");
        }
    }
}
