using System;
using System.Collections.Generic;

namespace Tarea4
{
interface IAfina
     {
          void Afina();
     }
public class Musico
    {
        public string nombre;
        public Musico (string n)

        {
          nombre = n;
        }
      public string Display()

        {
          return nombre;
        }
    }
class Bajista: Musico,IAfina

{
     public string instrumento;
     public Bajista (string n, string i ):base(n)
     {
         this.nombre = n;
         this.instrumento = i;
     }
     public void Afina()
      {
          Console.WriteLine("El bajista {0} afina su bajo {1}",nombre, instrumento);
      }

 }

class Guitarrista:Musico,IAfina
{
     public string instrumento;
     public Guitarrista (string n, string i ):base(n)
     {
          this.nombre = n;
          this.instrumento = i;
     }
     public void Afina()
     {
          Console.WriteLine("El guitarrista {0} afina su guitarra {1}",nombre, instrumento);
     }
}
class Program
{
     public static void Main()
     {

          Bajista b = new Bajista("Flea","generico");
          Guitarrista g = new Guitarrista("Santana","de lolo");
          //Musico [] m = new Musico[2];
          //m[0] = b;
          //m[1] = g;

          List<IAfina> musicos = new List<IAfina>();
          musicos.Add(b);
          musicos.Add(g);
          
          
          foreach ( IAfina x in musicos)
          x.Afina();
          Console.ReadKey();
     }
 }
}