namespace Problem01.HumanStudentAndWorker
{
    using System;

    public class Worker : Human
    {
        private const int WorkDayInWeek = 5;

        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (0 >= value)
                {
                    throw new ArgumentOutOfRangeException("The salary must be positive value!");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (0 >= value || 8 < value)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day must be in range (0...8]!");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(decimal weekSalary, double workHourPerDay)
        {
            decimal result = (weekSalary / WorkDayInWeek) / (decimal)workHourPerDay;

            return result;
        }

        public override string ToString()
        {
            return string.Format(
                                "{0} {1} {2}\tsalary per hour: {3:0.00}",
                                this.GetType().Name,
                                this.FirstName,
                                this.LastName,
                                this.MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }
    }
}
