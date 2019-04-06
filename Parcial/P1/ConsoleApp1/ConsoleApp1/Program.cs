using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate;
            birthDate = new DateTime(1932, 6, 1);
            Console.WriteLine($"La fecha de nacimiento es {birthDate}");
            Console.ReadLine();
        }
    }
}