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

                Trip trip = new Trip(driver);

                bool isValid = trip.checkDriverAge(driver);

                Assert.AreEqual(expectedResult, isValid, $"Age:{age},Expected:{expectedResult}");

        }

        [TestMethod]
        [DataRow("Edmonton", "Calgary", true)]
        [DataRow("Calgary", "Edmonton", true)]
        [DataRow("Toronto", "Calgary", false)]
        public void Trip_Start_LocationValid_AllCases(string startLocation, string endLocation, bool expectedResult)
        {
            Driver driver = new Driver();

            Trip trip = new Trip(driver);

            bool isValid = trip.IsValidTrip(startLocation,endLocation);

            Assert.AreEqual(expectedResult, isValid, $":startLocation{startLocation},endLocation{endLocation},Expected:{expectedResult}");

        }
    }

}
