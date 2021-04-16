using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePOO
{
    public class Automovil : Transporte
    {
        int kmHora = rnd.Next(60, 120); //Se genera un valor aleatorio entre 60 y 120 para la variable kmHora
        public Automovil (int pasajeros) : base(pasajeros) 
        {

        }
        public override string Avanzar()
        {
            return $"Los autos estan viajando a {kmHora} km/h";
        }

        public override string Detenerse()
        {
            return "Los autos se detienen ante cualquier desperfecto";
        }
    }
}
