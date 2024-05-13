using System;

namespace Practicas
{
    public interface Observado {
        
        void agregarObservador(Observador o);
        
        void quitarObservador(Observador o);

        void notificar(); //Avisa de que algo cambio

    }
}