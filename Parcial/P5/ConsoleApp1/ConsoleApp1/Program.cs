using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int funcion1(int max)
        {
            Console.WriteLine($"El valor de max es {max}");
            while(max >= 0)
            {
                if (max % 2 == 0 && max % 3 == 0)
                {
                    Console.WriteLine($"El numero mayor divisible por 6 es:{max}");
                    return max;
                } else
                {
                    max--;
                }
            }
            //Que debe ir aca
            return max;
        }

        static void Main(string[] args)
        {
            string x = "1000";
            int num = Convert.ToInt32(x);
            int z = num * num;
            Console.WriteLine($"El valor de x es {x}");
            int y = Program.funcion1(num);
            Console.WriteLine($"El valor de y es {y}");
            Console.Read();
        }
    }

}
