using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _19_Arreglos_clase_teorica
    {
        static void Main(string[] args)
        {
            /*
             * Arreglos (Arrays)
             * Un array es un indicador que puede almacenar varios valores simultaneamente.
             * Cada uno de estos valores se identifica mediante un número al cual se llama
             * indice, Asi, para acceder al primer elemento del array habria que usar
             * el indice cero, para el segundo índice uno, para el tercero el índice
             * dos y asi sucesivamente.
             * 
             *  Los arrays tambien son conocidos como grupo de variables.
             *  
             *  Sirven para almacenar datos por elemento de un colegio que desee guardar
             *  la edad de los alumnos.
             *  
             *  Tipos de arreglos:
             *  
             *  Arreglos de una dimencion:
             *  
             *  Declaración:
             *  
             *  tipo[] nombre = new tipo[tamaño];
             *  
             *  Ejemplo de calificaciones:
             *  
             *  float[] calificaciones = new float[10];
             *  
             *  instanciación: Proceso de leer o especificar información, como valores y el
             *  tipo de almacenamiento de una campo de datos.
             *  
             *  Asignar valores a los arreglos 
             *  
             *  calificaciones[2] = 8.5f;
             *  
             *  Asignando valores de una vez
             *  float[] valores = {1.5f, 3.78f, 2.1f};
             */

            // Ejercicio Arrays unidimencionales

            int cantidad, n;
            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;


            Console.WriteLine("Ingresa calificación de los alumnos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            float[] calificacion = new float[cantidad];

            for(int i = 0;  i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la calificación");
                calificacion[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            // sumar todas las calificaciones

            for(int i = 0;i < calificacion.Length;i++)
            {
                suma += calificacion[i];
            }

            // Calcular promedio

            promedio = (suma / cantidad);

            // obtener calificación mínima

            for (int i = 0; i < calificacion.Length; i++)
            {
                if(calificacion[i] < minima)
                {
                    minima = calificacion[i];
                }
            }

            // obtener calificación maxima

            for (int i = 0; i < calificacion.Length; i++)
            {
                if (calificacion[i] > maxima)
                {
                    maxima = calificacion[i];
                }
            }

            Console.WriteLine("Resumen de calificaciones");
            Console.WriteLine("Cantidad de calificaciones: {}");
        }

    }
}
