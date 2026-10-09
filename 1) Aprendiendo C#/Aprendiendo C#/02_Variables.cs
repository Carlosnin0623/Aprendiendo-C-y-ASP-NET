using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class _02_Variables
    {
        public static void Ejemplo(string[] args)
        {
            string Nombre = "Carlos Alberto Nin";
            short num1 = 28;
            float estatura = 1.80f; //la palabra f se usa para especificar que es de tipo float
            bool pescado = true;
            decimal numero = 1.5m;
            double numero2 = 2.5d;
            Console.WriteLine("Mi nombre es: {0}, tengo {1} años de edad y mido: {2} metros de estatura y el pescado me gusta?: {3}", Nombre, num1, estatura, pescado);
            Console.ReadKey();
        }
    }
}
