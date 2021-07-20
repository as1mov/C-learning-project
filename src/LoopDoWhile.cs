using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos la variable
            int a = 5;

            //Definimos el bucle do-while

            do
            {
                Console.WriteLine("Este es un bucle do-while");
            } while (a == 6);

            /*Este bucle realiza la acción al menos una vez
             y se detiene cuando la condición del while se cumple*/

            Console.ReadKey();
        }
    }
}
