using System;
using System.Text;

namespace Practicas
{
	public class GeneradorDeDatos
	{
		private static Random generador = new Random();
		
		public GeneradorDeDatos()
		{
		}
		
		public static int numeroAleatorio(int max)
    	{
        	if (max < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que cero.");

        	return generador.Next(0, max);
    	}
		
		public static int numeroAleatorio(int min, int max)
    	{
        	if (min < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que " + min);

        	return generador.Next(min, max+1);
    	}
		
		public static string stringAleatorio(int cant)
    	{
        	if (cant <= 0)
            	throw new ArgumentException("La cantidad de caracteres debe ser mayor que cero.");

        	const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        	StringBuilder resultado = new StringBuilder(cant);

        	for (int i = 0; i < cant; i++)
        	{
            	int indiceAleatorio = generador.Next(0, caracteres.Length);
            	resultado.Append(caracteres[indiceAleatorio]);
        	}

        	return resultado.ToString();
    	}
	}
}
