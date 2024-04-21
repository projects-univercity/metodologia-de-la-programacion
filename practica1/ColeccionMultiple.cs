using System;

namespace Practicas
{
	
	public class ColeccionMultiple : Coleccionable
	{
		// disable once FieldCanBeMadeReadOnly.Local
		Coleccionable pila;
		Coleccionable cola;
		
		
		public ColeccionMultiple(Coleccionable pila, Coleccionable cola){
			this.pila = pila;
			this.cola = cola;
		}
		
		public Coleccionable Pila {
			get{return this.pila;}
		}

		public Coleccionable Cola {
			get {return this.cola;}
		}

		#region Coleccionable implementation

		public int cuantos()
		{
			return this.pila.cuantos() + this.pila.cuantos();
		}

		public Comparable minimo()
		{
			Comparable comparable;
			if(((Numero)pila.minimo()).getValor() < ((Numero)cola.minimo()).getValor()){
				comparable = pila.minimo();
			}
			else{
				comparable = cola.minimo();
			}
			return comparable;
		}

		public Comparable maximo()
		{
			Comparable comparable;
			if(((Numero)pila.maximo()).getValor() > ((Numero)cola.maximo()).getValor()){
				comparable = pila.maximo();
			}
			else{
				comparable = cola.maximo();
			}
			return comparable;
		}

		public void agregar(Comparable comparable)
		{
			throw new NotImplementedException();
		}

		public bool contiene(Comparable comparable)
		{
			return pila.contiene(comparable) || cola.contiene(comparable);
		}

		#endregion
		
		
		public Iterador CrearIterador()
		{
			throw new NotImplementedException();
		}
	}
}
