using Delivery.Contexts;
using Delivery.Models;
using System.Linq;

namespace Delivery.Repositories
{
    public class DeliveryManRepo : ICommonRepository<DeliveryMan>
    {
        private readonly DeliveryContext deliveryContext;

        public DeliveryManRepo(DeliveryContext deliveryContext)
        {
            this.deliveryContext = deliveryContext;
        }
        public IQueryable<DeliveryMan> GetAll()
        {
            return deliveryContext.DeliveryMen.AsQueryable();
        }

        public void Add(DeliveryMan man)
        {
            deliveryContext.DeliveryMen.Add(man);
            deliveryContext.SaveChanges();
        }

        public DeliveryMan GetSingle(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Put(DeliveryMan entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
