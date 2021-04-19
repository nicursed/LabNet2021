using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomExceptionMethod.throwCustomException();
            }
            catch(CustomException ex) 
            {
                Console.WriteLine("Custom Exception catched!" + "\n");
                Console.WriteLine($"Exception message: {ex.Message}.");
                Console.ReadKey();
            };
        }
    }
}
