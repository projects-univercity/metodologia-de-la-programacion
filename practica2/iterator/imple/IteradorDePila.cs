using System;
using System.Collections.Generic;

namespace Practicas
{
    public class IteradorDePila : Iterador
    {
    	Pila pila;
    	int posicionActual = 0;
        
        
        public IteradorDePila(Pila pila){
    		this.pila = pila;
    		this.Primero();
        }
        
        //public IteradorDePila(List<Comparable> elementos){
    		//this.pila = elementos;
        //}
        
        public object Actual()
        {
            return this.pila.getComparables()[this.posicionActual];
        }

        public bool Fin()
        {
        	return this.posicionActual >= this.pila.cuantos();
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
