using Flight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System
{
   
        public class FlightContext
        {
            public List<Passenger> Passengers { get; set; } = new List<Passenger>();
            public List<Pilot> Pilots { get; set; } = new List<Pilot>();
            public List<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();
            public List<Flight> Flights { get; set; } = new List<Flight>();
            public List<Booking> Bookings { get; set; } = new List<Booking>();
        }
    
}
