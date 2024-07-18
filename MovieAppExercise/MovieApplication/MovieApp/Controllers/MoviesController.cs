using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace MovieWebApp.Controllers {
    public class MoviesController : Controller {

        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService) {
            _movieService = movieService;
        }

        public IActionResult Index() {
            var movieCards = _movieService.GetTestMovieCards();
            return View(movieCards);
        }

        public async Task<IActionResult> Details(int id) {
            var movie = await _movieService.GetMovieDetailsAsync(id);
            if (movie == null) {
                return NotFound();
            }
            return View(movie);
        }

    }
}
