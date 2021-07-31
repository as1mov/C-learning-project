using System;

namespace ArrayIrregular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al contrario de los array normales, abrimos y cerramos dos corchetes
            //Esto indica tiene múltiples arrays dentro de uno solo

            int [][] matriz = new int [3][];

            //El corchete donde está el 3 indica el número de arrays que contiene el array
            //Empezamos a declarar cada uno de los arrays, donde el valor en los corchetes indicará el tamaño de la matriz

            matriz[0] = new int [4];
            matriz[1] = new int [3];
            matriz[2] = new int [6];

            //Asignamos valores a los arrays

            matriz[0] = new int[] { 10, 12, 3, 7 };
            matriz[1] = new int[] { 5, 70, 24 };
            matriz[2] = new int[] { 1, 32, 26, 62, 100, 82 };

            //Otro modo de crear el array

            int [][] matriz2 = new int [][]
            {
                new int[] { 10, 12, 3, 7 },
                new int[] { 5, 70, 24 },
                new int[] { 1, 32, 26, 62, 100, 82 }
            };

            /*Cómo acceder a un valor dentro del array:
            el primer valor entre corchetes es el número del array
            el segundo es el índice del valor de dentro del array*/

            Console.WriteLine("El segundo valor de la segunda matriz es {0} ", matriz[1][1]);

            //Accedemoms a todos los valores del array con un for

            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("Los valores del array {0} son: ", i);
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("{0}", matriz[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
