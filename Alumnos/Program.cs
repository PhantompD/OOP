using System;


namespace Alumnos
{
    abstract class Alumnos
    {
       protected string Nombre;
       protected string Semestre;
       public Alumnos(string N, string S)
       {
           this.Nombre=N;
           this.Semestre=S;
       }
       public abstract void print();
       
    }

    class Licenciatura : Alumnos
    {
        public Licenciatura(string N,string S):base(N,S)
        {
          
        }
        public override void print()
        {
             Console.WriteLine("El estudiante {0} de {1}" , Nombre, Semestre);
             Console.WriteLine("Hara su servicio social y residecia");
             
        }
    }
    class Posgrado : Alumnos
    {
        public Posgrado(string N,string S):base(N,S)
        {
            
        }
        public override void print()
        {
            Console.WriteLine("El estudiante {0} de {1}" ,Nombre,Semestre);
            Console.WriteLine("investigara sobre la computación cuantica");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Licenciatura D = new Licenciatura("Daniel Abader","Licenciatura");
            Posgrado M = new Posgrado("Marian D.","Posgrado");
            D.print();
            M.print();
        }

    }
}