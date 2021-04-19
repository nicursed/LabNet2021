using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class CustomExceptionMethod
    {
        public static void throwCustomException()
        {
            throw new CustomException();
        }

    }
}
