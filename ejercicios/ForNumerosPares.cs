using System;

namespace ForNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ejemplo de for con continue que eliminará de una sucesión los números pares

            for (int i = 1; i < 10; i++)
            {
                if (i %2 == 0)
                {
                    Console.WriteLine("Aquí había un número par");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
