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
            string expected = "";

            Worker worker = new Worker();
            worker.Name = expected;

            string actual = worker.Name;
            Assert.AreEqual(expected, actual, "");

        }
    }
}
