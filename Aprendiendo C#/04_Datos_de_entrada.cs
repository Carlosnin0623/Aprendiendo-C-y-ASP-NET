using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _04_Datos_de_entrada
    {
        public static void Ejemplo(string[] args)
        {
            /* Capturar datos de entrada */

            string nombre;
            short edad;
            double altura;

            try
            {
                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad:");
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingresa tu altura:");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Mi nombre es: {0}, mi edad es: {1} y mi altura es: {2}", nombre, edad, altura);
           

            }catch(FormatException)
            {
                Console.WriteLine("En esta campo solo es permitido valores numericos");

            }catch(OverflowException)
            {
                Console.WriteLine("El valor ingresado es superior al permitido, ingrese un valor menor");

            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido el siguiente error: {0}", ex.ToString());
            }

            Console.WriteLine("Por fvaor, Presiona la tecla enter para salir.");
            Console.ReadKey();  
        }
    }
}
