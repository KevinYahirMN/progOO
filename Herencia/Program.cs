using System;
using System.Collections.Generic;

namespace Herencia
{
// esta clase se llama con .base
abstract class Musico
{
    public string nombre;
    public Musico(string n){

        nombre = n;
    }

public abstract string saludo();
    
    }

     class Vocalista : Musico
     {
public Vocalista(string n):base(n){}

public override string saludo()
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
        return "y soy bajista";
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
            return "y soy pianista";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        Vocalista m = new Vocalista("Lady gaga");
        Bajista b = new Bajista("el mayoneso ", "jejeje");
        Pianista p = new Pianista("el calacas chidas ","perfect");

        List<Musico> musicos = new List<Musico>();
        musicos.Add(m);
        musicos.Add(b);
        musicos.Add(new Bajista("ayuwoki","hee hee"));

        foreach(Musico x in musicos)
        {

            Console.WriteLine(x.saludo());
        }
            Console.WriteLine(m.saludo());
        }
    }
    
}
