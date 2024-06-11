using System;

namespace Practicas
{
	public abstract class Manejador
	{
		//paso 1
		private Manejador sucesor = null;
		
		public Manejador(){}
		
		public Manejador(Manejador manejador)
		{
			this.sucesor = manejador;
			
		}
		
		//paso 2 implemento la interfaz de todos los manejadores
		
		public virtual int numeroAleatorio(int max){
			if(this.sucesor != null)
				return this.sucesor.numeroAleatorio(max);
			return 0;
		}
		
		public virtual string stringAleatorio(int cant){
			if(this.sucesor != null)
				return this.sucesor.stringAleatorio(cant);
			return "";
		}
		
		public virtual int numeroPorTeclado()
    	{
			if(this.sucesor != null)
				return this.sucesor.numeroPorTeclado();
			return 0;
    	}
		
		public virtual string stringPorTeclado()
    	{
			if(this.sucesor != null)
				return this.sucesor.stringPorTeclado();
			return "";
    	}
		
		public virtual double numeroDesdeArchivo(double max){
			if(this.sucesor != null)
				this.sucesor.numeroDesdeArchivo(max);
			return 0.0;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			if(this.sucesor != null)
				this.sucesor.stringDesdeArchivo(cant);
			return "";
		}
	}
}
