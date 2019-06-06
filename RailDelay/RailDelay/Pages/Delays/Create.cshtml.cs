using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Pages.Delays
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public CreateModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TicketID"] = new SelectList(_context.Set<Ticket>(), "ID", "TicketName");
            return Page();
        }

        [BindProperty]
        public Delay Delay { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Delay.Add(Delay);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}