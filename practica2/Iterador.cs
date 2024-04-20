using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2.PIterator
{
 // IEnumerator
    public interface Iterador
    {
        void Primero();
        
        void Siguiente();
        
        bool Fin();
        
        object Actual();
    }
}
