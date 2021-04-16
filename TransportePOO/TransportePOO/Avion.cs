using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    public class Avion : Transporte
    {
        int metrosAltura = rnd.Next(300, 1000); //Se genera un valor aleatorio entre 300 y 1000 para la variable metrosAltura

        public Avion(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Los aviones estan volando a {metrosAltura} metros de altura";
        }
        public override string Detenerse()
        {
            return "Los aviones aterrizan en pista ante cualquier desperfecto";
        }
    }
}
