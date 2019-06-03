using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Pages.Delays
{
    public class DetailsModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public DetailsModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Delay Delay { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Delay = await _context.Delay
                .Include(d => d.Ticket).FirstOrDefaultAsync(m => m.ID == id);

            if (Delay == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
