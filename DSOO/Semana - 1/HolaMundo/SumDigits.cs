using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class SumDigits
    {
        public static void Init()
        {
            int value = 0;
            string sucession = "";
            string input;
            do
            {
                Console.WriteLine("Ingrese una secuencia de digitos o '0' para salir: ");
                input  = Console.ReadLine();
                if(input != "0")
                {
                foreach (var i in input)
                {
                    sucession = sucession == "" ? i + "" : sucession + " + " + i;
                    value += int.Parse(i + "");
                }

                Console.WriteLine("La sucesion de numeros: " + sucession + " da la suma: " + value);

                 value = 0;
                 sucession = "";
                }

            } while (input != "0");
        }
    }
}
