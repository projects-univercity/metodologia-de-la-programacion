using System;

namespace Practicas
{
	
	public class IteradorDeCola
	{
    	List<Comparable> list;
    	int posicionActual = 0;
        
        
        public IteradorDeCola(Cola pila){
    		list = pila.getComparables();
        }
        
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
