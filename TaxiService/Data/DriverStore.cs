using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Models;

namespace TaxiService.Data
{
    internal class DriverStore
    {
        public List<Driver> Drivers { get; private set; } = new List<Driver>
        {
            new Driver
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                Age = 33,
                StartDate = new DateTime(2000, 09, 22)
                
            },
            new Driver
            {
                Id = Guid.NewGuid(),
                Name = "Jane Smith",
                Age = 50,
                StartDate = new DateTime(1995, 04, 05)
            },
            new Driver
            {
                Id = Guid.NewGuid(),
                Name = "Bobby Raven",
                Age = 18,
                StartDate = new DateTime(1995, 04, 05)
            }
        };
    }
}
