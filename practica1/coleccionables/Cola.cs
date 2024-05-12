
using System;
using System.Collections.Generic;

namespace Practicas
{

	class Cola : Coleccionable
    {
		List<Comparable>comparables = new List<Comparable>();
        
        public Cola(){
        }
        
		public List<Comparable> getComparables(){
            return this.comparables;
        }
        
        public int cuantos() {
            return this.comparables.Count;
        }
        
        public void agregar(Comparable comparable) {
            this.encolar(comparable);
        }

		public void encolar(Comparable comparable){
			this.comparables.Add(comparable);
		}

		public Comparable desencolar(){
			if(this.comparables.Count == 0)
				return null;
			Comparable comparable = this.comparables[0];
			comparables.RemoveAt(0);
			return comparable;
		}

        public bool contiene(Comparable comparable)
        {
            // disable once LocalVariableHidesMember
            bool contiene = false;
            foreach (var element in this.comparables)
            {
                if(element.sosIgual(comparable))
                {
                    contiene = true;
                    break;
                }
            }
            return contiene;
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
			return new IteradorConcreto(this.comparables);
		}
    }
}
