
using System;

namespace Practicas
{

    public class Numero: Comparable
    {
        private int valor;

        public Numero()
        {
        }
        
        public Numero(int valor) {
            this.valor = valor;
        }

        // disable once ConvertToAutoProperty
        public int getValor() {
            return this.valor;
        }
        public void setValor(int valor){
        	this.valor = valor;
        }

        public bool sosIgual(Comparable comparable)
        {
        	return this.valor == ((Numero)comparable).getValor();
        }

        public bool sosMayor(Comparable comparable)
        {
            return this.valor < ((Numero)comparable).getValor();
        }

        public bool sosMenor(Comparable comparable)
        {
            return this.valor > ((Numero)comparable).getValor();
        }
        
        
    }
}