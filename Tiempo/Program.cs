using System;

namespace Tiempo
{
    class Program
    {
        class Duracion
        {

          public double Horas;
          public double Minutos;
          public double Segundos;

          public Duracion (double H, double M, double S)
          {
            Horas=H;
            Minutos=M;
            Segundos=S;
          }

           public void print()
           {

            Console.WriteLine("Horas:{0}", Horas + (Minutos/60) + (Segundos/3600));

           }



        }

        static void Main(string[] args)
        {
            Duracion a = new Duracion (2,10,5);
            a.print();
        }
    }
}
