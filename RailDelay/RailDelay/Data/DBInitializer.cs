using RailDelay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for students.
            if (context.Delay.Any())
            {
                return; // DB has been seeded
            }

            var delays = new Delay[]
            {
                new Delay{
                    ID = 1,
                    TravelDate = DateTime.Parse("2019-04-01"),
                    TicketID = 1,
                    TicketNumber = "",
                    LastDateOfUse = DateTime.Parse("2019-03-28"),
                    DepartureTrainStationID = "BE.NMBS.008821006",
                    DestinationTrainStationID = "BE.NMBS.008813003",
                    TransferTrainStationID = "",
                    PlannedDepartureTime = DateTime.Parse("2019-04-01 8:15"),
                    PlannedArrivalTime = DateTime.Parse("2019-04-01 9:00"),
                    PlannedTrain1Number = "1234",
                    PlannedTrain2Number = "",
                    ActualDepartureTime = DateTime.Parse("2019-04-01 8:30"),
                    ActualArrivalTime = DateTime.Parse("2019-04-01, 9:15"),
                    ActualTrain1Number = "6543",
                    ActualTrain2Number = ""
                },
                new Delay
                {
                    ID = 2,
                    TravelDate = DateTime.Parse("2019-05-01"),
                    TicketID = 1,
                    TicketNumber = "",
                    LastDateOfUse = DateTime.Parse("2019-04-28"),
                    DepartureTrainStationID = "BE.NMBS.008813003",
                    DestinationTrainStationID = "BE.NMBS.008821006",
                    TransferTrainStationID = "",
                    PlannedDepartureTime = DateTime.Parse("2019-05-01 8:15"),
                    PlannedArrivalTime = DateTime.Parse("2019-05-01 9:00"),
                    PlannedTrain1Number = "1234",
                    PlannedTrain2Number = "",
                    ActualDepartureTime = DateTime.Parse("2019-05-01 8:30"),
                    ActualArrivalTime = DateTime.Parse("2019-05-01 9:15"),
                    ActualTrain1Number = "6543",
                    ActualTrain2Number = ""
                }
            };
            foreach (Delay delay in delays)
            {
                context.Delay.Add(delay);
            }
            context.SaveChanges();

        }
    }
}
