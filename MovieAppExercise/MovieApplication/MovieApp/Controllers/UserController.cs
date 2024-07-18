using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace Web.Controllers {
    public class UserController : Controller {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        
    }
}