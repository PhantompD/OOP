using System;

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

    class Program
    {
        static void Main(string[] args)
        {
            Estado b = new Estado ( "blabla", 1700);
            b.Imp();
        }
    }
}
