using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RailDelay.Models;

namespace RailDelay.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Default
        public async Task<IActionResult> Index()
        {
            PaginatedList<TrainStation> stationList = (PaginatedList<TrainStation>) new List<TrainStation>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://api.irail.be/stations/?format=json&lang=en"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    StationApi stationApi = new StationApi();
                    stationApi = JsonConvert.DeserializeObject<StationApi>(apiResponse);
                    stationList = PaginatedList<TrainStation>.Create((IQueryable<TrainStation>)stationApi.Station, 1, 10);                }
            }
            return View(stationList);
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}