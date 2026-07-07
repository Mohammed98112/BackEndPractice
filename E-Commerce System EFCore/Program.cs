using E_Commerce_System_EFCore.Models;
using E_Commerce_System_ERD___Models_Copy;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace E_Commerce_System_EFCore
{
    public class Program
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

        //case 2) Add a New Product to a Category
        public static void AddaNewProducttoaCategory()
        {




        }






        //case 3) Place an Order 

        //case 4)  Write a Product Review

        //case 5) Update Product Price and Availability 

        //case 6) Cancel an Order 

        //case 7) Delete a Review

        //case 8) View All Products (Get All)

        //case 9) Filter Products by Category and Price Range

        //case 10) Get Category with All Its Products (Include) 

        //case 11) View Order History with Full Details(ThenInclude)

        //case 12) Product Summary Report (Projection + LazyLoading) 


        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                mainmenue();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    //case 1) Register a New User

                    case 1:
                        break;


                    //case 2) Add a New Product to a Category
                    case 2:
                        break;


                    //case 3) Place an Order 
                    case 3:
                        break;



                    //case 4)  Write a Product Review
                    case 4:
                        break;


                    //case 5) Update Product Price and Availability 
                    case 5:
                        break;



                    //case 6) Cancel an Order 
                    case 6:
                        break;


                    //case 7) Delete a Review
                    case 7:
                        break;


                    //case 8) View All Products (Get All)
                    case 8:
                        break;



                    //case 9) Filter Products by Category and Price Range
                    case 9:
                        break;


                    //case 10) Get Category with All Its Products (Include) 
                    case 10:
                        break;


                        //case 11) View Order History with Full Details(ThenInclude)
                    case 11:
                        break;

                        //case 12) Product Summary Report (Projection + LazyLoading) 
                    case 12:
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
