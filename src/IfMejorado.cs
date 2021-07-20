using System;

namespace IfMejorada
{
    class Program
    {

        static void Main(string[] args)
        {

            /*Estructura del if mejorado:
             * condición ? primera expresión : segunda expresión;
             * la condición únicamente puede ser verdadera o falsa
             * El operador condicional es correcto
             * La expresión a ? b : c ? d : e
             * es evaluada como a ? b : (c ? d : e)
             * y no como (a ? b : c) ? d : e
             */

            int nota = 4;
            string evaluacion;

            //Con if largo:
            //if (nota >= 5)
            //{
            //    evaluacion = "aprobado";
            //}
            //else
            //{
            //    evaluacion = "suspenso";
            //}

            //con if mejorado

            evaluacion = nota >= 5 ? "aprobado" : "suspenso";
            
            Console.WriteLine(evaluacion);
            Console.ReadKey();
        }
    }
}
