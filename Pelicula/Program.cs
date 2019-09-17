using System;
using System.Collections.Generic;

namespace Pelicula{

//Clase Pelicula
class Peli{
private string Titulo;
private Int16 Año;  

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

static void Main(){


    Peli p1 = new Peli();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016); 
    Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());




}








}



}