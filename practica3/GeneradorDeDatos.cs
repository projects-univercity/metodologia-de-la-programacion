using System;
using System.Text;

namespace Practicas
{
	public class GeneradorDeDatos : Manejador
	{
		/**************Start SINGLETON************/
		private static Random generador = null;
		
		public GeneradorDeDatos(){}
		
		public GeneradorDeDatos(Manejador manejador) : base (manejador){}
		
		private Random getInstancia()
		{
			if(generador == null){
				generador = new Random();
			}
			return generador;
		}
		/*************End SINGLETON*****************/
		
		public override int numeroAleatorio(int max)
    	{
        	if (max < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que cero.");

        	return getInstancia().Next(0, max);
    	}
		
		public int numeroAleatorio(int min, int max)
    	{
        	if (min < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que " + min);

        	return getInstancia().Next(min, max+1);
    	}
		
		public override string stringAleatorio(int cant)
    	{
        	if (cant <= 0)
            	throw new ArgumentException("La cantidad de caracteres debe ser mayor que cero.");

        	const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        	StringBuilder resultado = new StringBuilder(cant);

        	for (int i = 0; i < cant; i++)
        	{
            	int indiceAleatorio = getInstancia().Next(0, caracteres.Length);
            	resultado.Append(caracteres[indiceAleatorio]);
        	}

        	return resultado.ToString();
    	}
	}
}
