using System;
using System.Collections.Generic;
//Ejercicio 2
namespace ClassGeneradorDatosRandom
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random;

        public GeneradorDeDatosAleatorios()
        {
            random = new Random();
        }

        public int numeroAleatorio(int max)
        {
            return random.Next(max+1);
        }

        public string stringAleatorio(int cant)
        {
            cant=5;
            const string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] Aleatorio= new char[cant];

            for (int i = 0; i < cant; i++)
            {
                Aleatorio[i] = str[random.Next(str.Length)];
            }
            return new string(Aleatorio);
        }

    }
}