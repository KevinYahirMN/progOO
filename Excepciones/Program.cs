using System;

namespace Excepciones
{
    class EdadIncorrectaException : Exception
    {
        public EdadIncorrectaException(): base(error){}

        public EdadIncorrectaException(): base("Edad muy alta"){}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura un numero");

            int num = 0;
            string captura;

            try 
            {
                captura = Console.ReadLine();
                num = Int32.Parse(captura);
            
                Console.WriteLine("Se capturo el numero {0}",captura);
            }

            catch(EdadIncorrectaException)
            {
                
            }
            catch(Exception x)
            {
                Console.Write(x.Message);
            }
            finally
            {
                Console.WriteLine("Captura un numero we");
                
            }
            
        }
    }
}
