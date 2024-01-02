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
            
               /* Driver driver = new Driver { Age = age};

                TripService trip = new Trip(driver);

                bool isValid = trip.checkDriverAge(driver);

                Assert.AreEqual(expectedResult, isValid, $"Age:{age},Expected:{expectedResult}");
*/
        }

        [TestMethod]
        [DataRow("Edmonton", "Calgary", true)]
        [DataRow("Calgary", "Edmonton", true)]
        [DataRow("Toronto", "Calgary", false)]
        [DataRow("Calgary", "Calgary", false)]
        public void Trip_Start_LocationValid_AllCases(string startLocation, string endLocation, bool expectedResult)
        {/*
            Driver driver = new Driver();

            TripService trip = new Trip(driver);

            bool isValid = trip.IsValidTrip(startLocation,endLocation);

            Assert.AreEqual(expectedResult, isValid, $":startLocation{startLocation},endLocation{endLocation},Expected:{expectedResult}");
*/
        }

        [TestMethod]
        [DataRow("Edmonton", "Calgary",21, true)]
        [DataRow("Calgary", "Edmonton",20, false)]
        [DataRow("Toronto", "Calgary",22, false)]
        [DataRow("Calgary", "Calgary",20, false)]

        public void Trip_StartCheck_AllCases(string startLocation, string endLocation,int age, bool expectedResult)
        {
           /* Driver driver = new Driver() { Age=age};

            TripService trip = new Trip(driver);

            bool isValid = trip.Start(startLocation, endLocation);

            Assert.AreEqual(expectedResult, isValid, $":startLocation{startLocation},endLocation{endLocation},Expected:{expectedResult}");
*/
        }
    }

}
