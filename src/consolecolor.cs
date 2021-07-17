using System;

namespace ConsoleColor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cambiar color de fondo y de texto de la consola
            
            Console.BackgroundColor = System.ConsoleColor.DarkBlue;
            Console.ForegroundColor = System.ConsoleColor.DarkGray;
            Console.Clear();

            Console.WriteLine("Observa cómo ha cambiado el fondo y el texto de la consola");

            Console.ReadKey();
        }
    }
}
