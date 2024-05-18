using System;
using System.Collections.Generic;

namespace Practicas
{
	public class IteradorDeCola: Iterador
    {
    	Cola cola;
    	int posicionActual = 0;
        
        
        public IteradorDeCola(Cola cola){
    		this.cola = cola;
    		this.Primero();
        }
        
        //public IteradorDeCola(List<Comparable> elementos){
    	//	this.list = elementos;
        //}
        
        public object Actual()
        {
        	return this.cola.getComparables()[this.posicionActual];
        }

        public bool Fin()
        {
        	return this.posicionActual >= this.cola.cuantos();
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
