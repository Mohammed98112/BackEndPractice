namespace Flight_Management_System
{
    internal class Program
    {
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
                        break;


                    //case 2) Add an Aircraft
                    case 2:
                        break;


                    //case 3) Register a Pilot
                    case 3:
                        break;



                    //case 4) View All Flights
                    case 4:
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
