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
        [TestMethod]
        public void TestWorkerId()
        {
            const string expected = "100";

            Shift shift = new Shift();
            shift.WorkerID = expected;

            string actual = shift.WorkerID;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        [TestMethod]
        public void TestHoursWorked()
        {
            const double expected = 30.00;

            Shift shift = new Shift();
            shift.HoursWorked = expected;

            double actual = shift.HoursWorked;
            Assert.AreEqual(expected, actual, "Values are not eqyal");
        }

        [TestMethod]
        public void TestDate()
        {
            DateTime expected = 
        
        }
    }
}
