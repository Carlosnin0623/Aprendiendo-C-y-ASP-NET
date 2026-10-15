using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class Bucle_For
    {
        public static void Ejemplo(string[] args)
        {
            int n, cantidad;
            float calif;
            float suma = 0.0f;
            float promedio = 0.0f;

            // pedir datos
            Console.WriteLine("Ingrese la cantidad de calificaciones");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (n = 0; n < cantidad; n++){

                Console.WriteLine("Ingrese calificaciones de los alumnos");
                calif = Convert.ToSingle(Console.ReadLine());

                suma += calif;
            }

            promedio = suma / cantidad;

            Console.WriteLine("El promedio de calificación es: {0}", promedio);
           
            Console.ReadKey();
        }
    }
}
