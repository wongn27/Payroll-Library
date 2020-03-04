using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public class Department
    {
        private string name;
        private List<Worker> workers;
        private List<Shift> shifts;

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

        public List<Worker> Workers
        {
            get
            {
                return workers;
            }
            set
            {
                workers = value;
            }
        }

        public List<Shift> Shifts
        {
            get
            {
                return shifts;
            }
            set
            {
                shifts = value;
            }
        }

        public Department() 
        {
            name = string.Empty;
            workers = 
            shifts = 
        }

        public Worker FindWorker (int workerId)
        {
            if (workers.Contains(workerId))
            {
                Worker result = workers.Find(x => x.Id == workerId);
                return result;
            }
            else
            {
                return null;
            }
        }

        public double CalculatePay (int workerId)
        {
            if (workers.Contains(workerId) {

            }
        }

        public override string ToString()
        {
            string departmentString = $"{name.ToString()} {workers.ToString()} {shifts.ToString()}";
            return departmentString;
        }
    }
}