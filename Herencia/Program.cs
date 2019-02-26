using System;

namespace Herencia
{

class Musico
{
    public string nombre;
    public Musico(string n){

        nombre = n;
    }

    public string saludo()
    {
     return string.Format("Hola, soy {0}", nombre) ;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Musico m = new Musico("Lady gaga");

        Console.WriteLine(m.saludo());
        }
    }
}
