using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
		{
            
            //Conversión explícita
            
			      double doble = 15.25;
			      int entero;
			
			      entero = (int)doble;
			      Console.WriteLine(entero);

            //Conversión implícita

            int numero = 55555555;
            long numerogrande = numero;

            Console.WriteLine(numerogrande);

            //Conversión de tipo

            string cadena = doble.ToString();

            Console.WriteLine(cadena);

			      Console.ReadKey();
        }
    }
}
