using System;
using System.Collections.Generic;

namespace Practica
{
    class Persona: IComparable
    {
        string nombre {get; set;}

        DateTime FechaNacimiento {get;set;}

        public Persona(string n, DateTime fn)
        {
            nombre = n; FechaNacimiento = fn;
        }
        public override string ToString()
        {
            return  String.Format("{0} {1}", nombre,FechaNacimiento.ToString("dd/MM/yy"));
        }

        public int CompareTo(object obj)
        {
            return FechaNacimiento.CompareTo((obj as Persona).FechaNacimiento);
        }
    }
            class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            //No olvides el ADD KRNAL
            personas.Add(new Persona("Ana", new DateTime(2017,9,12)));
            personas.Add(new Persona("Pepe", new DateTime(2001,8,3)));
            personas.Add(new Persona("Tom", new DateTime(2011,1,11)));
            personas.Add(new Persona("Jose", new DateTime(2015,5,9)));
            
            personas.Sort();

            foreach(var p in personas){
                Console.WriteLine(p);
            }
            
           
        }
    }
}
