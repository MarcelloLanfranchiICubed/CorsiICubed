using Delivery.Contexts;
using Delivery.Models;
using System.Linq;

namespace Delivery.Repositories
{
    public class OrderRepo : ICommonRepository<Order>
    {
        private readonly DeliveryContext deliveryContext;

        public OrderRepo(DeliveryContext deliveryContext)
        {
            this.deliveryContext = deliveryContext;
        }

        public void Add(Order order)
        {
            deliveryContext.Orders.Add(order);
            deliveryContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Order> GetAll()
        {
            return deliveryContext.Orders.AsQueryable();
        }

        public Order GetSingle(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Put(Order entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
