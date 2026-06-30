  using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }       // System Generated
        public string PassengerName { get; set; }  // User Input
        public string PassengerEmail { get; set; } // User Input
        public string PassengerPhone { get; set; } // User Input
        public string PassportNumber { get; set; } // User Input
        public string Nationality { get; set; }    // User Input
    }
}
