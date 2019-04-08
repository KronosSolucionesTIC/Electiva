using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            double parcial1 = 0;
            double parcial2 = 0;
            double parcial3 = 0;
            double parcial4 = 0;
            double promedio = 0;
            string estudiante = "";
            int cantidad = 0;

            //Pregunta cantidad de estudiantes para ingreso
            Console.Write("Escriba cantidad de estudiantes:");
            try
            {   
                //Valida que sea tipo entero
                cantidad = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato de dato no es el solicitado.");
            }   
            catch (OverflowException)
            {
                Console.WriteLine("El numero es muy grande o fuera de rango.");
            }

            // Crea un nuevo diccionario con valores tipo string, y con llaves   
            // tipo string
            Dictionary<string, double> Diccionario =
                new Dictionary<string, double>();

            for(int i=1; i <= cantidad; i++)
            { 
                //Solicita un numero entero al usuario
                Console.Write("Escribe valor del parcial 1:");
                //Se convierte double
                parcial1 = Convert.ToDouble(Console.ReadLine());
                //Solicita un numero entero al usuario
                Console.Write("Escribe valor del parcial 2:");
                //Se convierte double
                parcial2 = Convert.ToDouble(Console.ReadLine());
                //Solicita un numero entero al usuario
                Console.Write("Escribe valor del parcial 3:");
                //Se convierte double
                parcial3 = Convert.ToDouble(Console.ReadLine());
                //Solicita un numero entero al usuario
                Console.Write("Escribe valor del parcial 4:");
                //Se convierte double
                parcial4 = Convert.ToDouble(Console.ReadLine());
                //Solicita un numero entero al usuario
                Console.Write("Escribe el nombre del estudiante:");
                //Se convierte double
                estudiante = Console.ReadLine();
                //Operacion para sacar promedio
                promedio = (parcial1 * 0.25) + (parcial2 * 0.25) + (parcial3 * 0.25) + (parcial4 * 0.25);
                promedio = promedio / 4;

                // El método Add lanza una nueva excepción si la nueva llave está
                // ya en el diccionario
                try
                {
                    // Agrega algunos elementos al diccionario. No hay
                    // llaves duplicadas, pero valores si.
                    Diccionario.Add(estudiante, promedio);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Un elemento con llave = " + estudiante + " ya existe.");
                }
            }

            //Reccore el diccionario
            foreach (var registro in Diccionario)
            {
                Console.Write(registro + " ");
            }
            Console.ReadLine();
        }
    }
}
