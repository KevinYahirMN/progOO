using System;

namespace Herencia
{

class Musico
{
    public string nombre;
    public Musico(string n){

        nombre = n;
    }

    public virtual string saludo()
    {
     return string.Format("Hola, soy {0}", nombre) ;
    }
    }

    class Bajista : Musico
    {
        public string bajo;
          public Bajista (string nombre, string bajo):base(nombre){
          this.bajo = bajo;
     }
     public override string saludo()
     {
        return base.saludo() + "y soy bajista";
     }
    }

    class Pianista : Musico
    {
        public string piano;
        public Pianista (string nombre, string piano):base(nombre){
            this.piano = piano;
        }
        public override string saludo()
        {
            return base.saludo() + "y soy pianista";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        Musico m = new Musico("Lady gaga");
        Bajista b = new Bajista("el rapsodia boemia ", "cereza");
        Pianista p = new Pianista("Lucas muecas ","perfect");


        Console.WriteLine(m.saludo());
        Console.WriteLine(b.saludo());
        Console.WriteLine(p.saludo());
        }
    }
}
