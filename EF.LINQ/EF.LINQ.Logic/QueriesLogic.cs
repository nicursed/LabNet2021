using EF.LINQ.Data;
using EF.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.LINQ.Logic
{
    public class QueriesLogic
    {
        private readonly NorthwindContext context;

        public QueriesLogic()
        {
            context = new NorthwindContext();
        }


        public List<Customer> ObjetoCustomer()
        {

            var queryCustomer = from customers in context.Customers
                                where customers.CompanyName == "Chop-suey Chinese"
                                select customers;

            return queryCustomer.ToList();
        }

        public List<Product> ProdSinStock()
        {
            var querySinStock = from products in context.Products
                                where products.UnitsInStock == 0
                                select products;

            return querySinStock.ToList();

        }

        public List<Product> ProdEnStock()
        {
            var queryEnStock = from products in context.Products
                               where products.UnitsInStock >= 1 && products.UnitPrice > 3
                               select products;


            return queryEnStock.ToList();
        }

        public List<Customer> CustWA()
        {
            var queryCustWA = from customers in context.Customers
                              where customers.Region == "WA"
                              select customers;

            return queryCustWA.ToList();
        }

        public Product ProdFirstNull()
        {
            var queryFirstNull = context.Products.FirstOrDefault(p => p.ProductID == 789);

            return queryFirstNull;
        }

        public List<Customer> CustName()
        {
            var custName = from customers in context.Customers
                           select customers;

            return custName.ToList();
        }

        public IQueryable JoinCustYOrders()
        {
            var date = new DateTime(1997, 1, 1);
            var queryJoin = from customer in context.Customers
                        join order in context.Orders
                        on customer.CustomerID equals order.CustomerID
                        where customer.Region == "WA" && order.OrderDate > date
                        select new
                        {
                            customer.ContactName,
                            order.OrderDate
                        };

            return queryJoin;
        }

    }
}
