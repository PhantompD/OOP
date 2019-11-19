using System;

namespace Stock
{
    
    class Stock<T>
    {
       
     public T[] elementos;
     readonly int max_size;
     public int apuntador = 0;
    
    
     public Stock():this(100)
     {
         
     }
    
       public Stock(int size)
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
           return elementos[apuntador_pila];
         }
         
         else
         {
            apuntador = 0;
            throw new InvalidOperationException("Error");
         }
     }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
