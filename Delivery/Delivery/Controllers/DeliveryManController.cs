using Delivery.Models;
using Delivery.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    [Route("delivery-men")]
    public class DeliveryManController : CommonController<DeliveryMan>
    {
        public DeliveryManController(ICommonRepository<DeliveryMan> repository) : base(repository)
        {
        }
    }
}
