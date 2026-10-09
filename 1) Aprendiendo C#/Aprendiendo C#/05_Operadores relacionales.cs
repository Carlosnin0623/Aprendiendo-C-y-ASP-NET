using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _05_Operadores_relacionales
    {
        public static void Ejemplo(string[] args)
        {
            /* Operadores Relacionales
             * 
             * Se usan para expresar la relación que existe entre dos valores
             *
             * Estas expresiones, al igual que las expresiones aritmeticas, tienen sus
             * propios operadores.
             * 
             * La expresión será evaluada, pero el resultado de la evaluación tendrá
             * únicamente dos valores posibles: true o false Booleanos.
             * 
             * SIGNO OPERADOR
             *   
             *    == igualdad
             *    != No igual - Diferente
             *    > Mayor que
             *    < Menor que
             *    >= Mayor o igual que
             *    <= Menor o igual que
             *    
             *    
             */

            /* Ejemplo 1 */
            double nota1, nota2, resultado;

            try
            {
                Console.WriteLine("Ingrese el primer número:");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                nota2 = Convert.ToDouble(Console.ReadLine());

                resultado = (nota1 + nota2) / 2;

                if(resultado >= 5)
                {
                    Console.WriteLine("Aprobo el semestre tu calificación es: {0}", resultado);
                }
                else
                {
                    Console.WriteLine("No aprobo el semestre tu calificación es: {0}", resultado);
                }

            }catch (FormatException)
            {
                Console.WriteLine("Lo siento solo se permiten números en este campo");

            }catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado en este campo es demaciado grande, intente con un valor mas pequeño");

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
