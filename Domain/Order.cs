using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDomain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Product> Products { get; set; }
        public List<Shipment> Shipments { get; set; }
        public List<Payment> Payments { get; set; }
    }

}
