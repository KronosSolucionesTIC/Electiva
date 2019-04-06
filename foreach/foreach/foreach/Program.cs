using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una lista de cadena de carácteres o strings mediante un inicializador de colección o lista
            var colores = new List<string> { "rojo", "amarillo", "morado", "verde" };
            // Iterate through the list.  
            foreach (var color in colores)
            {
                Console.Write(color + " ");
            }
            Console.ReadLine();
            // Salida:rojo amarillo morado verde
        }
    }
}
