using System;
using System.Collections.Generic;
using System.Text;

namespace Students_and_Workers.Models
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private uint workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, uint workHoursPerDay) 
            : base(firstName, lastName)
        {
            if (weekSalary < 0) { throw new ArgumentException("Salary can't be less than zero"); }

            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
        }

        public uint WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }

        public override string Info()
        {
            return $"{this.FirstName} {this.LastName} - {this.MoneyPerHour():F2} lv.";
        }
    }
}
