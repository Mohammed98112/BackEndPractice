namespace E_Commerce_System_EFCore
{
    internal class Program
    {
        public static ECommerceContext context = new ECommerceContext();
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
        //case 1) Register a New User
        public static void ADDUser()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Full name: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Phone.No: ");
            string number = Console.ReadLine();
            Console.WriteLine("Adress: ");
            string Adress = Console.ReadLine();




            context.Users.Add(new User
            {
                username = username,
                email = email,
                passwordHash = password,
                fullName = fullName,
                phoneNumber = number,  
                address = Adress,
                isActive = true

            });
            context.SaveChanges();
            User saved = context.Users.OrderBy(x => x.userId).Last();
            Console.WriteLine($"User registered successfully. The ID:{saved.userId}");



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
