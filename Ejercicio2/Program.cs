using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el primer numero: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                int j = Convert.ToInt32(Console.ReadLine());

                DivCeroException.DivisionPorCero(i, j);
                Console.ReadKey();
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                Console.ReadLine();
            }
        }
    }
}
