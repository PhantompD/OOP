using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Proyecto
{
    class Producto
    {
       
        //Declaración de variables
        public string Codigo 
        {
            get; 
            set;
        }
        
       
        public string Descripcion
        {
            get; 
            set;
        }
       
        public decimal Precio
        {
            get; 
            set;
        }
       
        public int Departamento
        {
            get;
            set;
        }
       
        public int Likes
        {
            get;
            set;
        }


        public Producto(string C, string D, decimal PR, int DP, int L)
        {
            Codigo = C;
            Descripcion = D;
            Precio = PR;
            Departamento = DP;
            Likes = L;
        }

        //Constructor
        public Producto()
        {}
  
       class ProductoDB
       {

        //Creando una lista 
        public static void EscribeBIN(string archivo, List<Producto> productos) 
        {
            FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);
            
            foreach(Producto p in productos)
            {
            
             binOut.Write(p.Codigo);
             binOut.Write(p.Descripcion);
             binOut.Write(p.Precio);
             binOut.Write(p.Departamento);
             binOut.Write(p.Likes);
             }

             binOut.Close();
        }

        //Creando una lista 
        public static void EscribeTXT(string archivo, List<Producto> productos) 
        {

         FileStream fs = new FileStream(archivo , FileMode.OpenOrCreate, FileAccess.Write);
         StreamWriter txtOut = new StreamWriter(fs);

         foreach(Producto p in productos)
         {
            
             txtOut.WriteLine("{0}|{1}|{2}", p.Codigo,p.Descripcion,p.Precio);
        }

        txtOut.Close();

        }
         
         // leer los producto
         public static List<Producto> LeeBIN(string archivo) 
         {

          List<Producto> productos = new List<Producto>();  
          FileStream fs = new FileStream(archivo , FileMode.Open, FileAccess.Read);
         
         using( BinaryReader binIn = new BinaryReader(fs))
          {
            
            while( binIn.PeekChar() != -1 ) 
            {
                Producto producto = new Producto();
                producto.Codigo = binIn.ReadString();
                producto.Descripcion = binIn.ReadString();
                producto.Precio = binIn.ReadDecimal();
                      
                productos.Add( producto);

            }

           }

        return productos;

        }

         public static List<Producto> LeeTXT(string archivo)
         {
        
         List<Producto> productos = new List<Producto>();   

         using( StreamReader sr = new StreamReader(archivo))
         {
            string line = "";
           
            while(  (line =  sr.ReadLine()) != null ) 
            {
                string[] columnas = line.Split('|');
            
                productos.Add( new Producto(columnas[0],columnas[1],Decimal.Parse(columnas[2]),int.Parse(columnas[3]),int.Parse(columnas[4])));

            }

        }

        return productos;

        }

        //Metodo de menu principal con opciones 
        public static void GetDepartment()
        {
   
         string eleccion_producto = Console.ReadLine();
         int depo=Convert.ToInt32(eleccion_producto);
    
        switch (depo)
        {
         case 1:
         Console.WriteLine("0700|Nintendo Switch|1800.00|Departamento 1|1000");
         break;

         case 2:
         Console.WriteLine("6767|Play Station|1092.00|Departamento 2|2000");      
         break;

         case 3:
         Console.WriteLine("9067|SNES|1586.00|Departamento 3|3000");
         break;

        case 4:
         Console.WriteLine("0067|XBOX 360|1082.00|Departamento 4|4000");
        break;

        case 5:
        Console.WriteLine("Salida");
        break;

        default:
        Console.WriteLine("Fin de lista");
        break;
      
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
         List<Producto> productos = new List<Producto>();
         productos.Add(new Producto("0700","Nintendo Switch", 1800,1 ,1000));            
         productos.Add(new Producto("9090","Play Station 4", 1092, 2,2000));            
         productos.Add(new Producto("5738","SNES", 1506,3,  3000));            
         productos.Add(new Producto("2369","XBOX 360", 1082,4, 4000));           


        //Ver producto de un departamento usando switch-case
        Console.WriteLine("Escoge un Departamento");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Departamento 1");
        Console.WriteLine("Departamento 2");
        Console.WriteLine("Departamento 3");
        Console.WriteLine("Departamento 4");
        Console.WriteLine("Salir");
        ProductoDB.GetDepartment(); 

       

        // Define the query expression.
        IEnumerable<Producto> productoQuery =
            from p in productos 
            where p.Precio > 18000
            orderby p.Descripcion
            select p;

        IEnumerable<Producto> productoQuery2 =  productos.Select(p => p).Where( p => p.Precio > 18000).OrderBy(p => p.Descripcion);
      
       //Imprime resultados 
        ProductoDB.EscribeBIN(@"productos.bin",productos);

        Console.WriteLine("Archivo Grabado");
            Console.ReadKey();
            List<Producto>productos_leidos = ProductoDB.LeeBIN("producto.bin");

            foreach(Producto pr in productos_leidos)
            {
                Console.WriteLine("{0} {1} {2}", pr.Codigo, pr.Descripcion, pr.Precio, pr.Departamento, pr.Likes);
            }


          






        }

      }

    }

    }
}