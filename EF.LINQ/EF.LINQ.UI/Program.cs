using EF.LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            QueriesLogic query = new QueriesLogic();

            Console.WriteLine("Presione cualquier tecla para pasar de consigna en consigna \n");
            Console.ReadKey();

            foreach (var item in query.ObjetoCustomer())
            {
                Console.WriteLine($"Punto 1 - Customer Company Name: {item.CompanyName}" + "\n");
            }
            Console.ReadKey();


            Console.WriteLine("Punto 2 - Productos sin stock: \n");
            foreach (var item in query.ProdSinStock())
            {
                Console.WriteLine(item.ProductName + "\n");
            }
            Console.ReadKey();


            Console.WriteLine("Punto 3 - Productos en stock y Unit price: \n");
            foreach (var item in query.ProdEnStock())
            {
                Console.WriteLine($"{item.UnitsInStock} - {item.UnitPrice}" + "\n");
            }
            Console.ReadKey();


            Console.WriteLine("Punto 4 - Customers de Washington: \n");
            foreach (var item in query.CustWA())
            {
                Console.WriteLine($"Nombre: {item.ContactName} - Nombre de la compania: {item.CompanyName}" + "\n");
            }
            Console.ReadKey();


            Console.WriteLine("Punto 5 - ID Null \n");
            var idNull = query.ProdFirstNull();

            if (idNull == null) Console.WriteLine("Sin valor \n");
            Console.ReadKey();


            Console.WriteLine("Punto 6 - Nombres en May y Min: \n");
            foreach (var item in query.CustName())
            {
                Console.WriteLine($"{item.ContactName.ToUpper()} - {item.ContactName.ToLower()}");
            }

           //Console.WriteLine("Punto 7 - Join Customers y Orders: \n"); - No supe que ni como mostrar

            Console.ReadLine();
        }
    }
}
