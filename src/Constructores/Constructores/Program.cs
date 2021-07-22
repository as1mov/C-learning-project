using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos instancia de clase
            Moto honda = new Moto("honda", "verde");

            honda.arrancar();

            Console.ReadKey();
        }
    }
}