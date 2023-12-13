using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaxiService.Services;

namespace TaxiService.Models
{
    internal class Trip : ITrip
    {
        public Driver Driver { get; }

        public TripStatus Status { get; set; }
        public string StartLocation{ get; set; }
        public string EndLocation { get; set; }

        public Trip(Driver driver)
        {
            Driver = driver;
        }

        public void Start(string startLocation, string endLocation)
        {
            // check if trip is between Edmonton and Calgary
            if(!IsValidTrip(startLocation) || !IsValidTrip(endLocation) || (startLocation == endLocation))
            {
                Console.WriteLine("Error: Trip should be between Edmonton and Calgary only.");
                return;
            }
            // check if driver's age is greater than 21 
            if (Driver.Age < 21)
            {
                Console.WriteLine($"Sorry, Driver: {Driver.Name}'s age should be greater than 21 to complete this trip.");
                return;
            }

            StartLocation = startLocation;
            EndLocation = endLocation;
            Status = TripStatus.Driving;
            Console.WriteLine($"Trip started by Driver: {Driver.Name} from {startLocation} to {EndLocation}.");
            
        
        }

        public void Complete()
        {
            if(Status != TripStatus.Driving)
            {
                Console.WriteLine($"Error in trip completion.");
                return;
            }
                // Took 3 seconds to complete the trip
                Thread.Sleep(3000);
                Console.WriteLine($"Trip completed in 3 seconds.");
                // wait for fare
                Status = TripStatus.WaitingForFare;
                Console.WriteLine($"Driver waiting for fare.");
                // complete the trip
                Status = TripStatus.Complete;
                Console.WriteLine($"Trip completed by Driver: {Driver.Name} from {StartLocation} to {EndLocation}.");
                
                

        }

        private bool IsValidTrip(string location)
        {
            return location.Equals("Edmonton", StringComparison.OrdinalIgnoreCase) ||
                location.Equals("Calgary", StringComparison.OrdinalIgnoreCase);
        }
        

    }
}
