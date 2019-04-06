using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp5
{
    class Program
    {
        // Esta es la función principal del programa
        // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Variables necesarias
            float valor = 0.0f;
            float resultado = 0.0f;
            // Mostramos el menú
            Console.Write("Introduce un numero entero para saber si es par o impar: ");
            valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valor);

            if (valor == 0)
            {
                Console.WriteLine("IF = El numero es cero {0}",valor);
            }
            else if (valor % 2 == 0){
                Console.WriteLine("IF = El numero es par {0}", valor);
            }
            else{
                Console.WriteLine("IF = El numero es impar {0}", valor);
            }

            resultado = valor % 2;

            switch (resultado)
            {
                // Caso para valor 0
                case 0:
                    Console.WriteLine("SWTICH = El numero es par o cero {0}", valor);
                    break;
                default:
                    Console.WriteLine("SWTICH = El numero es impar {0}", valor);
                    break;

            }
            Console.ReadLine();
        }
    }
}