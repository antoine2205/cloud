using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RailDelay.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Pages.Shared
{
    public class DI_BasePageModel : PageModel
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IAuthorizationService _authorizationService;
        protected readonly UserManager<IdentityUser> _userManager;

        public DI_BasePageModel(ApplicationDbContext Context, IAuthorizationService AuthorizationService, UserManager<IdentityUser> UserManager):base()
        {
            _context = Context;
            _authorizationService = AuthorizationService;
            _userManager = UserManager;
        }
    }
}
