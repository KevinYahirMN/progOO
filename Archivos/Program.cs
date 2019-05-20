using System;
using System.IO;

namespace archivos
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Especifica una ruta");

string ruta= Console.ReadLine();
// string ruta= @".\folder2"; //@ indica que lo tome
if( Directory.Exists(ruta))
{
Directory.Delete(ruta,true);

}
else
{
Directory.CreateDirectory(ruta);
}

}
}
}