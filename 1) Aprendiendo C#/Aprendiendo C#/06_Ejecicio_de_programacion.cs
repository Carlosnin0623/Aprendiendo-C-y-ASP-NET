using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _06_Ejecicio_de_programacion
    {
        public static void Main(string[] args)
        {
            /*
             *  Construir un programa que pida por pantalla 3 números y luego diga
             *  cuál es el mayor de los números ingresados.
             * 
             *  Al ejecutar el programa debe mostrar por ejemplo lo siguiente:
             * 
             *  Ingrese primer número: 25
             *  Ingrese segundo número: 18
             *  Ingrese tercer número: 14
             *  
             *  El número mayor es: 25
             */

            double num1, num2, num3;

            Console.WriteLine("Aplicación para obtener el número mas alto");
            Console.WriteLine("Ingresa el primer número:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer número:");
            num3 = Convert.ToDouble(Console.ReadLine());

            if(num1 > num2 && num2 > num3)
            {
                Console.WriteLine("El primer número es mayor");

            }else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("El segundo número es mayor");

            }else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El tercer número es mayor");
            }

            Console.ReadKey();
        }
    }
}
