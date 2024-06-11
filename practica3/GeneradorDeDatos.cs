using System;
using System.Text;

namespace Practicas
{
	public class GeneradorDeDatos : Manejador
	{
		private static Random generador;
		
		/**************Start SINGLETON************/
		private static GeneradorDeDatos instancia;
		
		//Metodo para devolver una sola instancia
		public static GeneradorDeDatos getInstancia(){
			if(instancia == null)
				instancia = new GeneradorDeDatos();
			return instancia;
		}
		
		//Constructor en privado para no permitir creacion de instancias
		private GeneradorDeDatos()
		{
			generador = new Random();
		}
		/*************End SINGLETON*****************/
		
		public override int numeroAleatorio(int max)
    	{
        	if (max < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que cero.");

        	return generador.Next(0, max);
    	}
		
		public int numeroAleatorio(int min, int max)
    	{
        	if (min < 0)
            	throw new ArgumentException("El valor máximo debe ser mayor que " + min);

        	return generador.Next(min, max+1);
    	}
		
		public override string stringAleatorio(int cant)
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
