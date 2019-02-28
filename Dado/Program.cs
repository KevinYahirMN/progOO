using System;

namespace Dados
{
    class Dados
    {
public int valor;

Random valor = new Random();
int aleatorio = valor.Next(1,6);
public string color;

public Dado (int valor, string color)
{

 this.color = color;
}


    }
    class Program
    {

        static void Main(string[] args)
        {
            Dados dado1 = new Dados(3,"verde");
            Dados dado2 = new Dados(5,"rojo");
            Dados dado3 = new Dados(4,"azul");
        }         
    }     
    }
     
    
