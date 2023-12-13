using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Models;

namespace TaxiService.Services
{
    internal interface ITrip
    {
        /// <summary>
        /// The driver of the trip.
        /// </summary>
        public Driver Driver { get; }

        /// <summary>
        /// The trip status.
        /// </summary>
        public TripStatus Status { get; set; }

        /// <summary>
        /// Starts a new trip.
        /// </summary>
        /// <param name="startLocation">The starting location of the trip.</param>
        /// <param name="endLocation">THe ending location of the trip.</param>
        public void Start(string startLocation, string endLocation);
    }
}
