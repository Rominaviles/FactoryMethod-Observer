using System;
using System.Collections.Generic;
using Interfaces;
using Classpersona;
using ClasesMet;
using strategy;
using Interfaces3;
using ClassProfesor;

namespace Classalumno
{//Actividad 1, ejercicio 15
    public class Alumno : Persona, Observador 
    {
        private int legajo;
        private int promedio;
//Agregacion Strategy
        private EstrategiaComparacion estrategia;

        public Alumno(string n, int d, int l, int p) : base (n, d)
        {
//Estrategia por defecto
            estrategia= new EstrategiaPorDni();
            this.legajo=l;
            this.promedio=p;
        }
//Estrategia setter
        public void setEstrategia(EstrategiaComparacion c)
        {
            estrategia = c;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        public override string ToString()
        {
            return "Nombre: "+ getNombre() + ", Dni: " + getDNI() + ", Legajo: " + getLegajo() + ", Promedio: " + getPromedio();
        }

        //EJERCICIO 18 (Implementacion de la interface comparable)
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, ((Alumno)c)); 
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, ((Alumno)c));
        }

        public override bool SosMayor(Comparable c)
        {
            return estrategia.SosMayor(this, ((Alumno)c));
        }

        //Ejercicio 11, Actividad 3

        public void PrestarAtencion()
        {
            Console.WriteLine("Prestando Atencion.");
        }

        public void Distraerse()
        {
            Random rdm = new Random();
            int opc = rdm.Next(3);
            switch (opc)
            {
                case 1 : Console.WriteLine("Mirando el celular.."); break;
                case 2 : Console.WriteLine("Dibujando en el margen de la carpeta.."); break;
                case 3 : Console.WriteLine("Tirando aviones de papel.."); break;
            }
        }

            //Metodos Observador
        public void Actualizar(Observado o)
        {
            
            if(o.isEstaHablando() == true)
            {
                this.PrestarAtencion();
            }
            else
            {
                this.Distraerse();
            
            }
        }
        

    }
}

