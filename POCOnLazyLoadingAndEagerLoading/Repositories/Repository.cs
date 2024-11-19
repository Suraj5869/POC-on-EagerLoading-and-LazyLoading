using Microsoft.EntityFrameworkCore;
using POCOnLazyLoadingAndEagerLoading.Data;

namespace POCOnLazyLoadingAndEagerLoading.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;
        public Repository(Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            var authors = _dbSet.AsQueryable();
            return authors;
        }
        
    }
}
