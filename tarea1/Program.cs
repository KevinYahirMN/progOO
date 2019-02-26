using System;
using System.Collections.Generic;

namespace tarea1
{
   class Persona{
protected string nombre;
protected int edad;

public string Nombre {
get { return nombre;}
set { nombre = value; }
}

public Persona(string nombre, int e )
{
this.nombre = nombre;
edad = e;
}
public virtual void Imprime()
{
Console.WriteLine(nombre);
}

public void Imprime(int veces){
for (int i=0; i<veces; i++ )
Imprime();
}

        public static Persona operator +(Persona a, Persona b)
        {
            return new Persona(a.nombre+b.nombre, a.edad+b.edad);
        }

        public static Persona operator -(Persona a, Persona b)
        {
            return new Persona(a.nombre, a.edad-b.edad);
        }
        public static bool operator <(Persona a, Persona b)
        {       
            return (a.edad<b.edad);           
        }
         public static bool operator >(Persona a, Persona b)
        {       
            return (a.edad>b.edad);           
        }
    }

    class Alumno:Persona
{
private string num_control;

public Alumno(string nombre, int edad
, string n ):base(nombre,edad)
{
// this.nombre = nombre;
// this.edad = edad;
this.num_control = n; }
public override void Imprime()
{
Console.WriteLine(num_control);
}

}


class program
{
static void Main(string[] args)
{
Persona p = new Persona("Ana",46);
List<Persona> personas = new List<Persona>();
personas.Add(p);
//personas.Add("Jim");
personas.Add( new Alumno("Jim",18,"18210782"));
personas.Add( new Persona("Ki",12));
p.Imprime(3);
personas[1].Imprime();
Alumno a = new Alumno("Zoe",19,"ZZ");
a.Imprime();
// Console.WriteLine("Helo Wsd!");
}
}
}
