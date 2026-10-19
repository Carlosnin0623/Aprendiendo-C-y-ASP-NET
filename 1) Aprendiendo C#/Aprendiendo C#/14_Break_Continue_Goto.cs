using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _14_Break_Continue_Goto
    {
       public static void Ejemplo(string[] args)
        {
            /* break: Si cumple la condicion detiene la ejecución del bucle
            int id;

            for(id = 1; id < 20; id++)
            {
                if(id == 9)
                {
                    break;
                }

                Console.WriteLine(id);
            }
            */


            /* Continue: si se cumple la condición, omitira el resultado y seguira con el proximo número

            for(int id = 1; id < 20; id++)
            {
                Thread.Sleep(1000);

                if(id == 9)
                {
                    Console.WriteLine("");
                    continue;
                }

                Console.WriteLine(id);
            }

            */

            // go to: 

            for(int id = 1; id < 20; id++)
            {
                Thread.Sleep(500);

               if(id == 9)
                {
                    Console.WriteLine("");
                    if(id == 9)
                    {
                        continue;
                    }

                    goto retirados;
                }

                Console.WriteLine(id);
            }

        retirados:
            Console.WriteLine("El afliliado 9 se reporto como retirado");




            Console.ReadKey();
        }
    }
}
