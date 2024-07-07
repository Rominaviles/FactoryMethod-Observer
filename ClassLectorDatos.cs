using System;
using System.Collections.Generic;
//Ejercicio 3
namespace ClassLectorDatos
{
    public class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero: ");
            string? num = Console.ReadLine();
            int Esnum;
            while (!int.TryParse(num, out Esnum))
            {
                Console.WriteLine("Vuelva a escribir un numero por favor: ");
                num = Console.ReadLine();
            }
            return Esnum;
        }

        public string StringPorTeclado()
        {
            Console.WriteLine("Ingrese el texto: ");
            return Console.ReadLine() ?? "";
        }

    }
}