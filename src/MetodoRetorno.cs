using System;

namespace MetodoRetorno
{
    class Program
    {

        //Declaramos el método

        public static int Sumar (int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
		    {
            //Invocamos el método en Main
            Console.WriteLine(Sumar(15,35));
        }
    }
}
