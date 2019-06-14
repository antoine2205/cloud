using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoreApiClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RailDelay.Models;

namespace RailDelay.Pages.Stations
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public PaginatedList<TrainStation> StationList { get; set; }

        public string IdSort { get; set; }
        public string NameSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex)
        {
            currentSort = sortOrder;
            IdSort = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            NameSort = sortOrder == "name_desc" ? "name_asce" : "name_desc";
            CurrentFilter = searchString;

            /*ApiClient<TrainStation> apiClient = new ApiClient<TrainStation>(new Uri("http://api.irail.be"));
            List<TrainStation> trainStations = await apiClient.GetStrainStations();
            IQueryable<TrainStation> stationApiQ = trainStations.AsQueryable<TrainStation>;*/

            IQueryable<TrainStation> stationApiQ;

            using (var httpClient = new HttpClient())
            {

                using (var response = await httpClient.GetAsync("http://api.irail.be/stations/?format=json&lang=en"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    StationApi stationApi = new StationApi();
                    stationApi = JsonConvert.DeserializeObject<StationApi>(apiResponse);
                    stationApiQ = stationApi.Station.AsQueryable<TrainStation>();
                }
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                stationApiQ = stationApiQ.Where(s => s.Name.Contains(searchString) || 
                                                s.ID.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "id_desc":
                    stationApiQ = stationApiQ.OrderByDescending(s => s.ID);
                    break;
                case "name_desc":
                    stationApiQ = stationApiQ.OrderByDescending(s => s.Name);
                    break;
                case "name_asce":
                    stationApiQ = stationApiQ.OrderBy(s => s.Name);
                    break;
                default:
                    stationApiQ = stationApiQ.OrderBy(s => s.ID);
                    break;
            }

            StationList = PaginatedList<TrainStation>.Create(stationApiQ, pageIndex ?? 1, 10);

        }
    }
}
