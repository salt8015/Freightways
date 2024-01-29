using System.Linq.Expressions;

namespace FreightwaysApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
