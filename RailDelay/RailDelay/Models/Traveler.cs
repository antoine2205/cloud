using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RailDelay.Models
{
    public class Traveler
    {
        [Key]
        [DataType(DataType.Text)]
        // user ID from AspNetUser table
        public string OwnerID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        [Display(Name = "House Number")]
        public string HouseNumber { get; set; }
        public string Box { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public string Mobyle { get; set; }
        public string Email { get; set; }
    }
}
