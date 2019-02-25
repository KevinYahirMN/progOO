using System;
using System.Collections.Generic;

namespace tarea1
{
   class Persona
    {
        //Atributos
        private string nombre;
        private int edad;
        //Se hacen los datos propiedad
        public string Nombre
        {
            get {return nombre;}
            set {nombre=value;}
        }
        //La clase también tiene métodos
        //El primer método será un constructor, la mayoría de los métodos son públicos
        public Persona (string nombre, int e)
        {
            //Se usa el this. para diferenciar entre las variables locales y las que se encuentran en la clase, si no hubiera ambiguedad, no se necesita el this
            this.nombre=nombre;
            this.edad=e;
        }

        //Método para imprimir, void porque no retorna valor
        public void Imprime()
        {
            Console.WriteLine(nombre);

        }

        //Sobrecarga de imprime, se llama igual, pero tiene argumentos o tipos de datos distintos
        public void Imprime(int veces)
        {
            for (int i=0;i<=veces;i++)
            {
                Imprime();
            }
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
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea una lista para los objetos tipo persona, la lista se llama personas
            List<Persona>personas=new List<Persona>();
           
            //Aquí se crean los objetos, esto se hace después de hacer el constructor en la clase Persona
            Persona x=new Persona("Ana",46);

            //Se agrega Ana a la lista
            personas.Add(x);
            //Igualmente, se pueden instanciar nuevos objetos dentro de una lista
            personas.Add(new Persona("Meow",-5));
            x.Imprime(3);

        }
    }
}
