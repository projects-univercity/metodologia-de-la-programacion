using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class IteradorDeCola : Iterador
	{
    	List<Comparable> list;
    	int posicionActual = 0;
        
        
    	//public IteradorDeCola(Cola cola){
    		//list = cola.getComparables();
    	//}
    	
        public IteradorDeCola(List<Comparable> elementos){
    		this.list = elementos;
        }
        
        public object Actual()
        {
            return list[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual >= list.Count;
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
