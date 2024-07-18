using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace Web.Controllers {
    public class AdminController : Controller {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService) {
            _adminService = adminService;
        }

    }
}