using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _08_Estructura_de_control_switch
    {
        public static void Ejemplo(string[] args)
        {
            /* ejericio: Calculadora de operaciones aritmeticas */

            float a, b, resultado;
            int opcion;

            // Mostrar el menú de opciones:

            Console.WriteLine("(1). Suma");
            Console.WriteLine("(2). Resta");
            Console.WriteLine("(3). Multiplicación");
            Console.WriteLine("(4). Division");
            Console.WriteLine("Elige una de las opciones:");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digita el primer número:");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digita el segundo número:");
            b = Convert.ToSingle(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine("El resultado de la suma es: {0}", resultado);
                break;

                case 2:
                    resultado = a - b;
                    Console.WriteLine("El resultado de la resta es: {0}", resultado);
                break;

                case 3:
                    resultado = a * b;
                    Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
                break;

                case 4:

                    if(b == 0)
                    {
                        Console.WriteLine("No es posible dividir por 0");
                    }
                    else
                    {
                        resultado = a / b;
                        Console.WriteLine("El resultado de la división es: {0}", resultado);
                    }
                break;

                default:
                    Console.WriteLine("La opción elegida no es válida");
                    break;

            }

            Console.ReadKey();

        }
    }
}
