using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace Web.Controllers {
    public class CastsController : Controller {
        private readonly ICastService _castService;

        public CastsController(ICastService castService) {
            _castService = castService;
        }

        public async Task<IActionResult> Details(int id) {
            var cast = await _castService.GetCastDetailsAsync(id);
            if (cast == null) {
                return NotFound();
            }
            return View(cast);
        }

    }
}