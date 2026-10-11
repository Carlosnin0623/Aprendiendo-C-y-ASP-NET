using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_C_
{
    internal class _07_Expresiones_logicas
    {
        public static void Ejemplo(string[] args)
        {
            /*
             *  Expresiones Logicas (Conjunción)
             * 
             *  Operador   Significado  Condición
             *  
             *     &&          Y         Se evalua como verdadera unicamente cuando ambas
             *                           expresiones son verdaderas
             *                           
             *                           
             *    P       Q        P&&Q
             *    
             *   True    True     TRUE
             *   False   True     FALSE
             *   True    False    FALSE
             *   FALSE   FALSE    TRUE
             *   
             *   Expresiones Logicas (Conjunción)
             *   
             *   Operador   Significado  Condición 
             *   
             *     ||           O          Se evalua como verdadera siempre que al menos
             *                             una condición sea verdadera
             *   
             *   
             *    P       Q        P||Q
             *   TRUE    TRUE       TRUE
             *   TRUE    FALSE      TRUE
             *   FALSE   TRUE       TRUE
             *   FALSE   FALSE      FALSE
             *   
             *   
             *   Expresiones Logicas (Negacion)
             *   
             *   Operador   Significado  Condición
             *   
             *      !        Negacion     Esto quiere decir que si el operando
             *                            del lado derecho es true, el operador regresa
             *                            false. Y si el operador del lado derecho es false,
             *                            el operador regresa true
             *                            
             *    P       Negacion 
             *   TRUE      FALSE
             *   FALSE     TRUE
             * 
             */

            int tanque = 40;
            int recorrido = 250;

            if(tanque < 50 && recorrido > 200)
            {
                Console.WriteLine("Las expresiones son verdaderas, tanquear el vehiculo");
            }
            else
            {
                Console.WriteLine("Las expresiones no se cumplen, false");
            }

          
            // Expresiones Logicas (Negacion)

            bool dia = true;

            if (!dia)
            {
                Console.WriteLine("No puedes salir a hacer tus deligencias: {0}", dia);
            }
            else
            {
                Console.WriteLine("Puedes salir a hacer tus deligencias: {0}", dia);
            }

            /*
             *  Programa que verifique si el usuario puede conducir
             *  18 o 15 permiso de los padre
             */

            int edad;
            bool permiso;
            string valor;

            Console.WriteLine("Ingresa tu edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tienes permiso de tus padres: true=Si false=No");
            valor = Console.ReadLine();

            if (valor.ToLower() == "si")
            {
                permiso = true;

                if (permiso && edad == 15)
                {
                    Console.WriteLine("Puedes conducir, pero con cuidado");
                }
            } else if (valor.ToLower() == "no")
            {
                 permiso = false;

                if(!permiso && edad >= 18)
                {
                    Console.WriteLine("Puedes conducir, ya que eres un adulto");

                }else if (!permiso && edad <= 15)
                {
                    Console.WriteLine("No Puedes conducir, ya que no tienes permiso de tus padres, ni eres mayor de edad");
                }
            }
                Console.ReadKey();
        }
    }
}
