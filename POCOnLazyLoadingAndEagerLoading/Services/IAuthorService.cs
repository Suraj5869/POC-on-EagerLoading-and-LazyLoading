using POCOnLazyLoadingAndEagerLoading.Models;

namespace POCOnLazyLoadingAndEagerLoading.Services
{
    public interface IAuthorService
    {
        public List<Author> GetAllLazy();
        public List<Author> GetAllEager();
    }
}
