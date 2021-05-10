using EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context; //readonly restringe donde puedo modificar o instanciar el contexto: en linea o en constructor

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
