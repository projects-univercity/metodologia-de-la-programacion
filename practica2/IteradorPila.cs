using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1;

namespace Praticas
{
    public class IteradorPila : Iterador
    {
    	List<Comparable> lista;
    	int posicionActual = 0;
        
        
        public IteradorPila(Pila pila){
    		lista = pila.getComparables();
        }
        
        public IteradorPila(/*List<Comparable> elementos*/){
        	
        }
        
        public object Actual()
        {
            return lista[posicionActual];
        }

        public bool Fin()
        {
            return posicionActual >= lista.Count;
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
