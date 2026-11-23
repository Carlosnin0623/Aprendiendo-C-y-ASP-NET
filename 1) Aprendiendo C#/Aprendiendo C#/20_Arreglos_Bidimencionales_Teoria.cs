using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _20_Arreglos_Bidimencionales_Teoria
    {
        static void Main(string[] args)
        {
            /*
             *  Arreglos (Arrrays) bidimencionales
             *  
             *  Permite organizar valores en filas y columnas
             *  
             *  conocidos como matrices.
             *  
             *  usamos dos indices o posiciones (el de la fila y el de la columa)
             *  
             *  Arreglo unidimencional:
             *  [1,2,3,4,5,6,7,8,9]
             * 
             *  Declaracion de los arreglos de dos dimencioanes
             *  
             *  float[,] tabla = new float[5,3]; declaracion con valores definidos
             *  
             *  float[,] tabla = new float[n,m]; declaracion con variables
             *  
             *  
             * 
             */

            int cantidad;
            int salones;
            int n;
            int m;

            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;

            try
            {
                Console.WriteLine("Ingrese la cantidad de salones");
                salones = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de alumnos");
                cantidad = Convert.ToInt32(Console.ReadLine());

                float[,] calif = new float[salones, cantidad];

                // Registrar calificaciones

                for (n = 0; n < calif.GetLength(0); n++)
                {
                    Console.WriteLine("Salón: {0}", n + 1);
                    for (m = 0; m < calif.GetLength(1); m++)
                    {
                        Console.WriteLine("Ingresa la calificación del alumno: {0}", m + 1);
                        calif[n, m] = Convert.ToSingle(Console.ReadLine());
                    }
                }

                // Sumar todas las calificaciones

                for (n = 0; n < calif.GetLength(0); n++)
                {
                    for (m = 0; m < calif.GetLength(1); m++)
                    {
                        suma += calif[n, m];
                    }
                }

                // Promedio

                promedio = suma / (cantidad * salones);


                // Obtener calificacion mas baja de los alumnos 

                for (n = 0; n < calif.GetLength(0); n++)
                {
                    for (m = 0; m < calif.GetLength(1); m++)
                    {
                        if (calif[n, m] < minima)
                        {
                            minima = calif[n, m];
                        }
                    }
                }

                // Obtener calificacion mas alta de los alumnos 

                for (n = 0; n < calif.GetLength(0); n++)
                {
                    for (m = 0; m < calif.GetLength(1); m++)
                    {
                        if (calif[n, m] > maxima)
                        {
                            maxima = calif[n, m];
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("El dato ingresado no esta permitido");
            }
            catch(OverflowException)
            {
                Console.WriteLine("El dato ingresado es demaciado grande");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Estas intentando acceder a un elemento que esta fuera de los límites");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: {0}", ex.Message);
            }

           

            Console.WriteLine("Suma de calificaciones: {0}", suma);
            Console.WriteLine("Promedio de calificaciones: {0}", promedio);
            Console.WriteLine("Calificación mas alta: {0}", maxima);
            Console.WriteLine("Calificación mas baja: {0}", minima);


            Console.ReadKey();
        }
    }
}
