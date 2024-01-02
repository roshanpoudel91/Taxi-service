using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaxiService.Interfaces;
using TaxiService.Models;

namespace TaxiService.Services
{
    internal class TripService
    {
        public readonly ITrip _trip;
        public readonly IDriver _driver;
      
        public TripService(ITrip trip, IDriver driver)
        {
            _trip = trip;
            _driver = driver;
        }

        public void start()
        {
            _trip.Status = TripStatus.Driving;

            Console.WriteLine($"Trip started by Driver: {_driver.Name} from {_trip.StartLocation} to {_trip.EndLocation}.");

        }

        public void complete()
        {
            if (_trip.Status != TripStatus.Driving)
            {
                Console.WriteLine($"Error in trip completion.");
                return;
            }


            // Took 3 seconds to complete the trip
            Thread.Sleep(_trip.TimeToComplete * 1000);
            Console.WriteLine($"Trip completed in {_trip.TimeToComplete} seconds.");
            // wait for fare
            _trip.Status = TripStatus.WaitingForFare;
            Console.WriteLine($"Driver waiting for fare.");
            // complete the trip
            _trip.Status = TripStatus.Complete;
            Console.WriteLine($"Trip completed by Driver: {_driver.Name} from {_trip.StartLocation} to {_trip.EndLocation}.");
        }







    }
}
