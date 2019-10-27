using System;
using System.Collections.Generic;

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

       public virtual void Toca()
      {
          Console.WriteLine("Toca su instrumento");
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

        public override void Toca()
        {
            Console.WriteLine("Empieza a tocar su {0}", bajo);
        }
    }

    class Baterista : Músico 
    {
        private string bateria;

        public Baterista(string no, string b):base(no)
        {
            bateria = b;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} afinando su {1}", nombre, bateria);
        }

        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y soy baterista", nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("Empieza a tocar su {0}", bateria);
        }
    }
    
    class Guitarrista : Músico 
    {
        private string guitarra;

        public Guitarrista(string no, string b):base(no)
        {
            guitarra = b;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} afinando su {1}", nombre, guitarra);
        }

        public override void Saludo()
        {
            Console.WriteLine("Hola soy {0} y soy guitarrista", nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("Empieza a tocar su {0}", guitarra);
        }
    }
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Bajista b = new Bajista ("Dan", "Banjoo");
            Baterista c = new Baterista ("Roy", "Batt");
            Guitarrista a = new Guitarrista ("Ned", "Del Olo");

           

            List<Músico> grupo = new List <Músico>();
            grupo.Add(a);
            grupo.Add(b);
            grupo.Add(c);

            foreach(Músico m in grupo)
            {
                m.Saludo();
                m.Afina();
                m.Toca();
                Console.WriteLine("////////");
            }
         

        }
    }
}
