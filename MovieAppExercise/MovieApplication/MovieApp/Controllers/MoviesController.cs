using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace MovieWebApp.Controllers {
    public class MoviesController : Controller {

        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;

        public MoviesController(IMovieService movieService, IGenreService genreService) {
            _movieService = movieService;
            _genreService = genreService;
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

        public async Task<IActionResult> MoviesByGenre(int id, int pageSize = 30, int pageNumber = 1) {
            var movies = await _movieService.GetMoviesByGenreAsync(id, pageSize, pageNumber);
            var genre = await _genreService.GetGenreByIdAsync(id);
            ViewData["GenreId"] = id;
            ViewData["GenreName"] = genre?.Name;
            return View(movies);
        }

    }
}
