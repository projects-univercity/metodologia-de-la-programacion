using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Conjunto
	{
		
		List<ClaveValor>elementos;
		
		public Conjunto()
		{
			this.elementos = new List<ClaveValor>();
		}
		
		public void agregar(ClaveValor claveValor){
			this.elementos.Add(claveValor);
		}
		
		public bool pertenece(Comparable coparable){
			return false;//*TODO*/
		}
		
	}
}
