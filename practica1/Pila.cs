using System;
using System.Collections.Generic;

namespace Practicas
{
    
    public class Pila : Coleccionable
    {
        List<Comparable> comparables = new List<Comparable>();
        
        public Pila(){
        }
        
        public List<Comparable> getComparables(){
            return this.comparables;
        }
        
        public void agregar(Comparable comparable)
        {
            this.comparables.Add(comparable);
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
            // disable once LocalVariableHidesMember
            Comparable maximo = null;
            if (this.comparables.Count > 0)
                maximo = this.comparables[0];
          
            for (int i = 1; i < this.comparables.Count; i++)
            {
                if (this.comparables[i].sosMayor(maximo))
                    maximo = this.comparables[i];
            }
            return maximo;
        }

        public Comparable minimo()
        {
            // disable once LocalVariableHidesMember
            Comparable minimo = null;
            if (this.comparables.Count > 0)
                minimo = this.comparables[0];
            
            for (int i = 1; i < this.comparables.Count; i++)
            {
                if (this.comparables[i].sosMenor(minimo))
                    minimo = this.comparables[i];
            }
            return minimo;
        }
        
        
		public Iterador CrearIterador()
		{
			return new IteradorConcreto(this.comparables);
		}
    }
}
