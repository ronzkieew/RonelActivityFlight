namespace RonelActivityFlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueSearch = true;

            while (continueSearch)
            {

                //var flights = new List<string[]>
                //{
                //   new string[] {"Manila", "Cebu", "Philippine Airlines" },
                //   new string[] {"Iloilo", "Puerto Princesa", "Cebu Pacific" },
                //   new string[] {"Davao", "Boracay", "AirAsia" }
                //};

                Console.WriteLine("\n === FLIGHT MANAGEMENT SYSTEM ===\n");

                Console.WriteLine("1. Search for a flight");
                Console.WriteLine("2. Add new flight");
                Console.WriteLine("3. Update Airlines");
                Console.WriteLine("4. Delete flight");
                Console.WriteLine("5. Exit");

                Console.Write("\nPlease select an option (1-5): ");
                string option = Console.ReadLine().Trim();

            //            Console.Write("Please enter your origin: ");
            //            string userOrigin = Console.ReadLine().Trim();

            //            Console.Write("Please enter your destination: ");
            //            string userDestination = Console.ReadLine().Trim();

            //            bool flightFound = false;
            //            foreach (var f in flights)
            //            {
            //                if (f[0].ToLower() == userOrigin.ToLower() && f[1].ToLower() == userDestination.ToLower())
            //                {
            //                    Console.Write("\n\nFlight found with " + f[2]);
            //                    flightFound = true;

            //                }
            //            }
            //            if (flightFound == false)
            //            {
            //                Console.WriteLine("No flight found for the given origin and destination.");
            //            }

                        Console.Write("\nDo you want to try again? (y/n): ");
                        string response = Console.ReadLine().ToLower();

                        if (response != "y")
                        {
                            continueSearch = false;
                        }
                    }
                    Console.WriteLine("\nThank you for using Flight Management System. I hope you have a wonderful day and goodbye!");
        }
  }
}
