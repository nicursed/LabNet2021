using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Logic
    {
     public static void ThrowException()
        { 
                DateTime? dateNull = null;
                string dateFormatted = dateNull.Value.ToString("MM/yy");  
        } 
        
    }
}
