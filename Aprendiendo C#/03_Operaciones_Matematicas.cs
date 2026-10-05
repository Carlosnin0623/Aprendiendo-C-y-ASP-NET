using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _03_Operaciones_Matematicas
    {
        public static void Ejemplo(string[] args)
        {
            /* Operadores Matematicos */

            byte num1 = 20;
            byte num2 = 10;

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;

            Console.WriteLine("Operaciones Matematicas");
            Console.WriteLine("Suma: {0}", suma);
            Console.WriteLine("Resta: {0}", resta);
            Console.WriteLine("La multiplicación: {0}", multiplicacion);
            Console.WriteLine("La división: {0}", division);
            Console.ReadKey();
        }
    }
}
