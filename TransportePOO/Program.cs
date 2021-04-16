using System;
using System.Collections.Generic;

namespace TransportePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use un null dentro de ambas listas para que el muestreo comience desde el index 1 y no el 0
            List<Transporte> automoviles = new List<Transporte> 
            {   
                null,
                new Automovil(1),
                new Automovil(3),
                new Automovil(4),
                new Automovil(2),
                new Automovil(1)
            };

            List<Transporte> aviones = new List<Transporte>
            {   
                null,
                new Avion(200),
                new Avion(150),
                new Avion(50),
                new Avion(90),
                new Avion(120)
            };

            for (int i = 1; i < automoviles.Count; i++)
            {
                Console.WriteLine($"Automovil {i} : {automoviles[i].getPasajeros()} pasajeros");

                //Cuando llega al ultimo item de la lista es decir la longitud menos 1, llama al metodo Avanzar y al Detenerse
                if (i == automoviles.Count - 1)
                {
                    Console.WriteLine($"\n{automoviles[i].Avanzar()} \n");
                    Console.WriteLine($"{automoviles[i].Detenerse()} \n");
                }
            }

            for (int i = 1; i < aviones.Count; i++)
            {
                Console.WriteLine($"Avion {i} : {aviones[i].getPasajeros()} pasajeros");

                if (i == aviones.Count - 1)
                {
                    Console.WriteLine($"\n{aviones[i].Avanzar()} \n");
                    Console.WriteLine($"{aviones[i].Detenerse()} \n");
                }
            }
            Console.ReadKey();
        }
    }
}
