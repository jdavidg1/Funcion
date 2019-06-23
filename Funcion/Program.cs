using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables

            int opcion = 0;

            // Presentación de menú

            Console.WriteLine("1 Suma");
            Console.WriteLine("2 Resta");
            Console.WriteLine("3 División");
            Console.WriteLine("4 Multiplicación");

            //Pedimos la opción

            Console.WriteLine("Selecciona la opción:");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                //Suma

                Suma();

            }


            if (opcion == 2)
            {
                //Resta

            }


            if (opcion == 3)
            {
                //Multiplicación

            }

            if (opcion == 4)
            {
                //División

            }


        }

        static void Suma()
        {
            float a = 0f, b = 0f, r = 0;

            //Pedimos los números

            Console.WriteLine("Dame el primer número: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a + b;

            Console.WriteLine($"El resultado de {a} + {b} es = {r}");

            Console.ReadKey();
        }
    }
}
