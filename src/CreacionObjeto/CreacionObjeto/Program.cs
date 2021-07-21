using System;

namespace CreacionObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de clase (creamos el objeto desde una clase)

            Moto harley = new Moto();

            //Accedemos a la variable pública de la clase y asignamos un valor
            harley.nombre = "Harley Davidson";

            //Invocamos a un método de la clase
            harley.arrancar();
            Console.WriteLine(harley.nombre + " ha arrancado");

            Console.ReadKey();
        }
    }
}