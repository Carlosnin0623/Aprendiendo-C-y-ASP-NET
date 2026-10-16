using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _13_Bucle_Do_While
    {
        static void Main(string[] args)
        {
            /*
             *   Ciclo Do While
             *   
             *   do{
             *   
             *     Código
             *   
             *   }(condición);
             *   
             *   El bucle do while es una estructura de control repetitiva que permite ejecutar
             *   un bloque de código al menos una vez, independientemente de si la condición 
             *   es verdadera o falsa.
             *   
             *   Después de ejecutar las instrucciones, se evalúa una condición.
             *   Si es verdadera (true), el bucle vuelve a ejecutarse; si es falsa (false),
             *   el bucle termina.
             * 
             */

            float pies, pulgadas, centimetros;
            string respuesta;

            do
            {

                Console.WriteLine("Ingrese los pies");
                pies = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese las pulgadas");
                pulgadas = Convert.ToSingle(Console.ReadLine());

                centimetros = ((pies * 12) + pulgadas) * 2.54f;

                Console.WriteLine("son {0} centímetros", centimetros);

                Console.WriteLine("Deseas hacer otra conversión");
                respuesta = Console.ReadLine();


            } while (respuesta.ToLower() == "si");

            Console.ReadKey();
        }
    }
}
