using Microsoft.EntityFrameworkCore;
using POCOnLazyLoadingAndEagerLoading.Models;
using POCOnLazyLoadingAndEagerLoading.Repositories;

namespace POCOnLazyLoadingAndEagerLoading.Services
{
    public class AuthorService:IAuthorService
    {
        private readonly IRepository<Author> _repository;

        public AuthorService(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public List<Author> GetAllLazy()
        {
            var authors = _repository.GetAll().ToList();//It loads the author data only
            return authors;
        }

        public List<Author> GetAllEager()
        {
            var authors = _repository.GetAll().Include(a=>a.Books).ToList();//It loads the author data including the book details also
            return authors;
        }
    }
}
