using System;

namespace IfElseif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de uso de if y else if

            Console.WriteLine("Por favor, introduzca la temperatura actual");
            string inputTemperatura = Console.ReadLine();

            int temperatura = 0;
            int grados;
            
            //Hacemos TryParse para controlar que el dato introducido es correcto
            
            if(int.TryParse(inputTemperatura, out grados))
            {
                temperatura = grados;
            }
            else
            {
                Console.WriteLine("El valor introducido no es correcto. Un terrible temblor invade tu cuerpo");
            }

            //Creamos los if y elseif según la temperatura introducida

            if (temperatura < 10)
            {
                Console.WriteLine("Abrígate bien. Hace frío");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("Quizá necesites una chaquetita");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("Hace calor, ponte algo ligero");
            }
            else
            {
                Console.WriteLine("Estás en Mordor, regresa a Hobbiton");
            }

            Console.ReadKey();
        }
    }
}
