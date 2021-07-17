using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // String class

            //Podemos declarar la variable tanto en mayúscula como minúscula, pero por convención, lo haremos en minúscula

            string libro = "Fundación";

            Console.WriteLine("El título es " + libro);

            string autor = "Asimov";

            Console.WriteLine("El autor es " + autor);

            //Podemos meter todo esto en una variable

            string texto = "El título del libro es " + libro + "  y su autor es " + autor;
            Console.WriteLine(texto);

            //Podemos usar la clase String para alterar de algún modo el resultado de la variable llamando a un método

            string mayuscula = texto.ToUpper();

            Console.WriteLine(mayuscula);
            
            Console.ReadKey();
        }
    }
}
