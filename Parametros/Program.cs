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

      class Suma {

	static void suma(int a, int b, out int resultado)
    {
		resultado = a + b;
	}

	static int suma(int a, int b)
    {
		return a + b;
	}

     class Resta
     {
       
       public void resul(in int c) 
       {

       }
	 }

        
        static void Main(string[] args)
        {
            //Parametros por ref
            Cuadrado q = new Cuadrado();
		    int x = 3;
            Console.WriteLine("con x = 3");
		    q.cuadrado(x);
		    Console.WriteLine("Pase de parametros: " + x);

		    q.cuadradoR(ref x);
		    Console.WriteLine("Pase de parametros por ref: " + x);

            Console.WriteLine("/////"); //Espacio

            //Parametros por out
            int num1 = 15;
		    int num2 = 10;
		    int r; 

            suma(num1, num2, out r);

             Console.WriteLine("Suma de 10 + 15 usando");
            Console.WriteLine("Pase de parametros: " + r);
		    Console.WriteLine("Pase de parametros por out: " + suma(num1,num2) );

            Console.WriteLine("/////"); //Espacio

            //Parametros por in

            Console.WriteLine("Usando in");
            Resta y = new Resta();
            int n = 2;
            n=n-1;
            y.resul(in n);
            Console.WriteLine(n);
		

        }






        
    }
}
}
