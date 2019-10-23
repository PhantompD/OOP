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
            

            public void Conv()
            {
                double sobra = Segundos % 3600;
                double Hrs = 0;              

                while(Segundos > 3600)
                {
                    Segundos = Segundos - 3600;
                    Hrs = Hrs + 1;
                }

                Console.WriteLine("Hora: {0}:{1}:{2}", Hrs, "0", sobra);
            }



        }

        static void Main(string[] args)
        {

            Duracion a = new Duracion (2,10,5);
            Duracion b = new Duracion(0, 0, 7200);
            a.print();
            b.Conv();
            //restaS
        }
    }
}
