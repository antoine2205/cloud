using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RailDelay.Models;

namespace RailDelay.Pages.Stations
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        public TrainStation Station = new TrainStation();
        public string UrlPictureStation;

        public async Task OnGetAsync(string id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://api.irail.be/stations/?format=json&lang=en"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    StationApi stationApi = new StationApi();
                    stationApi = JsonConvert.DeserializeObject<StationApi>(apiResponse);
                    IQueryable<TrainStation> stationApiQ = stationApi.Station.AsQueryable<TrainStation>();
                    Station = stationApiQ.FirstOrDefault(s => s.ID == id);
                }

                string StationId = Station.ID.Substring(Station.ID.Length - 9);
                UrlPictureStation = "https://github.com/iRail/stations/blob/master/Pictures/" + StationId + ".jpg?raw=true";
            }
        }
    }

}