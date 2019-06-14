using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RailDelay.Data;
using RailDelay.Models;
using RailDelay.Pages.Shared;

namespace RailDelay.Pages
{
    public class FormModel : DI_BasePageModel
    {
        public FormModel(ApplicationDbContext Context, IAuthorizationService AuthorizationService, UserManager<IdentityUser> UserManager) : base (Context, AuthorizationService, UserManager)
        {

        }

        public Traveler Traveler { get; private set; }
        public IList<Delay> Delay { get; private set; }
        public int LineNumber { get; set; }

        public async void OnGetAsync()
        {
            string userID = _userManager.GetUserId(User);
            Traveler = await _context.Traveler.FirstOrDefaultAsync(t => t.OwnerID == userID);

            try {
            Delay = await _context.Delay
                .Where(d => d.OwnerID == userID)
                .Include(d => d.Ticket).ToListAsync();
            }
            catch
            {

            }
        }
    }
}