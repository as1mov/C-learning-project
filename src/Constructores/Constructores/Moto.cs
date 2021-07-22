using System;
using System.Collections.Generic;
using System.Text;

namespace Constructores
{
    class Moto
    {
        /*podemos asignar las variables como privadas, ya que se invocarán desde el constructor.
        No hay necesidad de acceder a ellas desde fuera de la clase*/

        private string nombre;
        private string color;

        //Constructor
        public Moto(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        //Métodos o acciones

        public void arrancar()
        {
            Console.WriteLine("prrrrrrrnnnnnnn");
        }
    }
}
