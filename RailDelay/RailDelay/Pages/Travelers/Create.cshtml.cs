using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RailDelay.Data;
using RailDelay.Models;
using RailDelay.Pages.Shared;

namespace RailDelay.Pages.Travelers
{
    public class CreateModel : DI_BasePageModel
    {
        public CreateModel(RailDelay.Data.ApplicationDbContext Context, IAuthorizationService DelayAuthorizationService, UserManager<IdentityUser> UserManager) : base(Context, DelayAuthorizationService, UserManager)
        {

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Traveler Traveler { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            Traveler.OwnerID = _userManager.GetUserId(User);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Traveler.Add(Traveler);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}