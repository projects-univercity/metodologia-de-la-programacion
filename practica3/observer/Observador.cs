using System;

namespace Practicas
{
    public interface Observador {
        
        void actualizar(String accion); //Se entera del cambio
    }
}