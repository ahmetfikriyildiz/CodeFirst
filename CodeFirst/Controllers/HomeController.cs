using CodeFirst.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public HomeController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }
    }
}
