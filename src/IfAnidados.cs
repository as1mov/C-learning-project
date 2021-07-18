using System;

namespace IfAnidados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de uso de if anidados

            bool estaRegistrado = true;
            string nombreUsuario;

            Console.WriteLine("Introduzca su nombre de usuario");
            nombreUsuario = Console.ReadLine();

            if (estaRegistrado)
            {
                Console.WriteLine("Bienvenid@ usuario registrado");
                if(nombreUsuario != "")
                {
                    Console.WriteLine("Bienvenid@, " + nombreUsuario);
                    if (nombreUsuario.Equals("Administrador"))
                    {
                        Console.WriteLine("Bienvenid@, administrador");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
