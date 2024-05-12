using System;

namespace Practicas
{
    public interface Iterador
    {
        void Primero();
        
        void Siguiente();
        
        bool Fin();
        
        object Actual();
    }
}
