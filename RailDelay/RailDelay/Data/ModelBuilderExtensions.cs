using Microsoft.EntityFrameworkCore;
using RailDelay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    ID = 1,
                    TicketName = "Biljet"
                }, 
                new Ticket
                {
                    ID = 2,
                    TicketName = "Treinkaart"
                },
                new Ticket
                {
                    ID = 3,
                    TicketName = "Campus"
                },
                new Ticket
                {
                    ID = 4,
                    TicketName = "Halftijdse Treinkaart"
                },
                new Ticket
                {
                    ID = 5,
                    TicketName = "Pass"
                },
                new Ticket
                {
                    ID = 6,
                    TicketName = "Kaart"
                },
                new Ticket
                {
                    ID = 7,
                    TicketName = "MOBIB Kaart"
                });
                
            modelBuilder.Entity<Delay>().HasData(
                new Delay
                {
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
                    TravelDate = new DateTime(2019, 5, 1),
                    TicketID = 1,
                    TicketNumber = "",
                    LastDateOfUse = new DateTime(2019, 4, 28),
                    DepartureTrainStationID = "BE.NMBS.008813003",
                    DestinationTrainStationID = "BE.NMBS.008821006",
                    TransferTrainStationID = "",
                    PlannedDepartureTime = new DateTime(2019, 5, 1, 8, 15, 0),
                    PlannedArrivalTime = new DateTime(2019, 5, 1, 9, 0, 0),
                    PlannedTrain1Number = "1234",
                    PlannedTrain2Number = "",
                    ActualDepartureTime = new DateTime(2019, 5, 1, 8, 30, 0),
                    ActualArrivalTime = new DateTime(2019, 5, 1, 9, 15, 0),
                    ActualTrain1Number = "6543",
                    ActualTrain2Number = ""
                });
        }
    }
}
