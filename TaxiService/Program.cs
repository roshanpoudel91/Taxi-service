using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using TaxiService.Data;
using TaxiService.Models;
using TaxiService.Services;

[assembly: InternalsVisibleTo("TaxiService.Tests")]

namespace TaxiService
{
    class Program
    {
        /**
         * Write a program which which performs trips for a given driver. When the trip
         * is done the program writes a small message saying the trip was complete. If 
         * for some reason the trip is unsuccessful an error message will be returned.
         * 
         * Requirements:
         * 
         * The minimum driving age is 21
         * A trip between Edmonton and Calgary is 3 seconds.
         * Only trips between Edmonton and Calgary need to be supported. If other locations are selected it can be considered an error.
         * 
         */

        static void Main(string[] args)
        {
            string startLocation = "Edmonton";
            string endLocation = "Calgary";

            List<Driver>drivers = new DriverStore().Drivers;

            // Given a driver perform the trip from Edmonton to Calgary.
            foreach(var driver in drivers)
            {
                Console.WriteLine("-------------------------------------------");
                Trip trip = new Trip(driver);
                trip.Start(startLocation, endLocation);
                trip.Complete();
                Console.WriteLine("-------------------------------------------");

            }

        }

        
    }
}
