using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
		{
            
            string texto1 = "35";
            string texto2 = "45";

            int num1 = Int32.Parse(texto1);
            int num2 = Int32.Parse(texto2);

            int resultado = num1 + num2;

            Console.WriteLine(resultado);

			      Console.ReadKey();
        }
    }
}
