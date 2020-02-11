//******************************************************
// File: WorkerTests.cs
//
// Purpose: Contains the class definition for WorkerTests.
//          WorkerTests tests each member variable
//          to make sure the results are correct.
//
// Written By: Natalie Wong
//
// Compiler: Visual Studio 2019
//
//******************************************************

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;

namespace PayrollTesting
{
    [TestClass]
    public class WorkerTests
    {
        #region Methods
        //************************************************************************
        // Method: TestName
        //
        // Purpose: Tests the Name to make sure the result is correct.
        //************************************************************************
        [TestMethod]
        public void TestName()
        {
            const string expected = "Rose Diaz";

            var worker = new Worker();
            worker.Name = expected;

            string actual = worker.Name;
            Assert.AreEqual(expected, actual, "Values are not equal");

        }

        //************************************************************************
        // Method: TestId
        //
        // Purpose: Tests the Id to make sure the result is correct.
        //************************************************************************
        [TestMethod]
        public void TestId()
        {
            const int expected = 100;

            var worker = new Worker();
            worker.Id = expected;

            int actual = worker.Id;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        //************************************************************************
        // Method: TestPayRate
        //
        // Purpose: Tests the PayRate to make sure the result is correct.
        //************************************************************************
        [TestMethod]
        public void TestPayRate()
        {
            const double expected = 10.00;

            var worker = new Worker();
            worker.PayRate = expected;

            double actual = worker.PayRate;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }
        #endregion
    }
}
