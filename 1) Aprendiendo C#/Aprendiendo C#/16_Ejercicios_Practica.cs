using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _16_Ejercicios_Practica
    {
       public static void Ejemplo(string[] args)
        {
            /*
             *  Escribe un programa que muestre un contador regresivo desde un número 
             *  ingresado por el usuario hasta 1.

             *  
             * 
             * 
             * 
             */

            int numero;
            int resultado = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Introduce el número");
                numero = Convert.ToInt32(Console.ReadLine());

                resultado += numero;

                Console.WriteLine("Quieres agregar otro número");
                Console.WriteLine("Si");
                Console.WriteLine("No");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "si");

            Console.WriteLine("El resultado de la suma de todos los números es: {0}", resultado);

            Console.ReadKey();
        }
    }
}
