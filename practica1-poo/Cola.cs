
using System;
using System.Collections.Generic;

namespace Practicas
{

	public class Cola: Coleccionable
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
            this.comparables.Add(comparable);
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
        
        
        
        public Comparable minimo()
        {
            // disable once LocalVariableHidesMember
            Comparable minimo = null;
            if (comparables.Count > 0)
                minimo = this.comparables[0];
            //foreach (Comparable comparable in elementos)
            //{
            //    if (maximo.SosMayor(comparable))
            //        maximo = comparable;
            //}
            for (int i = 0; i < this.comparables.Count; i++)
            {
                if (minimo.sosMenor(comparables[i]))
                    minimo = this.comparables[i];
            }
            return minimo;
        }
        
        public Comparable maximo()
        {
            // disable once LocalVariableHidesMember
            Comparable maximo = null;
            if (comparables.Count > 0)
                maximo = comparables[0];
            //foreach (Comparable comparable in elementos)
            //{
            //    if (maximo.SosMayor(comparable))
            //        maximo = comparable;
            //}
            for (int i = 0; i < comparables.Count; i++)
            {
                if (maximo.sosMayor(comparables[i]))
                    maximo = comparables[i];
            }
            return maximo;
        }
        

        

        

        
    }
}
