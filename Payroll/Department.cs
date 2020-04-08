//******************************************************
// File: Department.cs
//
// Purpose: Contains the class definition for Department.
//          Department has a default constructor that 
//          will set the values of each member 
//          variable to a default value, contains 
//          properties for each member variable,
//          contains a method to find a worker,
//          contains a method to calculate pay,
//          and contains a method that returns a 
//          string that contains descriptive text 
//          and data for all member variables.
//
// Written By: Natalie Wong
//
// Compiler: Visual Studio 2019
//
//******************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Payroll
{
    [DataContract]
    public class Department
    {
        #region Auto-Implemented Properties
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "workers")]
        public List<Worker> Workers { get; set; }

        [DataMember(Name = "shifts")]
        public List<Shift> Shifts { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Default constructor. Sets the values of each member variable to a default value.
        /// </summary>
        public Department()
        {
            Name = string.Empty;
            Workers = new List<Worker>();
            Shifts = new List<Shift>();
        }

        /// <summary>
        ///  Takes a worker’s id as a parameter. 
        ///  It should return the Worker with the given id. 
        ///  If it is not found then return null.
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public Worker FindWorker(int workerId)
        {
            var worker = Workers.FirstOrDefault(w => w.Id == workerId);
            if (worker == null)
                return null;

            return worker;
        }

        /// <summary>
        /// Finds all workers with the workerId.
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public IEnumerable<Worker> FindWorkers(int workerId)
        {
            var workers = Workers.Where(w => w.Id == workerId);

            return workers;
        }

        /// <summary>
        /// This method calculates a worker’s pay.
        /// The worker’s pay is the total hours worked for all of their shifts times their pay rate.
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public double CalculatePay(int workerId)
        {
            double totalPay = 0.0;
            double totalHours = 0.0;

            Worker worker = FindWorker(workerId);

            int index;
            for (index = 0; index < Shifts.Count; index++)
            {
                if (Shifts[index].WorkerID == workerId)
                {
                    totalHours += Shifts[index].HoursWorked;
                }
            }

            totalPay = worker.PayRate * totalHours;

            return totalPay;
        }

        /// <summary>
        /// This method should return a string that contains data for all member variables. 
        /// This means that the department name as well as all data in each collection 
        /// should be part of the string that is returned.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string departmentString = "";
            departmentString += Name + "\n";

            for (int i = 0; i < Workers.Count; i++)
            {
                departmentString += Workers[i].ToString() + "\n";
            }

            for (int i = 0; i < Shifts.Count; i++)
            {
                departmentString += Shifts[i].ToString() + "\n";
            }

            return departmentString;
        }

        public double CalculateTotalHoursWorked()
        {
            double totalHours = 0.0;

            foreach (Shift shift in Shifts)
            {
                totalHours += shift.HoursWorked;
            }

            return totalHours;
        }

        public double CalculateTotalPay()
        {
            double totalPay = 0.0;

            foreach (Worker worker in Workers)
            {
                int workerId = worker.Id;
                double pay = CalculatePay(workerId);
                totalPay += pay;
            }

            return totalPay;
        }
        #endregion
    }
}