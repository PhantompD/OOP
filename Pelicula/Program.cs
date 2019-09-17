using System;
using System.Collections.Generic;

namespace Pelicula{

//Clase Pelicula
class Peli{
private string Titulo;
private int Año;  
//private string pais;
//private string director;

 private List<Actor> actores = new List<Actor>();


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

public void AgregarActor(Actor actor)
        {
            actores.Add(actor);
        }

        public void imprime() 
        {
			Console.WriteLine("actores de pelicula {0}. {1} ", Titulo, Año);
            foreach(Actor a in actores)
            {
                Console.WriteLine("{0}, {1}", a.nombre, a.año);
            }
		}

static void Main(){

Peli p1 = new Peli("Spiderman", 2012);
			p1.AgregarActor(new Actor("Andrew Garfield", 1983));
			p1.AgregarActor(new Actor("Emma Stone", 1988));

			p1.imprime();

    /* Peli p1 = new Peli();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016); 
    p1.Imprime();*/

/*List<Peli> peliculas = new List<Peli>();
			peliculas.Add(new Peli("Birdman", 2018));
            peliculas.Add(new Peli("Shrek", 2002));
            peliculas.Add(new Peli("Avengers", 2012));
            peliculas.Add(new Peli("Toy Story", 2019));
            peliculas.Add(new Peli("Bohemian Rhapsody", 2018));
            foreach(Peli p in peliculas)
            {
               Console.WriteLine(p);           
            }*/



}









}

class Actor
    {
        public string nombre;
        public Int16 año;
        public Actor(String nombre, Int16 año)
        {
            this.nombre = nombre;
            this.año = año;
        }
    }


}