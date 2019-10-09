using System;

namespace Domino
{
    class Program
    {

      class Domino
      {
        public readonly int LadoA;
        public readonly int LadoB;

       public Domino(int LA, int LB)
       {
           LadoA=LA;
           LadoB=LB;
       }
          
          public static int operator +(Domino a, Domino b)
          {
              return (a.LadoA + a.LadoB + b.LadoB + b.LadoA);
          }

      }




        static void Main(string[] args)
        {
            Domino a = new Domino (2,0);
            var b = new Domino (4,2);
            Console.WriteLine(a + b);
        }
    }
}
