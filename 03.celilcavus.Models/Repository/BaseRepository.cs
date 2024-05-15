using _02.celilcavus.DbContexts;
using _03.celilcavus.Models.Interfaces;
using System.ComponentModel;
using System.Linq.Expressions;

namespace _03.celilcavus.Models.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly BilimzamaniContext bilimzamaniContext;

        public BaseRepository(BilimzamaniContext bilimzamaniContext)
        {
            this.bilimzamaniContext = bilimzamaniContext;
        }

        public int Add(T entity)
        {
            bilimzamaniContext.Set<T>().Add(entity);
            return 1;
        }

        public IQueryable<T> CategoryByName(Expression<Func<T,bool>> expression)
        {
            return bilimzamaniContext.Set<T>().Where(expression);
        }

        public int Delete(T entity)
        {
            bilimzamaniContext.Set<T>().Remove(entity);
            return 1;
        }

        public T FindById(int id)
        {
            return bilimzamaniContext.Set<T>().Find(id)!;
        }

        public IEnumerable<T> GetAll()
        {
            return bilimzamaniContext.Set<T>().ToList();
        }

        public int SaveChanges()
        {
           return bilimzamaniContext.SaveChanges();
        }

        public int Update(T entity)
        {
            bilimzamaniContext.Set<T>().Update(entity);
            return 1;
        }
    }
}
