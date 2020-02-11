//******************************************************
// File: ShiftTests.cs
//
// Purpose: Contains the class definition for ShiftTests.
//          ShiftTests tests each member variable
//          to make sure the results are correct.
//
// Written By: Natalie Wong
//
// Compiler: Visual Studio 2019
//
//******************************************************

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollTesting
{
    [TestClass]
    public class ShiftTests
    {
        #region Methods
        //*********************************************************************
        // Method: TestWorkerId
        //
        // Purpose: Tests the WorkerId to make sure the result is correct.
        //*********************************************************************
        [TestMethod]
        public void TestWorkerId()
        {
            const string expected = "100";

            var shift = new Shift();
            shift.WorkerID = expected;

            string actual = shift.WorkerID;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        //************************************************************************
        // Method: TestHoursWorked
        //
        // Purpose: Tests the HoursWorked to make sure the result is correct.
        //************************************************************************
        [TestMethod]
        public void TestHoursWorked()
        {
            const double expected = 30.00;

            var shift = new Shift();
            shift.HoursWorked = expected;

            double actual = shift.HoursWorked;
            Assert.AreEqual(expected, actual, "Values are not eqyal");
        }

        //************************************************************************
        // Method: TestDate
        //
        // Purpose: Tests the Date to make sure the result is correct.
        //************************************************************************
        [TestMethod]
        public void TestDate()
        {
            int day = 17, month = 1, year = 2020;

            var expected = new DateTime(2020,1,17);

            var actual =  new DateTime(year, month, day);

            Assert.AreEqual(expected, actual, "Values are not equal");        
        }
        #endregion
    }
}
