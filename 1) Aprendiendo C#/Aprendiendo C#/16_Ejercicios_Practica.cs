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
        static void Main(string[] args)
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

            Console.WriteLine("Digite el valor");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            while (numero >= 1)
            {
                Console.WriteLine("{0}", numero);
                Thread.Sleep(100);
                numero--;
            }


            Console.ReadKey();
        }
    }
}
