using System;
using System.Collections.Generic;
using Classalumno;
using ClassFabricaComparable;
using Interfaces;
using ClassLectorDatos;
using ClassGeneradorDatosRandom;


namespace ClassFabricaAlumnos
{
    public class FabricaDeAlumnos: FabricaComparables
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaDeAlumnos()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }
        public override Comparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(5);
            int dni = generador.numeroAleatorio(99999999);
            int legajo = generador.numeroAleatorio(10000);
            int promedio = generador.numeroAleatorio(10);  

            return new Alumno(nombre, dni, legajo,promedio);
    
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Para nombre:");
            string nombre = lector.StringPorTeclado();
            Console.WriteLine("Para dni:");
            int dni = lector.NumeroPorTeclado();
            Console.WriteLine("Para legajo:");
            int legajo = lector.NumeroPorTeclado();
            Console.WriteLine("Para promedio:");
            int promedio = lector.NumeroPorTeclado();
            
            return new Alumno(nombre, dni, legajo,promedio);
        }
    }
}