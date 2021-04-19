using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic.ThrowException();
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception catched!" + "\n");
                Console.WriteLine($"Exception type: {ex.GetType().ToString()}." + "\n");
                Console.WriteLine($"Exception message: {ex.Message}");
                Console.ReadLine();
            };
        }
    }
}
