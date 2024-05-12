using System;
using System.Collections.Generic;

namespace Practicas
{
	public class IteradorDiccionario : Iterador
	{
		
		List<ClaveValor> list;
    	int posicionActual = 0;

		public IteradorDiccionario(List<ClaveValor> list)
		{
    		this.list = list;
		}
	
        public object Actual()
        {
            return list[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual >= this.list.Count;
        }

        public void Primero()
        {
            posicionActual = 0;
        }

        public void Siguiente()
        {
            posicionActual++;
        }
	}
}
