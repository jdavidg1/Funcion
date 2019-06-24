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
            Console.WriteLine("3 Multiplicación");
            Console.WriteLine("4 División");

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

                //declaración de variable para resultado

                float resultado = 0f;

                //Invocamos y obtenemos el resultado

                resultado = Resta();

                Console.WriteLine("El resultado de la resta es {0}", resultado);
                Console.ReadKey();

            }


            if (opcion == 3)
            {
                //Multiplicación
                float n1 = 0f, n2 = 0;

                // Solicitar los valores

                Console.WriteLine("Dame el primer número: ");
                n1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Dame el segundo número: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                // Invocar la función

                Multiplicacion(n1, n2);


            }

            if (opcion == 4)
            {
                //División
                //Definición de variables

                float n1 = 0.0f, n2 = 0.0f, resultado = 0.0f;


                // Solicitar los valores

                Console.WriteLine("Dame el primer número: ");
                n1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Dame el segundo número: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                // Invocar la función

                resultado = Division(n1, n2);

                // Console.WriteLine("El resultado de la división es {0}", resultado);
                Console.WriteLine($"El resultado de la división de {n1}/{n2} es = {resultado}");

                Console.ReadKey();




            }


        }

        static void Suma()   // Esta función no regresa ningún valor, todo se hace dentro de la función
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


        static float Resta()
        {
            //Definición de variables

            float a = 0f, b = 0f, r = 0;

            Console.WriteLine("Dame el primer número: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Dame el segundo número: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a - b;

            //Regresamos el resultado

            return r;

        }

        static void Multiplicacion(float a, float b) //Recibe valores pero no regresa
        {
            //Variables necesarias

            float r = 0f;

            r = a * b;

            Console.WriteLine($"El resultado de {a} * {b} es = {r}");

            Console.ReadKey();

        }

        static float Division(float a, float b)
        {
            //Definición de variables

            float r = 0f;

            if (b == 0)
            {
                Console.WriteLine("La división no se puede hacer");
                return 0.0f;
            }

            else
            {

                r = a / b;
                return r;
            }

        }

    }
}
