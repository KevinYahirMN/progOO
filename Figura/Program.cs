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
            Console.WriteLine("Se dibuja un Circulo en {0} de color {1} con bordes {2} con un radio de {3}",
            position,fill,border, radio);
        }
    }

    class Triangulo : Figura
    {
        public Triangulo(Vector2D pos):base(pos)
        {}
        public Triangulo():base()
        {}

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Triangulo en {0} de color {1} con bordes {2}",
            position,fill,border);
        }
    }

    class Rectangulo : Figura
    {
        public Rectangulo(Vector2D pos):base(pos)
        {
            fill = "blue";
            border = "red";
        }
        public Rectangulo():base()
        {}

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1} con bordes {2}",
            position,fill, border);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura>figuras= new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2D(200,200) ));
            figuras.Add(new Triangulo(new Vector2D(150,230) ));
                figuras.Add(new Triangulo());

            foreach (Figura f in figuras)
            f.Dibuja();
        }
    }
}