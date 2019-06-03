using Delivery.Contexts;
using Delivery.Models;
using System.Linq;

namespace Delivery.Repositories
{
    public class SingleOrderRepo : ICommonRepository<SingleOrder>
    {
        private readonly DeliveryContext deliveryContext;

        public SingleOrderRepo(DeliveryContext deliveryContext)
        {
            this.deliveryContext = deliveryContext;
        }

        public void Add(SingleOrder singleOrder)
        {
            deliveryContext.SingleOrders.Add(singleOrder);
            deliveryContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<SingleOrder> GetAll()
        {
            return deliveryContext.SingleOrders.AsQueryable();
        }

        public SingleOrder GetSingle(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Put(SingleOrder entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
