using System;

namespace RecordJugador
{
    class Program
    {

        static int record = 1000;
        static string recordJugador = "Lucía";
        static void Main(string[] args)
        {
            checkRecord(100, "Daniel");
            checkRecord(1100, "BleizeN");
            checkRecord(750, "Cloud");
            Console.ReadKey();
        }
        public static void checkRecord(int puntos, string jugador)
        {
            if(puntos > record)
            {
                record = puntos;
                recordJugador = jugador;
                Console.WriteLine("El nuevo record es " + puntos);
                Console.WriteLine("Ha sido conseguido por " + jugador);
            }
            else
            {
                Console.WriteLine("El record de " + record + " del jugador " + recordJugador + " no ha sido superado");
            }
        }
    }
}
