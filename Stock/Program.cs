using System;
using System.Collections;

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

     }

    
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

            //Cola

            string Nombre;
         
            Queue Cola =new Queue();

            Cola.Enqueue("Carlos  \n");
            Cola.Enqueue("Raul  \n");
            Cola.Enqueue("Daniel  \n");
            Cola.Enqueue("Fer");

            Console.WriteLine("/////////////////");
            Console.WriteLine("Elementos de la Cola");
            
            for(int i=0;i<4;i++)
            {
        
         Nombre=(string) Cola.Dequeue();
         
         Console.Write(Nombre);
        
         
            }



            
        }
    }
}
