using System;
using System.Collections.Generic;

namespace Practicas
{
	public class IteradorDiccionario : Iterador
	{
		
		Diccionario diccionario;
    	int posicionActual = 0;

		public IteradorDiccionario(Diccionario diccionario)
		{
    		this.diccionario = diccionario;
		}
	
        public object Actual()
        {
        	return diccionario.getClaveValores()[posicionActual];
        }

        public bool Fin()
        {
        	return this.posicionActual >= this.diccionario.cuantos();
        }

        public void Primero()
        {
            this.posicionActual = 0;
        }

        public void Siguiente()
        {
            this.posicionActual++;
        }
	}
}
