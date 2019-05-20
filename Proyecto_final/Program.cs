using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto_final
{
    class Producto
    {
        public string Codigo;
        public string Descripcion;
        public Decimal Precio;
        public int Departamento;
        public int Likes;

        public Producto (string Codigo, string Descripcion, Decimal Precio, int Departamento, int Likes)
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
        const string ruta = @"C:\Users\Kevin\progOO\Proyecto_final";
        const string path = ruta + "Productos.txt";

         static List<Producto> Productos()
        {
            if (!Directory.Exists(ruta))
            Directory.CreateDirectory(ruta);
//#####################################################################################################
            StreamReader Leertxt = new StreamReader(
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));

            List<Producto> Productostxt = new List<Producto>();
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
                Productostxt.Add(producto);
            }
                
              BinaryReader LeerBin = new BinaryReader(
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));

            List<Producto> Productosbin = new List<Producto>();
            while (Leertxt.Peek() != -1)
            {
             
                Producto producto = new Producto("","",0,0,0);
                producto.Codigo = LeerBin.ReadString();
                producto.Descripcion = LeerBin.ReadString();
                producto.Precio = LeerBin.ReadDecimal();
                producto.Departamento = LeerBin.ReadInt32();
                producto.Likes = LeerBin.ReadInt32();
                Productosbin.Add(producto);
            }
                Leertxt.Close();
                 LeerBin.Close();
                return Productostxt;
                return Productosbin;
        }
         static void SaveProductos(List<Producto> Productos)
        {
            StreamWriter Escribirtxt = new StreamWriter(
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));

            foreach (Producto p in Productos)
            {
                Escribirtxt.Write(p.Codigo +"|");
                Escribirtxt.Write(p.Descripcion + "|");
                Escribirtxt.Write(p.Precio + "|");
                Escribirtxt.Write(p.Departamento + "|");
                Escribirtxt.WriteLine(p.Likes);
            }

             BinaryWriter bin = new BinaryWriter(
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));

            foreach (Producto p in Productos)
            {
                bin.Write(p.Codigo +"|");
                bin.Write(p.Descripcion + "|");
                bin.Write(p.Precio + "|");
                bin.Write(p.Departamento + "|");
                bin.Write(p.Likes);
            }
                bin.Close();
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
