using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _18_Ejercicios_Metodos
    {
        public static void Ejemplo(string[] args)
        {
            /*
             *  Crea un programa que permita al usuario realizar 
             *  operaciones matemáticas básicas (suma, resta, multiplicación, división) 
             *  utilizando métodos separados para cada operación.
             *  El programa debe solicitar dos números y la operación deseada al usuario 
             *  y luego mostrar el resultado.
             * 
             */

            string nombre;
            int opcion;
            decimal num1, num2;
            decimal resultado = 0m;

            Console.WriteLine("Digita tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Cuales de estas operaciones deseas realizar?");
            Console.WriteLine("(1) Suma");
            Console.WriteLine("(2) Resta");
            Console.WriteLine("(3) Multiplicación");
            Console.WriteLine("(4) División");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digita el primer número");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digita el segundo número");
            num2 = Convert.ToDecimal(Console.ReadLine());

            if(opcion == 1)
            {
               resultado = Suma(num1,num2);
               Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }else if(opcion == 2)
            {
                resultado = Resta(num1, num2);
                Console.WriteLine("El resultado de la resta es: {0}", resultado);

            }else if(opcion == 3)
            {
                resultado = Multiplicacion(num1, num2);
                Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);

            }else if( opcion == 4)
            {
                if(num2 == 0)
                {
                    Console.WriteLine("Lo siento no es posible dividir por 0");
                }
                else
                {
                    resultado = division(num1, num2);
                    Console.WriteLine("El resultado de la división es: {0}", resultado);
                }

            }

            Console.ReadKey();

        }

        static decimal Suma(decimal numero1, decimal numero2)
        {
            decimal resultado = 0m;

            resultado = numero1 + numero2;

            return resultado;
        }

        static decimal Resta(decimal numero1, decimal numero2)
        {
            decimal resultado = 0m;

            resultado = numero1 - numero2;

            return resultado;
        }

        static decimal Multiplicacion(decimal numero1, decimal numero2)
        {
            decimal resultado = 0m;

            resultado = numero1 * numero2;

            return resultado;
        }

        static decimal division(decimal numero1, decimal numero2)
        {
            decimal resultado = 0m;

            resultado = numero1 / numero2;

            return resultado;
        }
    }
}
