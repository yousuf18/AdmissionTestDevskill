using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataMerge
    {
        public List<Customer> CustomerList { get; set; }
        public List<Order> OrderList { get; set;}

        public  List<(string customerName, List<string> productNames)> GetInfo()
        {

            var customerInfo = OrderList.Where(x => x.CustomerId != 1).ToList();

            throw new NotImplementedException();
        }
    }
}
