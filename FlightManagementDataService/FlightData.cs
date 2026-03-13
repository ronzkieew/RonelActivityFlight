using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightModels;

namespace FlightManagementDataService
{
    public class FlightData
    {
        private List<flightModel> flights = new List<flightModel>();

        public FlightDataService()
        {
            flights.Add(new flightModel { Origin = "Manila", Destination = "Cebu", Airline = "Philippine Airlines" });
            flights.Add(new flightModel { Origin = "Iloilo", Destination = "Puerto Princesa", Airline = "Cebu Pacific" });
            flights.Add(new flightModel { Origin = "Davao", Destination = "Boracay", Airline = "AirAsia" });
        }
        public flightModel? GetFlight(string origin, string destination)
        {
            return flights.FirstOrDefault(f => f.Origin.ToLower() == origin.ToLower() && f.Destination.ToLower() == destination.ToLower());
        }

    }
}
