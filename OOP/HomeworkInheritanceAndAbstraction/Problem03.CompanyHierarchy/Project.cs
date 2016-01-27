namespace Problem03.CompanyHierarchy
{
    using System;

    public class Project
    {
        private string name;
        private string details;

        public Project(string name, string details, DateTime startDate, ProjectState state)
        {
            this.Name = name;
            this.Details = details;
            this.StartDate = startDate;
            this.State = state;
        }

        public ProjectState State { get; set; }

        public DateTime StartDate { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Project Name!");
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Project details!");
                this.details = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "\n\tProject name : {0}\n\tDetails : {1}\n\tStart date : {2}\n\tState : {3}",
                this.Name,
                this.Details,
                this.StartDate,
                this.State);
        }
    }
}
