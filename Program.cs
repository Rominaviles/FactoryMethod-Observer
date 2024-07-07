using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using strategy;
using Interfaces;
using Classpersona;
using Classcola;
using Classpila;
using Classalumno;
using Classnumero;
using Interfaces2;
using Microsoft.VisualBasic;
using ClassFabricaComparable;
using Interfaces3;
using ClassFabricaAlumnos;
using ClassFabricaNumeros;
using ClassProfesor;


namespace ClasesMet
{
    class Program
//CLASE1
    {
        //Definicion de constantes y variables
        private static Random rdm = new Random();
        private const int RangoMin= 1;
        private const int RangoMax = 50;
        private const int DNImin= 10000;
        private const int DNImax= 99999;
        private const int LegajoMin= 100;
        private const int LegajoMax= 10000;
        private const int PromedioMin= 1;
        private const int PromedioMax= 10;

        //EJERCICIO 6, MODIFICAR LLENAR E INFORMAR
        public static void llenar (Coleccionable c, int opcion)
        {
            int cont = 0;
            while (cont<20)
            {
                Comparable comparable = FabricaComparables.crearAleatorio(opcion);
                c.agregar(comparable);
                cont++;
                Console.WriteLine("Elemento agregado, n°" + cont);
            }
            
        }

        
        public static void informar(Coleccionable c, int opcion) 
        {
            Console.WriteLine("La cantidad de elementos  que contiene son: " + "\n" + c.cuantos());
            Console.WriteLine("El elemento minimo es: " +"\n" + c.minimo());
            Console.WriteLine("El elemento maximo es: " + "\n" + c.maximo());
            Console.WriteLine("Ingrese el siguiente dato para verificar su existencia: ");

            Comparable comp= FabricaComparables.crearPorTeclado(opcion);

            if (c.contiene (comp))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El elemento leido no esta en la coleccion");
            }


        }


        //Funcion adicional para generar nombre aleatorio
        public static string NombreAleatorio()
        {
            List<string> nombre= new List<string>{
                "Tomas","Ramon","Felipe","Julian","Benjamin","Sam","Sarah","Jazmin","Tamara","Melody","Joel",
                "Gerardo", "Alex", "Brian", "Mariano", "Ezequiel","Anahi","Martina","Melina","Lucas","Geremias",
                "Maria","Daiana","Nancy"
                };
            return nombre[rdm.Next(nombre.Count)];
        }



//Clase 3
        //Ejercicio 13
        public static void DictadoDeClases(Profesor p)
        {
            int cont=0;
            while(cont<=5)
            {
                p.hablarALaClase();
                p.escribirEnElPizarron();
                cont++;
                
            }
        }

        
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola= new Cola();

            Console.WriteLine("Números:");
            llenar(pila, 1);
            Console.WriteLine("Informacion sobre la pila de numeros");
            informar(pila, 1);
    
            Console.WriteLine("Alumnos:");
            llenar(cola, 2);
            Console.WriteLine("Informacion sobre la cola de alumnos");
            informar(cola, 2);
            

            /*List<Alumno> alumnos = new List<Alumno>();
            Profesor profe = new Profesor("Ramon", 35678343, 10,true);
            Console.WriteLine("Alumnos:");

            int cont=0;
            while (cont<20)
            {
                string nombre = NombreAleatorio();
                int dni = rdm.Next(DNImin, DNImax);
                int legajo = rdm.Next(LegajoMin, LegajoMax);
                int promedio = rdm.Next(PromedioMin, PromedioMax);
                Alumno alumno= new Alumno(nombre, dni, legajo, promedio);
                Console.WriteLine("Alumno n°" + cont + " agregado: " + "\n" + alumno);
                profe.AgregarObservador(alumno);
                alumnos.Add(alumno);
                cont++;
            } 
            
            DictadoDeClases(profe);
*/

        }
    }


}