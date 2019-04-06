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
            for (int i=0; i<12; i++)
            {
                Console.WriteLine("{0}",Convert.ToString(i));
                //Do somethig here
                i = i + 1;                
            }
            Console.Read();
        }
    }
}
