//******************************************************
// File: Shift.cs
//
// Purpose: Contains the class definition for Shift.
//          Shift has a default constructor that 
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
using System.Runtime.Serialization;

namespace Payroll
{
    [DataContract]
    public class Shift
    {
        #region Member Variables
        private int workerID;
        private double hoursWorked;
        private DateTime date;
        #endregion

        #region Properties
        [DataMember(Name = "workid")]
        public int WorkerID
        {
            get
            {
                return workerID;
            }
            set
            {
                workerID = value;
            }
        }

        [DataMember(Name = "hoursworked")]
        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }

        [DataMember(Name = "date")]
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        #endregion

        #region Methods
        //***********************************************************************************************
        // Method: Shift
        //
        // Purpose: Default constructor. Sets the values of each member variable to a default value.
        //***********************************************************************************************
        public Shift()
        {
            workerID = 0;
            hoursWorked = 0D;
            date = DateTime.Now;
        }

        /// <summary>
        /// Returns a string representation of the <see cref="Shift"/>
        /// instance's current state.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string shiftString = $"{workerID.ToString()} {hoursWorked.ToString()} {date.ToString()}";
            return shiftString;
        }
        #endregion
    }
}
