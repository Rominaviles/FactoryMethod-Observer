using System;
using System.Collections.Generic;
using Interfaces;

//Para hacer iterator hay que implementar 2 interfaces, iterable e iterador
namespace Interfaces2
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        Boolean fin();
        Comparable actual();
    }

}