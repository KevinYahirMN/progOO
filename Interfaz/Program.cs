using System;
using System.Collections.Generic;
namespace Interfaz
{

    interface IRenderizable
    {
      void Render();
    }
   
   class Image : IRenderizable
   {
       public void Render()
       {
         Console.WriteLine("The image is rendering");
       }
   }

    class Video : IRenderizable
   {
       public void Render()
       {
         Console.WriteLine("The video is rendering");
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,IRenderizable> dic = new Dictionary<String,IRenderizable>();
            dic.Add("intro.mov", new Video());
            dic.Add("pepe.png", new Image());
            dic.Add("ending.mov", new Video());
            dic.Add("imagen.png", new Image());
            dic.Add("pauerpoint.mov", new Video());
            
            IRenderizable contenido;

           Console.WriteLine(dic.TryGetValue("pepe.png",out contenido));
           Console.WriteLine(contenido);
        }
    }
}
