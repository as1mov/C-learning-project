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
                    fichas(jugador, ingreso);

                } else if (jugador == 1)
                {
                    jugador = 2;
                    fichas(jugador, ingreso);
                }

                tablero();

                //Verifica si hay ganador
                char[] checkFicha = { 'X', 'O' };

                foreach (char ficha in checkFicha)
                {
                    if ((casillas[0, 0] == ficha) && (casillas[0, 1] == ficha) && (casillas[0, 2] == ficha)
                        || (casillas[1, 0] == ficha) && (casillas[1, 1] == ficha) && (casillas[1, 2] == ficha)
                        || (casillas[2, 0] == ficha) && (casillas[2, 1] == ficha) && (casillas[2, 2] == ficha)
                        || (casillas[0, 0] == ficha) && (casillas[1, 0] == ficha) && (casillas[2, 0] == ficha)
                        || (casillas[0, 1] == ficha) && (casillas[1, 1] == ficha) && (casillas[2, 1] == ficha)
                        || (casillas[0, 2] == ficha) && (casillas[1, 2] == ficha) && (casillas[2, 2] == ficha)
                        || (casillas[0, 0] == ficha) && (casillas[1, 1] == ficha) && (casillas[2, 2] == ficha)
                        || (casillas[0, 2] == ficha) && (casillas[1, 1] == ficha) && (casillas[2, 0] == ficha))
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

                            Console.WriteLine("Pulsa una tecla para reiniciar la partida");
                            Console.Read();
                            ingreso = 0;
                            Reset();
                            break;
                        }
                    }
                    else if (turno == 10)
                    {
                        Console.WriteLine("\n ¡Ha habido un empate!");
                        Console.WriteLine("Pulsa una tecla para reiniciar la partida");
                        Console.Read();
                        ingreso = 0;
                        Reset();
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

                    if ((ingreso == 1) && (casillas[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 2) && (casillas[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 3) && (casillas[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 4) && (casillas[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 5) && (casillas[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 6) && (casillas[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 7) && (casillas[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 8) && (casillas[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 9) && (casillas[2, 2] == '9'))
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
        public static void tablero()
        {
            Console.Clear();
            Console.WriteLine("_________________");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", casillas[0, 0], casillas[0, 1], casillas[0, 2]);
            Console.WriteLine("_____|_____|_____|");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", casillas[1, 0], casillas[1, 1], casillas[1, 2]);
            Console.WriteLine("_____|_____|_____|");
            Console.WriteLine("     |     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |", casillas[2, 0], casillas[2, 1], casillas[2, 2]);
            Console.WriteLine("_____|_____|_____|");
            turno++;
        }

        //Array que contiene las variables del juego que contiene las casillas
        public static char[,] casillas =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        //Array que contiene las variables del juego que contiene las casillas iniciales
        public static char[,] casillasIniciales =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        // Método para resetear la partida

        public static void Reset()
        {
            casillas = casillasIniciales;
            tablero();
            turno = 0;
        }

        //Cuantificar turnos

        static int turno = 0;

        //Método identificar jugador

        public static void fichas(int jugador, int ingreso)
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
                case 1: casillas[0, 0] = ficha; break;
                case 2: casillas[0, 1] = ficha; break;
                case 3: casillas[0, 2] = ficha; break;
                case 4: casillas[1, 0] = ficha; break;
                case 5: casillas[1, 1] = ficha; break;
                case 6: casillas[1, 2] = ficha; break;
                case 7: casillas[2, 0] = ficha; break;
                case 8: casillas[2, 1] = ficha; break;
                case 9: casillas[2, 2] = ficha; break;
            }
        }
    }
}
