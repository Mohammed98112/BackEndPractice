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
                FlightHours = hours

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
                        break;



                    //case 6) Book a Flight
                    case 6:
                        break;


                    //case 7) Cancel a Booking
                    case 7:
                        break;


                    //case 8) Schedule a Flight
                    case 8:
                        break;



                    //case 9) Book a Flight
                    case 9:
                        break;


                    //case 10) Cancel a Booking
                    case 10:
                        break;


                    //case 11) Flight Revenue & Load Factor Report
                    case 11:
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
