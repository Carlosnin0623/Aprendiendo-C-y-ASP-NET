using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _11_Foreach
    {
        public static void Ejemplo(string[] args)
        {
            /*
             *  El forEach nos va ayudar a recorrer cadenas de texto o arrays
             *
             *
             */

            string nombre = "Academia Ciencia";

            foreach (char letra in nombre)
            {
               Console.WriteLine(" {0} ", letra);
            }

            Console.ReadKey();
        }
    }
}
