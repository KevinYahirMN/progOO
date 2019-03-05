using System;

namespace Sobrecarga
{
class Persona //: Object    Se hedera en la clases implicitamente
{
 public int id;
 public string nombre;

 public Persona (int id, string nombre)
 {
     this.id = id;
     this.nombre = nombre;
 }

 public static bool operator ==(Persona A, Persona B)
 {
   return A.id == B.id;
 }
 public static bool operator !=(Persona A, Persona B)
 {
   return A.id != B.id;
 }
public override bool Equals(object o)
{
    return this.id.Equals((o as Persona).id);
  //((Persona) o).nombre(); Forma general
}
public override Int32 GetHashCode()
{
 return this.id.GetHashCode();
}
}


    class Program
    {
        static void Main(string[] args)
        {
            Persona A = new Persona(1,"ana");
            Persona C = new Persona(1,"ana");
            Persona B = C;
            Console.WriteLine(A.GetHashCode());
             Console.WriteLine(B.GetHashCode());
              Console.WriteLine(C.GetHashCode());
            if (A == B)
            {
                Console.WriteLine("Son iguales");
                
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}
