using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {

            //Definimos dos vectores de dos modos diferentes

            int[] vector = new int[5];
            int[] vector2 = { 1, 2, 3, 4, 5 };


            /*Recorremos el vector con el bucle for (Cambiamos la impresión de pantalla
            entre los dos vectores para ver las diferencias*/

            for (int i = 0; i<5; i++) {

                Console.WriteLine(vector2[i]);

            }
                    
            Console.ReadKey();
        }
    }
}
