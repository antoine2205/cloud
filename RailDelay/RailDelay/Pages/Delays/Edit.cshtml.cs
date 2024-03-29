﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Pages.Delays
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly RailDelay.Data.ApplicationDbContext _context;

        public EditModel(RailDelay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Delay Delay { get; set; }

        public IQueryable<TrainStation> StationApiQ;

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

            ViewData["TicketID"] = new SelectList(_context.Set<Ticket>(), "ID", "TicketName");

            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync("http://api.irail.be/stations/?format=json&lang=en"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    StationApi stationApi = new StationApi();
                    stationApi = JsonConvert.DeserializeObject<StationApi>(apiResponse);
                    StationApiQ = stationApi.Station.AsQueryable<TrainStation>().OrderBy(s => s.Name);
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Delay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DelayExists(Delay.ID))
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

        private bool DelayExists(int id)
        {
            return _context.Delay.Any(e => e.ID == id);
        }
    }
}
