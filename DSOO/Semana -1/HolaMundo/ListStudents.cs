using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class ListStudents
    {
        static List<ListStudents> MyStudents;

        readonly string name;
        readonly double calification;

        public ListStudents(string name, double calification) {
            this.name = name;
            this.calification = calification;
        }

        public static void Init()
        {
             ListStudents.MyStudents = new List<ListStudents>();
            string name;
            do
            {
                Console.WriteLine("Ingrese 'FIN' para salir");
                Console.WriteLine("------------- o -------------");
                Console.WriteLine("Ingrese el nombre del estudiante número: " + (ListStudents.MyStudents.Count + 1));
                name = Console.ReadLine();
                if (name == "FIN")
                {
                    foreach (var item in MyStudents)
                    {
                        string pass = item.calification >= 80 ? "El estudiante llegó a la ultima etapa" : "El estudiante no llegó a la ultima etapa";
                        Console.WriteLine("Estudiante: " + item.name + " - Calificacion: " + item.calification + " - " + pass);

                    }

                }
                else
                {
                    Console.WriteLine("Ingrese calificacion 1: ");
                    string cal1 = Console.ReadLine();
                    Console.WriteLine("Ingrese calificacion 2: ");
                    string cal2 = Console.ReadLine();
                    Console.WriteLine("Ingrese calificacion 3: ");
                    string cal3 = Console.ReadLine();
                    double calification = double.Parse(cal1) + double.Parse(cal2) + double.Parse(cal3);
                    ListStudents student = new ListStudents(name, calification);
                    ListStudents.MyStudents.Add(student);
                }

            } while (name != "FIN");
        }
        
    }
}
