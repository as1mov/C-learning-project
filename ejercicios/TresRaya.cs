using System;

namespace TresRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables del juego
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;

            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                    Fichas(jugador, ingreso);

                } else if (jugador == 1)
                {
                    jugador = 2;
                    Fichas(jugador, ingreso);
                }

                Tablero();

                //Verifica si hay ganador
                char[] checkFicha = { 'X', 'O' };

                foreach (char ficha in checkFicha)
                {
                    if ((Casillas[0, 0] == ficha) && (Casillas[0, 1] == ficha) && (Casillas[0, 2] == ficha)
                        || (Casillas[1, 0] == ficha) && (Casillas[1, 1] == ficha) && (Casillas[1, 2] == ficha)
                        || (Casillas[2, 0] == ficha) && (Casillas[2, 1] == ficha) && (Casillas[2, 2] == ficha)
                        || (Casillas[0, 0] == ficha) && (Casillas[1, 0] == ficha) && (Casillas[2, 0] == ficha)
                        || (Casillas[0, 1] == ficha) && (Casillas[1, 1] == ficha) && (Casillas[2, 1] == ficha)
                        || (Casillas[0, 2] == ficha) && (Casillas[1, 2] == ficha) && (Casillas[2, 2] == ficha)
                        || (Casillas[0, 0] == ficha) && (Casillas[1, 1] == ficha) && (Casillas[2, 2] == ficha)
                        || (Casillas[0, 2] == ficha) && (Casillas[1, 1] == ficha) && (Casillas[2, 0] == ficha))
                    {
                        if (ficha == 'X')
                        {
                            Console.Beep();
                            Console.WriteLine("¡Ha ganado el jugador 2!");
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("¡Ha ganado el jugador 1!");
                        }
                        break;
                    }
                    
                }

                //Verifica el valor ingresado
                #region
                do
                {
                    Console.WriteLine("\nJugador {0}: Elige una casilla", jugador);
                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Casilla en uso, elige otra casilla");
                    }

                    if ((ingreso == 1) && (Casillas[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 2) && (Casillas[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 3) && (Casillas[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 4) && (Casillas[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 5) && (Casillas[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 6) && (Casillas[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 7) && (Casillas[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 8) && (Casillas[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 9) && (Casillas[2, 2] == '9'))
                        ingresoCorrecto = true;
                    else
                    {
                        Console.WriteLine("\n Por favor, ingresa otro número");
                        ingresoCorrecto = false;
                    }
                    #endregion
                } while (!ingresoCorrecto);

            } while (true);
        }

        //Método para crear el tablero
        public static void Tablero()
        {
            Console.Clear();
            Console.WriteLine("_________________");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", Casillas[0, 0], Casillas[0, 1], Casillas[0, 2]);
            Console.WriteLine("_____|_____|_____|");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", Casillas[1, 0], Casillas[1, 1], Casillas[1, 2]);
            Console.WriteLine("_____|_____|_____|");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", Casillas[2, 0], Casillas[2, 1], Casillas[2, 2]);
            Console.WriteLine("_____|_____|_____|");
        }

        //Array que contiene las variables del juego que contiene las casillas
        public static char[,] Casillas =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        //Método identificar jugador

        public static void Fichas(int jugador, int ingreso)
        {
            char ficha = ' ';

            if (jugador == 1)
            {
                ficha = 'X';
            }else if (jugador == 2)
            {
                ficha = 'O';
            }

            switch (ingreso)
            {
                case 1: Casillas[0, 0] = ficha; break;
                case 2: Casillas[0, 1] = ficha; break;
                case 3: Casillas[0, 2] = ficha; break;
                case 4: Casillas[1, 0] = ficha; break;
                case 5: Casillas[1, 1] = ficha; break;
                case 6: Casillas[1, 2] = ficha; break;
                case 7: Casillas[2, 0] = ficha; break;
                case 8: Casillas[2, 1] = ficha; break;
                case 9: Casillas[2, 2] = ficha; break;
            }
        }

    }
}
