using System;

namespace Tiempo
{
    class Program
    {
        class Duracion
        {

          public int Horas;
          public int Minutos;
          public int Segundos;

          public Duracion (int H, int M, int S)
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
                int sobra = Segundos % 3600;
                int Hrs = 0; 
                int Min = 0;              

                while(Segundos > 3600)
                {
                    Segundos = Segundos - 3600;
                    Hrs = Hrs + 1;
                }


                while(sobra > 60)
                {
                  sobra = sobra - 60;
                  Min = Min + 1;
                }

                Horas = Hrs;
                Minutos = Min;

                Console.WriteLine("Hora: {0}:{1}:{2}", Horas, Min, sobra);
               
            }

              public static int operator +(Duracion c, Duracion a)
          {
               
              return ( (a.Horas + c.Horas) * 3600 + (a.Minutos + c.Minutos) * 60 + a.Segundos + c.Segundos);
          }

          
          



        }

        static void Main(string[] args)
        {

            Duracion a = new Duracion (2,10,5);
            Duracion b = new Duracion(0, 0, 7300);
            Duracion c = new Duracion(3, 3, 20);          
            a.print();
            b.Conv();
            Console.WriteLine(a + c);
            
            
        }
    }
}
