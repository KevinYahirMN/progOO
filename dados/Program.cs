using System;

namespace dados
{
    class Dado 
    {
        public int valor;
        public string color;

public Dado (int valor, string color)
{
    this.valor = valor;
    this.color = color;
}
         public void Imprime()
        {
            Console.WriteLine(valor.ToString());
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dado dado1 = new Dado(5,"verde");
            Dado dado2 = new Dado(3,"azul");
            Dado dado3 = new Dado(1,"rojo");
            dado1.Imprime();
        }
    }
}
