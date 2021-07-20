using System;

namespace EntradaDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            int edad;

            Console.WriteLine("Por favor, escriba su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor, indíquenos su edad");

            /*Como Console.WriteLine recoge únicamente datos de tipo string,
            deberemos hacer una conversión explícita de tipo de dato*/

            edad = int.Parse(Console.ReadLine());

            //Otra manera sería: edad = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine(edad);

            Console.WriteLine("Pulse cualquier botón para salir");

            Console.ReadKey();
        }
    }
}
