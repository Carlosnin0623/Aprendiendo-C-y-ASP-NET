using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aprendiendo_C_
{
    internal class _15_Ejercicio_Calculadora
    {
        public static void Ejemplo(string[] args)
        {
            /* Calculadora
             * 
             * 
             * 
             * */

            float num1, num2, resultado;
            int opcion;
            string repetir;

            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("Menú de operaciones");
                Console.WriteLine("(1) Suma");
                Console.WriteLine("(2) Resta");
                Console.WriteLine("(3) Multiplicación");
                Console.WriteLine("(4) División");
                Console.WriteLine("(5) Salir");
                Console.WriteLine("Elige una de las opciones");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 5)
                    {
                        Console.WriteLine("Saliendo del programa");
                        break;
                    }
                    else if(opcion < 5)
                    {
                        Console.WriteLine("Ingresa el primer número");
                        num1 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Ingresa el segundo número");
                        num2 = Convert.ToSingle(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                resultado = num1 + num2;
                                Console.WriteLine("El resultado es: {0}", resultado);
                                break;
                            case 2:
                                resultado = num1 - num2;
                                Console.WriteLine("El resultado es: {0}", resultado);
                                break;
                            case 3:
                                resultado = num1 * num2;
                                Console.WriteLine("El resultado es: {0}", resultado);
                                break;
                            case 4:

                                if (num2 == 0)
                                {
                                    Console.WriteLine("No es posible dividir por 0");
                                }
                                else
                                {
                                    resultado = num1 / num2;
                                    Console.WriteLine("El resultado es: {0}", resultado);
                                }
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es valida");
                    }
                }catch(FormatException)
                {
                    Console.WriteLine("El formato ingresado no es correcto");

                }catch(OverflowException)
                {
                    Console.WriteLine("El valor ingresado es demaciado grande");

                }catch(Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error: {0}", ex.ToString());
                }
                Console.WriteLine("Deseas volver a la aplicación");
                Console.WriteLine("(Si)");
                Console.WriteLine("(No)");
                repetir = Console.ReadLine(); 

            } while (repetir.ToLower() == "si");

            Console.ReadKey();
        }
    }
}
