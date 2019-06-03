using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailDelay.Data;
using RailDelay.Models;

namespace RailDelay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelaysController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DelaysController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET api/delays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delay>>> Get()
        {
            return await context.Delay.ToListAsync();
        }

        // GET api/delays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Delay>> Get(int id)
        {
            Delay delay = await context.Delay.FindAsync(id);

            if (delay == null)
            {
                return NotFound();
            }

            return delay;
        }

        // POST api/delays
        [HttpPost]
        public async void Post(Delay model)
        {
            if (ModelState.IsValid)
            {
                Delay newDelay = new Delay()
                {
                    ID = model.ID,
                    TravelDate = model.TravelDate,
                    TicketID = model.TicketID,
                    TicketNumber = model.TicketNumber,
                    LastDateOfUse = model.LastDateOfUse,
                    DepartureTrainStationID = model.DepartureTrainStationID,
                    DestinationTrainStationID = model.DestinationTrainStationID,
                    TransferTrainStationID = model.TransferTrainStationID,
                    PlannedDepartureTime = model.PlannedDepartureTime,
                    PlannedArrivalTime = model.PlannedArrivalTime,
                    PlannedTrain1Number = model.PlannedTrain1Number,
                    PlannedTrain2Number = model.PlannedTrain2Number,
                    ActualDepartureTime = model.ActualDepartureTime,
                    ActualArrivalTime = model.ActualArrivalTime,
                    ActualTrain1Number = model.ActualTrain1Number,
                    ActualTrain2Number = model.ActualTrain2Number
                };
                await context.Delay.AddAsync(newDelay);
            }
        }

        // PUT api/delays/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/delays/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            Delay delay = await context.Delay.FindAsync(id);

            if (delay != null)
            {
                context.Delay.Remove(delay);
            }
        }
    }
}
