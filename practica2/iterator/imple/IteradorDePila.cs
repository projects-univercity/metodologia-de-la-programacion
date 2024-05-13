using System;
using System.Collections.Generic;

namespace Practicas
{
    public class IteradorDePila : Iterador
    {
    	List<Comparable> list;
    	int posicionActual = 0;
        
        
        public IteradorDePila(Pila pila){
    		list = pila.getComparables();
        }
        
        public IteradorDePila(List<Comparable> elementos){
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
