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
			if(pila.minimo().sosMenor(cola.minimo())){
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
			if(pila.maximo().sosMayor(cola.maximo())){
				comparable = pila.maximo();
			}
			else{
				comparable = cola.maximo();
			}
			return comparable;
		}

		public void agregar(Comparable comparable)
		{
			this.pila.agregar(comparable);
			this.cola.agregar(comparable);
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
