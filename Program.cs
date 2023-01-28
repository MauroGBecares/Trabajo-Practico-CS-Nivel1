using System;

namespace TPFinal_Bécares
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            //     a. El mayor de los números pares.
            //     b. La cantidad de números impares.
            //     c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int numero, conImpar = 0, maxPar = 0, menPrimo = 0;
            bool bMpar = false, bmprimo = false;

            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if(par(numero))
                {
                    if(!bMpar)
                    {
                        maxPar = numero;
                        bMpar = true;
                    }
                    else if(numero > maxPar)
                        maxPar = numero;
                }
                else
                    conImpar++;

                if(primo(numero))
                {
                    if(!bmprimo)
                    {
                        menPrimo = numero;
                        bmprimo = true;
                    }
                    else if(numero < menPrimo)
                        menPrimo = numero;
                }
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El mayor de los números pares es: " + maxPar);
            Console.WriteLine("La cantidad de números impares es: " + conImpar);
            Console.WriteLine("El menor de los números primo es: " + menPrimo);


        }

        static bool par(int a)
        {
            if(a % 2 == 0)
                return true;
            else
                return false;
        }

        static bool primo(int primo)
        {
            int con = 0;
            for (int x = 1; x <= primo; x++)
            {
                if(primo % x == 0)
                    con++;  
            }
            if(con == 2)
                return true;
            else
                return false;
        }
    }
}
