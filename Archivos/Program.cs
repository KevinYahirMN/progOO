using System;
using System.IO;
namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Especifica una ruta");
            //string ruta = "C:\\Users\\Kevin\\progOO\\Archivos";
             string ruta = Console.ReadLine();

            if (Directory.Exists(ruta))
            {
                Directory.Delete(ruta, true); 
            }
            else
            {
                Directory.CreateDirectory(ruta);
            }
        }
    }
}
