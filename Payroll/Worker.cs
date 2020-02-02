using System;

namespace Payroll
{
    public class Worker
    {
        private string name;
        private int id;
        private double payRate;

        public Worker()
        {
            name = string.Empty;
            id = 0;
            payRate = 0D;
        }

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

        public override string ToString()
        {
            string workerString = name + " " + Convert.ToString(id) + " " + Convert.ToString(payRate);
            return workerString;
        }
    }
}
