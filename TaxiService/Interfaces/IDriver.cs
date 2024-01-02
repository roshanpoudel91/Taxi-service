using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService.Interfaces
{
    internal interface IDriver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public bool checkDriverAge();
    }
}
