using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RailDelay.Authorization;
using RailDelay.Data;
using RailDelay.Models;
using RailDelay.Pages.Shared;

namespace RailDelay.Pages.Delays
{
    [Authorize]
    public class IndexModel : DI_BasePageModel
    {
        public IndexModel(RailDelay.Data.ApplicationDbContext Context, IAuthorizationService AuthorizationService, UserManager<IdentityUser> UserManager):base(Context, AuthorizationService, UserManager)
        {

        }

        public IList<Delay> Delay { get;set; }

        public async Task OnGetAsync()
        {
            Delay = await _context.Delay
                .Where(d => d.OwnerID == _userManager.GetUserId(User))
                .Include(d => d.Ticket).ToListAsync();
        }
    }
}
