using System;

namespace FootballLeague
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;

        private string firstName;
        private string lastname;
        private decimal salary;
        private DateTime birthDay;
        
        public Player(string firstName, string lastName, decimal salary, DateTime birthday, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.BirthDay = birthday;
            this.Team = team;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                Validate.CheckForStringLength(value, "First name!\n", 3);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }

            set
            {
                Validate.CheckForStringLength(value, "Last name!\n", 3);
                this.lastname = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                Validate.CheckForNegativValue(value, "Salary!\n");
                this.salary = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return this.birthDay;
            }

            set
            {
                if (value.Year.CompareTo( MinimumAllowedYear) < 0)
                {
                    throw new ArgumentOutOfRangeException("\nDate of birth cannot be earlier than " + MinimumAllowedYear);
                }

                this.birthDay = value;
            }
        }

        public Team Team { get; set; }

        public override string ToString()
        {
            return "\t" + this.FirstName + " " + this.LastName;
        }
    }
}