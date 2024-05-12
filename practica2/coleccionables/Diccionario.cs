
using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Diccionario : Coleccionable
	{
		List<ClaveValor> clavesValores;
		
		public Diccionario()
		{
			this.clavesValores = new List<ClaveValor>();
		}

		/**Agrega la asociación clave-valor al diccionario si es
		   que la clave no existe en el diccionario. 
		   Si la clave existe, entonces reemplaza el valor asociado.
		 */
		public void agregar(Numero claveIn, Comparable valorIn){
			if(!this.contiene(claveIn))
			{
				ClaveValor inClaveValor = new ClaveValor(claveIn, valorIn);
				clavesValores.Add(inClaveValor);
				return;
			}
			foreach (ClaveValor claveValor in this.clavesValores) 
			{
				if(claveValor.getClave().sosIgual(claveIn))
				{
					claveValor.setValor(valorIn);
				}
			}
			
		}

		//Devuelve el valor asociada a la clave recibida por parámetro o null si la clave no existe
		public Comparable valorDe(Numero valor){
			foreach(Comparable elem in this.clavesValores){
				if(elem.sosIgual(valor))
					return elem;
			}
			return null;
		}
		
		#region Coleccionable implementation
		public int cuantos()
		{
			return this.clavesValores.Count;
		}
		
		public Comparable minimo()
		{
			Comparable numeroMin = null;
			if(this.clavesValores.Count == 0)
				return numeroMin;
			numeroMin = this.clavesValores[0].getValor();;
			for (int i = 1; i < this.clavesValores.Count; i++) {
				if(this.clavesValores[i].getValor().sosMenor(numeroMin))
					numeroMin = this.clavesValores[i].getValor();
			}
			return numeroMin;
		}
		
		public Comparable maximo()
		{
			Comparable numeroMin = null;
			if(this.clavesValores.Count == 0)
				return numeroMin;
			numeroMin = this.clavesValores[0].getValor();;
			for (int i = 1; i < this.clavesValores.Count; i++) {
				if(this.clavesValores[i].getValor().sosMayor(numeroMin))
					numeroMin = this.clavesValores[i].getValor();
			}
			return numeroMin;
		}
		
		/**
		 Agrega una clave por default, y el comparable recibido por parametro al Diccionario
		 */
		public void agregar(Comparable comparable)
		{
			if(this.clavesValores.Count == 0){
				this.agregar(new Numero(000), comparable);
				return;
			}
			Numero valor = this.clavesValores[this.clavesValores.Count-1].getClave();
			int nuevoValor = valor.getValor() + 1;
			this.agregar(new Numero(nuevoValor), comparable);
		}
		
		public bool contiene(Comparable comparable)
		{
			foreach(ClaveValor elem in this.clavesValores){
				if(elem.getValor().sosIgual(comparable))
					return true;
			}
			return false;
		}
		#endregion

		public Iterador CrearIterador()
		{
			return new IteradorDiccionario(this.clavesValores);
		}
	}
}
