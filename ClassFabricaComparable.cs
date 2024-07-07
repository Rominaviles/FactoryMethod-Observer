using System;
using System.Collections.Generic;
using ClassFabricaAlumnos;
using ClassFabricaNumeros;
using Interfaces;
using Interfaces3;


namespace ClassFabricaComparable
{
    public abstract class FabricaComparables: FabricaDeComparables
    {
        public static Comparable crearAleatorio(int xopc)
        {
            FabricaComparables? fabrica = null;
            switch (xopc)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica =new FabricaDeAlumnos(); break;
            }
               
            if (fabrica != null)
            {
                return fabrica.crearAleatorio();
            }
            else
            {
                throw new InvalidOperationException("No se pudo crear la fábrica.");
            }
        }
        public abstract Comparable crearAleatorio();

        public static Comparable crearPorTeclado(int xopc)
        {
            FabricaComparables? fabrica = null;
            switch (xopc)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica =new FabricaDeAlumnos(); break;
            }
               
            if (fabrica != null)
            {
                return fabrica.crearPorTeclado();
            }
            else
            {
                throw new InvalidOperationException("No se pudo crear la fábrica.");
            }
        }
        public abstract Comparable crearPorTeclado();


    }
}