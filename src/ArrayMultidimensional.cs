using System;

namespace ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de matriz bidimensional

            int[,] matrizBidimensional;


            //Declaración de matriz tridimensional

            int[,,] matrizTridimensional;

            /*Una matriz puede tener tantas dimensiones como quieras.
             * El número de comas dentro de los corchetes indica las dimensiones que tiene*/

            //Declaración e inialización de una matriz bidimensional

            int[,] array2 = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            //Para imprimir un valor concreto tenemos que indicar las coordenadas dentro de la matriz

            Console.WriteLine("El valor del número central es {0}", array2[1,1]);

            //Creación de matriz tridimensional

            string[,,] array3 = new string[,,]
            {
                {
                    { "a", "b", "c" },
                    { "d", "e", "f" },
                    { "g", "h", "i" }
                },
                {
                    { "j", "k", "l" },
                    { "m", "n", "o" },
                    { "p", "q", "r" }
                },
                                {
                    { "s", "t", "u" },
                    { "v", "w", "x" },
                    { "y", "z", "*" }
                }
            };

            /*Para imprimir un valor, debemos indicar primero en qué tabla se encuentra, luego la fila
            y por último la columna. Imprimamos la letra "n"*/

            Console.WriteLine("En algún recóndito lugar, existe la letra {0}", array3[1,1,1]);

            //Para conocer las dimensiones de un array utilizamos el método Rank

            Console.WriteLine("array2 tiene {0} dimensiones", array2.Rank);
            Console.WriteLine("array3 tiene {0} dimensiones", array3.Rank);

            Console.ReadKey();
        }
    }
}
