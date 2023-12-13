using System;
using System.Runtime.CompilerServices;
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
            
            // TODO: Given a driver perform the trip from Edmonton to Calgary.

            Console.WriteLine($"The trip between {startLocation} and {endLocation} is complete!");
        }
    }
}
