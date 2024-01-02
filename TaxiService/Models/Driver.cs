﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiService.Interfaces;

namespace TaxiService.Models
{
    internal class Driver: IDriver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }

        public bool checkDriverAge()
        {
            
            return Age >= 21;

        }
    }
}
