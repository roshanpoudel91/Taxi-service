using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TaxiService.Models;
using TaxiService.Services;

namespace TaxiService.Tests
{
    [TestClass]
    public class TripTests
    {
        [TestMethod]
        [DataRow(19,false)]
        [DataRow(21,true)]
        [DataRow(26,true)]
        public void Trip_Start_MinimumAgeValid_AllCases(int age, bool expectedResult)
        {
            
                Driver driver = new Driver { Age = age};

                bool isValid = driver.checkDriverAge();

                Assert.AreEqual(expectedResult, isValid, $"Age:{age},Expected:{expectedResult}");

        }

        [TestMethod]
        [DataRow("Edmonton", "Calgary", true)]
        [DataRow("Calgary", "Edmonton", true)]
        [DataRow("Toronto", "Calgary", false)]
        [DataRow("Calgary", "Calgary", false)]
        public void Trip_Start_LocationValid_AllCases(string startLocation, string endLocation, bool expectedResult)
        {
          
            Trip trip = new Trip()
            {
               StartLocation = startLocation,
               EndLocation = endLocation
             };

            bool isValid = trip.isValidTrip();

            Assert.AreEqual(expectedResult, isValid, $":startLocation{startLocation},endLocation{endLocation},Expected:{expectedResult}");

        }

        [TestMethod]
        [DataRow(1, false)]
        [DataRow(2, false)]
        [DataRow(3, true)]
        [DataRow(100, true)]

        public void Trip_CheckTime_AllCases(int time, bool expectedResult)
        {

            Trip trip = new Trip()
            {
                TimeToComplete = time
            };

            bool isValid = trip.checkTimeToComplete();

            Assert.AreEqual(expectedResult, isValid, $"Time:{time},Expected:{expectedResult}");

        }
    }

}
