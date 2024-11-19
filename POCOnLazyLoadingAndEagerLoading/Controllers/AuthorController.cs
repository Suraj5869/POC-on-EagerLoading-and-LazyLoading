using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POCOnLazyLoadingAndEagerLoading.Models;
using POCOnLazyLoadingAndEagerLoading.Services;

namespace POCOnLazyLoadingAndEagerLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }


        [HttpGet("lazy")]
        public IActionResult GetAllLazy()
        {
            var authors = _authorService.GetAllLazy();
            return Ok(authors);
        }

        [HttpGet("Eager")]
        public IActionResult GetAllEager()
        {
            var authors = _authorService.GetAllEager();
            return Ok(authors);
        }
    }
}
