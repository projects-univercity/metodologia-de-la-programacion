using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Conjunto : Coleccionable
	{
		List<Comparable> comparables;
		
		public Conjunto()
		{
			this.comparables = new List<Comparable>();
		}
		
		public List<Comparable> getListClaveValor(){
			return this.comparables;
		}
		
		public bool pertenece(Comparable comparable){
			foreach(Comparable elem in this.comparables){
				if(elem.sosIgual(comparable))
					return true;
			}
			return false;
		}
		
		#region Coleccionable implementation
		
		public int cuantos()
		{
			return this.comparables.Count;
		}
		
		public Comparable minimo()
		{
			Comparable numeroMin = null;
			if(comparables.Count == 0)
				return numeroMin;
			numeroMin = this.comparables[0];
			for (int i = 1; i < this.comparables.Count; i++) {
				if(comparables[i].sosMenor(numeroMin))
					numeroMin = comparables[i];
			}
			return numeroMin;
		}
		
		public Comparable maximo()
		{
			Comparable numeroMax = null;
			if(comparables.Count == 0)
				return numeroMax;
			numeroMax = comparables[0];
			for (int i = 1; i < this.comparables.Count; i++) {
				if(comparables[i].sosMayor(numeroMax))
					numeroMax = comparables[i];
			}
			return numeroMax;
		}
		
		public void agregar(Comparable comparable)
		{
			if(!this.pertenece(comparable)){
				this.comparables.Add(comparable);
			}
		}
		
		public bool contiene(Comparable comparable)
		{
			return this.pertenece(comparable);
		}
		#endregion

		#region Iterable implementation
		public Iterador CrearIterador()
		{
			throw new NotImplementedException();
		}
		#endregion
		
	}
}
