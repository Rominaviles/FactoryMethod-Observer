using System;
using System.Collections.Generic;
using Interfaces;
//Ejercicio 4
namespace Interfaces3
{
    public interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
    }
}