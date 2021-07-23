using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración del array

            int[] edades;

            //Inicialización del array

            edades = new int[4];

            /*Aunque parezca que el array está vacío, en realidad no lo está.
            Si no hemos asignado ningún valor, la matriz tendrá asignados los valores por defecto según su tipo.
            Así, si el array es de tipo entero, cogerá por defecto el 0. En objetos o strings, null.
            Probamos a imprimirlo...*/

            Console.WriteLine(edades[3]);

            //Asignamos valores al array

            edades[0] = 12;
            edades[1] = 18;
            edades[2] = 27;

            //Si dejamos un valor sin añadir, se le dará el valor por defecto, en este caso, 0

            //Imprimimos uno de los valores asignados

            Console.WriteLine(edades[2]);

            //Nos devuelve el valor 27.

            //Si le pedimos la cuarta posición [3], cuyo valor no ha sido asignado, nos devolverá 0

            Console.WriteLine(edades[3]);

            //Si intentamos acceder a un índice de la matriz que no existe.

            edades[3] = 8;

            //Nos dará un error de excepción, ya que dicho valor no existe en la matriz (está fuera de rango)

            //Otras formas de declarar un array:

            string[] alumnos = { "José", "Luis", "Ana", "Lucía" };

            //El tamaño del array lo fijará el número de datos que estén entre llaves.

            //Otro modo:

            int[] numeros = new int[] { 2, 4, 8, 15, 22 };

            Console.ReadKey();
        }
    }
}
