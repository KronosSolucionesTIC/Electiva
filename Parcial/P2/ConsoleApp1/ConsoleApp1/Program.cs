using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = -1;

            do
            {
                y++;
                x = x - y;
                Console.WriteLine($"El valor de X es {x}; El valor de y es {y}");
            } while (x > 0 && y >= 0);
            Console.Read();
        }
    }
}
