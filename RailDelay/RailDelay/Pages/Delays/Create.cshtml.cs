using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RailDelay.Data;
using RailDelay.Models;
using RailDelay.Pages.Shared;

namespace RailDelay.Pages.Delays
{
    [Authorize]
    public class CreateModel : DI_BasePageModel
    {
        public CreateModel(RailDelay.Data.ApplicationDbContext Context, IAuthorizationService DelayAuthorizationService, UserManager<IdentityUser> UserManager):base(Context, DelayAuthorizationService, UserManager)
        {

        }

        [BindProperty]
        public Delay Delay { get; set; }

        public IQueryable<TrainStation> StationApiQ { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
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

            Delay.OwnerID = _userManager.GetUserId(User);

            _context.Delay.Add(Delay);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}