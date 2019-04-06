using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Crea un nuevo diccionario con valores tipo string, y con llaves   
        // tipo string
        Dictionary<string, string> openWith =
            new Dictionary<string, string>();

        // Agrega algunos elementos al diccionario. No hay
        // llaves duplicadas, pero valores si.
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");

        // El método Add lanza una nueva excepción si la nueva llave está
        // ya en el diccionario
        try
        {
            openWith.Add("txt", "winword.exe");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Un elemento con llave = \"txt\" ya existe.");
        }

        // El indexador puede ser usado para cambiar el valor 
        //asociado a la llave
        openWith["rtf"] = "winword.exe";
        Console.WriteLine("Para la llave = \"rtf\", valor = {0}.",
            openWith["rtf"]);
        Console.ReadLine();

        // Si una llave no existe, debe configurarse el indexador, 
        //de tal manera que agregue un par nuevo de key o llave y value o valor.
        openWith["doc"] = "winword.exe";

        // El indexador envía una excepción si la llave requerida 
        //no se encuentra en el diccionario
        try
        {
            Console.WriteLine("Para llave = \"tif\", valor = {0}.",
                openWith["tif"]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Llave = \"tif\" no es encontrada.");
        }
    }
}