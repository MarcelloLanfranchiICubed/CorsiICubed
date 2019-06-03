using Delivery.Contexts;
using Delivery.Models;
using System.Linq;

namespace Delivery.Repositories
{

    public class RecipeRepo : ICommonRepository<Recipe>
    {
        private readonly DeliveryContext deliveryContext;

        public RecipeRepo(DeliveryContext deliveryContext)
        {
            this.deliveryContext = deliveryContext;
        }

        public IQueryable<Recipe> GetAll()
        {
            return deliveryContext.Recipes.AsQueryable();
        }

        public void Add(Recipe recipe)
        {
            deliveryContext.Recipes.Add(recipe);
            deliveryContext.SaveChanges();
        }

        public Recipe GetSingle(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Put(Recipe entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
