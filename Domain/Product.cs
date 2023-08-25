using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDomain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
   

        public List<Order> Orders { get; set; }
    }

}
