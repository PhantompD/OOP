using System;
using System.Collections.Generic;

namespace Publicación
{

    abstract class Public
    {
        protected string Texto;
        protected int HP;

        public Public(string Texto, int HP)
        {
            this.Texto = Texto;
            this.HP = HP;
        }

        public abstract void Imp();
    }

    class Estado : Public
    {
        public string Est;

        public Estado(string Texto, int HP):base(Texto, HP)
        {
            Est = "Estado";
        }

        public override void Imp()
        {
            Console.WriteLine("Publicación de tipo: {0}", Est);
            Console.WriteLine("Contenido: {0}", Texto);
            Console.WriteLine("Publicado a las {0} horas", HP);
        }

    }



        class Foto : Public
    {
        public string Est;
        public string Imagen;

        public Foto(string Texto, int HP):base(Texto, HP)
        {
            Est = "Foto";
            Imagen = "Foto.jpg";
        }

        public override void Imp()
        {
            Console.WriteLine("Publicación de tipo: {0}", Est);
            Console.WriteLine("{0}", Texto);
            Console.WriteLine("Publicado a las {0} horas", HP);
            Console.WriteLine("Contenido: {0}", Imagen);
        }

    }


    class Link : Public
    {
        public string Est;
        public string link;

        public Link(string Texto, int HP):base(Texto, HP)
        {
            Est = "Link";
            link = "http://";
        }

        public override void Imp()
        {
            Console.WriteLine("Publicación de tipo: {0}", Est);
            Console.WriteLine("{0}", Texto);
            Console.WriteLine("Publicado a las {0} horas", HP);
            Console.WriteLine("URL: {0}", link);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Estado a = new Estado ( "blabla", 1700);
            Foto b = new Foto ( "los tiempos de dios son perfectos", 1200);
            Link c = new Link ( "Entra a este link", 1800);
            //b.Imp();
            
            List<Public> pub = new List<Public>();
            pub.Add(a);
            pub.Add(b);
            pub.Add(c); 

            foreach (Public p in pub)
            {
                Console.WriteLine("//");
                p.Imp();

            }
        }
            
    }
}
