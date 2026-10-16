using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _12_Bucle_While
    {
        public static void Ejemplo(string[] args)
        {
            /*   Ciclo While
             *   
             *   While(condicion){
             *   
             *     Código
             *   
             *   }
             *   
             *   Este ciclo se usa cuando queremos repetir algo en nuestro programa, pero
             *   la condición debe evaluarse como verdadera, si no se cumple la condicion
             *   entonces sale de la ejecución del bucle
             * 
             * 
             * 
             * */

            // Crea un programa que permita enfiar un horno a 20 c°

            int temperatura_horno;

            try
            {
                Console.WriteLine("Ingresa la termperatura del horno:");
                temperatura_horno = Convert.ToInt32(Console.ReadLine());

                while (temperatura_horno >= 0)
                {
                    if (temperatura_horno >= 20)
                    {
                        Thread.Sleep(1500);
                        Console.WriteLine("La temperatura del horno es muy alta: {0}c°", temperatura_horno);

                    }
                    else if (temperatura_horno < 20 && temperatura_horno > 0)
                    {
                        Thread.Sleep(1500);
                        
                        Console.WriteLine("La temperatura del horno esta bajando {0}c°", temperatura_horno);

                    }
                    else if (temperatura_horno == 0)
                    {
                        Thread.Sleep(1500);
                        Console.WriteLine("El horno se ha apagado");
                    }

                    temperatura_horno--;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato ingresado no es correcto");

            }catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado es muy grande");

            }catch(Exception ex)
            {
                Console.WriteLine("Se ha producido un error: {0}", ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
