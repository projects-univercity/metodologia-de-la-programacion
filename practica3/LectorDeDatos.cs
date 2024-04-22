using System;

namespace Practicas
{
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public static int numeroPorTeclado()
    	{
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();
            return int.Parse(entrada);
    	}
		
		public static string stringPorTeclado()
    	{
        	Console.Write("Ingrese cadena: ");
        	return Console.ReadLine();
    	}
	}
}
