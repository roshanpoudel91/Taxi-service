using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using TaxiService.Data;
using TaxiService.Interfaces;
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
           

            /*List<Driver>drivers = new DriverStore().Drivers;*/

            // Given a driver perform the trip from Edmonton to Calgary.
           /* foreach(var driver in drivers)
            {*/
                Console.WriteLine("-------------------------------------------");
                
                ITrip trip = new Trip();
                Console.WriteLine("Enter Start Location");
                trip.StartLocation = Console.ReadLine();
                Console.WriteLine("Enter End Location");
                trip.EndLocation = Console.ReadLine();

                if (!trip.isValidTrip())
                {
                    Console.WriteLine("Error: Trip should be between Edmonton and Calgary only.");
                    return;
                }

                IDriver driver = new Driver();
                Console.WriteLine("Enter Driver's name");
                driver.Name = Console.ReadLine();

                Console.WriteLine("Enter Driver's age");
                driver.Age = Convert.ToInt32(Console.ReadLine());

                if (!driver.checkDriverAge())
                {
                    Console.WriteLine($"Error: Driver: {driver.Name}'s age should be greater than 21 to complete this trip.");
                    return;
                }
               
                Console.WriteLine("Enter Time to Complete in second");
                trip.TimeToComplete = Convert.ToInt32(Console.ReadLine());

                if (!trip.checkTimeToComplete())
                {
                        Console.WriteLine($"Error: Trip Time should be greater than or equal to 3 second");
                        return;
                }


                trip.Status = TripStatus.NotStarted;
                TripService tripService = new TripService(trip, driver);
                
                tripService.start();
                tripService.complete();
                Console.WriteLine("-------------------------------------------");

           /* }*/

        }

        
    }
}
