using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Pilot
    {
        public int PilotId { get; set; }           // System Generated
        public string PilotName { get; set; }     // User Input
        public string PilotPhone { get; set; }    // User Input
        public string LicenseNumber { get; set; } // User Input
        public int FlightHours { get; set; }      // User Input 
        public bool IsAvailable { get; set; }     // Default Value 
    }
}
