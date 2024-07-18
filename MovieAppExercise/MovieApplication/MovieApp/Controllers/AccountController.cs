using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;

namespace Web.Controllers {
    public class AccountController : Controller {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService) {
            _accountService = accountService;
        }

    }
}