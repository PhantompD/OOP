using System;

namespace Parametros
{
    class Program
    {
      class Cuadrado
      {
          public void cuadrado(int n) 
          { 
			n = n*n;
	      }

	      public void cuadradoR(ref int n) 
          { 
			n = n*n;
	      }


       }



        
        
        
        
        static void Main(string[] args)
        {
            //Parametros por ref
            Cuadrado q = new Cuadrado();
		    int x = 3;
            Console.WriteLine("con x = 3");
		    q.cuadrado(x);
		    Console.WriteLine("Pase de parametros:" + x);

		    q.cuadradoR(ref x);
		    Console.WriteLine("Pase de parametros por ref:" + x);
        }






        
    }
}
