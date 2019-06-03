using System.Linq;

namespace Delivery.Repositories
{
    public interface ICommonRepository<T>
    {
        IQueryable<T> GetAll();
        T GetSingle(int id);
        void Add(T entity);
        void Put(T entity);
        void Delete(int id);
    }
}
