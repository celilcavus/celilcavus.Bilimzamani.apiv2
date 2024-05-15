using System.Linq.Expressions;

namespace _03.celilcavus.Models.Interfaces
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        IEnumerable<T> GetAll();
        T FindById(int id);
        IQueryable<T> CategoryByName(Expression<Func<T, bool>> expression);
        int SaveChanges();
    }
}
