using System;

namespace Practicas
{
	public class Carta 
	{
		
		private String figura;
		private int numero;
		
		public Carta(String figura, int numero)
		{
			this.figura = figura;
			this.numero = numero;
		}
		
		public String getFigura(){
			return this.figura;
		}
		
		public int getNumero(){
			return this.numero;
		}
	}
}
