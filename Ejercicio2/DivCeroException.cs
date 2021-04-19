using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class DivCeroException
    {
        public static void DivisionPorCero(int i, int j)
        {
            try
            {
                int resultado = i / j;
                Console.WriteLine($"El resultado es {resultado}");

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("Solo Chuck Norris puede dividir por cero!");
            }
        }
    }
}
