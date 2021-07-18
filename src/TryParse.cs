using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversión de strings en tipos de datos numéricos con TryParse

            string numeroTexto = "2910";

            int conversion;

            bool parsing = int.TryParse(numeroTexto, out conversion);

            if (parsing)
            {
                Console.WriteLine("Parsing realizado. El número es " + conversion);
            }
            else
            {
                Console.WriteLine("Parsing erróneo");
            }

            Console.ReadKey();
        }
    }
}
