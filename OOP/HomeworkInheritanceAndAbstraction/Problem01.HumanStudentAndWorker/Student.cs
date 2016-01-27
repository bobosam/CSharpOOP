namespace Problem01.HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private long facultyNumber;

        public Student(string firstName, string lastName, long facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public long FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (10000 > value || 9999999999 < value)
                {
                    throw new ArgumentOutOfRangeException("Number length must be in range [5...10] digits!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}\tfac.numb: {3}", this.GetType().Name, this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
