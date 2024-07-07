using System;
using System.Collections.Generic;
using Classpersona;
using Interfaces3;
//Ejercicio 8
namespace ClassProfesor
{
    public class Profesor: Persona, Observado
    {
        private int antiguedad;
        private List <Observador> observadores = new List <Observador>();  

        private bool estaHablando;

        public Profesor(string n, int d, int a, bool estaHablando) : base (n,d)
        {
            this.estaHablando= estaHablando; 
            this.antiguedad = a;
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }
        public override string ToString()
        {
            return "Nombre: "+ getNombre() + ", Dni: " + getDNI() + ", antiguedad: " + getAntiguedad();
        }

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando algun tema.");
            this.estaHablando=true;
            this.notificar();
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron.");
            this.estaHablando=false;
            this.notificar();
        }

        public bool isEstaHablando() 
        {
            return this.estaHablando;
        }

        //Metodos de interface Observado

        public void AgregarObservador(Observador o)
        {
            this.observadores.Add(o);
        }
        public void QuitarObservador (Observador o)
        {
            this.observadores.Remove(o);
        }
        public void notificar()
        {
            foreach (Observador o in observadores)
            {
                o.Actualizar(this);
            }
        }

    }
}