using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class CustomException : Exception
    {
        public CustomException() : base("Custom Exception error message") 
        {

        }
       
    }
}
