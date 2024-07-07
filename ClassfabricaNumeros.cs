using System;
using System.Collections.Generic;
using ClassFabricaComparable;
using Classnumero;
using Interfaces;
using ClassGeneradorDatosRandom;
using ClassLectorDatos;


namespace ClassFabricaNumeros
{
    public class FabricaDeNumeros : FabricaComparables
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaDeNumeros()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }


        public override Comparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatorio(1000000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(lector.NumeroPorTeclado());
        }
    }
}