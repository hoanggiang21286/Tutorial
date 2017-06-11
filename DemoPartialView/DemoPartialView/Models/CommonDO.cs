using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;


namespace DemoPartialView.Models
{
    public class CommonDO
    {
        public List<Customer> GetListCustomer(string id, string name)
        {
            List<Customer> listCustomer = new List<Customer>();
            using (LogisticsEntities de = new LogisticsEntities())
            {
                listCustomer = de.Customers.Where(w => w.CustomerID == id && w.CustomerName.Contains(name)).ToList();

                
            }
            return listCustomer;
        }
    }
}