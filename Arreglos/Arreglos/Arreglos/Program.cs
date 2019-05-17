using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] calificaciones = new float[10];
            foreach (var name in calificaciones)
            {
                Console.Write(name + " ");
            }
            Console.ReadLine();
        }
    }
}
