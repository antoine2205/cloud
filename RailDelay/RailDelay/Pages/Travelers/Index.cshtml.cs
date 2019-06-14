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
    public class IndexModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public IndexModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Traveler> Traveler { get;set; }

        public async Task OnGetAsync()
        {
            Traveler = await _context.Traveler.ToListAsync();
        }
    }
}
