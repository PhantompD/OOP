using System;

namespace Anon
{
    class Duplicador
    {
	public void duplica(int n) 
    { 
			n = n*2;
	}
    
    }
    class Persona
    {
	    public string nombre;
	    public string apellido;


	    public Persona() {
		nombre = "Rogers";
		apellido = "Rabbit";
	    }
    }

    class Anonymous
    {
	    static public void anonimo(Persona p) { 
			p.nombre = "xxxxxxxxx";
			p.apellido = "xxxxxxxxx";
	    }
        static void Main(){
		Persona Anon = new Persona();

		Console.WriteLine(Anon.nombre);
		anonimo(Anon);
		Console.WriteLine(Anon.nombre);
	    }
    }

    class Program
    {
        static void Main()
	    {
		Duplicador d = new Duplicador();
		int x = 2;
		d.duplica(x);
		Console.WriteLine(x);
		d.duplica_ref(x);
		Console.WriteLine(x);
	    }
    }
}