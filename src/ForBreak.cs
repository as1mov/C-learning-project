using System;

namespace forBreak
{
    class Program
    {
        static void Main(string[] args)
        {

            /*La instrucción "break" rompe la ejecución del bucle contenedor más próximo
             El control se pasará a la instrucción que hay a continuación de la finalizada (si existe)
             */

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
                                                 
            Console.ReadKey();
        }
    }
}
