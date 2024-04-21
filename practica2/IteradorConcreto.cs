using System;
using System.Collections.Generic;

namespace Practicas
{
    public class IteradorConcreto : Iterador
    {
    	List<Comparable> list;
    	int posicionActual = 0;
        
        
        public IteradorConcreto(Pila pila){
    		list = pila.getComparables();
        }
        
        public IteradorConcreto(List<Comparable> elementos){
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
