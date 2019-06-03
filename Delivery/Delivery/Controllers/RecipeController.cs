using Delivery.Models;
using Delivery.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("recipes")]
    public class RecipeController : CommonController<Recipe>
    {
        public RecipeController(ICommonRepository<Recipe> repository) : base(repository)
        {

        }
    }
}
