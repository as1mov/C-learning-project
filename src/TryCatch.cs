using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
		{
            Console.WriteLine("Introduce un número");
            string input = Console.ReadLine();

            //Capturamos la sentencia susceptible de generar excepciones
            try
            {
                int valorInt = int.Parse(input);
            }
            /*Devolvemos la excepción con el catch según el tipo de error que sea
            Podemos crear tantos catchs como excepciones diferentes queramos capturar
            En cualquier caso, si en un catch dejamos solo Exception, capturará cualquier tipo de excepción
            */

            // Cuando el formato no es el correcto (Por ejemplo, introducir texto)
            catch (FormatException)
            {
                Console.WriteLine("No has introducido un valor númerico, calamar");
            }
            //Cuando hay sobrecarga (el valor es demasiado grande para el tipo de variable)
            catch (OverflowException)
            {
                Console.WriteLine("El número introducido es demasiado grande");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No has introducido ningún valor");
            }

            //Utilizamos finally para ejecutar un código, pase lo que pase

            finally
            {
                Console.WriteLine("Esto se ejecutará pase lo que pase");
            }
        }
    }
}
