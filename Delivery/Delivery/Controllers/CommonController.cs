using Delivery.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Controllers
{
    [ApiController]
    public class CommonController<T> : ControllerBase
    {
        private readonly ICommonRepository<T> repository;

        public CommonController(ICommonRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            return repository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<T> Get(int id)
        {
            return repository.GetSingle(id);
        }

        [HttpPost]
        public void Post([FromBody] T entity)
        {
            repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] T entity)
        {
            repository.Put(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
