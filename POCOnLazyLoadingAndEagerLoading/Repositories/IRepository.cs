namespace POCOnLazyLoadingAndEagerLoading.Repositories
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll();

    }
}
