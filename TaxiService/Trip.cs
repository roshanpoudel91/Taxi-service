using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaxiService.Data;
using TaxiService.Interfaces;
using TaxiService.Models;

namespace TaxiService
{
    internal class Trip:ITrip
    {
       
        public Driver Driver { get; set; }

        public TripStatus Status { get; set; }
      
        public string StartLocation { get; set; }
        
        public string EndLocation { get; set; }

        public int TimeToComplete { get; set; }


        public bool isValidTrip()
        {
            if (StartLocation == EndLocation)
            {
                return false;
            }
            return StartLocation.Equals("Edmonton", StringComparison.OrdinalIgnoreCase) &&
                EndLocation.Equals("Calgary", StringComparison.OrdinalIgnoreCase) ||
                 StartLocation.Equals("Calgary", StringComparison.OrdinalIgnoreCase) &&
                EndLocation.Equals("Edmonton", StringComparison.OrdinalIgnoreCase);
        }

        public bool checkTimeToComplete()
        {
            return TimeToComplete >= 3;
            
        }
        
}
}
