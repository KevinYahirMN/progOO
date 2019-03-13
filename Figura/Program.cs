using System;
using System.Collections.Generic;

namespace Figura
{

     class Vector2D 
    {
      public int x,y;
      public Vector2D(int x, int y)
      {
          this.x = x; this.y = y;
      }

public override string ToString()
{
    return String.Format("{0},{1}",x,y);
}
    }
    abstract class Figura
{
    public Vector2D position;
    public string fill, border;
    
    public Figura():this(new Vector2D(100,100))
    {}
    public Figura(Vector2D pos)
    {
        position = pos;
        fill = "White";
        border = "Black";
    }
    public abstract void Dibuja();
}
   
   class Circulo : Figura
{
    private int radio;
    public Circulo(Vector2D pos, int radio):base(pos)
    {
      this.radio = radio;
    }
    public Circulo():base()
    {
       this.radio = 10;
    }

    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un Circulo en {0} de color {1}, con un radio de {2}",position,fill, radio);
    }
}

class Rectangulo : Figura
{
    private int radio;
   
    public Rectangulo(Vector2D pos, int radio):base(pos)
    {}
    public Rectangulo():base()
    {}

    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}, con un radio de {2}",position,fill, radio);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            List<figuras>= new List<Figuras>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200,200) ));
            Console.WriteLine("Hello darkness mi old friend, i come to talk with you again");

            foreach (Figura f in figuras)
            f.Dibuja();
        }
    }
}
