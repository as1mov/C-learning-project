using System;

namespace Switch
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Selecciona 1, 2 o 3");
            string opcion = Console.ReadLine();
            int numero = int.Parse(opcion);

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Has elegido la opción 1");
                    break;
                case 2:
                    Console.WriteLine("Has elegido la opción 2");
                    break;
                case 3:
                    Console.WriteLine("Has elegido la opción 3");
                    break;
                default:
                    Console.WriteLine("Por favor, selecciona 1, 2 o 3");
                    break;
            }
            
            Console.ReadKey();
        }

    }
}
