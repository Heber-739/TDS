using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             1 - El precio de los productos no tiene incluido el incremento del 15% que representa la ganancia del negocio, por lo tanto,el algoritmo debe 
                        calcular el precio final a abonar por un cliente. Se ingresa el precio del producto y como resultado muestra el precio de venta.
             2 - En el campeonato estudiantil llegan a la última etapa los participantes que superen los 80 puntos. El algoritmo pide el nombre de cada 
                    participante y la puntuación de los 3 jurados. Debe mostrar el nombre y el puntaje total de cada participante.
                    Nota: cuando se ingrese "FIN" en el nombre del participante finaliza nuestro programa.
             3 - Modifica la salida de la resolución del punto 2. Se pide mostrar un mensaje que indique si cada participante llegó a la última etapa o no.
             4 - Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos. Por ejemplo, la suma de los dígitos
                    del 3433 es 13.  Para darle un poco más de emoción, el programa no se limitará a escribir el resultado de la suma, sino que también
                    escribirá todos los sumandos utilizados: 3 + 4 + 3 + 3 = 13.
             5 - Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de dígitos, es decir, puede ser un número
                    de dos dígitos como un número de 6 dígitos. Tomá la codificación anterior e introducí los cambios que sean necesarios.
            */
            Init();
        }

        public static void Init() {
            int choise;

            do
            {

                Console.WriteLine("Seleccione la operacion que desee ejecutar:");
                Console.WriteLine(" ( 1 ) - Obtener precio actualizado");
                Console.WriteLine(" ( 2 ) - Ingresar participantes y puntaje");
                Console.WriteLine(" ( 3 ) - Sumar digitos");
                Console.WriteLine(" ( 4 ) - Salir");

                choise = int.Parse(Console.ReadLine());

            } while (choise < 0 || choise > 4);

            if (choise == 4)
            {
                Console.WriteLine("Gracias, vuelvas prontos!");
                Console.WriteLine("Presione cualquier tecla para salir");
                Console.Read();
            }
            else
            {
            Execute(choise);
            }

        }

        public static void Execute(int choise)
        {
            switch (choise)
            {

                case 1:
                    GetPrices newPrices = new GetPrices();
                    newPrices.Init();
                    break;

                case 2:
                    ListStudents.Init();
                    break;

                case 3:
                    SumDigits.Init();
                    break;
            }
                    Init();
        }
    }
}
