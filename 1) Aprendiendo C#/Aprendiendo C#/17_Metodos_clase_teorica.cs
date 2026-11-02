using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _17_Metodos_clase_teorica
    {
       public static void Ejemplo(string[] args)
        {
            /*
             *  Funciones y metodos
             *  
             *  La función o método es un elemento del programa que contiene
             *  código y se puede ejecutar, es decir, lleva a cabo una operación
             *  (Conjunto de instrucciones). La funcion o metodo puede llamarse
             *  o invocarse cuando sea necesario y entonces el código que se encuentra
             *  en su interior se va a ejecutar. Una vez la función termina de ejecutarse
             *  el programa continua en la sentencia siguiente de donde fue llamada.
             * 
             */

            /* Ejercicio */

            string nombre;
            int numeroEscritorios;
            decimal resultado = 0.0m;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite la cantidad de escritorios que desea comprar:");
            numeroEscritorios = Convert.ToInt32(Console.ReadLine());

            resultado = Calcular(nombre, numeroEscritorios);

            Console.WriteLine("Factura Final");
            Console.WriteLine("El Sr/Sra: {0} ha comprado {1} unidades ", nombre, numeroEscritorios);
            Console.WriteLine("El total a pagar es: ${0:N2}", resultado);

            Console.ReadKey();

        }

        public static decimal Calcular(string nombre, int numeroEscritorios)
        {
            decimal valor = numeroEscritorios * 650.00m;
            decimal resultado = 0.0m;

            if (numeroEscritorios < 5)
            {
                resultado = valor * 0.9m;

            }else if(numeroEscritorios >=  5 && numeroEscritorios < 10)
            {
                resultado = valor * 0.8m;

            }else if (numeroEscritorios >= 10)
            {
                resultado = valor * 0.6m;
            }

            return resultado;
        }
    }
}
