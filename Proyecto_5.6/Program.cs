using System;
using System.IO;
using System.Collections.Generic;
namespace Proyecto_5._6
{
    public class Producto
    {
        public string Codigo;
        public string Descripcion;
        public Decimal Precio;
        public int Departamento;
        public int Likes;

        public Producto(string Codigo, string Descripcion, 
              Decimal Precio, int Departamento, int Likes)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion; 
            this.Precio = Precio;
            this.Departamento = Departamento;
            this.Likes = Likes; 
        }
    }

    public class ProductoDB
    {
        private const string ruta =  @"C:\Users\Kevin\Desktop\Productos\";
        private const string Path = ruta + "Productos.txt";
        public static List<Producto> ObtenerProductos()
        {
            if (!Directory.Exists(ruta))
                Directory.CreateDirectory(ruta);

            StreamReader Leertxt = new StreamReader(
            new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));    
        
            List<Producto> Productos = new List<Producto>();
            while (Leertxt.Peek() != -1)
            {
                string row = Leertxt.ReadLine();
                string [] columnas = row.Split('|');
                Producto producto = new Producto("","",0,0,0);
                producto.Codigo = columnas[0];
                producto.Descripcion = columnas[1];
                producto.Precio = Convert.ToDecimal(columnas[2]);
                producto.Departamento = Convert.ToInt32(columnas[3]);
                producto.Likes = Convert.ToInt32(columnas[4]);
                Productos.Add(producto);
            }
            
            Leertxt.Close();
            return Productos;     
        }
        public static void SalvarProductos(List<Producto> productos)
        {
            StreamWriter Escribirtxt = new StreamWriter(
            new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Producto p in productos)
            {
                Escribirtxt.Write(p.Codigo +"|");
                Escribirtxt.Write(p.Descripcion + "|");
                Escribirtxt.Write(p.Precio + "|");
                Escribirtxt.Write(p.Departamento + "|");
                Escribirtxt.WriteLine(p.Likes);
            }
           
            Escribirtxt.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> Productos = new List<Producto>();
           Productos.Add(new Producto("AA11", "Lapiz rojo", 22.5m, 5, 22));
           Productos.Add(new Producto("AA12", "Lapiz azul", 25.5m, 3, 7));
           Productos.Add(new Producto("AA13", "Lapiz verde", 30.3m, 2, 1));   
        }
    }
}