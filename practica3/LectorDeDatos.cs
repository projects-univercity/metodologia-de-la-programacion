using System;

namespace Practicas
{
	public class LectorDeDatos : Manejador
	{
		
		public LectorDeDatos(){}
		
		public LectorDeDatos(Manejador sucesor) : base (sucesor)
		{
		}
		
		public override int numeroPorTeclado()
    	{
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();
            return int.Parse(entrada);
    	}
		
		public override string stringPorTeclado()
    	{
        	Console.Write("Ingrese cadena: ");
        	return Console.ReadLine();
    	}
	}
}
