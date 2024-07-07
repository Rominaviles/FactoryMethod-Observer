using System;
using System.Collections.Generic; 

namespace Interfaces3
{
    public interface Observado
    {
        void AgregarObservador(Observador o);
        void QuitarObservador (Observador o);
        void notificar();
        bool isEstaHablando();
    }
}