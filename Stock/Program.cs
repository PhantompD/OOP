using System;

namespace Stock
{
    
    class Stocks<T>
    {
       
     public T[] elementos;
     readonly int max_size;
     public int apuntador = 0;
    
    
     public Stocks():this(100)
     {
         
     }
    
       public Stocks(int size)
     {
         max_size = size;
         elementos = new T[max_size];
     }

    
     public void Push(T elemento)
     {
         
         if(apuntador >= max_size)
         {
            throw new StackOverflowException();
         }

         else
         {
            elementos[apuntador] = elemento;
            apuntador++;
         }

     }  

     
     public T Pop()
     {
         apuntador--;
        
         if(apuntador >= 0)
         {
           return elementos[apuntador];
         }
         
         else
         {
            apuntador = 0;
            throw new InvalidOperationException("Error");
         }
     }


     /*public T Cola()
     {
         apuntador--;
        
         if(apuntador >= 0)
         {
           return elementos[apuntador];
         }
         
         else
         {
            apuntador = 0;
            throw new InvalidOperationException("Error");
         }
     }

    
    }*/

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Stocks <int> elementos = new Stocks <int> (4); 
            
            elementos.Push(1);
            elementos.Push(4);
            elementos.Push(10);
            elementos.Push(15);
        
            Console.WriteLine("Elementos de la pila");
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());
            
        }
    }
}
