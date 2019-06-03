using System.Collections.Generic;

namespace Delivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public IEnumerable<SingleOrder> SingleOrders { get; set; }
    }
}
