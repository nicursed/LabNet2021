using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    public abstract class Transporte
    {
        public static Random rnd = new Random();

        private int pasajeros;

        public Transporte (int pasajeros) 
        {
            this.pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public int getPasajeros()
        {
            return pasajeros;
        }

    }

       
} 
