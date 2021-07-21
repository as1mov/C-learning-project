using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //continue: se utiliza para terminar con la ejecución del bucle aunque la condición no se haya cumplido

            //Ejemplo de break

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine("Se para el blucle");
                    break;
                }
            }

            //Ejemplo de continue

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Console.WriteLine("Nos saltamos el número 5");
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
