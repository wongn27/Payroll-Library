using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;
using System.Runtime.Serialization.Json;
using System.IO;

namespace PayrollTesting
{
    [TestClass]
    public class DepartmentTests
    {

        [TestMethod]
        public void TestFindWithGoodId()
        {
            string fileName = "dept.json";

            var department = new Department();

            department = DeserializeDepartmentJSON(fileName);


            int expected = 100;
            Worker worker = department.FindWorker(expected);
            int actual = worker.Id;

            Assert.AreEqual(expected, actual, "Values are not equal");
        }

        [TestMethod]
        public void TestFindWithBadId()
        {
            string fileName = "dept.json";

            var department = new Department();

            department = DeserializeDepartmentJSON(fileName);

            Worker expected = null;
            Worker worker = department.FindWorker(3000);
            //int actual = worker.Id;

            Assert.AreEqual(expected, worker, "Values are not equal");
        }

        [TestMethod]
        public void TestCalculatePay()
        {
            string fileName = "dept.json";

            var department = new Department();

            department = DeserializeDepartmentJSON(fileName);

            double expected = 1300;
            double totalPay = department.CalculatePay(100);

            Assert.AreEqual(expected, totalPay, 0.001, "Values are not equal");
        }

        /// <summary>
        /// Reads Department data from JSON file <see cref="Department"/>
        /// </summary>
        /// <returns></returns>
        public static Department DeserializeDepartmentJSON(string fileName)
        {
            Department department;

            var reader = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            var inputSerializer = new DataContractJsonSerializer(typeof(Department));

            department = (Department)inputSerializer.ReadObject(reader);
            reader.Close();

            return department;
        }
    }
}