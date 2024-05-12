using System;

namespace Practicas
{
    public interface Observador {
        
        void actualizar(Observado o); //Se entera del cambio
    }
}