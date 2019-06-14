using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Pages.Travelers
{
    public class EditModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public EditModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Traveler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelerExists(Traveler.OwnerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TravelerExists(string id)
        {
            return _context.Traveler.Any(e => e.OwnerID == id);
        }
    }
}
