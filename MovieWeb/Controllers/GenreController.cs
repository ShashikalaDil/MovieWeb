using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;
using MovieWeb.Models;
using System.Linq;

namespace MovieWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly MovieWebContext _context;
        public GenreController(MovieWebContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
            return View();

        }
        
        public IActionResult ActionMovies()
        {
            var category = _context.Categories
                .Where(c => c.Name == "Action")
                .FirstOrDefault();

            if (category == null)
            {
                return NotFound();
            }

            int categoryId = category.CategoryId;

            var movies = _context.Movies
                .Where(m => m.CategoryId == categoryId)
                .ToList(); 

            return View(movies);
        }


    }
}
