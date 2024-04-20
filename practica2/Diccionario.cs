
using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Diccionario: Coleccionable
	{
		List<KeyValuePair<object, Comparable>> elementos = new List<KeyValuePair<object, Comparable>>();
		
		public Diccionario()
		{
		}

		#region Coleccionable implementation

		public int cuantos()
		{
			throw new NotImplementedException();
		}

		public Comparable minimo()
		{
			throw new NotImplementedException();
		}

		public Comparable maximo()
		{
			throw new NotImplementedException();
		}

		public void agregar(Comparable comparable)
		{
			elementos.Add(new KeyValuePair<object, Comparable>(elementos.Count, comparable));
		}

		public bool contiene(Comparable comparable)
		{
			foreach ( KeyValuePair<object, Comparable> elemento in elementos) {
				if(elemento.Value.sosIgual(comparable))
					return true;
			}
			return false;
		}

		#endregion
	}
}
