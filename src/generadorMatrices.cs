using System;

namespace PacMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de las variables que vamos a emplear en la aplicación
            int filasMatriz1;
            int columnasMatriz1;
            Random rnd = new Random();

            Console.WriteLine("Generador de matrices");

            //Solicitamos el ingreso de los datos al usuario.
            Console.WriteLine("Introduzca el número de filas de la matriz 1");
            filasMatriz1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el número de columnas de la matriz 1");
            columnasMatriz1 = int.Parse(Console.ReadLine());

            //Creamos la matriz 1

            int[,] matriz1 = new int[filasMatriz1, columnasMatriz1];


            //Recorremos la matriz1 y la imprimimos


            for (int filas = 0; filas < matriz1.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz1.GetLength(1);
                    columnas++)

                    matriz1[filas, columnas] = rnd.Next(10);
            }

            for (int filas = 0; filas < matriz1.GetLength(0); filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < matriz1.GetLength(1); columnas++)

                    Console.Write(matriz1[filas, columnas]+" ");
                    
            }

            Console.ReadKey();
        }
    }
}
