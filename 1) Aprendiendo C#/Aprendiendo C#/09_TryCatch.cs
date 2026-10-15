using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _09_TryCatch
    {
        public static void Ejemplo(string[] args)
        {
            /*
             *  Try Catch
             *  
             *  Cuando se presenta un error al momento de ingresar datos, la aplicación se va a
             *  detener. Esta estructura nos va a permitir mostrar el error avisándole al usuario
             *  que ingreso un formato no valido.
             *  
             *   try{
             *   
             *     Código
             *   }
             *   
             *   Catch(Exception "Tipos de variables de Expección"){
             *   
             *   
             *   }
             *
             */

            int n1, n2, resultado;

            try
            {
                Console.WriteLine("Ingresa el primer número");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo número");
                n2 = Convert.ToInt32(Console.ReadLine());

                resultado = n1 * n2;

                Console.WriteLine("El resultado es: {0}", resultado);

            }catch(FormatException)
            {
                Console.WriteLine("El formato ingresado no es valido");

            }catch(OverflowException)
            {
                Console.WriteLine("El valor ingresado es demaciado grande");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
