using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public class Delay
    {
        public int ID { get; set; }

        [Display(Name = "Reisdatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime TravelDate { get; set; }

        [Display(Name = "Vervoerbewijs")]
        public int TicketID { get; set; }

        [Display(Name = "Nummer vervoerbewijs")]
        [StringLength(maximumLength: 13, MinimumLength = 1)]
        public string TicketNumber { get; set; }

        [Display(Name = "Laatste gebruiksdatum")]
        [DataType(DataType.Date)]
        public DateTime LastDateOfUse { get; set; }

        [Display(Name = "Vertrekstation")]
        public string DepartureTrainStationID { get; set; }

        [Display(Name = "Bestemmingsstation")]
        public string DestinationTrainStationID { get; set; }

        [Display(Name = "Overstap station")]
        public string TransferTrainStationID { get; set; }

        [Display(Name = "Vertrekuur")]
        [DataType(DataType.Time)]
        public DateTime PlannedDepartureTime { get; set; }

        [Display(Name = "Aankomstuur")]
        [DataType(DataType.Time)]
        public DateTime PlannedArrivalTime { get; set; }

        [Display(Name = "Treinnummers voorziene trein(en)")]
        [StringLength(maximumLength: 4)]
        public string PlannedTrain1Number { get; set; }

        [Display(Name = "Treinnummers voorziene trein(en)")]
        [StringLength(maximumLength: 4)]
        public string PlannedTrain2Number { get; set; }

        [Display(Name = "Vertrekuur")]
        [DataType(DataType.Time)]
        public DateTime ActualDepartureTime { get; set; }

        [Display(Name = "Aankomstuur")]
        [DataType(DataType.Time)]
        public DateTime ActualArrivalTime { get; set; }

        [Display(Name = "Treinnummers voorziene trein(en)")]
        [StringLength(maximumLength: 4)]
        public string ActualTrain1Number { get; set; }

        [Display(Name = "Treinnummers voorziene trein(en)")]
        [StringLength(maximumLength: 4)]
        public string ActualTrain2Number { get; set; }

        public Ticket Ticket { get; set; }
    }
}
