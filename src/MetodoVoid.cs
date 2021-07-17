using System;

namespace MetodoVoid
{
    class Program
    {
        // Creamos los métodos fuera del Main
        public static void Frase()
        {
            Console.WriteLine("Esto es un método o función sin retorno de valor");
        }

        public static void Texto (string texto)
        {
            Console.WriteLine(texto);
        }

        static void Main(string[] args)
		    {
            //Invocamos los métodos en Main
            Frase();
            Texto("Hola, esto es un método");

            Console.ReadKey();
        }
    }
}
