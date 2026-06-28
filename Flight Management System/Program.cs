using Flight_Management_System.Models;

namespace Flight_Management_System
{
    internal class Program
    {
        public static FlightContext context = new FlightContext(); // Connect to the database/// Used to access and store data


        //MainMenu
        public static void mainmenue()
        {

            Console.WriteLine("==============================================");
            Console.WriteLine("   FLIGHT MANAGEMENT SYSTEM (FMS)");
            Console.WriteLine("==============================================");


            Console.WriteLine("========== MAIN MENU ==========");
            Console.WriteLine(" 1.  Register a Passenger");
            Console.WriteLine(" 2.  Add an Aircraft");
            Console.WriteLine(" 3.  Register a Pilot");
            Console.WriteLine(" 4.  View All Flights");
            Console.WriteLine(" 5.  Schedule a Flight");
            Console.WriteLine(" 6.  Book a Flight");
            Console.WriteLine(" 7.  Cancel a Booking");
            Console.WriteLine(" 8.  Depart a Flight");
            Console.WriteLine(" 9.  Cancel a Flight");
            Console.WriteLine(" 10. Passenger Booking History");
            Console.WriteLine(" 11. Flight Revenue & Load Factor Report");
            Console.WriteLine(" 0.  Exit");


        }

        //case 1) Register a Passenger
        public static void RegisteraPassenger()
        {

            Console.WriteLine("--- Register a Passenger ---");
            Console.WriteLine("Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome Mr.{name} ");
            Console.WriteLine("Email     : ");
            string email = Console.ReadLine();
            Console.WriteLine("Phone     : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Nationality : ");
            string nationality = Console.ReadLine();
            Console.WriteLine("Passport/ID No : ");
            string passport = Console.ReadLine();

            // Check if a passenger with the same passport number already exists

            bool duplicate = context.Passengers.Any(p => p.PassportNumber == passport);
            if (duplicate)
            { Console.WriteLine("ERROR: A passenger with this passport number already exists."); return; }// Stop registration process


            // Generate a passenger ID 
            int passengerID = context.Passengers.Count + 1;

            // Create a new Passenger object and assign entered values
            var Passenger = new Passenger
            {
                PassengerId = passengerID,
                PassengerName = name,
                PassengerEmail = email,
                PassengerPhone = phone,
                PassportNumber = passport,
                Nationality = nationality

            };

            context.Passengers.Add(Passenger);     // Add passenger to the database context


            Console.WriteLine($"Passenger registered successfully! Assigned ID: {Passenger.PassengerId}");

        }

        //case 2) Add an Aircraft
        public static void AddanAircraft()
        {
            Console.WriteLine("--- Add an Aircraft  ---");
            Console.WriteLine("Model: Boeing 737, Airbus A320");
            Console.WriteLine("Enter aircraft model:     ");
            string model = Console.ReadLine();
            Console.Write("Total Seats: ");
            int seats = int.Parse
                (Console.ReadLine());
            if (seats <= 0)
            {
                Console.WriteLine("ERROR: seats must be more than 0 !");
                return;

            }
            var Aircraft = new Aircraft
            {

                AircraftId = context.Aircrafts.Count + 1,
                Model = model,
                TotalSeats = seats,
                IsOperational = true

            };

            context.Aircrafts.Add(Aircraft);

            Console.WriteLine($"Passenger registered successfully! Assigned ID: {Aircraft.AircraftId}");

        }

        //case 3) Register a Pilot
        public static void RegisteraPilot()

        {
            Console.WriteLine("--- Register a Pilot ---");
            Console.WriteLine("Name       : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome Mr.{name} ");
            Console.WriteLine("Phone           : ");
            string phone = Console.ReadLine();
            Console.WriteLine("License Number  : ");
            string license = Console.ReadLine();

            bool check = context.Pilots.Any(a => a.LicenseNumber == license);
            if (check)
            { Console.WriteLine("ERROR: A pilot with this LicenseNumber already exists."); return; }// Stop registration process

            Console.Write("Total Flight Hours (existing): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            if (hours <= 0)
            {
                Console.WriteLine("ERROR: seats must be more than 0 !");
                return;

            }

            var pilot = new Pilot
            {
                PilotId = context.Pilots.Count + 1,
                PilotName = name,
                PilotPhone = phone,
                LicenseNumber = license,
                FlightHours = hours,
                IsAvailable = true

            };
            context.Pilots.Add(pilot);
            Console.WriteLine($"pilot registered successfully! Assigned ID: {pilot.PilotId}");


        }

        //case 4) View All Flights

        public static void ViewAllFlights()
        {
            Console.WriteLine("--- View All Flights ---");

            if (context.Flights.Count == 0)
            { Console.WriteLine("No flights available yet"); return; }// Stop  process

            foreach (var flight in context.Flights)
            {
                Console.WriteLine($"Flight Code   : {flight.FlightCode}");
                Console.WriteLine($"Origin        : {flight.Origin}");
                Console.WriteLine($"Destination   : {flight.Destination}");
                Console.WriteLine($"Departure Date: {flight.DepartureDate}");
                Console.WriteLine($"Departure Time: {flight.DepartureTime}");
                Console.WriteLine($"AvailableSeats: {flight.AvailableSeats}");
                Console.WriteLine($"Ticket Price  : {flight.TicketPrice} OMR");
                Console.WriteLine($"Status        : {flight.Status}");
                Console.WriteLine("----------------------------------");
            }





        }

        //case 5) Schedule a Flight
        public static void ScheduleaFlight()
        { }

        // Case 6: Book a Flight
        public static void BookaFlight()
        { }

        //case 7) Cancel a Booking

        public static void CancelBooking()
        {
            Console.WriteLine("--- Cancel a Booking ---");

            //Ask for booking ID
            Console.Write("Enter Booking ID: ");
            int bookingId = Convert.ToInt32(Console.ReadLine());

            //Find booking
            Booking booking =
                context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);

            if (booking == null)
            {
                Console.WriteLine("Booking not found.");
                return;
            }

            // Check if already cancelled
            if (booking.Status == "Cancelled")
            {
                Console.WriteLine("Booking is already cancelled.");
                return;
            }

            // Find the flight related to this booking using FlightId
            Flight flight =
                context.Flights.FirstOrDefault(f => f.FlightId == booking.FlightId);

            if (flight == null)
            {
                Console.WriteLine("Related flight not found.");
                return;
            }

            // Cancel booking
            booking.Status = "Cancelled";

            // Return seat back to flight
            flight.AvailableSeats++;

            Console.WriteLine("Booking cancelled successfully!");
            Console.WriteLine($"Booking ID: {booking.BookingId}");
            Console.WriteLine($"Seat returned to flight {flight.FlightCode}");
        }


        //case 8) Depart a Flight
        public static void DepartaFlight()
        {
            Console.WriteLine("--- Depart a Flight ---");

            // Ask the user for the flight they want to mark as departed
            Console.Write("Enter Flight ID: ");
            int flightId = Convert.ToInt32(Console.ReadLine());

            // Search for the flight in the flights list
            Flight flight = context.Flights.FirstOrDefault(f => f.FlightId == flightId);

            // If no flight is found, stop the process
            if (flight == null)
            {
                Console.WriteLine("Flight not found.");
                return;
            }

            // A flight can only depart if its current status is "Scheduled"
            // If it is already Departed or Cancelled, don't allow the operation
            if (flight.Status != "Scheduled")
            {
                Console.WriteLine("Only scheduled flights can depart.");
                return;
            }

            // Find the pilot assigned to this flight
            Pilot pilot = context.Pilots.FirstOrDefault(p => p.PilotId == flight.PilotId);

            // Safety check to make sure the assigned pilot exists
            if (pilot == null)
            {
                Console.WriteLine("Assigned pilot not found.");
                return;
            }

            // Ask how many hours this flight takes
            // (The Flight class doesn't have a Duration property,
            // so we ask the user for it.)
            Console.Write("Enter Flight Duration (Hours): ");
            int duration = Convert.ToInt32(Console.ReadLine());

            // Flight duration must be greater than zero
            if (duration <= 0)
            {
                Console.WriteLine("Invalid duration.");
                return;
            }

            // Change the flight status because the flight has now taken off
            flight.Status = "Departed";

            // Add the completed flight hours to the pilot's total experience
            pilot.FlightHours += duration;

            // The pilot has finished this flight and is now available
            // to be assigned to another scheduled flight
            pilot.IsAvailable = true;

            // Display a confirmation message
            Console.WriteLine("Flight departed successfully!");
            Console.WriteLine($"Flight Code : {flight.FlightCode}");
            Console.WriteLine($"Status      : {flight.Status}");
            Console.WriteLine($"Pilot       : {pilot.PilotName}");
            Console.WriteLine($"Total Hours : {pilot.FlightHours}");
        }


        //case 9) Cancel a Flight
        public static void CancelFlight()
        { }


        //case 10) Passenger Booking History
        public static void PassengerBookingHistory()
        { }


        //case 11) Flight Revenue & Load Factor Report
        public static void FlightRevenueLoadFactorReport()
        { }


        static void Main(string[] args)
        {

            bool exit = false;
            while (exit == false)
            {
                mainmenue();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    //case 1) Register a Passenger

                    case 1:
                        RegisteraPassenger();
                        break;


                    //case 2) Add an Aircraft
                    case 2:
                        AddanAircraft();
                        break;


                    //case 3) Register a Pilot
                    case 3:
                        RegisteraPilot();
                        break;



                    //case 4) View All Flights
                    case 4:
                        ViewAllFlights();
                        break;


                    //case 5) Schedule a Flight
                    case 5:
                        ScheduleaFlight();
                        break;



                    //case 6) Book a Flight
                    case 6:
                        BookaFlight();
                        break;


                    //case 7) Cancel a Booking
                    case 7:
                        CancelBooking();
                        break;


                    //case 8) Depart a Flight
                    case 8:
                        DepartaFlight();
                        break;



                    //case 9) Cancel a Flight
                    case 9:
                        CancelFlight();
                        break;


                    //case 10) Passenger Booking History
                    case 10:
                        PassengerBookingHistory();
                        break;


                    //case 11) Flight Revenue & Load Factor Report
                    case 11:
                        FlightRevenueLoadFactorReport();
                        break;

                    //case 0) Exit
                    case 0:
                        exit = true;
                        break;


                    //wrong option
                    default:
                        Console.WriteLine("invalid option");
                        break;

                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();








            }
        }
    }
}
