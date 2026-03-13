namespace RonelActivityFlight
{
    internal class Program
    {
        static List<string[]> flights = new List<string[]>
            {
                new string[] {"Manila", "Cebu", "Philippine Airlines" },
                new string[] {"Iloilo", "Puerto Princesa", "Cebu Pacific" },
                new string[] {"Davao", "Boracay", "AirAsia" }
            };

        static void Main(string[] args)
        {
            bool continueSearch = true;

            while (continueSearch)
            {
                showMenu();

                Console.Write("\nPlease select an option (1-5): ");
                string option = Console.ReadLine().Trim();

                switch (option)
                {
                    case "1":
                        searchFlight();
                        break;

                    case "2":
                        addFlight();
                        break;

                    case "3":
                        updateAirline();
                        break;

                    case "4":
                        deleteFlight();
                        break;

                    case "5":
                        Console.Write("\nDo you want to perform another action? (y/n): ");
                        string response = Console.ReadLine().Trim().ToLower();

                        if (response != "y")
                        {
                            continueSearch = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
            Console.WriteLine("\nThank you for using Flight Management System. I hope you have a wonderful day and goodbye!");
        }

                static void showMenu()
                {
                    Console.WriteLine(" === FLIGHT MANAGEMENT SYSTEM ===\n");
                    Console.WriteLine("1. Search for a flight");
                    Console.WriteLine("2. Add new flight");
                    Console.WriteLine("3. Update Airline");
                    Console.WriteLine("4. Delete flight");
                    Console.WriteLine("5. Exit");
                }
                static void searchFlight()
                {
                    Console.Write("Please enter your Origin: ");
                    string userOrigin = Console.ReadLine().Trim().ToLower();

                    Console.Write("Please enter your destination: ");
                    string userDestination = Console.ReadLine().Trim().ToLower();

                    bool flightFound = false;
                    foreach (var f in flights)
                    {
                        if (f[0].ToLower() == userOrigin.ToLower() && f[1].ToLower() == userDestination.ToLower())
                        {
                            Console.WriteLine("\nFlight found with " + f[2]);
                            flightFound = true;
                            break;
                        }
                    }
                    if (flightFound == false) Console.WriteLine("\nNo flight found for the given origin and destination.");
                }

                static void addFlight()
                {
                    Console.Write("Enter New Origin: ");
                    string newOrigin = Console.ReadLine().Trim();

                    Console.Write("Enter New Destination: ");
                    string newDestination = Console.ReadLine().Trim();

                    Console.Write("Enter Airline Name: ");
                    string airline = Console.ReadLine().Trim();

                    flights.Add(new string[] { newOrigin, newDestination, airline });
                    Console.WriteLine("\nFlight added succesfully to the system!");
                }

                static void updateAirline()
                {
                    Console.Write("Enter the origin of the Airline to update: ");
                    string searchOrigin = Console.ReadLine().Trim();

                    bool updated = false;

                    foreach (var f in flights)
                    {
                        if (f[0].ToLower() == searchOrigin.ToLower())
                        {
                            Console.Write("Current airline of the origin is " + f[2] + ". Please enter new airline: ");
                            f[2] = Console.ReadLine();
                            Console.WriteLine("Update successful!");
                            updated = true;
                            break;
                        }
                    }
                    if (updated == false)
                        Console.WriteLine("Flight not found.");
                }

                static void deleteFlight()
                {
                    Console.Write("Enter origin of the flight to remove: ");
                    string deleteOrigin = Console.ReadLine();
                    int initialCount = flights.Count;

                    for (int i = 0; i < flights.Count; i++)
                    {
                        if (flights[i][0].ToLower() == deleteOrigin.ToLower())
                        {
                            flights.Remove(flights[i]);
                            Console.WriteLine("Flight deleted.");
                            break;
                        }
                    }
                    if (flights.Count == initialCount)
                        Console.WriteLine("Flight not found.");
                } 
    }
}