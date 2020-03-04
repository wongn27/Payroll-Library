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
using System.Runtime.Serialization;
using System.Text;

namespace Payroll
{
    [DataContract]
    public class Department
    {
        [DataMember(Name = "name")]
        private string Name { get; set; }

        [DataMember(Name = "workers")]
        private List<Worker> Workers { get; set; }

        [DataMember(Name = "shifts")]
        private List<Shift> Shifts { get; set; }

        public Department() 
        {
            Name = string.Empty;
            Workers = new List<Worker>();
            Shifts = new List<Shift>();
        }

        //public Worker FindWorker (int workerId)
        //{
        //    if (Workers.Contains(workerId))
        //    {
        //        Worker result = Workers.Find(x => x.Id == workerId);
        //        return result;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public double CalculatePay (int workerId)
        //{
        //    if (Workers.Contains(workerId) {

        //    }
        //}

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
    }
}