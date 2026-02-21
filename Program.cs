namespace RonelActivityFlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" === Flight Search ===\n");

            string[] origin = { "Manila", "Iloilo", "Davao" };
            string[] destination = { "Cebu", "Puerto Princesa", "Boracay" };
            string[] airline = { "Manila to Cebu. Philippine Airlines.", "Iloilo to Cebu. Cebu Pacific.", "Davao to Boracay." +
                    " AirAsia." };

            Console.Write("Please enter your origin: ");
            string userOrigin = Console.ReadLine();

            Console.Write("Please enter your destination: ");
            string userDestination = Console.ReadLine();

            bool flightFound = false;
            for (int x = 0; x < 3; x++)
            {
                if (userOrigin == origin[x] && userDestination == destination[x])
                {
                    Console.Write($"\nFlight found: {airline[x]}\n\n");
                    flightFound = true;
                    break;
                }
            }
            if (flightFound == false)
            {
                Console.WriteLine("No flight found for the given origin and destination.");
            }
        }
    }
}
