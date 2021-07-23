using System;

namespace ForForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Partiendo del siguiente array

            int[] numeros = new int[10];

            //Vamos a asignarle valores e imprimirlos (necesitaremos recorrer dos veces el array con dos for
            //Utilizamos el método Length para no "salirnos" de la matriz

            //Asignamos valores:

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
            }

            //Imprimimos:

            for(int j=0; j < numeros.Length; j++)
            {
                Console.WriteLine("El valor del índice {0} es {1}", j, numeros[j]);
            }

            //Sin embargo, el loop foreach es mejor para recorrer arrays

            foreach(int k in numeros)
            {
                Console.WriteLine("El valor del índice {0} es {1}", k, numeros[k]);
            }

            Console.ReadKey();
        }
    }
}
