using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flor> flors = new List<Flor>
            {

            };
            ArregloFloral arregloFloral = new ArregloFloral(flors);
            
            
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            double TotalArreglo = 0;
            string TipoFlor = "";
            double CantidadFlores = 0;
            
            while (TipoFlor != "salir")
            {
                Console.WriteLine("ingrese el tipo de flor que quiere arreglar(o escriba 'salir'): ");
                TipoFlor = Console.ReadLine();
                if(TipoFlor == "salir")
                {
                    break;
                }
                Console.WriteLine("ingrese el costo de la flor: ");
                double CostoFlor = double.Parse(Console.ReadLine());
                Console.WriteLine("Que cantidad de " + TipoFlor + "?");
                CantidadFlores = int.Parse(Console.ReadLine());
                Flor unaflor = new Flor(TipoFlor, CostoFlor);
                flors.Add(unaflor);
            }
            Console.WriteLine("Gracias por haber ingresado las flores, ahora vamos a calcular el precio del arreglo.");
            
          
            TotalArreglo += CantidadFlores * arregloFloral.ObtenerCostoArreglo(flors);
            double descuento = 0;
            double TotalDelTotal = 0;
            if(flors.Count >= 5)
            {
                descuento = TotalArreglo * 0.10;

                Pedido pedido = new Pedido(arregloFloral, TotalDelTotal, true);
                Cliente unCliente = new Cliente(nombre, pedido);
                foreach (var f in flors)
                {
                    unCliente.MostrarResumenPedido(f.Tipo, f.Costo, CantidadFlores);
                    
                }
                TotalDelTotal = TotalArreglo - descuento;
                Console.WriteLine($"El costo total con descuento del 10% es de: {TotalDelTotal}");
            }
            else
            {
                Pedido pedido2 = new Pedido(arregloFloral, TotalArreglo, false);
                Cliente otroCliente = new Cliente(nombre, pedido2);
                foreach (var f in flors)
                {
                    otroCliente.MostrarResumenPedido(f.Tipo, f.Costo, CantidadFlores);
                    
                }
                Console.WriteLine($"El costo total sin descuento es de: {TotalArreglo}");
            }
            Console.ReadLine();


        }
    }
}
