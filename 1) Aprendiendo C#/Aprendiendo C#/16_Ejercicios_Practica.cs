using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _16_Ejercicios_Practica
    {
        static void Main(string[] args)
        {
            // Ejercicio tabla de multiplicar del número ingresado

            int numero;

            Console.WriteLine("Ejercicio tabla de multiplicar");
            Console.WriteLine("Digite el número para crear su tabla");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }

            Console.ReadKey();


        }
    }
}
