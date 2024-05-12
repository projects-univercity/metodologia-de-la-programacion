using System;

namespace Practicas
{
    
	public interface Coleccionable : Iterable
    {
        int cuantos();
        
        Comparable minimo();
        
        Comparable maximo();
        
        void agregar(Comparable comparable);
        
        bool contiene(Comparable comparable);
        
    }
}
