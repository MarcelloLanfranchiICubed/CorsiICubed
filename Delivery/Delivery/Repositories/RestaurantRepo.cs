using Delivery.Contexts;
using Delivery.Models;
using System.Linq;

namespace Delivery.Repositories
{
    public class RestaurantRepo : ICommonRepository<Restaurant>
    {
        private readonly DeliveryContext deliveryContext;

        public RestaurantRepo(DeliveryContext deliveryContext)
        {
            this.deliveryContext = deliveryContext;
        }

        public IQueryable<Restaurant> GetAll()
        {
            return deliveryContext.Restaurants.AsQueryable();
        }

        public void Add(Restaurant restaurant)
        {
            deliveryContext.Restaurants.Add(restaurant);
            deliveryContext.SaveChanges();
        }

        public Restaurant GetSingle(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Put(Restaurant entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
