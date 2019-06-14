using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Pages.Travelers
{
    public class DetailsModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public DetailsModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Traveler Traveler { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Traveler = await _context.Traveler.FirstOrDefaultAsync(m => m.OwnerID == id);

            if (Traveler == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
