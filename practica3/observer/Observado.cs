using System;

namespace Practicas
{
    public interface Observado {
        
        void agregarObservador(Observador o);
        
        void quitarObservador(Observador o);

        void notificar(String accion); //Avisa de que algo cambio

    }
}