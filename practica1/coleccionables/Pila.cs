using System;
using System.Collections.Generic;

namespace Practicas
{
    
    public class Pila : Coleccionable
    {
        List<Comparable> comparables;
        
        public Pila(){
        	this.comparables = new List<Comparable>();
        }
        
        public List<Comparable> getComparables(){
            return this.comparables;
        }
        
        public void agregar(Comparable comparable)
        {
        	this.apilar(comparable);
        }

        public void apilar(Comparable comparable){
        	this.comparables.Add(comparable);
        }

        public Comparable desapilar(){
        	if(this.comparables.Count == 0){
        		return null;
        	}
        	Comparable comparable = this.comparables[this.comparables.Count -1];
        	this.comparables.RemoveAt(this.comparables.Count -1);
        	return comparable;
        }
        
        

        public bool contiene(Comparable comparable){
            // disable once LocalVariableHidesMember
            foreach (var element in this.comparables){
                if(element.sosIgual(comparable)){
                	return true;
                }
            }
            return false;
        }

        public int cuantos(){
            return this.comparables.Count;
        }

        public Comparable maximo(){
        	if(this.comparables.Count == 0)	return null;
        	
            Comparable maximo = this.comparables[0];
            for (int i = 1; i < this.comparables.Count; i++)
            {
            	if (!maximo.sosMayor(this.comparables[i]))
                    maximo = this.comparables[i];
            }
            return maximo;
        }

        public Comparable minimo()
        {
           if(this.comparables.Count == 0) return null;
           
           Comparable minimo = this.comparables[0];        
            for (int i = 1; i < this.comparables.Count; i++)
            {
            	if (!minimo.sosMenor(this.comparables[i]))
                    minimo = this.comparables[i];
            }
            return minimo;
        }
        
        
		public Iterador CrearIterador()
		{
			return new IteradorDePila(this.comparables);
		}
    }
}
