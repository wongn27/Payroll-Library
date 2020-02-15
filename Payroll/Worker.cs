//******************************************************
// File: Worker.cs
//
// Purpose: Contains the class definition for Worker.
//          Worker has a default constructor that 
//          will set the values of each member 
//          variable to a default value, contains 
//          properties for each member variable,
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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Payroll
{
    [DataContract]
    public class Worker
    {
        #region Member Variables
        private string name;
        private int id;
        private double payRate;
        #endregion

        #region Properties
        [DataMember(Name ="name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [DataMember(Name = "id")]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        [DataMember(Name = "payrate")]
        public double PayRate
        {
            get
            {
                return payRate;
            }
            set
            {
                payRate = value;
            }
        }
        #endregion

        #region Methods
        //***********************************************************************************************
        // Method: Worker
        //
        // Purpose: Default constructor. Sets the values of each member variable to a default value.
        //***********************************************************************************************
        public Worker()
        {
            name = string.Empty;
            id = 0;
            payRate = 0D;
        }

        /// <summary>
        /// Returns a string representation of the <see cref="Worker"/>
        /// instance's current state.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string workerString = $"{name.ToString()} {id.ToString()} {payRate.ToString()}";
            return workerString;
        }
        #endregion
    }
}
