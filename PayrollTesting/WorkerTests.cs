using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;

namespace PayrollTesting
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void TestName()
        {
            const string expected = "Rose Diaz";

            Worker worker = new Worker();
            worker.Name = expected;

            string actual = worker.Name;
            Assert.AreEqual(expected, actual, "Values are not equal");

        }

        [TestMethod]
        public void TestId()
        {
            const int expected = 100;

            Worker worker = new Worker();
            worker.Id = expected;
            new Shift().ToString();
            int actual = worker.Id;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        [TestMethod]
        public void TestPayRate()
        {
            const double expected = 10.00;

            Worker worker = new Worker();
            worker.PayRate = expected;

            double actual = worker.PayRate;
            Assert.AreEqual(expected, actual, "Values are not equal");
        }
    }
}
