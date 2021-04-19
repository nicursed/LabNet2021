using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivCero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"El resultado es: {DivCeroException.DivisionPorCero(10, 0)}");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}" + "\n");
                Console.WriteLine("No se puede dividir por cero.");
            }

            finally
            {
                Console.WriteLine("\n" + "La operacion finalizo.");
            }
            
            Console.ReadKey();
        }
    }
}
