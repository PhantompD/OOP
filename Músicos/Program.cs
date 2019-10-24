using System;

namespace Músicos
{
    
    class Músico
    {
      protected string nombre;

      public Músico(string n)
      {
       nombre = n;
      }

      public virtual void Afina()
      {
       Console.WriteLine("{0} afina su instrumento", nombre );
      } 

      public virtual void Saludo()
      {
          Console.WriteLine("Hola soy {0}", nombre);
      }

    }

    class Bajista : Músico 
    {
        private string bajo;

        public Bajista(string no, string b):base(no)
        {
            bajo = b;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} afinando su {1}", nombre, bajo);
        }

        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y soy bajista", nombre);
        }
    }
    
    
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Bajista b = new Bajista("Dan", "Banjoo");
            b.Saludo();
            b.Afina();
        }
    }
}
