using System;
using System.Collections.Generic;

namespace Pelicula{

//Clase Pelicula
class Peli{
private string Titulo;
private int Año;  
//private string pais;
//private string director;

//Constructor #1
Peli(){}

//Constructor #2
public Peli(string T, int A)
{
  this.Titulo=T;
  this.Año=A;
}

public void SetTitulo(string titulo)
{
       this.Titulo=titulo;
}

public void SetAño(Int16 año)
{
       this.Año=año;
}

public string GetTitulo()
{
       return this.Titulo;
}

public int GetAño()
{
       return this.Año;
}

public void Imprime()
{
 //Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

}

static void Main(){


    Peli p1 = new Peli();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016); 
    p1.Imprime();
   




}









}



}