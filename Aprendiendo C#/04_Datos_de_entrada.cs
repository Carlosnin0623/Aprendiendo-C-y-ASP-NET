using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _04_Datos_de_entrada
    {
        static void Main(string[] args)
        {
            /* Capturar datos de entrada */

            string nombre;
            short edad;
            try
            {
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad:");
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mi nombre es: {0} y mi edad es: {1}", nombre, edad);
                Console.ReadKey();

            }catch(FormatException)
            {
                Console.WriteLine("Solo es permitido agregar valores númericos en el campo edad");

            }catch(OverflowException)
            {
                Console.WriteLine("El valor ingresado es superior al permitido, ingrese un valor menor");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido el siguiente error: {0}", ex.ToString());
            }

            Console.ReadKey();
            
        }
    }
}
