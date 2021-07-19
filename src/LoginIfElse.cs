using System;

namespace Login
{
    class Program
    {

        static string nombreUsuario;
        static string pass;

        static void Main(string[] args)
        {
            Registro();
            Ingreso();
            Console.ReadKey();
        }

        public static void Registro()
        {
            Console.WriteLine("Por favor, introduce nombre de usuario");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Introduce contraseña");
            pass = Console.ReadLine();
            Console.WriteLine("Registrado satisfactoriamente");
        }

        public static void Ingreso()
        {
            Console.WriteLine("Introduce nombre de usuario");
            if (nombreUsuario == Console.ReadLine())
            {
                Console.WriteLine("Introduce la contraseña");
                if (pass == Console.ReadLine())
                {
                    Console.WriteLine("Sesión iniciada satisfactoriamente");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta. Ejecuta el programa de nuevo");
                }
            }
            else
            {
                Console.WriteLine("Usuario incorrecto. Ejecute el programa de nuevo");
            }
        }
    }
}
