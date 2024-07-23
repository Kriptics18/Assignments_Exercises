using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents {
    public class GenresViewComponent : ViewComponent {

        private readonly IGenreService _genreService;
        private readonly ILogger<GenresViewComponent> _logger;

        public GenresViewComponent(IGenreService genreService, ILogger<GenresViewComponent> logger) {
            _genreService = genreService;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            
            var genres = await _genreService.GetAllGenresAsync();
            return View(genres);
        }

    }
}
