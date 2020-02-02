using System;

namespace Payroll
{
    public class Shift
    {
        private string workerID;
        private double hoursWorked;
        private DateTime date;

        public Shift()
        {
            workerID = string.Empty;
            hoursWorked = 0D;
            date = DateTime.Today;
        }

        public string WorkerID
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

        public override string ToString()
        {
            string shiftString = workerID + " " + Convert.ToString(hoursWorked) + " " + Convert.ToString(date);
            return shiftString;
        }
    }
}
