//******************************************************
// File: DepartmentTests.cs
//
// Purpose: Contains the class definition for DepartmentTests.
//          DepartmentTests tests each member variable
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
using System.Runtime.Serialization.Json;
using System.IO;

namespace PayrollTesting
{
    [TestClass]
    public class DepartmentTests
    {
        #region Test Methods
        /// <summary>
        /// Should pass a VALID ID into Find and it should return a worker instance with the target id.
        /// </summary>
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

        /// <summary>
        /// Should pass an INVALID ID into Find and it should return null.
        /// </summary>
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

        /// <summary>
        /// Should pass a VALID ID into CalculatePay and it should return the correct pay amount.
        /// </summary>
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
        #endregion
    }
}