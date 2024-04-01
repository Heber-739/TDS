using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class GetPrices
    {
        public void Init()
        {
            double price;

            do
            {
              
                    Console.WriteLine("Ingrese el precio del producto o '0' para salir");
                string input = Console.ReadLine();
                    price = double.Parse(input);
                    if (price != 0)
                    {
                        Console.WriteLine("El precio del producto es: " + price * 1.15);
                    }
                
            
            } while (price != 0);
        }
    }
}
