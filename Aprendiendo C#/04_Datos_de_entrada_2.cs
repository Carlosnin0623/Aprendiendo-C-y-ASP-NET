using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _04_Datos_de_entrada_2
    {
        public static void Ejemplo(string[] args)
        {
            string nombre;

            byte opcion;

            float num1, num2, resultado;

            try
            {
                Console.WriteLine("Aplicación Calculadora:");

                Console.WriteLine("Ingresa tu nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el primer número:");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número:");
                num2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("(1) Suma");
                Console.WriteLine("(2) Resta");
                Console.WriteLine("(3) Multiplicación");
                Console.WriteLine("(4) División");
                Console.WriteLine("(5) Salir");
                Console.WriteLine("Cuales de las siguientes operaciones desea realizar?:");
                opcion = Convert.ToByte(Console.ReadLine());

                if (opcion == 1)
                {
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: {0}", resultado);

                }
                else if (opcion == 2)
                {
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: {0}", resultado);

                }
                else if (opcion == 3)
                {
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);

                }
                else if (opcion == 4)
                {

                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("No es posible dividir entre 0");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de la división es: {0}", resultado);
                    }

                }else if (opcion == 5)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo del sistema....");
                }
                else
                {
                    Console.WriteLine("La opción seleccionada no esta disponible");
                }
            }catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es correcto");

            }catch(OverflowException)
            {
                Console.WriteLine("El valor ingresado supera el límite establecido, intente con un valor mas pequeño");

            }catch(Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();

        }
    }
}
