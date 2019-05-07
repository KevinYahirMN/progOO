using System;
using System.Collections.Generic;

namespace Repaso_herencia
{
    class Comentario
    {
        public string id;
        public string texto;
        public string autor;
     
        public Comentario(string autor, string texto)
        {
          id = Guid.NewGuid().ToString();
          this.texto = texto; this.autor = autor;
        }     

        public override string ToString()
        {
            return string.Format("{0} \n {1} {2}", id, autor, texto);
        }
    }

    class Post
    {
        public string id;
        public DateTime fecha;
           public string autor;

        public List<Comentario> comentarios;

        public Post(string autor)
        {
            id = Guid.NewGuid().ToString();
            fecha = DateTime.Now;
            comentarios = new List<Comentario>();
            this.autor = autor;
        }

        class d
        {

        }
        public class PostTexto : Post
        {
            public string texto;

            public PostTexto(string texto, string autor):base(autor)
            {
                this.texto = texto;
            }

            public override string ToString() 
            {
                string comments = "";
                foreach (var comment in this.comentarios)
                comments+=comment + "\n";
                return string.Format("{0} \n{1} \n{2} \n{3}", texto, autor, comments
                , fecha.Date);
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> muro = new List<Post>();
            string texto = "Paso pack";
            string autor = "babylov69";
         

            muro[1].comentarios.Add(new Comentario("babylov69","al cine pvto xdxd"));
            muro[1].comentarios.Add(new Comentario("eloc","te la rifastes ajajaja"));

            foreach ( var post in muro)
            Console.WriteLine(post);
        }
    }
}
