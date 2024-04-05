using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Facu_Cami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Domicilio dom = new Domicilio("Jonte", 5299, "Monte Castro");
            Persona facundo = new Persona("Facundo", dom);
            Persona camila= new Persona("Camila", dom);
            Televisor tv = new Televisor("Phillips", "32PHG5813/77", 32, true, 1);
            facundo.Tv = tv;
            camila.Tv = tv;

            Console.WriteLine(tv.status);
            facundo.Tv.cambiarEstado();
            Console.WriteLine(tv.status);
            camila.Tv.cambiarEstado();
            Console.WriteLine(tv.status);
            Console.WriteLine(tv.ObtenerCanalActual());
            camila.Tv.CambiarCanal(32);
            Console.WriteLine(facundo.Tv.ObtenerCanalActual());



        }
    }
}
